using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Text;

namespace WebApplication6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login Page";
        }

        protected void logUsers_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from [Table] where Username='" + logUsers.UserName + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                if (temp == 1)
                {
                    conn.Open();
                    string checkPasswordQuery = "Select password from [Table] where Username='" + logUsers.UserName + "'";
                    SqlCommand command = new SqlCommand(checkPasswordQuery, conn);
                    string password = command.ExecuteScalar().ToString().Replace(" ", "");
                    conn.Close();
                    command.Dispose();
                    if (password == logUsers.Password)
                    {
                        Session["Username"] = logUsers.UserName;
                        logUsers.FailureTextStyle.ForeColor = Color.Green;
                        logUsers.FailureText = "Welcome, " + logUsers.UserName;
                        btnSQL.Visible = true;
                    }
                    else
                    {
                        logUsers.FailureText = "Password is incorrect.";
                    }
                }
                else
                    logUsers.FailureText = "Username is incorrect.";
                com.Dispose();
            }
        }

        private void ChangePassword1_ChangePasswordError(object sender, EventArgs e)
        {
            ChangePassword1.ChangePasswordFailureText = "Error: New password cannot be same as old password.";
            throw new NotImplementedException();
        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblMessage.Text = "";
                if (txtUser.Text != "")
                {
                    if (ChangePassword1.CurrentPassword == ChangePassword1.NewPassword)
                        ChangePassword1.ChangePasswordError += ChangePassword1_ChangePasswordError;
                    else
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
                        conn.Open();
                        string checkuser = "select count(*) from [Table] where Username='" + txtUser.Text + "'";
                        SqlCommand com = new SqlCommand(checkuser, conn);
                        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                        com.Dispose();
                        conn.Close();
                        if (temp == 1)
                        {
                            conn.Open();
                            string checkPasswordQuery = "Select password from [Table] where Username='" + txtUser.Text + "'";
                            SqlCommand command = new SqlCommand(checkPasswordQuery, conn);
                            string password = command.ExecuteScalar().ToString().Replace(" ", "");
                            command.Dispose();
                            conn.Close();
                            OleDbConnection con = new OleDbConnection((ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString));
                            con.Open();
                            OleDbCommand comm = new OleDbCommand();
                            comm.Connection = con;
                            comm.CommandText = "Select password from [tbl_login] where Username='" + txtUser.Text + "'";
                            comm.ExecuteNonQuery();
                            comm.Dispose();
                            string password2 = comm.ExecuteScalar().ToString().Replace(" ", "");
                            con.Close();
                            if (password == ChangePassword1.CurrentPassword)
                            {
                                conn.Open();
                                string Query = "update [Table] set Password=@NewPassword where Username=@UName and Password=@password";
                                SqlCommand command2 = new SqlCommand(Query, conn);
                                command2.Parameters.AddWithValue("@UName", txtUser.Text);
                                command2.Parameters.AddWithValue("@password", ChangePassword1.CurrentPassword);
                                command2.Parameters.AddWithValue("@NewPassword", ChangePassword1.NewPassword);
                                command2.Connection = conn;
                                command2.CommandText = Query;
                                command2.ExecuteNonQuery();
                                command2.Dispose();
                                conn.Close();
                                con.Open();
                                OleDbCommand oledb = new OleDbCommand();
                                oledb.Connection = con;
                                oledb.CommandText = "update [tbl_login] set [Password]='" + ChangePassword1.NewPassword + "' where [Username]='" + txtUser.Text + "' and [Password]='" + ChangePassword1.CurrentPassword + "'";
                                oledb.ExecuteNonQuery();
                                con.Close();
                                oledb.Dispose();
                                ChangePassword1.SuccessText = "Your password has been changed!";
                            }
                            else
                            {
                                lblMessage.Text += "Error. Invalid password.";
                            }
                        }
                        else
                        {
                            lblMessage.Text += "Error. Invalid username.";
                        }
                    }
                }
                else
                    lblMessage.Text += "Error. Username is required.";
            }
        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
            if (IsPostBack)
            {
                DataSet ds = new DataSet();
                string password = string.Empty;
                string email = string.Empty;
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string SQLQuery = "SELECT Password FROM [Table] WHERE Username = '" + PasswordRecovery1.UserName + "'";
                    string Email = "SELECT Email FROM [Table] WHERE Username = '" + PasswordRecovery1.UserName + "'";
                    using (SqlCommand cmd = new SqlCommand(SQLQuery, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand.Connection.Open();
                        da.Fill(ds);
                        cmd.Connection = con;
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                password = sdr["Password"].ToString();
                            }
                        }
                        con.Close();
                    }
                    using (SqlCommand cmd = new SqlCommand(Email, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand.Connection.Open();
                        da.Fill(ds);
                        cmd.Connection = con;
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                email = sdr["Email"].ToString();
                            }
                        }
                        con.Close();
                        cmd.Dispose();
                    }
                }
                lblPassword.Visible = true;
                if (!string.IsNullOrEmpty(password))
                {
                    e.Message.To.Add(email);
                    e.Message.Subject = "Password Recovery";
                    e.Message.Body = string.Format("Hi {0}<%UserName%>,<br /><br />Your password is {1}<%Password%>.<br /><br />Thank You. <br /><br /> <a href=\"Default.aspx\">Login Page</a>", PasswordRecovery1.UserName, password);
                    e.Message.Priority = MailPriority.Normal;
                    e.Message.BodyEncoding = Encoding.UTF8;
                    e.Message.HeadersEncoding = Encoding.UTF8;
                    e.Message.Attachments.Add(new Attachment("Software.txt"));
                }
                if (!string.IsNullOrEmpty(password))
                {
                    MailMessage mm = new MailMessage("max.voisard@gmail.com", email);
                    mm.Subject = "Password Recovery";
                    mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You. <br /><br /> <a href=\"Default.aspx\">Login Page</a>", PasswordRecovery1.UserName, password);
                    mm.CC.Add("Notification_Lost@contoso.com");
                    mm.IsBodyHtml = true;
                    mm.Priority = MailPriority.Normal;
                    mm.BodyEncoding = Encoding.UTF8;
                    mm.HeadersEncoding = Encoding.UTF8;
                    mm.Attachments.Add(new Attachment("Software.txt"));
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Credentials = new NetworkCredential("max.voisard@gmail.com", "Rookies45%");
                    smtp.UseDefaultCredentials = true;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(mm);
                }
            }
        }
    }
}