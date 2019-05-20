using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.Caching;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

namespace WebApplication6
{

    public partial class Registration : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
        static Random number = new Random();
        static int randomNumber = number.Next(100000, 999999);

        protected void Page_Load(object sender, EventArgs e)
        {
            /* conn.Open();
            string checkuser = "delete from [Table]";
            SqlCommand command = new SqlCommand(checkuser, conn);
            command.ExecuteNonQuery();
            command.Dispose(); */
            if (!ScriptManager1.IsInAsyncPostBack)
                Session["timeout"] = DateTime.Now.AddMinutes(15).ToString();
        }

        public bool IsReCaptchValid()
        {
            var result = false;
            var captchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = "6Le-Sk0UAAAAAJwb5_I5DCnR-pB6qREBG876rGkY";
            var apiUrl = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, captchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    JObject jResponse = JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("success");
                    result = (isSuccess) ? true : false;
                }
            }
            return result;
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            lblSuccessMessage.Visible = false;
            lblErrorMessage.Visible = false;
            bool flag = true;
            var phoneNum = hdnLabelState.Value;
            Regex regexObj = new Regex(@"[^\d]");
            phoneNum = regexObj.Replace(phoneNum, "");
            try
            {
                if (CheckBox1.Checked == true)
                {
                    if (IsReCaptchValid())
                    {
                        Guid newGUID = Guid.NewGuid();
                        conn.Open();
                        string checkuser = "select count(*) from [Table] where Username='" + RegisterUser.UserName + "'";
                        SqlCommand command = new SqlCommand(checkuser, conn);
                        command.Dispose();
                        int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                        string checkemail = "select count(*) from [Table] where Email='" + RegisterUser.Email + "'";
                        SqlCommand command2 = new SqlCommand(checkemail, conn);
                        command2.Dispose();
                        int temp2 = Convert.ToInt32(command2.ExecuteScalar().ToString());
                        string checkphone = "select count(*) from [Table] where PhoneNumber='" + phone.Value + "'";
                        SqlCommand command3 = new SqlCommand(checkphone, conn);
                        command3.Dispose();
                        int temp3 = Convert.ToInt32(command3.ExecuteScalar().ToString());
                        if (temp == 1)
                        {
                            lblErrorMessage.Visible = true;
                            lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: Username already exists.";
                        }
                        else
                        {
                            if (flag == false) // Should be temp2 == 1 when done testing with your own email
                            {
                                lblErrorMessage.Visible = true;
                                lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: An account with that email has already been taken.";
                            }
                            else
                            {
                                if (flag == false)  // Should be temp3 == 1 when done testing with your own phone number
                                {
                                    lblErrorMessage.Visible = true;
                                    lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: An account with that phone number has already been taken.";
                                } 
                                else
                                {
                                    if (!(Regex.Match(phone.Value, @"^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}$").Success))
                                    {
                                        lblErrorMessage.Visible = true;
                                        lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: Invalid phone number formatting.";
                                    }
                                    else
                                    {
                                        string trimmedUserName = RegisterUser.UserName.Trim();
                                        if (RegisterUser.UserName.Length != trimmedUserName.Length)
                                        {
                                            lblErrorMessage.Visible = true;
                                            lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: The username cannot contain leading or trailing spaces.";
                                        }
                                        else
                                        {
                                            if (RegisterUser.Password.IndexOf(RegisterUser.UserName, StringComparison.OrdinalIgnoreCase) >= 0)
                                            {
                                                lblErrorMessage.Visible = true;
                                                lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: The username cannot appear anywhere in the password.";
                                            }
                                            else
                                            {
                                                string insertQuery = "insert into [Table] (Id, Username, Email, Password, SecurityQuestion, SecurityAnswer, PasswordHint, FirstName, MiddleName, LastName, Company, PhoneNumber, Address1, Address2, Location, ZIPCode, DOB, Gender, Image) values (@Id, @Uname, @email, @password, @SecurityQuestion, @SecurityAnswer, @PasswordHint, @FirstName, @MiddleName, @LastName, @Company, @PhoneNumber, @Address1, @Address2, @Location, @ZIPCode, @DOB, @Gender, @Image);";
                                                SqlCommand com = new SqlCommand(insertQuery, conn);
                                                com.Parameters.AddWithValue("@Id", newGUID);
                                                com.Parameters.AddWithValue("@UName", RegisterUser.UserName);
                                                com.Parameters.AddWithValue("@email", RegisterUser.Email);
                                                com.Parameters.AddWithValue("@password", RegisterUser.Password.Replace("'", "''"));
                                                com.Parameters.AddWithValue("@SecurityQuestion", RegisterUser.Question);
                                                com.Parameters.AddWithValue("@SecurityAnswer", RegisterUser.Answer);
                                                com.Parameters.AddWithValue("@PasswordHint", PasswordHint.Text);
                                                com.Parameters.AddWithValue("@FirstName", first.Value);
                                                com.Parameters.AddWithValue("@MiddleName", middle.Value);
                                                com.Parameters.AddWithValue("@LastName", last.Value);
                                                com.Parameters.AddWithValue("@Company", company.Value);
                                                com.Parameters.AddWithValue("@PhoneNumber", hdnLabelState.Value);
                                                com.Parameters.AddWithValue("@Address1", address.Value);
                                                com.Parameters.AddWithValue("@Address2", address2.Value);
                                                com.Parameters.AddWithValue("@Location", autocomplete.Value);
                                                com.Parameters.AddWithValue("@ZIPCode", zip.Value);
                                                com.Parameters.AddWithValue("@DOB", dob.Value);
                                                com.Parameters.AddWithValue("@Gender", gender.Value);
                                                if (FileUpload1.HasFile)
                                                {
                                                    string str = FileUpload1.FileName;
                                                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/" + str));
                                                    string Image = "~/Images/" + str.ToString();
                                                    com.Parameters.AddWithValue("@Image", Image);
                                                    Image2.ImageUrl = Image;
                                                }
                                                com.ExecuteNonQuery();
                                                com.Dispose();
                                                lblSuccessMessage.Visible = true;
                                                lblSuccessMessage.InnerHtml = "<i class='fa fa-check'></i> Registration successful";
                                                const string accountSid = "ACf8330fcc3ede57b663dbede2858535d0";
                                                const string authToken = "5eb820b34245cef33060f9e34d0b61b9";
                                                TwilioClient.Init(accountSid, authToken);
                                                var message = MessageResource.Create(
                                                    body: "Thank you for registering to Max's Tech and Math Site! Your verification code is: " + randomNumber,
                                                    from: new Twilio.Types.PhoneNumber("+19376391990"),
                                                    to: new Twilio.Types.PhoneNumber(phoneNum)
                                                );
                                                mpePopUp.Show();
                                                MailMessage msg = new MailMessage();
                                                msg.From = new MailAddress("max.voisard@gmail.com");
                                                msg.To.Add(RegisterUser.Email);
                                                msg.Subject = "Registration Confirmation";
                                                msg.IsBodyHtml = true;
                                                var inlineLogo = new LinkedResource(Server.MapPath("~/Images/Logo.PNG"), "image/png");
                                                inlineLogo.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo2 = new LinkedResource(Server.MapPath("~/Images/PictureOfMe.jpg"), "image/jpeg");
                                                inlineLogo2.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo3 = new LinkedResource(Server.MapPath("~/Images/Facebook.jpg"), "image/jpeg");
                                                inlineLogo3.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo4 = new LinkedResource(Server.MapPath("~/Images/Twitter.png"), "image/png");
                                                inlineLogo4.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo5 = new LinkedResource(Server.MapPath("~/Images/Instagram.png"), "image/png");
                                                inlineLogo5.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo6 = new LinkedResource(Server.MapPath("~/Images/LinkedIn.png"), "image/png");
                                                inlineLogo6.ContentId = Guid.NewGuid().ToString();
                                                var inlineLogo7 = new LinkedResource(Server.MapPath("~/Images/favicon-96x96.png"), "image/png");
                                                inlineLogo7.ContentId = Guid.NewGuid().ToString();
                                                string body = File.ReadAllText(Server.MapPath("html/Email.html"));
                                                body = body.Replace("#FIRSTNAME#", first.Value + "!");
                                                body = body.Replace("/Images/Logo.PNG", "cid:" + inlineLogo.ContentId);
                                                body = body.Replace("/Images/PictureOfMe.jpg", "cid:" + inlineLogo2.ContentId);
                                                body = body.Replace("/Images/Facebook.jpg", "cid:" + inlineLogo3.ContentId);
                                                body = body.Replace("/Images/Twitter.png", "cid:" + inlineLogo4.ContentId);
                                                body = body.Replace("/Images/Instagram.png", "cid:" + inlineLogo5.ContentId);
                                                body = body.Replace("/Images/LinkedIn.png", "cid:" + inlineLogo6.ContentId);
                                                body = body.Replace("/Images/favicon-96x96.png", "cid:" + inlineLogo7.ContentId);
                                                msg.Body = body;
                                                var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
                                                view.LinkedResources.Add(inlineLogo);
                                                view.LinkedResources.Add(inlineLogo2);
                                                view.LinkedResources.Add(inlineLogo3);
                                                view.LinkedResources.Add(inlineLogo4);
                                                view.LinkedResources.Add(inlineLogo5);
                                                view.LinkedResources.Add(inlineLogo6);
                                                view.LinkedResources.Add(inlineLogo7);
                                                msg.AlternateViews.Add(view);
                                                var client = new SmtpClient();
                                                client.UseDefaultCredentials = false;
                                                client.Credentials = new NetworkCredential("max.voisard@gmail.com", "Rookies45%");
                                                client.Send(msg);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: ReCAPTCHA verification failed";
                    }
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: You must agree to the Privacy Policy and Terms of Service.";
                }
            }
            catch (Twilio.Exceptions.ApiException) {
                if (Regex.Match(phone.Value, @"^(\([0-9]{3}\) |[0-9]{3}-)[0-9]{3}-[0-9]{4}$").Success)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: Phone Number " + phoneNum + " does not exist";
                    lblSuccessMessage.Visible = false;
                    string checkuser = "delete from [Table] where Username='" + RegisterUser.UserName + "'";
                    SqlCommand command = new SqlCommand(checkuser, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Twilio.Exceptions.ApiConnectionException) { }
            catch (Twilio.Exceptions.AuthenticationException) { }
            catch (Twilio.Exceptions.CertificateValidationException) { }
            catch (Twilio.Exceptions.RestException) { }
            catch (Twilio.Exceptions.TwilioException) { }
            catch (Exception er)
            {
                lblErrorMessage.InnerHtml = "<i class='fa fa-exclamation-triangle'></i> Error: " + er.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            mpePopUp.Hide();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            mpePopUp.Hide();
        }

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            mpePopUp.Hide();
        }

        protected void timer1_tick(object sender, EventArgs e)
        {
            if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
            {
                lblTimer.Text = string.Format("Time Left: 00:{0}:{1}", ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(), ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
            }
            else
            {
                Timer1.Enabled = true;
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt32(TextBox1.Text);
            conn.Open();
            string insertQuery = "update [Table] set Verified=@Verified where Username='" + RegisterUser.UserName + "'";
            SqlCommand com = new SqlCommand(insertQuery, conn);
            MemoryCache cache = new MemoryCache("ValidationCache");
            string key = "Verification code";
            cache.Add(key, randomNumber, new CacheItemPolicy() { AbsoluteExpiration = DateTime.UtcNow.AddSeconds(900) });
            if (cache.Contains(key))
            {
                if (userInput == randomNumber)
                {
                    lblStatus.Text = "<i class='fa fa-check'></i> The code you entered matched our records!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    com.Parameters.AddWithValue("@Verified", 1);
                    com.ExecuteNonQuery();
                    com.Dispose();
                    conn.Close();
                    Thread.Sleep(5000);
                    mpePopUp.Hide();
                }
                else
                {
                    lblStatus.Text = "<i class='fa fa-exclamation-triangle'></i> Error: The code you entered did not match our records.";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    com.Parameters.AddWithValue("@Verified", 0);
                    com.ExecuteNonQuery();
                    com.Dispose();
                    conn.Close();
                }
            }
            else
            {
                lblStatus.Text = "Error: Your 15-minute grace period has expired.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            randomNumber = number.Next(100000, 999999);
            const string accountSid = "ACf8330fcc3ede57b663dbede2858535d0";
            const string authToken = "5eb820b34245cef33060f9e34d0b61b9";
            TwilioClient.Init(accountSid, authToken);
            var phoneNum = phone.Value;
            Regex regexObj = new Regex(@"[^\d]");
            phoneNum = regexObj.Replace(phoneNum, "");
            var message = MessageResource.Create(
                body: "Thank you for registering to Max's Tech and Math Site! Your verification code is: " + randomNumber,
                from: new Twilio.Types.PhoneNumber("+19376391990"),
                to: new Twilio.Types.PhoneNumber("+1" + phoneNum)
            );
            mpePopUp.Show();
        }
    }
}