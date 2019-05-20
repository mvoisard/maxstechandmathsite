using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using NAudio.Wave;
using NReco.VideoConverter;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebApplication6
{

    public partial class Random2 : Page
    {
        private static string username, password, domain, uri;
        private static double employeeTaxes = 0.0, employerTaxes = 0.0, YTDTaxes = 0.0, stateTax = 0.0, totalStateTax = 0.0, fedUnemploymentTax = 0.0, stateUnemploymentTax = 0.0, totalSUT = 0.0, totalFUT = 0.0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                string username = Session["Username"].ToString();
                Label114.Text = Session["Username"].ToString();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
                conn.Open();
                string insertQuery = "select * from [Table] where Username='" + username + "'";
                SqlCommand com = new SqlCommand(insertQuery, conn);
                var results = com.ExecuteReader();
                if (results.Read())
                {
                    string imageURL = results["Image"].ToString();
                    ProfilePicture.Src = imageURL;
                }
                com.Dispose();
                conn.Close();
            }
            else
            {
                Label114.Text = "Session Expired";
                ProfilePicture.Src = "Images/SessionExpired.jpg";
                Label115.Text = "Your session has expired. Please log back in.";
            }
            SqlPersonalizationProvider sql = new SqlPersonalizationProvider();
            if (WebPartManager1.Personalization.Scope == PersonalizationScope.User)
                if (WebPartManager1.Personalization.CanEnterSharedScope)
                    WebPartManager1.Personalization.ToggleScope();
            string fileContent = Cache["Random"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("~/Random.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Random", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("~/Random.aspx")));
                }
            }
            if (Request.Cookies["Name"] == null)
            {
                string identifier = Guid.NewGuid().ToString();
                HttpCookie namecoockie = new HttpCookie("Name", identifier);
                namecoockie.Expires = DateTime.MaxValue;
                Response.AppendCookie(namecoockie);
            }
        }

        public static void Main(string[] args)
        {
            uri = args[0];
            username = args[1];
            password = args[2];

            if (args.Length == 3)
                domain = string.Empty;
            else
                domain = args[3];
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(TextBox104.Text);
            int max = Convert.ToInt32(TextBox105.Text);
            int amount = Convert.ToInt32(TextBox106.Text);
            lblRandom.Text = "Random numbers: ";
            Random number = new Random();
            for (int index = 0; index < amount; index++)
            {
                int randomNumber = number.Next(min, max);
                if (!(index == amount - 1))
                    lblRandom.Text += Convert.ToString(randomNumber) + ", ";
                else
                    lblRandom.Text += Convert.ToString(randomNumber);
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path = path.Replace(@"\", @"\\");
                client.DownloadFile("http://media.lehighvalleylive.com/sports_impact/photo/pete-weber-416ef9627e06a638.jpg", path + "\\PeteWeber.jpg");
            }
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            lblError2.Text = "";
            try
            {
                WebPartManager1.DisplayMode = WebPartManager.BrowseDisplayMode;
            }
            catch (ArgumentException)
            {
                lblError2.Text = "Please login in upper-right corner of Contact Page.";
            }
        }

        protected void btnDesign_Click(object sender, EventArgs e)
        {
            try
            {
                WebPartManager wpm = new WebPartManager();
                WebPartDisplayMode mode = wpm.SupportedDisplayModes[1];
            }
            catch (ArgumentException)
            {
                lblError2.Text = "Please login in upper-right corner of Contact Page.";
            }
        }

        protected void btnCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                WebPartManager1.DisplayMode = WebPartManager.CatalogDisplayMode;
            }
            catch (ArgumentException)
            {
                lblError2.Text = "Please login in upper-right corner of Contact Page.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                WebPartManager1.DisplayMode = WebPartManager.EditDisplayMode;
            }
            catch (ArgumentException)
            {
                lblError2.Text = "Please login in upper-right corner of Contact Page.";
            }
        }

        protected void CorrectFrame2()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox20.Text == "X" || TextBox20.Text == "/")
            {
                if (TextBox20.Text == "X")
                    Shot1 = 10;
                if (TextBox20.Text == "/")
                {
                    if (TextBox2.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox2.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox2.Text);
                }
            }
            else
            {
                if (TextBox2.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox2.Text);
                if (TextBox20.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox20.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox10.Text == "/")
                    TextBox21.Text = "20";
                TextBox20.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox2.Text = "-";
                else
                    TextBox2.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox10.Text == "X")
                        TextBox21.Text = "20";
                    if (TextBox10.Text == "/")
                        TextBox21.Text = Convert.ToString(10 + Convert.ToInt32(TextBox2.Text));
                    TextBox20.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox20.Text = "-";
                    else
                        TextBox20.Text = Convert.ToString(Shot2);
                    if (TextBox10.Text == "X")
                        TextBox21.Text = Convert.ToString(10 + total);
                    if (TextBox10.Text == "/")
                        TextBox21.Text = Convert.ToString(10 + Shot1);
                    TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + total);
                }
            }
        }

        protected void CorrectFrame3()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox30.Text == "X" || TextBox30.Text == "/")
            {
                if (TextBox30.Text == "X")
                    Shot1 = 10;
                if (TextBox30.Text == "/")
                {
                    if (TextBox3.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox3.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox3.Text);
                }
            }
            else
            {
                if (TextBox3.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox3.Text);
                if (TextBox30.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox30.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox20.Text == "/")
                    TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                if (TextBox10.Text == "X" && TextBox20.Text == "X")
                    TextBox21.Text = "30";
                TextBox30.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox3.Text = "-";
                else
                    TextBox3.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox20.Text == "/")
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + Shot1);
                    if (TextBox10.Text != "X" && TextBox20.Text == "X")
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                    if (TextBox10.Text == "X" && TextBox20.Text == "X")
                    {
                        TextBox21.Text = Convert.ToString(20 + Shot1);
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                    }
                    TextBox30.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox30.Text = "-";
                    else
                        TextBox30.Text = Convert.ToString(Shot2);
                    if (TextBox20.Text == "/")
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + Shot1);
                    if (TextBox10.Text != "X" && TextBox20.Text == "X")
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + total);
                    if (TextBox10.Text == "X" && TextBox20.Text == "X")
                    {
                        TextBox21.Text = Convert.ToString(Convert.ToInt32(TextBox20.Text) + 20 + Shot1);
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + total);
                    }
                    TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + total);
                }
            }
        }

        protected void CorrectFrame4()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox40.Text == "X" || TextBox40.Text == "/")
            {
                if (TextBox40.Text == "X")
                    Shot1 = 10;
                if (TextBox40.Text == "/")
                {
                    if (TextBox4.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox4.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox4.Text);
                }
            }
            else
            {
                if (TextBox4.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox4.Text);
                if (TextBox40.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox40.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox30.Text == "/")
                    TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                if (TextBox20.Text == "X" && TextBox30.Text == "X")
                    TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 30);
                TextBox40.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox4.Text = "-";
                else
                    TextBox4.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox30.Text == "/")
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + Shot1);
                    if (TextBox20.Text != "X" && TextBox30.Text == "X")
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                    if (TextBox20.Text == "X" && TextBox30.Text == "X")
                    {
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20 + Shot1);
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                    }
                    TextBox40.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox40.Text = "-";
                    else
                        TextBox40.Text = Convert.ToString(Shot2);
                    if (TextBox30.Text == "/")
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + Shot1);
                    if (TextBox20.Text != "X" && TextBox30.Text == "X")
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + total);
                    if (TextBox20.Text == "X" && TextBox30.Text == "X")
                    {
                        TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20 + Shot1);
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + total);
                    }
                    TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + total);
                }
            }
        }

        protected void CorrectFrame5()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox50.Text == "X" || TextBox50.Text == "/")
            {
                if (TextBox50.Text == "X")
                    Shot1 = 10;
                if (TextBox50.Text == "/")
                {
                    if (TextBox5.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox5.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox5.Text);
                }
            }
            else
            {
                if (TextBox5.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox5.Text);
                if (TextBox50.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox50.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox40.Text == "/")
                    TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                if (TextBox30.Text == "X" && TextBox40.Text == "X")
                    TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 30);
                TextBox50.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox5.Text = "-";
                else
                    TextBox5.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox40.Text == "/")
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + Shot1);
                    if (TextBox30.Text != "X" && TextBox40.Text == "X")
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                    if (TextBox30.Text == "X" && TextBox40.Text == "X")
                    {
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20 + Shot1);
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                    }
                    TextBox50.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox50.Text = "-";
                    else
                        TextBox50.Text = Convert.ToString(Shot2);
                    if (TextBox40.Text == "/")
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + Shot1);
                    if (TextBox30.Text != "X" && TextBox40.Text == "X")
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + total);
                    if (TextBox30.Text == "X" && TextBox40.Text == "X")
                    {
                        TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20 + Shot1);
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + total);
                    }
                    TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + total);
                }
            }
        }

        protected void CorrectFrame6()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox60.Text == "X" || TextBox60.Text == "/")
            {
                if (TextBox60.Text == "X")
                    Shot1 = 10;
                if (TextBox60.Text == "/")
                {
                    if (TextBox6.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox6.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox6.Text);
                }
            }
            else
            {
                if (TextBox6.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox6.Text);
                if (TextBox60.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox60.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox50.Text == "/")
                    TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                if (TextBox40.Text == "X" && TextBox50.Text == "X")
                    TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 30);
                TextBox60.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox6.Text = "-";
                else
                    TextBox6.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox50.Text == "/")
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + Shot1);
                    if (TextBox40.Text != "X" && TextBox50.Text == "X")
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                    if (TextBox40.Text == "X" && TextBox50.Text == "X")
                    {
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20 + Shot1);
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                    }
                    TextBox60.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox60.Text = "-";
                    else
                        TextBox60.Text = Convert.ToString(Shot2);
                    if (TextBox50.Text == "/")
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + Shot1);
                    if (TextBox40.Text != "X" && TextBox50.Text == "X")
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + total);
                    if (TextBox40.Text == "X" && TextBox50.Text == "X")
                    {
                        TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20 + Shot1);
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + total);
                    }
                    TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + total);
                }
            }
        }

        protected void CorrectFrame7()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox70.Text == "X" || TextBox70.Text == "/")
            {
                if (TextBox70.Text == "X")
                    Shot1 = 10;
                if (TextBox70.Text == "/")
                {
                    if (TextBox7.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox7.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox7.Text);
                }
            }
            else
            {
                if (TextBox7.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox7.Text);
                if (TextBox70.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox70.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox60.Text == "/")
                    TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                if (TextBox50.Text == "X" && TextBox60.Text == "X")
                    TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 30);
                TextBox70.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox7.Text = "-";
                else
                    TextBox7.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox60.Text == "/")
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + Shot1);
                    if (TextBox50.Text != "X" && TextBox60.Text == "X")
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                    if (TextBox50.Text == "X" && TextBox60.Text == "X")
                    {
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20 + Shot1);
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                    }
                    TextBox70.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox70.Text = "-";
                    else
                        TextBox70.Text = Convert.ToString(Shot2);
                    if (TextBox60.Text == "/")
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + Shot1);
                    if (TextBox50.Text != "X" && TextBox60.Text == "X")
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + total);
                    if (TextBox50.Text == "X" && TextBox60.Text == "X")
                    {
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20 + Shot1);
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + total);
                    }
                    TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + total);
                }
            }
        }


        protected void CorrectFrame8()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox80.Text == "X" || TextBox80.Text == "/")
            {
                if (TextBox80.Text == "X")
                    Shot1 = 10;
                if (TextBox80.Text == "/")
                {
                    if (TextBox8.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox8.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox8.Text);
                }
            }
            else
            {
                if (TextBox8.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox8.Text);
                if (TextBox80.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox80.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox70.Text == "/")
                    TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                if (TextBox60.Text == "X" && TextBox70.Text == "X")
                    TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 30);
                TextBox80.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox8.Text = "-";
                else
                    TextBox8.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox70.Text == "/")
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + Shot1);
                    if (TextBox60.Text != "X" && TextBox70.Text == "X")
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                    if (TextBox60.Text == "X" && TextBox70.Text == "X")
                    {
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20 + Shot1);
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                    }
                    TextBox70.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox80.Text = "-";
                    else
                        TextBox80.Text = Convert.ToString(Shot2);
                    if (TextBox70.Text == "/")
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + Shot1);
                    if (TextBox60.Text != "X" && TextBox70.Text == "X")
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + total);
                    if (TextBox60.Text == "X" && TextBox70.Text == "X")
                    {
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20 + Shot1);
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + total);
                    }
                    TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + total);
                }
            }
        }

        protected void CorrectFrame9()
        {
            int Shot1 = 0;
            int Shot2 = 0;
            if (TextBox90.Text == "X" || TextBox90.Text == "/")
            {
                if (TextBox90.Text == "X")
                    Shot1 = 10;
                if (TextBox90.Text == "/")
                {
                    if (TextBox9.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBox9.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBox9.Text);
                }
            }
            else
            {
                if (TextBox9.Text == "-")
                    Shot1 = 0;
                else
                    Shot1 = Convert.ToInt32(TextBox9.Text);
                if (TextBox90.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox90.Text);
            }
            int total = Shot1 + Shot2;
            if (Shot1 == 10)
            {
                if (TextBox80.Text == "/")
                    TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                if (TextBox70.Text == "X" && TextBox80.Text == "X")
                    TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 30);
                TextBox90.Text = "X";
            }
            else
            {
                if (Shot1 == 0)
                    TextBox9.Text = "-";
                else
                    TextBox9.Text = Convert.ToString(Shot1);
                if (total == 10)
                {
                    if (TextBox80.Text == "/")
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + Shot1);
                    if (TextBox70.Text != "X" && TextBox80.Text == "X")
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                    if (TextBox70.Text == "X" && TextBox80.Text == "X")
                    {
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20 + Shot1);
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                    }
                    TextBox80.Text = "/";
                }
                else
                {
                    if (Shot2 == 0)
                        TextBox90.Text = "-";
                    else
                        TextBox90.Text = Convert.ToString(Shot2);
                    if (TextBox80.Text == "/")
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + Shot1);
                    if (TextBox70.Text != "X" && TextBox80.Text == "X")
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + total);
                    if (TextBox70.Text == "X" && TextBox80.Text == "X")
                    {
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20 + Shot1);
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + total);
                    }
                    TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + total);
                }
            }
        }

        protected void CorrectFrame10()
        {
            int Shot1 = 0, Shot2 = 0, Shot3 = 0;
            if (TextBox100.Text == "X" || TextBox100.Text == "/")
            {
                if (TextBox100.Text == "X")
                {
                    Shot1 = 10;
                    Shot2 = 10;
                }
                if (TextBox100.Text == "/")
                {
                    if (TextBoxTen.Text == "-")
                        Shot1 = 0;
                    else
                        Shot1 = Convert.ToInt32(TextBoxTen.Text);
                    Shot2 = 10 - Convert.ToInt32(TextBoxTen.Text);
                }
                if (TextBox101.Text == "X" || TextBox101.Text == "-")
                {
                    if (TextBox101.Text == "X")
                        Shot3 = 10;
                    if (TextBox101.Text == "-")
                        Shot3 = 0;
                }
                else
                    Shot3 = Convert.ToInt32(TextBox101.Text);
            }
            else
            {
                if (TextBoxTen.Text == "-" || TextBoxTen.Text == "X")
                {
                    if (TextBoxTen.Text == "-")
                        Shot1 = 0;
                    if (TextBoxTen.Text == "X")
                        Shot1 = 10;
                }
                else
                    Shot1 = Convert.ToInt32(TextBoxTen.Text);
                if (TextBox100.Text == "-")
                    Shot2 = 0;
                else
                    Shot2 = Convert.ToInt32(TextBox100.Text);
                if (TextBox101.Text == "X" || TextBox101.Text == "-" || TextBox101.Text == "/")
                {
                    if (TextBox101.Text == "X")
                        Shot3 = 10;
                    if (TextBox101.Text == "-")
                        Shot3 = 0;
                    if (TextBox101.Text == "/")
                        Shot3 = 10 - Shot2;
                }
                else if (TextBox101.Text != "")
                    Shot3 = Convert.ToInt32(TextBox101.Text);
            }
            int total = Shot1 + Shot2;
            int total2 = Shot2 + Shot3;
            if (Shot2 == 10 || TextBox100.Text == "/")
            {
                if (Shot2 == 10)
                {
                    if (TextBox90.Text != "X" && TextBox90.Text != "/") { }
                    else
                    {
                        if (TextBox90.Text == "/")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                        if (TextBox80.Text != "X" && TextBox90.Text == "X")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 30);
                        if (TextBox80.Text == "X" && TextBox90.Text == "X")
                        {
                            TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 30);
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 30);
                        }
                    }
                    if (TextBox101.Text == "X" || TextBox101.Text == "-")
                    {
                        if (TextBox101.Text == "X")
                            TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 30);
                        if (TextBox101.Text == "-")
                            TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20);
                    }
                    else
                        TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20 + Shot3);
                }
                if (TextBox100.Text == "/")
                {
                    if (TextBox90.Text != "X" && TextBox90.Text != "/") { }
                    else
                    {
                        if (TextBox90.Text == "X")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                        if (TextBox90.Text == "/")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + Shot1);
                    }
                    if (TextBox101.Text == "X" || TextBox101.Text == "-")
                    {
                        if (TextBox101.Text == "X")
                            TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20);
                        if (TextBox101.Text == "-")
                            TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 10);
                    }
                    else
                        TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 10 + Shot3);
                }
            }
            else
            {
                if (TextBox101.Text == "")
                {
                    if (TextBox90.Text != "X" && TextBox90.Text != "/")
                        TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + total);
                    else
                    {
                        if (TextBox90.Text == "/")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + Shot1);
                        if (TextBox80.Text != "X" && TextBox90.Text == "X")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + total);
                        if (TextBox80.Text == "X" && TextBox90.Text == "X")
                        {
                            TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20 + Shot1);
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + total);
                        }
                        TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + total);
                    }
                }
                else
                {
                    if (TextBox90.Text == "/")
                        TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                    if (TextBox80.Text != "X" && TextBox90.Text == "X")
                        TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20 + Shot2);
                    if (TextBox80.Text == "X" && TextBox90.Text == "X")
                    {
                        TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 30);
                        TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20 + Shot2);
                    }
                    TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 10 + total2);
                }
            }
            if (TextBoxThirty.Text == "300")
            {
                lblError3.ForeColor = System.Drawing.Color.Green;
                lblError3.Text += "Congratulations, " + TextBox111.Text + "! You have bowled a perfect game!";
            }
            else if (Convert.ToInt32(TextBoxThirty.Text) >= 200)
            {
                lblError3.ForeColor = System.Drawing.Color.Green;
                lblError3.Text += "Great game, " + TextBox111.Text + "!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                string name = TextBox111.Text;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10 || name == "")
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                    if (name == "")
                        lblError3.Text += "Error: You must enter in a bowler name.";
                }
                else
                {
                    Label46.Visible = false;
                    TextBox111.Visible = false;
                    if (Shot1 == 10)
                        TextBox10.Text = "X";
                    else
                    {
                        if (Shot1 == 0)
                            TextBox1.Text = "-";
                        else
                            TextBox1.Text = Convert.ToString(Shot1);
                        if (total == 10)
                            TextBox10.Text = "/";
                        else
                        {
                            if (Shot2 == 0)
                                TextBox10.Text = "-";
                            else
                                TextBox10.Text = Convert.ToString(Shot2);
                            TextBox21.Text = " " + Convert.ToString(total);
                        }
                    }
                    if (TextBox20.Text == "")
                    {
                        Button1.Visible = false;
                        Button2.Visible = true;
                        Label42.Text = "2";
                    }
                    else if (TextBox30.Text == "")
                    {
                        Button1.Visible = false;
                        Button3.Visible = true;
                        Label42.Text = "3";
                        CorrectFrame2();
                    }
                    else if (TextBox40.Text == "")
                    {
                        Button1.Visible = false;
                        Button4.Visible = true;
                        Label42.Text = "4";
                        CorrectFrame2();
                        CorrectFrame3();
                    }
                    else if (TextBox50.Text == "")
                    {
                        Button1.Visible = false;
                        Button5.Visible = true;
                        Label42.Text = "5";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                    }
                    else if (TextBox60.Text == "")
                    {
                        Button1.Visible = false;
                        Button6.Visible = true;
                        Label42.Text = "6";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                    }
                    else if (TextBox70.Text == "")
                    {
                        Button1.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button1.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button1.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button1.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button1.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame2();
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox10.Text == "/")
                            TextBox21.Text = "20";
                        TextBox20.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox2.Text = "-";
                        else
                            TextBox2.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox10.Text == "X")
                                TextBox21.Text = "20";
                            if (TextBox10.Text == "/")
                                TextBox21.Text = Convert.ToString(10 + Convert.ToInt32(TextBox2.Text));
                            TextBox20.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox20.Text = "-";
                            else
                                TextBox20.Text = Convert.ToString(Shot2);
                            if (TextBox10.Text == "X")
                                TextBox21.Text = Convert.ToString(10 + total);
                            if (TextBox10.Text == "/")
                                TextBox21.Text = Convert.ToString(10 + Shot1);
                            TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + total);
                        }
                    }
                    if (TextBox30.Text == "")
                    {
                        Button2.Visible = false;
                        Button3.Visible = true;
                        Label42.Text = "3";
                    }
                    else if (TextBox40.Text == "")
                    {
                        Button2.Visible = false;
                        Button4.Visible = true;
                        Label42.Text = "4";
                        CorrectFrame3();
                    }
                    else if (TextBox50.Text == "")
                    {
                        Button2.Visible = false;
                        Button5.Visible = true;
                        Label42.Text = "5";
                        CorrectFrame3();
                        CorrectFrame4();
                    }
                    else if (TextBox60.Text == "")
                    {
                        Button2.Visible = false;
                        Button6.Visible = true;
                        Label42.Text = "6";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                    }
                    else if (TextBox70.Text == "")
                    {
                        Button2.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button2.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button2.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button2.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button2.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame3();
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox20.Text == "/")
                            TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                        if (TextBox10.Text == "X" && TextBox20.Text == "X")
                            TextBox21.Text = "30";
                        TextBox30.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox3.Text = "-";
                        else
                            TextBox3.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox20.Text == "/")
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + Shot1);
                            if (TextBox10.Text != "X" && TextBox20.Text == "X")
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                            if (TextBox10.Text == "X" && TextBox20.Text == "X")
                            {
                                TextBox21.Text = Convert.ToString(20 + Shot1);
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20);
                            }
                            TextBox30.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox30.Text = "-";
                            else
                                TextBox30.Text = Convert.ToString(Shot2);
                            if (TextBox20.Text == "/")
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + Shot1);
                            if (TextBox10.Text != "X" && TextBox20.Text == "X")
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + total);
                            if (TextBox10.Text == "X" && TextBox20.Text == "X")
                            {
                                TextBox21.Text = Convert.ToString(Convert.ToInt32(TextBox20.Text) + 20 + Shot1);
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 10 + total);
                            }
                            TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + total);
                        }
                    }
                    if (TextBox40.Text == "")
                    {
                        Button3.Visible = false;
                        Button4.Visible = true;
                        Label42.Text = "4";
                    }
                    else if (TextBox50.Text == "")
                    {
                        Button3.Visible = false;
                        Button5.Visible = true;
                        Label42.Text = "5";
                        CorrectFrame4();
                    }
                    else if (TextBox60.Text == "")
                    {
                        Button3.Visible = false;
                        Button6.Visible = true;
                        Label42.Text = "6";
                        CorrectFrame4();
                        CorrectFrame5();
                    }
                    else if (TextBox70.Text == "")
                    {
                        Button3.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button3.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button3.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button3.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button3.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame4();
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox30.Text == "/")
                            TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                        if (TextBox20.Text == "X" && TextBox30.Text == "X")
                            TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 30);
                        TextBox40.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox4.Text = "-";
                        else
                            TextBox4.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox30.Text == "/")
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + Shot1);
                            if (TextBox20.Text != "X" && TextBox30.Text == "X")
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                            if (TextBox20.Text == "X" && TextBox30.Text == "X")
                            {
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20 + Shot1);
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20);
                            }
                            TextBox40.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox40.Text = "-";
                            else
                                TextBox40.Text = Convert.ToString(Shot2);
                            if (TextBox30.Text == "/")
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + Shot1);
                            if (TextBox20.Text != "X" && TextBox30.Text == "X")
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + total);
                            if (TextBox20.Text == "X" && TextBox30.Text == "X")
                            {
                                TextBox22.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + 20 + Shot1);
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 10 + total);
                            }
                            TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + total);
                        }
                    }
                    if (TextBox50.Text == "")
                    {
                        Button4.Visible = false;
                        Button5.Visible = true;
                        Label42.Text = "5";
                    }
                    else if (TextBox60.Text == "")
                    {
                        Button4.Visible = false;
                        Button6.Visible = true;
                        Label42.Text = "6";
                        CorrectFrame5();
                    }
                    else if (TextBox70.Text == "")
                    {
                        Button4.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                        CorrectFrame5();
                        CorrectFrame6();
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button4.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button4.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button4.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button4.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame5();
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox40.Text == "/")
                            TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                        if (TextBox30.Text == "X" && TextBox40.Text == "X")
                            TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 30);
                        TextBox50.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox5.Text = "-";
                        else
                            TextBox5.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox40.Text == "/")
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + Shot1);
                            if (TextBox30.Text != "X" && TextBox40.Text == "X")
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                            if (TextBox30.Text == "X" && TextBox40.Text == "X")
                            {
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20 + Shot1);
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20);
                            }
                            TextBox50.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox50.Text = "-";
                            else
                                TextBox50.Text = Convert.ToString(Shot2);
                            if (TextBox40.Text == "/")
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + Shot1);
                            if (TextBox30.Text != "X" && TextBox40.Text == "X")
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + total);
                            if (TextBox30.Text == "X" && TextBox40.Text == "X")
                            {
                                TextBox23.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + 20 + Shot1);
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 10 + total);
                            }
                            TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + total);
                        }
                    }
                    if (TextBox60.Text == "")
                    {
                        Button5.Visible = false;
                        Button6.Visible = true;
                        Label42.Text = "6";
                    }
                    else if (TextBox70.Text == "")
                    {
                        Button5.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                        CorrectFrame6();
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button5.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame6();
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button5.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button5.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button5.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame6();
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox50.Text == "/")
                            TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                        if (TextBox40.Text == "X" && TextBox50.Text == "X")
                            TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 30);
                        TextBox60.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox6.Text = "-";
                        else
                            TextBox6.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox50.Text == "/")
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + Shot1);
                            if (TextBox40.Text != "X" && TextBox50.Text == "X")
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                            if (TextBox40.Text == "X" && TextBox50.Text == "X")
                            {
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20 + Shot1);
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20);
                            }
                            TextBox60.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox60.Text = "-";
                            else
                                TextBox60.Text = Convert.ToString(Shot2);
                            if (TextBox50.Text == "/")
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + Shot1);
                            if (TextBox40.Text != "X" && TextBox50.Text == "X")
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + total);
                            if (TextBox40.Text == "X" && TextBox50.Text == "X")
                            {
                                TextBox24.Text = Convert.ToString(Convert.ToInt32(TextBox23.Text) + 20 + Shot1);
                                TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 10 + total);
                            }
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + total);
                        }
                    }
                    if (TextBox70.Text == "")
                    {
                        Button6.Visible = false;
                        Button7.Visible = true;
                        Label42.Text = "7";
                    }
                    else if (TextBox80.Text == "")
                    {
                        Button6.Visible = false;
                        Button8.Visible = true;
                        Label42.Text = "8";
                        CorrectFrame7();
                    }
                    else if (TextBox90.Text == "")
                    {
                        Button6.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                        CorrectFrame7();
                        CorrectFrame8();
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button6.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button6.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame7();
                        CorrectFrame8();
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            // try
            // {
            lblError3.Text = "";
            int Shot1 = Convert.ToInt32(TextBox11.Text);
            int Shot2 = Convert.ToInt32(TextBox12.Text);
            int total = Shot1 + Shot2;
            if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
            {
                if (Shot1 < 0 || Shot2 < 0)
                    lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                if (Shot1 > 10 || Shot2 > 10)
                    lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                if (total > 10)
                    lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
            }
            else
            {
                if (Shot1 == 10)
                {
                    if (TextBox60.Text == "/")
                        TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                    if (TextBox50.Text == "X" && TextBox60.Text == "X")
                        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 30);
                    TextBox70.Text = "X";
                }
                else
                {
                    if (Shot1 == 0)
                        TextBox7.Text = "-";
                    else
                        TextBox7.Text = Convert.ToString(Shot1);
                    if (total == 10)
                    {
                        if (TextBox60.Text == "/")
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + Shot1);
                        if (TextBox50.Text != "X" && TextBox60.Text == "X")
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                        if (TextBox50.Text == "X" && TextBox60.Text == "X")
                        {
                            TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20 + Shot1);
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20);
                        }
                        TextBox70.Text = "/";
                    }
                    else
                    {
                        if (Shot2 == 0)
                            TextBox70.Text = "-";
                        else
                            TextBox70.Text = Convert.ToString(Shot2);
                        if (TextBox60.Text == "/")
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + Shot1);
                        if (TextBox50.Text != "X" && TextBox60.Text == "X")
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + total);
                        if (TextBox50.Text == "X" && TextBox60.Text == "X")
                        {
                            TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox24.Text) + 20 + Shot1);
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 10 + total);
                        }
                        TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + total);
                    }
                }
                if (TextBox80.Text == "")
                {
                    Button7.Visible = false;
                    Button8.Visible = true;
                    Label42.Text = "8";
                }
                else if (TextBox90.Text == "")
                {
                    Button7.Visible = false;
                    Button9.Visible = true;
                    Label42.Text = "9";
                    CorrectFrame8();
                }
                else if (TextBoxTen.Text == "")
                {
                    Button7.Visible = false;
                    Button10.Visible = true;
                    Label42.Text = "10";
                    CorrectFrame8();
                    CorrectFrame9();
                }
                if (TextBoxTen.Text != "")
                {
                    Button7.Visible = false;
                    Label42.Text = "10";
                    CorrectFrame8();
                    CorrectFrame9();
                    CorrectFrame10();
                }
            }
            /* }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            } */
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox70.Text == "/")
                            TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                        if (TextBox60.Text == "X" && TextBox70.Text == "X")
                            TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 30);
                        TextBox80.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox8.Text = "-";
                        else
                            TextBox8.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox70.Text == "/")
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + Shot1);
                            if (TextBox60.Text != "X" && TextBox70.Text == "X")
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                            if (TextBox60.Text == "X" && TextBox70.Text == "X")
                            {
                                TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20 + Shot1);
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20);
                            }
                            TextBox80.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox80.Text = "-";
                            else
                                TextBox80.Text = Convert.ToString(Shot2);
                            if (TextBox70.Text == "/")
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + Shot1);
                            if (TextBox60.Text != "X" && TextBox70.Text == "X")
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + total);
                            if (TextBox60.Text == "X" && TextBox70.Text == "X")
                            {
                                TextBox26.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + 20 + Shot1);
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 10 + total);
                            }
                            TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + total);
                        }
                    }
                    if (TextBox90.Text == "")
                    {
                        Button8.Visible = false;
                        Button9.Visible = true;
                        Label42.Text = "9";
                    }
                    else if (TextBoxTen.Text == "")
                    {
                        Button8.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                        CorrectFrame9();
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button8.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame9();
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || total > 10)
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                    if (total > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins in one frame. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        if (TextBox80.Text == "/")
                            TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                        if (TextBox70.Text == "X" && TextBox80.Text == "X")
                            TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 30);
                        TextBox90.Text = "X";
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBox9.Text = "-";
                        else
                            TextBox9.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            if (TextBox80.Text == "/")
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + Shot1);
                            if (TextBox70.Text != "X" && TextBox80.Text == "X")
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                            if (TextBox70.Text == "X" && TextBox80.Text == "X")
                            {
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20 + Shot1);
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20);
                            }
                            TextBox90.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox90.Text = "-";
                            else
                                TextBox90.Text = Convert.ToString(Shot2);
                            if (TextBox80.Text == "/")
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + Shot1);
                            if (TextBox70.Text != "X" && TextBox80.Text == "X")
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + total);
                            if (TextBox70.Text == "X" && TextBox80.Text == "X")
                            {
                                TextBox27.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + 20 + Shot1);
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 10 + total);
                            }
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + total);
                        }
                    }
                    if (TextBoxTen.Text == "")
                    {
                        Button9.Visible = false;
                        Button10.Visible = true;
                        Label42.Text = "10";
                    }
                    if (TextBoxTen.Text != "")
                    {
                        Button9.Visible = false;
                        Label42.Text = "10";
                        CorrectFrame10();
                    }
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot1 = Convert.ToInt32(TextBox11.Text);
                int Shot2 = Convert.ToInt32(TextBox12.Text);
                int total = Shot1 + Shot2;
                if (Shot1 < 0 || Shot2 < 0 || Shot1 > 10 || Shot2 > 10 || (Shot1 != 10 && total > 10))
                {
                    if (Shot1 < 0 || Shot2 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10 || Shot2 > 10 || (Shot1 != 10 && total > 10))
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                }
                else
                {
                    if (Shot1 == 10)
                    {
                        Label44.Visible = false;
                        Label45.Visible = false;
                        Label43.Visible = true;
                        TextBox11.Visible = false;
                        TextBox12.Visible = false;
                        TextBox110.Visible = true;
                        Button11.Visible = true;
                        if (TextBox90.Text == "/")
                            TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                        if (TextBox80.Text == "X" && TextBox90.Text == "X")
                            TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 30);
                        TextBoxTen.Text = "X";
                        if (Shot2 == 10)
                        {
                            TextBox100.Text = "X";
                            if (TextBox90.Text == "X")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 30);
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox100.Text = "-";
                            else
                                TextBox100.Text = Convert.ToString(Shot2);
                            if (TextBox90.Text == "X")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20 + Shot2);
                        }
                    }
                    else
                    {
                        if (Shot1 == 0)
                            TextBoxTen.Text = "-";
                        else
                            TextBoxTen.Text = Convert.ToString(Shot1);
                        if (total == 10)
                        {
                            Label44.Visible = false;
                            Label45.Visible = false;
                            Label43.Visible = true;
                            TextBox11.Visible = false;
                            TextBox12.Visible = false;
                            TextBox110.Visible = true;
                            Button11.Visible = true;
                            if (TextBox90.Text == "/")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + Shot1);
                            if (TextBox80.Text != "X" && TextBox90.Text == "X")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                            if (TextBox80.Text == "X" && TextBox90.Text == "X")
                            {
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20 + Shot1);
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 20);
                            }
                            TextBox100.Text = "/";
                        }
                        else
                        {
                            if (Shot2 == 0)
                                TextBox100.Text = "-";
                            else
                                TextBox100.Text = Convert.ToString(Shot2);
                            if (TextBox90.Text == "/")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + Shot1);
                            if (TextBox80.Text != "X" && TextBox90.Text == "X")
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + total);
                            if (TextBox80.Text == "X" && TextBox90.Text == "X")
                            {
                                TextBox28.Text = Convert.ToString(Convert.ToInt32(TextBox27.Text) + 20 + Shot1);
                                TextBox29.Text = Convert.ToString(Convert.ToInt32(TextBox28.Text) + 10 + total);
                            }
                            TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + total);
                            if (Convert.ToInt32(TextBoxThirty.Text) >= 200)
                            {
                                lblError3.ForeColor = System.Drawing.Color.Green;
                                lblError3.Text += "Great game, " + TextBox111.Text + "!";
                            }
                        }
                    }
                }
                Button10.Visible = false;
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                lblError3.Text = "";
                int Shot = 0;
                if (TextBox100.Text == "X" || TextBox100.Text == "/" || TextBox100.Text == "-") { }
                else
                    Shot = Convert.ToInt32(TextBox100.Text);
                int Shot1 = Convert.ToInt32(TextBox110.Text);
                if (Shot1 < 0 || Shot1 > 10)
                {
                    if (Shot1 < 0)
                        lblError3.Text += "Error: Cannot knock down negative number of pins on a shot. ";
                    if (Shot1 > 10)
                        lblError3.Text += "Error: Cannot knock down more than 10 pins on one shot. ";
                }
                else
                {
                    if (TextBox100.Text == "X")
                    {
                        if (Shot1 == 10)
                        {
                            if (TextBox100.Text == "/")
                                TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20);
                            if (TextBox100.Text == "X")
                            {
                                TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 30);
                                if (TextBoxThirty.Text == "300")
                                {
                                    lblError3.ForeColor = System.Drawing.Color.Green;
                                    lblError3.Text += "Congratulations, " + TextBox111.Text + "! You have bowled a perfect game!";
                                }
                            }
                            TextBox101.Text = "X";
                        }
                        else
                        {
                            if (Shot1 == 0)
                            {
                                TextBox101.Text = "-";
                                TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20);
                            }
                            else
                            {
                                TextBox101.Text = Convert.ToString(Shot1);
                                TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20 + Shot1);
                            }
                        }
                        Button11.Visible = false;
                    }
                    else
                    {
                        int pinsRemaining = 10 - Shot;
                        if (Shot1 > pinsRemaining)
                            lblError3.Text += "Error: Cannot knock down more than 10 pins on one spare. ";
                        else
                        {
                            if (Shot1 == pinsRemaining)
                            {
                                if (Shot == 0)
                                    if (TextBox100.Text == "/")
                                        TextBox101.Text = "X";
                                    else
                                        TextBox101.Text = "/";
                                else
                                    TextBox101.Text = "/";
                                TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 20);
                            }
                            else
                            {
                                if (Shot1 == 0)
                                {
                                    TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 10 + Shot);
                                    TextBox101.Text = "-";
                                }
                                else
                                {
                                    TextBoxThirty.Text = Convert.ToString(Convert.ToInt32(TextBox29.Text) + 10 + Shot + Shot1);
                                    TextBox101.Text = Convert.ToString(Shot1);
                                }
                            }
                            Button11.Visible = false;
                        }
                    }
                }
                if (TextBoxThirty.Text != "300" && Convert.ToInt32(TextBoxThirty.Text) >= 200)
                {
                    lblError3.ForeColor = System.Drawing.Color.Green;
                    lblError3.Text += "Great game, " + TextBox111.Text + "!";
                }
            }
            catch (FormatException)
            {
                lblError3.Text += "Error: You must enter an integer/whole number into each text box, i.e. not a decimal number, letters and/or special characters, or a blank space. ";
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            lblError3.ForeColor = System.Drawing.Color.Red;
            lblError3.Text = "";
            Label43.Visible = false;
            Label44.Visible = true;
            Label45.Visible = true;
            Label46.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBoxTen.Text = "";
            TextBox11.Text = "";
            TextBox11.Visible = true;
            TextBox12.Text = "";
            TextBox12.Visible = true;
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox23.Text = "";
            TextBox24.Text = "";
            TextBox25.Text = "";
            TextBox26.Text = "";
            TextBox27.Text = "";
            TextBox28.Text = "";
            TextBox29.Text = "";
            TextBox30.Text = "";
            TextBoxThirty.Text = "";
            TextBox40.Text = "";
            TextBox50.Text = "";
            TextBox60.Text = "";
            TextBox70.Text = "";
            TextBox80.Text = "";
            TextBox90.Text = "";
            TextBox100.Text = "";
            TextBox101.Text = "";
            TextBox110.Visible = false;
            TextBox111.Visible = true;
            Button1.Visible = true;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
            Button8.Visible = false;
            Button9.Visible = false;
            Button10.Visible = false;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            lblError3.ForeColor = System.Drawing.Color.Red;
            lblError3.Text = "";
            if ((TextBox100.Text == "X" || TextBox100.Text == "/") && TextBox101.Text == "") { }
            else
            {
                Label43.Visible = false;
                Label44.Visible = true;
                Label45.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox110.Visible = false;
            }
            if (ListBox2.SelectedValue == "Previous")
            {
                if (Label42.Text != "1")
                {
                    int frame = Convert.ToInt32(Label42.Text) - 1;
                    Label42.Text = Convert.ToString(frame);
                }
                if (TextBox10.Text != "" && TextBox20.Text == "")
                {
                    TextBox1.Text = "";
                    TextBox10.Text = "";
                    TextBox21.Text = "";
                    Button1.Visible = true;
                    Button2.Visible = false;
                }
                if (TextBox20.Text != "" && TextBox30.Text == "")
                {
                    TextBox2.Text = "";
                    TextBox20.Text = "";
                    TextBox22.Text = "";
                    if (TextBox10.Text == "X" || TextBox10.Text == "/")
                        TextBox21.Text = "";
                    Button2.Visible = true;
                    Button3.Visible = false;
                }
                if (TextBox30.Text != "" && TextBox40.Text == "")
                {
                    TextBox3.Text = "";
                    TextBox30.Text = "";
                    TextBox23.Text = "";
                    Button3.Visible = true;
                    Button4.Visible = false;
                    if (TextBox20.Text == "X" || TextBox20.Text == "/")
                        TextBox22.Text = "";
                    if (TextBox10.Text == "X" && TextBox20.Text == "X")
                        TextBox21.Text = "";
                    CorrectFrame2();
                }
                if (TextBox40.Text != "" && TextBox50.Text == "")
                {
                    TextBox4.Text = "";
                    TextBox40.Text = "";
                    TextBox24.Text = "";
                    Button4.Visible = true;
                    Button5.Visible = false;
                    if (TextBox30.Text == "X" || TextBox30.Text == "/")
                        TextBox23.Text = "";
                    if (TextBox20.Text == "X" && TextBox30.Text == "X")
                        TextBox22.Text = "";
                    CorrectFrame2();
                    CorrectFrame3();
                }
                if (TextBox50.Text != "" && TextBox60.Text == "")
                {
                    TextBox5.Text = "";
                    TextBox50.Text = "";
                    TextBox25.Text = "";
                    Button5.Visible = true;
                    Button6.Visible = false;
                    if (TextBox40.Text == "X" || TextBox40.Text == "/")
                        TextBox24.Text = "";
                    if (TextBox30.Text == "X" && TextBox40.Text == "X")
                        TextBox23.Text = "";
                    CorrectFrame2();
                    CorrectFrame3();
                    CorrectFrame4();
                }
                if (TextBox60.Text != "" && TextBox70.Text == "")
                {
                    TextBox6.Text = "";
                    TextBox60.Text = "";
                    TextBox26.Text = "";
                    Button6.Visible = true;
                    Button7.Visible = false;
                    if (TextBox50.Text == "X" || TextBox50.Text == "/")
                        TextBox25.Text = "";
                    if (TextBox40.Text == "X" && TextBox50.Text == "X")
                        TextBox24.Text = "";
                    CorrectFrame2();
                    CorrectFrame3();
                    CorrectFrame4();
                    CorrectFrame5();
                }
                if (TextBox70.Text != "" && TextBox80.Text == "")
                {
                    TextBox7.Text = "";
                    TextBox70.Text = "";
                    TextBox27.Text = "";
                    Button7.Visible = true;
                    Button8.Visible = false;
                    if (TextBox60.Text == "X" || TextBox60.Text == "/")
                        TextBox26.Text = "";
                    if (TextBox50.Text == "X" && TextBox60.Text == "X")
                        TextBox25.Text = "";
                }
                if (TextBox80.Text != "" && TextBox90.Text == "")
                {
                    TextBox8.Text = "";
                    TextBox80.Text = "";
                    TextBox28.Text = "";
                    Button8.Visible = true;
                    Button9.Visible = false;
                    if (TextBox70.Text == "X" || TextBox70.Text == "/")
                        TextBox27.Text = "";
                    if (TextBox60.Text == "X" && TextBox70.Text == "X")
                        TextBox26.Text = "";
                }
                if (TextBox90.Text != "" && TextBox100.Text == "")
                {
                    TextBox9.Text = "";
                    TextBox90.Text = "";
                    TextBox29.Text = "";
                    Button9.Visible = true;
                    Button10.Visible = false;
                    if (TextBox80.Text == "X" || TextBox80.Text == "/")
                        TextBox28.Text = "";
                    if (TextBox70.Text == "X" && TextBox80.Text == "X")
                        TextBox27.Text = "";
                }
                if (TextBox100.Text != "")
                {
                    if ((TextBox100.Text == "X" || TextBox100.Text == "/") && TextBox101.Text == "")
                    {
                        lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                    }
                    else
                    {
                        TextBoxTen.Text = "";
                        TextBox100.Text = "";
                        TextBox101.Text = "";
                        TextBoxThirty.Text = "";
                        Button10.Visible = true;
                        Label43.Visible = false;
                        Label44.Visible = true;
                        Label45.Visible = true;
                        TextBox11.Visible = true;
                        TextBox12.Visible = true;
                        TextBox110.Visible = false;
                        if (TextBox90.Text == "X" || TextBox90.Text == "/")
                            TextBox29.Text = "";
                        if (TextBox80.Text == "X" && TextBox90.Text == "X")
                            TextBox28.Text = "";
                    }
                }
            }
            if (ListBox2.SelectedValue == "1")
            {
                TextBox1.Text = "";
                TextBox10.Text = "";
                TextBox21.Text = "";
                Button1.Visible = true;
                int frame = Convert.ToInt32(Label42.Text);
                if (frame == 2)
                    Button2.Visible = false;
                if (frame == 3)
                {
                    Button3.Visible = false;
                    TextBox22.Text = "";
                }
                if (frame == 4)
                {
                    Button4.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                }
                if (frame == 5)
                {
                    Button5.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                }
                if (frame == 6)
                {
                    Button6.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                }
                if (frame == 7)
                {
                    Button7.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox26.Text = "";
                }
                if (frame == 8)
                {
                    Button8.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox26.Text = "";
                    TextBox27.Text = "";
                }
                if (frame == 9)
                {
                    Button9.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox26.Text = "";
                    TextBox27.Text = "";
                    TextBox28.Text = "";
                }
                if (frame == 10)
                {
                    Button10.Visible = false;
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox26.Text = "";
                    TextBox27.Text = "";
                    TextBox28.Text = "";
                    TextBox29.Text = "";
                }
                Label42.Text = ListBox2.SelectedValue;
            }
            if (ListBox2.SelectedValue == "2")
            {
                if (TextBox10.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox2.Text = "";
                    TextBox20.Text = "";
                    TextBox22.Text = "";
                    Button2.Visible = true;
                    if (TextBox10.Text == "X" || TextBox10.Text == "/")
                        TextBox21.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 3)
                        Button3.Visible = false;
                    if (frame == 4)
                    {
                        Button4.Visible = false;
                        TextBox23.Text = "";
                    }
                    if (frame == 5)
                    {
                        Button5.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                    }
                    if (frame == 6)
                    {
                        Button6.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                    }
                    if (frame == 7)
                    {
                        Button7.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                    }
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox23.Text = "";
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "3")
            {
                if (TextBox20.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox3.Text = "";
                    TextBox30.Text = "";
                    TextBox23.Text = "";
                    Button3.Visible = true;
                    if (TextBox20.Text == "X" || TextBox20.Text == "/")
                        TextBox22.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 4)
                    {
                        Button4.Visible = false;
                        if (TextBox10.Text == "X" && TextBox20.Text == "X")
                            TextBox21.Text = "";
                    }
                    if (frame >= 5 && frame <= 10)
                    {
                        if (TextBox10.Text == "X" && TextBox20.Text == "X")
                        {
                            TextBox21.Text = "";
                            TextBox22.Text = "";
                        }
                    }
                    if (frame == 5)
                    {
                        Button5.Visible = false;
                        TextBox24.Text = "";
                    }
                    if (frame == 6)
                    {
                        Button6.Visible = false;
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                    }
                    if (frame == 7)
                    {
                        Button7.Visible = false;
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                    }
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox24.Text = "";
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                    CorrectFrame2();
                }
            }
            if (ListBox2.SelectedValue == "4")
            {
                if (TextBox30.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox4.Text = "";
                    TextBox40.Text = "";
                    TextBox24.Text = "";
                    Button4.Visible = true;
                    if (TextBox30.Text == "X" || TextBox30.Text == "/")
                        TextBox23.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 5)
                    {
                        Button5.Visible = false;
                        if (TextBox20.Text == "X" && TextBox30.Text == "X")
                            TextBox22.Text = "";
                    }
                    if (frame >= 6 && frame <= 10)
                    {
                        if (TextBox20.Text == "X" && TextBox30.Text == "X")
                        {
                            TextBox22.Text = "";
                            TextBox23.Text = "";
                        }
                    }
                    if (frame == 6)
                    {
                        Button6.Visible = false;
                        TextBox25.Text = "";
                    }
                    if (frame == 7)
                    {
                        Button7.Visible = false;
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                    }
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox25.Text = "";
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "5")
            {
                if (TextBox40.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox5.Text = "";
                    TextBox50.Text = "";
                    TextBox25.Text = "";
                    Button5.Visible = true;
                    if (TextBox40.Text == "X" || TextBox40.Text == "/")
                        TextBox24.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 6)
                    {
                        Button6.Visible = false;
                        if (TextBox30.Text == "X" && TextBox40.Text == "X")
                            TextBox23.Text = "";
                    }
                    if (frame >= 7 && frame <= 10)
                    {
                        if (TextBox30.Text == "X" && TextBox40.Text == "X")
                        {
                            TextBox23.Text = "";
                            TextBox24.Text = "";
                        }
                    }
                    if (frame == 7)
                    {
                        Button7.Visible = false;
                        TextBox26.Text = "";
                    }
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox26.Text = "";
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "6")
            {
                if (TextBox50.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox6.Text = "";
                    TextBox60.Text = "";
                    TextBox26.Text = "";
                    Button6.Visible = true;
                    if (TextBox50.Text == "X" || TextBox50.Text == "/")
                        TextBox25.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 7)
                    {
                        Button7.Visible = false;
                        if (TextBox40.Text == "X" && TextBox50.Text == "X")
                            TextBox24.Text = "";
                    }
                    if (frame >= 8 && frame <= 10)
                    {
                        if (TextBox40.Text == "X" && TextBox50.Text == "X")
                        {
                            TextBox24.Text = "";
                            TextBox25.Text = "";
                        }
                    }
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        TextBox27.Text = "";
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox27.Text = "";
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "7")
            {
                if (TextBox60.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox7.Text = "";
                    TextBox70.Text = "";
                    TextBox27.Text = "";
                    Button7.Visible = true;
                    if (TextBox60.Text == "X" || TextBox60.Text == "/")
                        TextBox26.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 8)
                    {
                        Button8.Visible = false;
                        if (TextBox50.Text == "X" && TextBox60.Text == "X")
                            TextBox25.Text = "";
                    }
                    if (frame == 9 || frame == 10)
                    {
                        if (TextBox50.Text == "X" && TextBox60.Text == "X")
                        {
                            TextBox25.Text = "";
                            TextBox26.Text = "";
                        }
                    }
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        TextBox28.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        TextBox28.Text = "";
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "8")
            {
                if (TextBox70.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox8.Text = "";
                    TextBox80.Text = "";
                    TextBox28.Text = "";
                    Button8.Visible = true;
                    if (TextBox70.Text == "X" || TextBox70.Text == "/")
                        TextBox27.Text = "";
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 9)
                    {
                        Button9.Visible = false;
                        if (TextBox60.Text == "X" && TextBox70.Text == "X")
                            TextBox26.Text = "";
                    }
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        if (TextBox60.Text == "X" && TextBox70.Text == "X")
                        {
                            TextBox26.Text = "";
                            TextBox27.Text = "";
                        }
                        TextBox29.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "9")
            {
                if (TextBox80.Text == "")
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBox9.Text = "";
                    TextBox90.Text = "";
                    TextBox29.Text = "";
                    if (TextBox80.Text == "X" || TextBox80.Text == "/")
                        TextBox28.Text = "";
                    Button9.Visible = true;
                    int frame = Convert.ToInt32(Label42.Text);
                    if (frame == 10)
                    {
                        Button10.Visible = false;
                        if (TextBox70.Text == "X" && TextBox80.Text == "X")
                            TextBox27.Text = "";
                        if (TextBox100.Text != "")
                            TextBoxThirty.Text = "";
                        else { }
                    }
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
            if (ListBox2.SelectedValue == "10")
            {
                if (TextBox90.Text == "" || (TextBox100.Text != "" && TextBox101.Text == ""))
                {
                    lblError3.Text += "Please finish scoring the current frame before selecting a new frame.";
                }
                else
                {
                    TextBoxTen.Text = "";
                    TextBox100.Text = "";
                    TextBox101.Text = "";
                    TextBoxThirty.Text = "";
                    Button10.Visible = true;
                    Label43.Visible = false;
                    Label44.Visible = true;
                    Label45.Visible = true;
                    TextBox11.Visible = true;
                    TextBox12.Visible = true;
                    TextBox110.Visible = false;
                    if (TextBox90.Text == "X" || TextBox90.Text == "/")
                        TextBox29.Text = "";
                    if (TextBox80.Text == "X" && TextBox90.Text == "X")
                        TextBox28.Text = "";
                    Label42.Text = ListBox2.SelectedValue;
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                lblError4.Text = "";
                lblIPAddress.Text = "IP Address(es): ";
                lblCookies.Text = "Information on website's cookies (if any): ";
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path = path.Replace(@"\", @"\\");
                string url = TextBox102.Text;
                if (url.Length >= 8)
                {
                    string http = url.Substring(0, 7);
                    string https = url.Substring(0, 8);
                    if (http != "http://" && https != "https://")
                        url = "http://" + url;
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.CookieContainer = new CookieContainer();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                StreamWriter sw = new StreamWriter(path + "\\HTMLSourceCode.txt");
                sw.Write(sr.ReadToEnd());
                sr.Close();
                sw.Close();
                string hostname = response.ResponseUri.Host;
                IPHostEntry host;
                host = Dns.GetHostEntry(hostname);
                foreach (IPAddress ip in host.AddressList)
                {
                    lblIPAddress.Text += ip + "  ";
                }
                foreach (Cookie cook in response.Cookies)
                {
                    string version = cook.Version == 1 ? "2109" : "2965";
                    lblCookies.Text += "Cookie: " + cook.Name + " = " + cook.Value + ". Domain: " + cook.Domain + ". Path: " + cook.Path + ". Port: " + cook.Port + ". Secure: " + cook.Secure
                        + ". When Issued: " + cook.TimeStamp + ". Expires: " + cook.Expires + "...Expired? " + cook.Expired + ". Don't save: " + cook.Discard + ". Comment: " + cook.Comment
                        + ". URI for comments: " + cook.CommentUri + ". Version: RFC " + version + ". String: " + cook.ToString() + "\n";
                }
            }
            catch (HttpUnhandledException)
            {
                lblError4.Text += "Error: The requested URL could not be resolved.";
            }
            catch (UriFormatException)
            {
                lblError4.Text += "Error: The requested URL could not be resolved.";
            }
            catch (WebException)
            {
                lblError4.Text += "Error: The requested URL could not be resolved.";
            }
            catch (IOException)
            {
                lblError4.Text += "An I/O error occurred trying to write the code to the Desktop file.";
            }
            catch (Exception er)
            {
                lblError4.Text += er.Message;
            }
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            lblHash.Text = "";
            string variable = TextBox107.Text;
            int hash = variable.GetHashCode();
            lblHash.Text = "Regular hash code: " + Convert.ToString(hash);
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(variable);
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            HashAlgorithm sha256 = new SHA256CryptoServiceProvider();
            byte[] result = sha256.ComputeHash(tmpSource);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] result2 = sha1.ComputeHash(tmpSource);
            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            StringBuilder sOutput2 = new StringBuilder(result.Length);
            StringBuilder sOutput3 = new StringBuilder(result2.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));
                sOutput2.Append(result[i].ToString("X2"));
                sOutput3.Append(result2[i].ToString("X2"));
            }
            lblHash.Text += ", MD5 checksum hash: " + sOutput.ToString();
            lblHash.Text += ", SHA1 checksum hash: " + sOutput3.ToString();
            lblHash.Text += ", SHA256 checksum hash: " + sOutput2.ToString();
        }

        protected void Button22_Click(object sender, EventArgs e)
        { /*
        string fileName = System.IO.Path.GetFileName(FileUpload1.FileName);      // Obtaining file selected from FileUpload control
        string fullPath = Server.MapPath(FileUpload1.FileName);                  // Finding path of user on local machine
        fullPath = fullPath.Remove(fullPath.Length - fileName.Length - 9);       // Removing the file name and "Website\" part of path
        fullPath = fullPath.Replace(@"\", @"\\");                                // Replacing single backslashes with double backslashes
        string pathAndFile = fullPath + fileName;
        string output = fileName.Substring(fileName.Length - 3, 3);
        System.Drawing.Image image = new System.Drawing.Image.FromFile(pathAndFile);
        if (ListBox1.SelectedValue == "JPG")
            if (output == "png")
                image.Save(pathAndFile.Replace("png", "jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        if (output == "gif")
            image.Save(pathAndFile.Replace("gif", "jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        if (output == "bmp")
            image.Save(pathAndFile.Replace("bmp", "jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        if (output == "iff")
            image.Save(pathAndFile.Replace("iff", "jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        if (ListBox1.SelectedValue == "PNG")
            if (output == "jpg")
                image.Save(pathAndFile.Replace("jpg", "png"), System.Drawing.Imaging.ImageFormat.Png);
        if (output == "gif")
            image.Save(pathAndFile.Replace("gif", "png"), System.Drawing.Imaging.ImageFormat.Png);
        if (output == "bmp")
            image.Save(pathAndFile.Replace("bmp", "png"), System.Drawing.Imaging.ImageFormat.Png);
        if (output == "iff")
            image.Save(pathAndFile.Replace("iff", "png"), System.Drawing.Imaging.ImageFormat.Png);
        if (ListBox1.SelectedValue == "GIF")
            if (output == "jpg")
                image.Save(pathAndFile.Replace("jpg", "gif"), System.Drawing.Imaging.ImageFormat.Gif);
        if (output == "png")
            image.Save(pathAndFile.Replace("png", "gif"), System.Drawing.Imaging.ImageFormat.Gif);
        if (output == "bmp")
            image.Save(pathAndFile.Replace("bmp", "gif"), System.Drawing.Imaging.ImageFormat.Gif);
        if (output == "iff")
            image.Save(pathAndFile.Replace("iff", "gif"), System.Drawing.Imaging.ImageFormat.Gif);
        if (ListBox1.SelectedValue == "BMP")
            if (output == "jpg")
                image.Save(pathAndFile.Replace("jpg", "bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
        if (output == "png")
            image.Save(pathAndFile.Replace("png", "bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
        if (output == "gif")
            image.Save(pathAndFile.Replace("gif", "bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
        if (output == "iff")
            image.Save(pathAndFile.Replace("iff", "bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
        if (ListBox1.SelectedValue == "TIFF")
            if (output == "jpg")
                image.Save(pathAndFile.Replace("jpg", "tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
        if (output == "png")
            image.Save(pathAndFile.Replace("png", "tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
        if (output == "gif")
            image.Save(pathAndFile.Replace("gif", "tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
        if (output == "bmp")
            image.Save(pathAndFile.Replace("bmp", "tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
        */
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.FileName);       // Obtaining file selected from FileUpload control
            string fullPath = Server.MapPath(FileUpload1.FileName);                  // Finding path of user on local machine
            fullPath = fullPath.Remove(fullPath.Length - fileName.Length - 9);       // Removing the file name and "Website\" part of path
            fullPath = fullPath.Replace(@"\", @"\\");                                // Replacing single backslashes with double backslashes
            string pathAndFile = fullPath + fileName;
            pathAndFile.Replace("mp3", "wav");
            using (Mp3FileReader reader = new Mp3FileReader(pathAndFile))
            {
                using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                {
                    WaveFileWriter.CreateWaveFile(pathAndFile.Replace("mp3", "wav"), pcmStream);
                }
            }
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.FileName);                // Obtaining file selected from FileUpload control
            string fullPath = Server.MapPath(FileUpload1.FileName);                  // Finding path of user on local machine
            fullPath = fullPath.Remove(fullPath.Length - fileName.Length - 9);       // Removing the file name and "Website\" part of path
            fullPath = fullPath.Replace(@"\", @"\\");                                // Replacing single backslashes with double backslashes
            string pathAndFile = fullPath + fileName;
            var convert = new FFMpegConverter();
            convert.ConvertMedia(pathAndFile, fullPath + "\\ConvertedToVideo.mp4", Format.mp4);
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.FileName);      // Obtaining file selected from FileUpload control
            string fullPath = Server.MapPath(FileUpload1.FileName);                  // Finding path of user on local machine
            fullPath = fullPath.Remove(fullPath.Length - fileName.Length - 9);       // Removing the file name and "Website\" part of path
            fullPath = fullPath.Replace(@"\", @"\\");                                // Replacing single backslashes with double backslashes
            string pathAndFile = fullPath + fileName;
            StreamWriter sw = new StreamWriter(fullPath + "PDFtoText.txt");
            try
            {
                PdfReader reader = new PdfReader(pathAndFile);
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new LocationTextExtractionStrategy();
                    string s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    sw.WriteLine(s);
                }
                reader.Close();
                sw.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            int rounds = Convert.ToInt32(Label28.Text);
            rounds++;
            Label28.Text = Convert.ToString(rounds);
            Random number = new Random();
            int randomNumber = number.Next(0, 3);
            Image4.ImageUrl = "Images/Rock.PNG";
            Image4.Visible = true;
            Image5.Visible = true;
            if (randomNumber == 0)
            {
                Image5.ImageUrl = "Images/Rock.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Tie.mp3";
                player.controls.play();
                Label27.ForeColor = Color.Blue;
                Label27.Text = "It's a tie!";
                int ties = Convert.ToInt32(Label29.Text);
                ties++;
                Label29.Text = Convert.ToString(ties);
            }
            if (randomNumber == 1)
            {
                Image5.ImageUrl = "Images/Paper.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Price-is-right-losing-horn.mp3";
                player.controls.play();
                int computerScore = Convert.ToInt32(Label24.Text);
                computerScore++;
                Label24.Text = Convert.ToString(computerScore);
                Label27.ForeColor = Color.Red;
                Label27.Text = "You lost!";
            }
            if (randomNumber == 2)
            {
                Image5.ImageUrl = "Images/Scissors.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Winning-sound-effect.mp3";
                player.controls.play();
                int playerScore = Convert.ToInt32(Label23.Text);
                playerScore++;
                Label23.Text = Convert.ToString(playerScore);
                Label27.ForeColor = Color.Green;
                Label27.Text = "You won!";
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            int rounds = Convert.ToInt32(Label28.Text);
            rounds++;
            Label28.Text = Convert.ToString(rounds);
            Random number = new Random();
            int randomNumber = number.Next(0, 3);
            Image4.ImageUrl = "Images/Paper.PNG";
            Image4.Visible = true;
            Image5.Visible = true;
            if (randomNumber == 0)
            {
                Image5.ImageUrl = "Images/Rock.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Winning-sound-effect.mp3";
                player.controls.play();
                int playerScore = Convert.ToInt32(Label23.Text);
                playerScore++;
                Label23.Text = Convert.ToString(playerScore);
                Label27.ForeColor = Color.Green;
                Label27.Text = "You won!";
            }
            if (randomNumber == 1)
            {
                Image5.ImageUrl = "Images/Paper.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Tie.mp3";
                player.controls.play();
                Label27.ForeColor = Color.Blue;
                Label27.Text = "It's a tie!";
                int ties = Convert.ToInt32(Label29.Text);
                ties++;
                Label29.Text = Convert.ToString(ties);
            }
            if (randomNumber == 2)
            {
                Image5.ImageUrl = "Images/Scissors.PNG";
                player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Price-is-right-losing-horn.mp3";
                player.controls.play();
                int computerScore = Convert.ToInt32(Label24.Text);
                computerScore++;
                Label24.Text = Convert.ToString(computerScore);
                Label27.ForeColor = Color.Red;
                Label27.Text = "You lost!";
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            int rounds = Convert.ToInt32(Label28.Text);
            rounds++;
            Label28.Text = Convert.ToString(rounds);
            Random number = new Random();
            int randomNumber = number.Next(0, 3);
            Image4.ImageUrl = "Images/Scissors.PNG";
            Image4.Visible = true;
            Image5.Visible = true;
            if (randomNumber == 0)
            {
                Image5.ImageUrl = "Images/Rock.PNG";
                // player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Price-is-right-losing-horn.mp3";
                // player.controls.play();
                int computerScore = Convert.ToInt32(Label24.Text);
                computerScore++;
                Label24.Text = Convert.ToString(computerScore);
                Label27.ForeColor = Color.Red;
                Label27.Text = "You lost!";
            }
            if (randomNumber == 1)
            {
                Image5.ImageUrl = "Images/Paper.PNG";
                // player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Winning-sound-effect.mp3";
                // player.controls.play();
                int playerScore = Convert.ToInt32(Label23.Text);
                playerScore++;
                Label23.Text = Convert.ToString(playerScore);
                Label27.ForeColor = Color.Green;
                Label27.Text = "You won!";
            }
            if (randomNumber == 2)
            {
                Image5.ImageUrl = "Images/Scissors.PNG";
                // player.URL = "https://maxstechandmathsite.azurewebsites.net/Audio/Tie.mp3";
                // player.controls.play();
                Label27.ForeColor = Color.Blue;
                Label27.Text = "It's a tie!";
                int ties = Convert.ToInt32(Label29.Text);
                ties++;
                Label29.Text = Convert.ToString(ties);
            }
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            TextBox11.Text = "10";
            TextBox12.Text = "0";
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            lblBinary.ForeColor = Color.Black;
            lblBinary.Text = "";
            string hexstring = TextBox112.Text;
            StringBuilder sb = new StringBuilder();
            foreach (char c in hexstring.ToCharArray())
            {
                if (c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'a' && c != 'A' && c != 'b' && c != 'B' && c != 'c' && c != 'C' && c != 'd' && c != 'D' && c != 'e' && c != 'E' && c != 'f' && c != 'F')
                {
                    lblBinary.ForeColor = Color.Red;
                    lblBinary.Text += "Error. Hexadecimal characters can only be from numbers 0-9 and letters A-F.";
                    return;
                }
            }
            string binarystring = String.Join(String.Empty, hexstring.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0') + " "));
            lblBinary.Text += binarystring;
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            lblBinary.Text = "";
            string input = TextBox113.Text;
            lblBinary2.Text += String.Join(".", (input.Split('.').Select(x => Convert.ToString(Int32.Parse(x), 2).PadLeft(8, '0'))).ToArray());
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            lblASCII.Text = "";
            char c = Convert.ToChar(TextBox114.Text);
            byte[] asciiByte = new byte[c];
            asciiByte = ASCIIEncoding.ASCII.GetBytes(c.ToString());
            int value = Convert.ToInt32(c);
            string format = String.Format("{0:X}", value);
            string binary = Convert.ToString(value, 2);
            string octal = Convert.ToString(value, 8);
            lblASCII.Text += "ASCII decimal: " + value + ", Binary: " + binary + ", Hex: " + format + " (0x" + format + "), Octal: " + octal;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            lblDecimal.Text = "";
            try
            {
                int binary = Convert.ToInt32(TextBox115.Text, 2);
                string hex = String.Format("{0:X}", binary);
                string octal = Convert.ToString(binary, 8);
                lblDecimal.Text += "Decimal: " + binary.ToString() + ", ASCII/Unicode character: &#" + binary.ToString() + ";, Hex: " + hex + ", Octal: " + octal;
            }
            catch (Exception er)
            {
                lblDecimal.Text += er.Message;
            }
        }

        private void InitializeComponent()
        {

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            int variable = Convert.ToInt32(TextBox14.Text);
            try
            {
                unsafe
                {
                    int number = Convert.ToInt32(TextBox14.Text);
                    int* pointer = &number;
                    lblMemory.Text = "RAM Memory Address: " + (int)pointer;
                }
            }
            catch (FormatException)
            {
                lblMemory.Text = "Error: Must enter an integer.";
            }
            catch (Exception er)
            {
                lblMemory.Text = er.Message;
            }
        }

        protected void SubmitFunction(object sender, EventArgs e)
        {
            Label3.Text = "*Note: You cannot specify your own phone number as the sending number in order to protect the privacy of other peoples' phone numbers, in the case of hacking. Also, be careful with the text you send, i.e. no graphic, violent, sexual, inappropriate, or excessive content, as this website is not responsible for the messages sent by its users.";
            if (RadioButtonList2.SelectedIndex == 0)
            {
                try
                {
                    const string accountSid = "ACf8330fcc3ede57b663dbede2858535d0";
                    const string authToken = "5eb820b34245cef33060f9e34d0b61b9";
                    TwilioClient.Init(accountSid, authToken);
                    string phoneNum = phone.Value;
                    Regex regexObj = new Regex(@"[^\d]");
                    phoneNum = regexObj.Replace(phoneNum, "");
                    Thread.Sleep(2000);
                    var textMessage = MessageResource.Create(
                        body: message.Value,
                        from: new Twilio.Types.PhoneNumber("+19376391990"),
                        to: new Twilio.Types.PhoneNumber(lblNumber.Value)
                    );
                    Label3.Text = "Text message sent successfully!";
                }
                catch (Twilio.Exceptions.ApiException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Twilio.Exceptions.ApiConnectionException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Twilio.Exceptions.AuthenticationException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Twilio.Exceptions.CertificateValidationException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Twilio.Exceptions.RestException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Twilio.Exceptions.TwilioException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
            }

            if (RadioButtonList2.SelectedIndex == 1)
            {
                try
                {
                    var msg = new MailMessage();
                    msg.From = new MailAddress(yourEmail.Value);
                    var password = password2.Value;
                    msg.To.Add(new MailAddress(recipientEmail.Value));
                    msg.Subject = subject.Value;
                    if (FileUpload2.HasFile)
                    {
                        foreach (HttpPostedFile postedFile in FileUpload2.PostedFiles)
                        {
                            string fileName = System.IO.Path.GetFileName(postedFile.FileName);
                            Attachment myAttachment = new Attachment(FileUpload2.FileContent, fileName);
                            if (FileUpload2.PostedFile.ContentLength > 0)
                                msg.Attachments.Add(myAttachment);
                        }
                    }
                    msg.Body = message.Value;
                    if (DropDownList1.SelectedValue == "Normal")
                        msg.Priority = MailPriority.Normal;
                    if (DropDownList1.SelectedValue == "High")
                        msg.Priority = MailPriority.High;
                    if (DropDownList1.SelectedValue == "Low")
                        msg.Priority = MailPriority.Low;
                    var client = new SmtpClient();
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(msg.From.Address, password);
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    client.Send(msg);
                    client.Dispose();
                    Label3.Text = "Email sent successfully!";
                }
                catch (SmtpException er)
                {
                    Label3.Text = "Error: " + er.Message + ". You may have invalid credentials (i.e. email address and/or password) specified.";
                }
                catch (FormatException er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
                catch (Exception er)
                {
                    Label3.Text = "Error: " + er.Message;
                }
            }
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Label50.Text = "Total Fuel Expense: ";
            double miles = Convert.ToDouble(TextBox116.Text);
            double price = Convert.ToDouble(TextBox117.Text);
            double MPG = Convert.ToDouble(TextBox118.Text);
            double gallons = miles / MPG;
            double totalPrice = gallons * price;
            Label50.Text += "$" + totalPrice.ToString("N2") + " (gallons consumed: " + gallons.ToString("N2") + ") Calculation: " + miles + " miles / " + MPG + " MPG = " + gallons.ToString("N2") + " gallons * $" + price + " per gallon = $" + totalPrice.ToString("N2");
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            Label51.Text = "Payment per Period: ";
            Label52.Text = "Total Cost when Done Paying (Future Value): ";
            Label13.Text = "APR (Annual Percentage Rate): ";
            Label53.Text = "Calculations: ";
            double principal = Convert.ToDouble(TextBox15.Text);
            double fees = Convert.ToDouble(TextBox16.Text);
            double totalDue = principal + fees;
            double interest = Convert.ToDouble(TextBox119.Text) / 100;
            int paymentsPerPeriod = Convert.ToInt32(TextBox120.Text);
            int periods = Convert.ToInt32(TextBox121.Text);
            int totalPayments = paymentsPerPeriod * periods;
            double interest2 = interest / paymentsPerPeriod;
            double payment = totalDue * ((interest2 * Math.Pow(1 + interest2, totalPayments)) / (Math.Pow(1 + interest2, totalPayments) - 1));
            double totalCost = payment * totalPayments;
            double interestPaid = totalCost - principal;
            double apr = Microsoft.VisualBasic.Financial.Rate(totalPayments, -payment, principal) * paymentsPerPeriod * 100;
            Label51.Text += "$" + payment.ToString("N2");
            Label52.Text += "$" + totalCost.ToString("N2") + " (Principal paid: $" + principal + ", Interest paid: $" + interestPaid.ToString("N2") + ")";
            Label13.Text += apr.ToString("F3") + "%";
            Label53.Text += "Interest rate = " + interest + " / " + paymentsPerPeriod + " payments per period = " + interest2.ToString("N3") + ", Total Payments = " + paymentsPerPeriod + " payments per period * " + periods + " periods = " + totalPayments + ", Loan Payment = $" + totalDue + " * " + interest2.ToString("N3") + "(1 + " + interest2.ToString("N3") + ")^" + totalPayments + " / ((1 + " + interest2.ToString("N3") + ")^" + totalPayments + " - 1) = $" + payment.ToString("N2") + ", Total Cost When Done = $" + payment.ToString("N2") + " payment per period * " + totalPayments + " total periods = $" + totalCost.ToString("N2");
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            Label54.Text = "Payment per Period: ";
            double presentValue = Convert.ToDouble(TextBox122.Text);
            double interest = Convert.ToDouble(TextBox123.Text) / 100;
            int periods = Convert.ToInt32(TextBox124.Text);
            double payment = (presentValue * interest) / (1 - Math.Pow(1 + interest, -periods));
            Label54.Text += "$" + payment.ToString("N2") + "...from ($" + presentValue + "  * " + interest + ") / [1 - (1 + " + interest + ")^-" + periods + "]";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Label18.Text = "Present Value (PV): ";
            double paymentPerPeriod = Convert.ToDouble(TextBox17.Text);
            double interest = Convert.ToDouble(TextBox18.Text) / 100;
            int periods = Convert.ToInt32(TextBox19.Text);
            double presentValue = paymentPerPeriod * ((1 - (1 / Math.Pow(1 + interest, periods))) / interest);
            Label18.Text += "$" + presentValue.ToString("N2") + "...from $" + paymentPerPeriod + " * [1 - 1 / (1 + " + interest + ")^" + periods + "] / " + interest;
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Label19.Text = "Future Value (FV): ";
            double paymentPerPeriod = Convert.ToDouble(TextBox31.Text);
            double interest = Convert.ToDouble(TextBox32.Text) / 100;
            int periods = Convert.ToInt32(TextBox33.Text);
            double futureValue = paymentPerPeriod * ((Math.Pow(1 + interest, periods) - 1) / interest);
            Label19.Text += "$" + futureValue.ToString("N2") + "...from $" + paymentPerPeriod + " * [(1 + " + interest + ")^" + periods + " - 1] / " + interest;
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            Label55.Text = "Bond Price: ";
            Label56.Text = "Type Of Bond: ";
            Label57.Text = "Current Yield: ";
            Label58.Text = "Adjusted Current Yield: ";
            double faceValue = Convert.ToDouble(TextBox34.Text);
            double couponRate = Convert.ToDouble(TextBox35.Text) / 100;
            double YTM = Convert.ToDouble(TextBox36.Text) / 100;
            double maturity = Convert.ToDouble(TextBox37.Text);
            double coupon = faceValue * couponRate;
            if (RadioButtonList4.SelectedValue == "No")
            {
                if (RadioButtonList3.SelectedValue == "Semi-Annually")
                {
                    double bondPrice = (coupon / YTM) * (1 - 1 / Math.Pow(1 + YTM / 2, 2 * maturity)) + (faceValue / Math.Pow(1 + YTM / 2, 2 * maturity));
                    Label55.Text += "$" + bondPrice.ToString("N2") + "...Calculations: Coupon Value (C) =$" + faceValue + " * " + couponRate + " = $" + coupon + ", Bond Price = ($" + coupon + " /" + YTM + ") * [1 - 1 / (1 + " + YTM + "/2)^2*" + maturity + "] + [$" + faceValue + " / (1 + " + YTM + "/2)^2*" + maturity + "] = $" + bondPrice.ToString("N2");
                    if (bondPrice > faceValue)
                        Label56.Text += "Premium Bond";
                    if (bondPrice < faceValue)
                        Label56.Text += "Discount Bond";
                    if (bondPrice == faceValue)
                        Label56.Text += "Par Bond";
                    double currentYield = (coupon / bondPrice) * 100;
                    double adjustedCurrentYield = currentYield + ((faceValue - bondPrice) / maturity) / bondPrice;
                    Label57.Text += currentYield.ToString("N2") + "%...from ($" + coupon + " / $" + bondPrice.ToString("N2") + ") * 100%";
                    Label58.Text += adjustedCurrentYield.ToString("N2") + "%...from current yield + [($" + faceValue + " - $" + bondPrice.ToString("N2") + ") / " + maturity + "] / $" + bondPrice.ToString("N2");
                }
                if (RadioButtonList3.SelectedValue == "Quarterly")
                {
                    double bondPrice = (coupon / YTM) * (1 - 1 / Math.Pow(1 + YTM / 4, 4 * maturity)) + (faceValue / Math.Pow(1 + YTM / 4, 4 * maturity));
                    Label55.Text += "$" + bondPrice.ToString("N2") + "...Calculations: Coupon Value (C) = $" + faceValue + " * " + couponRate + " = $" + coupon + ", Bond Price = ($" + coupon + " / " + YTM + ") * [1 - 1 / (1 + " + YTM + "/4)^4*" + maturity + "] + [$" + faceValue + " / (1 + " + YTM + "/4)^4*" + maturity + "] = $" + bondPrice.ToString("N2");
                    if (bondPrice > faceValue)
                        Label56.Text += "Premium Bond";
                    if (bondPrice < faceValue)
                        Label56.Text += "Discount Bond";
                    if (bondPrice == faceValue)
                        Label56.Text += "Par Bond";
                    double currentYield = (coupon / bondPrice) * 100;
                    double adjustedCurrentYield = currentYield + ((faceValue - bondPrice) / maturity) / bondPrice;
                    Label57.Text += currentYield.ToString("N2") + "%...from ($" + coupon + " / $" + bondPrice.ToString("N2") + ") * 100%";
                    Label58.Text += adjustedCurrentYield.ToString("N2") + "%...from current yield + [($" + faceValue + " - $" + bondPrice.ToString("N2") + ") / " + maturity + "] / $" + bondPrice.ToString("N2");
                }
                if (RadioButtonList3.SelectedValue == "Annually")
                {
                    double bondPrice = (coupon / YTM) * (1 - 1 / Math.Pow(1 + YTM, maturity)) + (faceValue / Math.Pow(1 + YTM, maturity));
                    Label55.Text += "$" + bondPrice.ToString("N2") + "...Calculations: Coupon Value (C) = $" + faceValue + " * " + couponRate + " = $" + coupon + ", Bond Price = ($" + coupon + " / " + YTM + ") * [1 - 1 / (1 + " + YTM + ")^" + maturity + "] + [$" + faceValue + " / (1 + " + YTM + ")^" + maturity + "] = $" + bondPrice.ToString("N2");
                    if (bondPrice > faceValue)
                        Label56.Text += "Premium Bond";
                    if (bondPrice < faceValue)
                        Label56.Text += "Discount Bond";
                    if (bondPrice == faceValue)
                        Label56.Text += "Par Bond";
                    double currentYield = (coupon / bondPrice) * 100;
                    double adjustedCurrentYield = currentYield + ((faceValue - bondPrice) / maturity) / bondPrice;
                    Label57.Text += currentYield.ToString("N2") + "%...from ($" + coupon + " / $" + bondPrice.ToString("N2") + ") * 100%";
                    Label58.Text += adjustedCurrentYield.ToString("N2") + "%...from current yield + [($" + faceValue + " - $" + bondPrice.ToString("N2") + ") / " + maturity + "] / $" + bondPrice.ToString("N2");
                }
            }
            else
            {
                double interest = Convert.ToDouble(TextBox35.Text) / 100;
                double bondPrice = faceValue / Math.Pow(1 + interest, maturity);
                double currentYield = Math.Pow(faceValue / bondPrice, 1 / maturity) - 1; 
                Label55.Text += "$" + bondPrice.ToString("N2") + "...from $" + faceValue + " / (1 + " + interest + ")^" + maturity;
                Label56.Text += "Discount Bond (a Zero-Coupon Bond always is a Discount Bond)";
                Label57.Text += currentYield.ToString("N2") + "%...from ($" + faceValue + " / $" + bondPrice.ToString("N2") + ")^1/" + maturity + " - 1"; 
            }
        }

        protected void RadioButtonList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList4.SelectedValue == "Yes")
            {
                Label59.Visible = false;
                TextBox36.Visible = false;
                Label61.Visible = false;
                Label58.Visible = false;
                Label62.Visible = false;
                RadioButtonList3.Visible = false;
                Label60.Text = "Enter face/par value (this time, it is the<br />value at maturity, not initial value, so in other<br />words it is the future/final value): $";
                Label20.Text = "Enter interest rate: ";
            }
            if (RadioButtonList4.SelectedValue == "No")
            {
                Label59.Visible = true;
                TextBox36.Visible = true;
                Label61.Visible = true;
                Label58.Visible = true;
                Label62.Visible = true;
                RadioButtonList3.Visible = true;
                Label60.Text = "Enter face/par value: $";
                Label20.Text = "Enter coupon rate: ";
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Label67.Text = "Enter Face/Par Value: $";
            Label65.Text = "Enter Time until Maturity: ";
            Label66.Text = "Approximate Yield to Maturity: ";
            Label69.Text = "Exact Yield to Maturity: ";
            double faceValue = Convert.ToDouble(TextBox38.Text);
            double bondPrice = Convert.ToDouble(TextBox39.Text);
            double couponRate = Convert.ToDouble(TextBox41.Text) / 100;
            double maturity = Convert.ToDouble(TextBox42.Text);
            double coupon = faceValue * couponRate;
            double YTM = (coupon + (faceValue - bondPrice) / maturity) / ((faceValue + bondPrice) / 2) * 100;
            double priceRate = bondPrice / faceValue;
            if (RadioButtonList5.SelectedValue == "Quarterly")
            {
                int frequency = 4;
                double YTM2 = YTM / frequency;
                Label66.Text += YTM2.ToString("N2") + "% (annual yield would be " + YTM.ToString("N2") + "%...from [$" + coupon + "  + ($" + faceValue + " - $" + bondPrice + ") / " + maturity + "] / [($" + faceValue + " + " + "$" + bondPrice + ") / 2]";
                /* Excel.Application xl = new Excel.Application();
                Excel.WorksheetFunction wsf = xl.WorksheetFunction;
                double result = xl.Evaluate("YIELD('" + DateTime.Now.ToString("M/d/yyyy") + "','" + DateTime.Today.AddYears(Convert.ToInt32(maturity)) + "'," + couponRate + "%," + priceRate + "," + faceValue + "," + frequency + ",3)");
                Label69.Text += result.ToString("N2") + "%...using iterative trial-and-error process to get matching value."; */
            }
            if (RadioButtonList5.SelectedValue == "Semi-Annually")
            {
                int frequency = 2;
                double YTM2 = YTM / frequency;
                Label66.Text += YTM2.ToString("N2") + "% (annual yield would be " + YTM.ToString("N2") + "%...from [$" + coupon + "  + ($" + faceValue + " - $" + bondPrice + ") / " + maturity + "] / [($" + faceValue + " + " + "$" + bondPrice + ") / 2]";
                /* Excel.Application xl = new Excel.Application();
                Excel.WorksheetFunction wsf = xl.WorksheetFunction;
                double result = xl.Evaluate("YIELD(" + DateTime.Now.ToString("M/d/yyyy") + "," + DateTime.Today.AddYears(Convert.ToInt32(maturity)) + "," + couponRate + "," + priceRate + "," + faceValue + "," + frequency + ",3)");
                Label69.Text += result.ToString("N2") + "%...using iterative trial-and-error process to get matching value."; */
            }
            if (RadioButtonList5.SelectedValue == "Annually")
            {
                // int frequency = 1;
                Label66.Text += YTM.ToString("N2") + "%...from [$" + coupon + "  + ($" + faceValue + " - $" + bondPrice + ") / " + maturity + "] / [($" + faceValue + " + " + "$" + bondPrice + ") / 2]";
                /* Excel.Application xl = new Excel.Application();
                Excel.WorksheetFunction wsf = xl.WorksheetFunction;
                double result = xl.Evaluate("YIELD(" + DateTime.Now.ToString("M/d/yyyy") + "," + DateTime.Today.AddYears(Convert.ToInt32(maturity)) + "," + couponRate + "%," + priceRate + "," + faceValue + "," + frequency + ",3)");
                Label69.Text += result.ToString("N2") + "%...using iterative trial-and-error process to get matching value."; */
            }
        }

        protected void RadioButtonList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList6.SelectedIndex == 0)
            {
                Label67.Text = "Enter Face/Par Price: $";
                Label65.Text = "Enter Time Until Maturity: ";
                Label66.Text = "Approximate Yield to Maturity: ";
                Label69.Text = "Exact Yield to Maturity: ";
            }
            if (RadioButtonList6.SelectedIndex == 1)
            {
                Label67.Text = "Enter Call Price: $";
                Label65.Text = "Enter Time Until Call: ";
                Label66.Text = "Approximate Yield to Call: ";
                Label69.Text = "Exact Yield to Call: ";
            }
            if (RadioButtonList6.SelectedIndex == 2)
            {
                Label67.Text = "Enter Put Price: $";
                Label65.Text = "Enter Time Until Put: ";
                Label66.Text = "Approximate Yield to Put: ";
                Label69.Text = "Exact Yield to Put: ";
            }
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            Label75.Text = "Bond Return Amount: ";
            Label76.Text = "Bond Return Percent: ";
            double faceValue = Convert.ToDouble(TextBox48.Text);
            double buyingPrice = Convert.ToDouble(TextBox43.Text);
            double sellingPrice = Convert.ToDouble(TextBox44.Text);
            if (DropDownList2.SelectedIndex == 0)
            {
                double couponRate = Convert.ToDouble(TextBox45.Text) / 100;
                double maturity = Convert.ToDouble(TextBox47.Text);
                double annualCoupon = faceValue * couponRate;
                double totalCoupons = annualCoupon * maturity;
                if (DropDownList3.SelectedIndex == 0)
                {
                    double chargeRate = Convert.ToDouble(TextBox46.Text) / 100;
                    double charges = (sellingPrice + totalCoupons) * chargeRate;
                    double returnAmount = sellingPrice + totalCoupons - charges - buyingPrice;
                    double returnPercent = (returnAmount / buyingPrice) * 100;
                    if (returnAmount > 0.00)
                        Label75.Text += "$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons [from ($" + faceValue + " * " + couponRate + " * " + maturity + ")] - $" + charges.ToString("N2") + " total charges [from ($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] - $" + buyingPrice;
                    if (returnAmount < 0.00)
                    {
                        returnAmount += 2 * returnAmount;
                        Label75.Text += "-$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons [from ($" + faceValue + " * " + couponRate + " * " + maturity + ")] - $" + charges.ToString("N2") + " total charges [from ($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] - $" + buyingPrice;
                    }
                    if (returnAmount == 0.00)
                        Label75.Text += "$0.00 (even)...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons[from($" + faceValue + " * " + couponRate + " * " + maturity + ")] -$" + charges.ToString("N2") + " total charges[from($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] -$" + buyingPrice;
                    Label76.Text += returnPercent.ToString("N2") + "%...from ($" + returnAmount.ToString("N2") + " / $" + buyingPrice + ") * 100%";
                }
                if (DropDownList3.SelectedIndex == 1)
                {
                    double charges = Convert.ToDouble(TextBox46.Text);
                    double returnAmount = sellingPrice + totalCoupons - charges - buyingPrice;
                    double returnPercent = (returnAmount / buyingPrice) * 100;
                    if (returnAmount > 0.00)
                        Label75.Text += "$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons [from ($" + faceValue + " * " + couponRate + " * " + maturity + ")] - $" + charges + " - $" + buyingPrice;
                    if (returnAmount < 0.00)
                    {
                        returnAmount += 2 * returnAmount;
                        Label75.Text += "-$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons [from ($" + faceValue + " * " + couponRate + " * " + maturity + ")] - $" + charges + " - $" + buyingPrice;
                    }
                    if (returnAmount == 0.00)
                        Label75.Text += "$0.00 (even)...from $" + sellingPrice + " + $" + totalCoupons.ToString("N2") + " total coupons [from ($" + faceValue + " * " + couponRate + " * " + maturity + ")] - $" + charges + " - $" + buyingPrice;
                    Label76.Text += returnPercent.ToString("N2") + "%...from ($" + returnAmount.ToString("N2") + " / $" + buyingPrice + ") * 100%";
                }
            }
            if (DropDownList2.SelectedIndex == 1)
            {
                double totalCoupons = Convert.ToDouble(TextBox45.Text);
                if (DropDownList3.SelectedIndex == 0)
                {
                    double chargeRate = Convert.ToDouble(TextBox46.Text) / 100;
                    double charges = (sellingPrice + totalCoupons) * chargeRate;
                    double returnAmount = sellingPrice + totalCoupons - charges - buyingPrice;
                    double returnPercent = (returnAmount / buyingPrice) * 100;
                    if (returnAmount > 0.00)
                        Label75.Text += "$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges.ToString("N2") + " total charges [from ($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] - $" + buyingPrice;
                    if (returnAmount < 0.00)
                    {
                        returnAmount += 2 * returnAmount;
                        Label75.Text += "-$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges.ToString("N2") + " total charges [from ($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] - $" + buyingPrice;
                    }
                    if (returnAmount == 0.00)
                        Label75.Text += "$0.00 (even)...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges.ToString("N2") + " total charges [from ($" + sellingPrice + " + $" + totalCoupons.ToString("N2") + ") * " + chargeRate + "] - $" + buyingPrice;
                    Label76.Text += returnPercent.ToString("N2") + "%...from ($" + returnAmount.ToString("N2") + " / $" + buyingPrice + ") * 100%";
                }
                if (DropDownList3.SelectedIndex == 1)
                {
                    double charges = Convert.ToDouble(TextBox46.Text);
                    double returnAmount = sellingPrice + totalCoupons - charges - buyingPrice;
                    double returnPercent = (returnAmount / buyingPrice) * 100;
                    if (returnAmount > 0.00)
                        Label75.Text += "$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges + " - $" + buyingPrice;
                    if (returnAmount < 0.00)
                    {
                        returnAmount += 2 * returnAmount;
                        Label75.Text += "-$" + returnAmount.ToString("N2") + "...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges + " - $" + buyingPrice;
                    }
                    if (returnAmount == 0.00)
                        Label75.Text += "$0.00 (even)...from $" + sellingPrice + " + $" + totalCoupons + " - $" + charges + " - $" + buyingPrice;
                    Label76.Text += returnPercent.ToString("N2") + "%...from ($" + returnAmount.ToString("N2") + " / $" + buyingPrice + ") * 100%";
                }
            }
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            Label83.Text = "Interest Expense: ";
            double principal = Convert.ToDouble(TextBox49.Text);
            double interestRate = Convert.ToDouble(TextBox51.Text) / 100;
            double time = Convert.ToDouble(TextBox52.Text);
            double interest = principal * interestRate * time;
            Label83.Text += "$" + interest.ToString("N2") + "...from $" + principal + " * " + interestRate + " * " + time;
        }

        public static string GetDirectoryListingRegexForUrl(string url)
        {
            return "<a href=\".*\">(?<name>.*)</a>";
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            Label118.Text = "";
            if (DropDownList9.SelectedIndex == 0)
            {
                List<string> files = new List<string>();
                string url = TextBox13.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string html = reader.ReadToEnd();
                        Regex regex = new Regex(GetDirectoryListingRegexForUrl(url));
                        MatchCollection matches = regex.Matches(html);
                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches)
                            {
                                if (match.Success)
                                {
                                    string[] matchData = match.Groups[0].ToString().Split('\"');
                                    files.Add(matchData[1]);
                                }
                            }
                        }
                    }
                }
                files.ToArray();
                foreach (string filename in files)
                    Label118.Text += filename + ", ";
            }
            else
            {
                List<string> files = new List<string>();
                string url = TextBox13.Text;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Credentials = new NetworkCredential(@"maxstechandmathsite\$maxstechandmathsite", "dhD4ehA5k1mkdnWlQeZZL5gzfF6Zyw1NffqApLyj5ipSsHJxrzKpsjitCm3h");
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string html = reader.ReadToEnd();
                        Regex regex = new Regex(GetDirectoryListingRegexForUrl(url));
                        MatchCollection matches = regex.Matches(html);
                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches)
                            {
                                if (match.Success)
                                {
                                    string[] matchData = match.Groups[0].ToString().Split('\"');
                                    files.Add(matchData[1]);
                                }
                            }
                        }
                    }
                }
                files.ToArray();
                foreach (string filename in files)
                    Label118.Text += filename + ", ";
            }
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            Label118.Text = "";
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(TextBox13.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(@"maxstechandmathsite\$maxstechandmathsite", "dhD4ehA5k1mkdnWlQeZZL5gzfF6Zyw1NffqApLyj5ipSsHJxrzKpsjitCm3h");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                reader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Label118.Text += reader;
            }
            catch (WebException er)
            {
                Label118.Text += ((FtpWebResponse)er.Response).StatusDescription;
            }
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            myTable.Visible = true;
            // myTable.Attributes["style"] = "background-color: red";
            double beginningBookValue = Convert.ToDouble(TextBox125.Text);
            double salvageValue = Convert.ToDouble(TextBox126.Text);
            int years = Convert.ToInt32(TextBox127.Text);
            if (DropDownList4.SelectedIndex == 0)
            {
                double depreciationAmount = (beginningBookValue - salvageValue) / years;
                double percent = 100 / years;
                for (int index = 1; index <= years; index++)
                {
                    TableRow row = new TableRow();
                    TableCell cell1 = new TableCell();
                    cell1.Text = index.ToString();
                    row.Cells.Add(cell1);
                    TableCell cell2 = new TableCell();
                    double bookValue = beginningBookValue - (depreciationAmount * (index - 1));
                    cell2.Text = bookValue.ToString("C2");
                    row.Cells.Add(cell2);
                    TableCell cell3 = new TableCell();
                    cell3.Text = percent.ToString("N2") + "%";
                    row.Cells.Add(cell3);
                    TableCell cell4 = new TableCell();
                    cell4.Text = depreciationAmount.ToString("C2");
                    row.Cells.Add(cell4);
                    double accumulatedDepreciation = depreciationAmount * index;
                    TableCell cell5 = new TableCell();
                    cell5.Text = accumulatedDepreciation.ToString("C2");
                    row.Cells.Add(cell5);
                    double endingBookValue = bookValue - depreciationAmount;
                    TableCell cell6 = new TableCell();
                    cell6.Text = endingBookValue.ToString("C2");
                    row.Cells.Add(cell6);
                    myTable.Rows.Add(row);
                }
            }
            if (DropDownList4.SelectedIndex == 1)
            {
                double depreciationFactor = Convert.ToDouble(TextBox128.Text);
                double depreciationPercent = depreciationFactor / years;
                double depreciationPercent2 = depreciationPercent * 100;
                for (int index = 1; index <= years; index++)
                {
                    TableRow row = new TableRow();
                    TableCell cell1 = new TableCell();
                    cell1.Text = index.ToString();
                    row.Cells.Add(cell1);
                    if (index == 1)
                    {
                        TableCell cell2 = new TableCell();
                        cell2.Text = beginningBookValue.ToString("C2");
                        row.Cells.Add(cell2);
                        TableCell cell3 = new TableCell();
                        cell3.Text = depreciationPercent2.ToString("N2") + "%";
                        row.Cells.Add(cell3);
                        double depreciationAmount = depreciationPercent * beginningBookValue;
                        TableCell cell4 = new TableCell();
                        cell4.Text = depreciationAmount.ToString("C2");
                        row.Cells.Add(cell4);
                        TableCell cell5 = new TableCell();
                        cell5.Text = depreciationAmount.ToString("C2");
                        row.Cells.Add(cell5);
                        double bookValue = beginningBookValue - depreciationAmount;
                        TableCell cell6 = new TableCell();
                        cell6.Text = bookValue.ToString("C2");
                        row.Cells.Add(cell6);
                        myTable.Rows.Add(row);
                    }
                    if (index > 1)
                    {
                        TableRow previousRow = myTable.Rows[index - 1];
                        double previousBookValue = double.Parse(previousRow.Cells[5].Text, System.Globalization.NumberStyles.Currency);
                        double depreciationAmount = depreciationPercent * previousBookValue;
                        double bookValue = previousBookValue - depreciationAmount;
                        TableCell cell2 = new TableCell();
                        cell2.Text = previousRow.Cells[5].Text;
                        row.Cells.Add(cell2);
                        if (bookValue > salvageValue)
                        {
                            TableCell cell3 = new TableCell();
                            cell3.Text = depreciationPercent2.ToString("N2") + "%";
                            row.Cells.Add(cell3);
                            TableCell cell4 = new TableCell();
                            cell4.Text = depreciationAmount.ToString("C2");
                            row.Cells.Add(cell4);
                            double accumulatedDepreciation = double.Parse(previousRow.Cells[4].Text, System.Globalization.NumberStyles.Currency);
                            accumulatedDepreciation += depreciationAmount;
                            TableCell cell5 = new TableCell();
                            cell5.Text = accumulatedDepreciation.ToString("C2");
                            row.Cells.Add(cell5);
                            TableCell cell6 = new TableCell();
                            cell6.Text = bookValue.ToString("C2");
                            row.Cells.Add(cell6);
                            myTable.Rows.Add(row);
                        }
                        if (bookValue < salvageValue)
                        {
                            double depreciationAmount2 = previousBookValue - salvageValue;
                            double depreciationPercent3 = depreciationAmount2 / previousBookValue;
                            double depreciationPercent4 = depreciationPercent3 * 100;
                            TableCell cell3 = new TableCell();
                            cell3.Text = depreciationPercent4.ToString("N2") + "%";
                            row.Cells.Add(cell3);
                            TableCell cell4 = new TableCell();
                            cell4.Text = depreciationAmount2.ToString("C2");
                            row.Cells.Add(cell4);
                            double accumulatedDepreciation = beginningBookValue - salvageValue;
                            TableCell cell5 = new TableCell();
                            cell5.Text = accumulatedDepreciation.ToString("C2");
                            row.Cells.Add(cell5);
                            TableCell cell6 = new TableCell();
                            cell6.Text = salvageValue.ToString("C2");
                            row.Cells.Add(cell6);
                            myTable.Rows.Add(row);
                        }
                        if (bookValue == salvageValue)
                        {
                            TableCell cell3 = new TableCell();
                            cell3.Text = "0.00%";
                            row.Cells.Add(cell3);
                            TableCell cell4 = new TableCell();
                            cell4.Text = "$0.00";
                            row.Cells.Add(cell4);
                            double accumulatedDepreciation = beginningBookValue - salvageValue;
                            TableCell cell5 = new TableCell();
                            cell5.Text = accumulatedDepreciation.ToString("C2");
                            row.Cells.Add(cell5);
                            TableCell cell6 = new TableCell();
                            cell6.Text = salvageValue.ToString("C2");
                            row.Cells.Add(cell6);
                            myTable.Rows.Add(row);
                        }
                    }
                }
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList4.SelectedIndex == 0)
            {
                Label85.Visible = false;
                TextBox128.Visible = false;
            }
            if (DropDownList4.SelectedIndex == 1)
            {
                Label85.Visible = true;
                TextBox128.Visible = true;
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            Label88.Text = "Federal Income Tax Owed: ";
            Label95.Text = "Gross Pay: ";
            Label100.Text = "State Income Tax Owed: ";
            Label101.Text = "Social Security Tax Owed: ";
            Label99.Text = "Medicare Tax Owed: ";
            Label103.Text = "State Unemployment Tax Owed (for employer only): ";
            Label102.Text = "Federal Unemployment Tax Owed (employer only): ";
            Label104.Text = "Local (City & School) Taxes Owed (employer only): ";
            Label105.Text = "Total Taxes Owed for Employee: ";
            Label109.Text = "Total Taxes Owed for Employer: ";
            Label106.Text = "Net Pay: ";
            Label107.Text = "Year-To-Date Pay and Taxes: ";
            lblError5.Text = "";
            Label111.Text = "Enter Year # of your Employment: ";
            Label112.Text = "Enter Industry Tax Rate Average for ";
            int[,] weeklySingleTax = new int[135,11] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 9, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 10, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 12, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 13, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 14, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 15, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 16, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 17, 9, 1, 0, 0, 0, 0, 0, 0, 0, 0}, { 18, 10, 2, 0, 0, 0, 0, 0, 0, 0, 0}, { 19, 11, 3, 0, 0, 0, 0, 0, 0, 0, 0}, { 21, 12, 4, 0, 0, 0, 0, 0, 0, 0, 0}, { 22, 13, 5, 0, 0, 0, 0, 0, 0, 0, 0}, { 23, 14, 6, 0, 0, 0, 0, 0, 0, 0, 0}, { 25, 16, 7, 0, 0, 0, 0, 0, 0, 0, 0}, { 26, 17, 9, 1, 0, 0, 0, 0, 0, 0, 0}, { 27, 18, 10, 2, 0, 0, 0, 0, 0, 0, 0}, { 29, 19, 11, 3, 0, 0, 0, 0, 0, 0, 0}, { 30, 20, 12, 4, 0, 0, 0, 0, 0, 0, 0}, { 31, 22, 13, 5, 0, 0, 0, 0, 0, 0, 0}, { 33, 23, 14, 6, 0, 0, 0, 0, 0, 0, 0}, { 34, 24, 15, 7, 0, 0, 0, 0, 0, 0, 0}, { 35, 26, 16, 8, 0, 0, 0, 0, 0, 0, 0}, { 37, 27, 17, 9, 1, 0, 0, 0, 0, 0, 0}, { 38, 28, 18, 10, 2, 0, 0, 0, 0, 0, 0},
            { 39, 29, 20, 12, 3, 0, 0, 0, 0, 0, 0}, { 40, 31, 21, 13, 5, 0, 0, 0, 0, 0, 0}, { 42, 32, 22, 14, 6, 0, 0, 0, 0, 0, 0}, { 43, 33, 24, 15, 7, 0, 0, 0, 0, 0, 0}, { 44, 35, 25, 16, 8, 0, 0, 0, 0, 0, 0}, { 46, 36, 26, 17, 9, 1, 0, 0, 0, 0, 0}, { 47, 37, 28, 18, 10, 2, 0, 0, 0, 0, 0}, { 48, 38, 29, 19, 11, 3, 0, 0, 0, 0, 0}, { 50, 40, 30, 21, 12, 4, 0, 0, 0, 0, 0}, { 51, 41, 32, 22, 13, 5, 0, 0, 0, 0, 0}, { 52, 43, 32, 23, 14, 6, 0, 0, 0, 0, 0}, { 54, 44, 34, 25, 16, 7, 0, 0, 0, 0, 0}, { 55, 45, 36, 26, 17, 9, 1, 0, 0, 0, 0}, { 56, 47, 37, 27, 18, 10, 2, 0, 0, 0, 0}, { 58, 48, 38, 29, 19, 11, 3, 0, 0, 0, 0}, { 59, 49, 40, 30, 20, 12, 4, 0, 0, 0, 0},
            { 60, 51, 41, 31, 22, 13, 5, 0, 0, 0, 0}, { 62, 52, 42, 33, 23, 14, 6, 0, 0, 0, 0}, { 63, 53, 44, 34, 24, 15, 7, 0, 0, 0, 0}, { 64, 55, 45, 35, 25, 16, 8, 0, 0, 0, 0}, { 66, 56, 46, 36, 27, 17, 9, 1, 0, 0, 0}, { 67, 57, 47, 38, 28, 18, 10, 2, 0, 0, 0}, { 68, 59, 49, 39, 29, 20, 11, 3, 0, 0, 0}, { 70, 60, 50, 40, 31, 21, 13, 5, 0, 0, 0}, { 71, 61, 51, 42, 32, 22, 14, 6, 0, 0, 0}, { 72, 62, 53, 43, 33, 24, 15, 7, 0, 0, 0}, { 73, 64, 54, 44, 35, 25, 16, 8, 0, 0, 0}, { 75, 65, 55, 46, 36, 26, 17, 9, 1, 0, 0}, { 76, 66, 57, 47, 37, 28, 18, 10, 2, 0, 0}, { 77, 68, 58, 48, 39, 29, 19, 11, 3, 0, 0}, { 79, 69, 59, 50, 40, 30, 21, 12, 4, 0, 0},
            { 80, 70, 61, 51, 41, 32, 22, 13, 5, 0, 0}, { 81, 72, 62, 52, 43, 33, 23, 14, 6, 0, 0}, { 83, 73, 63, 54, 44, 34, 25, 16, 7, 0, 0}, { 84, 74, 65, 55, 45, 36, 26, 17, 9, 0, 0}, { 85, 76, 66, 56, 47, 37, 27, 18, 10, 2, 0}, { 87, 77, 67, 58, 48, 38, 29, 19, 11, 3, 0}, { 89, 78, 69, 59, 49, 40, 30, 20, 12, 4, 0}, { 91, 80, 70, 60, 51, 41, 31, 21, 13, 5, 0}, { 93, 81, 71, 62, 52, 42, 32, 23, 14, 6, 0}, { 96, 82, 73, 63, 53, 43, 34, 24, 15, 7, 0}, { 98, 84, 74, 64, 55, 45, 35, 25, 16, 8, 0}, { 101, 85, 75, 66, 56, 46, 36, 27, 17, 9, 1}, { 103, 86, 77, 67, 57, 47, 38, 28, 18, 10, 2}, { 105, 88, 78, 68, 58, 49, 39, 29, 20, 11, 3},
            { 108, 90, 79, 69, 60, 50, 40, 31, 21, 13, 4}, { 110, 93, 80, 71, 61, 51, 42, 32, 22, 14, 6}, { 113, 95, 82, 72, 62, 53, 43, 33, 24, 15, 7}, { 115, 97, 83, 73, 64, 54, 44, 35, 25, 16, 8}, { 118, 100, 84, 75, 65, 55, 46, 36, 26, 17, 9}, { 120, 102, 86, 76, 66, 57, 47, 37, 28, 18, 10}, { 122, 105, 87, 77, 68, 58, 48, 39, 29, 19, 11}, { 125, 107, 89, 79, 69, 59, 50, 40, 30, 21, 12}, { 127, 109, 92, 80, 70, 61, 51, 41, 32, 22, 13}, { 130, 112, 94, 81, 72, 62, 52, 43, 33, 23, 14}, { 132, 114, 97, 83, 73, 63, 54, 44, 34, 25, 15}, { 135, 117, 99, 84, 74, 65, 55, 45, 36, 26, 17},
            { 137, 119, 101, 85, 76, 66, 56, 47, 37, 27, 18}, { 139, 122, 104, 87, 77, 67, 58, 48, 38, 28, 19}, { 142, 124, 106, 88, 78, 69, 59, 49, 40, 30, 20}, { 144, 126, 109, 91, 80, 70, 60, 51, 41, 31, 21}, { 147, 129, 111, 93, 81, 71, 62, 52, 42, 32, 23}, { 149, 131, 113, 96, 82, 73, 63, 53, 43, 34, 24}, { 151, 134, 116, 98, 84, 74, 64, 54, 45, 35, 25}, { 154, 136, 118, 101, 85, 75, 65, 56, 46, 36, 27}, { 156, 139, 121, 103, 86, 76, 67, 57, 47, 38, 28}, { 159, 141, 123, 105, 88, 78, 68, 58, 49, 39, 29}, { 161, 143, 126, 108, 90, 79, 69, 60, 50, 40, 31}, { 164, 146, 128, 110, 92, 80, 71, 61, 51, 42, 32}, { 166, 148, 130, 113, 95, 82, 72, 62, 53, 43, 33},
            { 168, 151, 133, 115, 97, 83, 73, 64, 54, 44, 35}, { 171, 153, 135, 118, 100, 84, 75, 65, 55, 46, 36}, { 173, 155, 138, 120, 102, 86, 76, 66, 57, 47, 37}, { 176, 158, 140, 122, 105, 87, 77, 68, 58, 48, 39}, { 178, 160, 143, 125, 107, 89, 79, 69, 59, 50, 40}, { 180, 163, 145, 127, 109, 92, 80, 70, 61, 51, 41}, { 183, 165, 147, 130, 112, 94, 81, 72, 62, 52, 43}, { 185, 168, 150, 132, 114, 96, 83, 73, 63, 54, 44}, { 188, 170, 152, 134, 117, 99, 84, 74, 65, 55, 45}, { 190, 172, 155, 137, 119, 101, 85, 76, 66, 56, 47}, { 193, 175, 157, 139, 122, 104, 87, 77, 67, 58, 48}, { 195, 177, 159, 142, 124, 106, 88, 78, 69, 59, 49},
            { 197, 180, 162, 144, 126, 109, 91, 80, 70, 60, 50}, { 200, 182, 164, 147, 129, 111, 93, 81, 71, 61, 52}, { 202, 184, 167, 149, 131, 113, 96, 82, 73, 63, 53}, { 205, 187, 169, 151, 134, 116, 98, 84, 74, 64, 54}, { 207, 189, 172, 154, 136, 118, 100, 85, 75, 65, 56}, { 210, 192, 174, 156, 138, 121, 103, 86, 76, 67, 57}, { 212, 194, 176, 159, 141, 123, 105, 88, 78, 68, 58}, { 214, 197, 179, 161, 143, 126, 108, 90, 79, 69, 60}, { 217, 199, 181, 163, 146, 128, 110, 92, 80, 71, 61}, { 219, 201, 184, 166, 148, 130, 113, 95, 82, 72, 62}, { 222, 204, 186, 168, 151, 133, 115, 97, 83, 73, 64}, { 224, 206, 189, 171, 153, 135, 117, 100, 84, 75, 65},
            { 226, 209, 191, 173, 155, 138, 120, 102, 86, 76, 66}, { 229, 211, 193, 176, 158, 140, 122, 105, 87, 77, 68}, { 231, 214, 196, 178, 160, 142, 125, 107, 89, 79, 69}, { 234, 216, 198, 180, 163, 145, 127, 109, 92, 80, 70}, { 236, 218, 201, 183, 165, 147, 130, 112, 94, 81, 72}, { 239, 221, 203, 185, 167, 150, 132, 114, 96, 83, 73}, { 241, 223, 205, 188, 170, 152, 134, 117, 99, 84, 74}, { 243, 226, 208, 190, 172, 155, 137, 119, 101, 85, 76} };
            int[,] weeklyMarriedTax = new int[136,11] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 9, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 10, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 12, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 13, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 14, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 15, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 16, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 17, 9, 1, 0, 0, 0, 0, 0, 0, 0, 0}, { 18, 10, 2, 0, 0, 0, 0, 0, 0, 0, 0}, { 19, 11, 3, 0, 0, 0, 0, 0, 0, 0, 0}, { 20, 12, 4, 0, 0, 0, 0, 0, 0, 0, 0}, { 21, 13, 5, 0, 0, 0, 0, 0, 0, 0, 0}, { 23, 14, 6, 0, 0, 0, 0, 0, 0, 0, 0}, { 24, 16, 8, 0, 0, 0, 0, 0, 0, 0, 0}, { 25, 17, 9, 1, 0, 0, 0, 0, 0, 0, 0}, { 26, 18, 10, 2, 0, 0, 0, 0, 0, 0, 0}, { 27, 19, 11, 3, 0, 0, 0, 0, 0, 0, 0}, { 28, 20, 12, 4, 0, 0, 0, 0, 0, 0, 0}, { 29, 21, 13, 5, 0, 0, 0, 0, 0, 0, 0}, { 30, 22, 14, 6, 0, 0, 0, 0, 0, 0, 0}, { 31, 23, 15, 7, 0, 0, 0, 0, 0, 0, 0}, { 32, 24, 16, 8, 0, 0, 0, 0, 0, 0, 0}, { 34, 25, 17, 9, 1, 0, 0, 0, 0, 0, 0}, { 35, 27, 19, 10, 2, 0, 0, 0, 0, 0, 0},
            { 36, 28, 20, 12, 3, 0, 0, 0, 0, 0, 0}, { 37, 29, 21, 13, 5, 0, 0, 0, 0, 0, 0}, { 38, 30, 22, 14, 6, 0, 0, 0, 0, 0, 0}, { 39, 31, 23, 15, 7, 0, 0, 0, 0, 0, 0}, { 41, 32, 24, 16, 8, 0, 0, 0, 0, 0, 0}, { 42, 33, 25, 17, 9, 1, 0, 0, 0, 0, 0}, { 43, 34, 26, 18, 10, 2, 0, 0, 0, 0, 0}, { 45, 35, 27, 19, 11, 3, 0, 0, 0, 0, 0}, { 46, 36, 28, 20, 12, 4, 0, 0, 0, 0, 0}, { 47, 38, 30, 21, 13, 5, 0, 0, 0, 0, 0}, { 49, 39, 31, 23, 14, 6, 0, 0, 0, 0, 0}, { 50, 40, 32, 24, 16, 7, 0, 0, 0, 0, 0}, { 51, 42, 33, 25, 17, 9, 0, 0, 0, 0, 0}, { 53, 43, 34, 26, 18, 10, 2, 0, 0, 0, 0}, { 54, 44, 35, 27, 19, 11, 3, 0, 0, 0, 0}, { 55, 46, 36, 28, 20, 12, 4, 0, 0, 0, 0},
            { 57, 47, 37, 29, 21, 13, 5, 0, 0, 0, 0}, { 58, 48, 39, 30, 22, 14, 6, 0, 0, 0, 0}, { 59, 50, 40, 31, 23, 15, 7, 0, 0, 0, 0}, { 61, 51, 41, 32, 24, 16, 8, 0, 0, 0, 0}, { 62, 52, 42, 34, 25, 17, 9, 1, 0, 0, 0}, { 63, 53, 44, 35, 27, 18, 10, 2, 0, 0, 0}, { 64, 55, 45, 36, 28, 20, 11, 3, 0, 0, 0}, { 66, 56, 46, 37, 29, 21, 13, 5, 0, 0, 0}, { 67, 57, 48, 38, 30, 22, 14, 6, 0, 0, 0}, { 68, 59, 49, 39, 31, 23, 15, 7, 0, 0, 0}, { 70, 60, 50, 41, 32, 24, 16, 8, 0, 0, 0}, { 71, 61, 52, 42, 33, 25, 17, 9, 1, 0, 0}, { 72, 63, 53, 43, 34, 26, 18, 10, 2, 0, 0}, { 74, 64, 54, 45, 35, 27, 19, 11, 3, 0, 0}, { 75, 65, 56, 46, 36, 28, 20, 12, 4, 0, 0},
            { 76, 67, 57, 47, 38, 29, 21, 13, 5, 0, 0}, { 78, 68, 58, 49, 39, 31, 22, 14, 6, 0, 0}, { 79, 69, 60, 50, 40, 32, 24, 16, 7, 0, 0}, { 80, 71, 61, 51, 42, 33, 25, 17, 9, 0, 0}, { 82, 72, 62, 53, 43, 34, 26, 18, 10, 2, 0}, { 83, 73, 64, 54, 44, 35, 27, 19, 11, 3, 0}, { 84, 75, 65, 55, 46, 36, 28, 20, 12, 4, 0}, { 86, 76, 66, 57, 47, 37, 29, 21, 13, 5, 0}, { 87, 77, 68, 58, 48, 38, 30, 22, 14, 6, 0}, { 88, 79, 69, 59, 49, 40, 31, 23, 15, 7, 0}, { 90, 80, 70, 60, 51, 41, 32, 24, 16, 8, 0}, { 91, 81, 72, 62, 52, 42, 33, 25, 17, 9, 1}, { 92, 83, 73, 63, 53, 44, 35, 27, 18, 10, 2}, { 94, 84, 74, 64, 55, 45, 36, 28, 20, 11, 3},
            { 95, 85, 75, 66, 56, 46, 37, 29, 21, 13, 4}, { 96, 86, 77, 67, 57, 48, 38, 30, 22, 14, 6}, { 97, 88, 78, 68, 59, 49, 39, 31, 23, 15, 7}, { 99, 89, 79, 70, 60, 50, 41, 32, 24, 16, 8}, { 100, 90, 81, 71, 61, 52, 42, 33, 25, 17, 9}, { 101, 92, 82, 72, 63, 53, 43, 34, 26, 18, 10}, { 103, 93, 83, 74, 64, 54, 45, 35, 27, 19, 11}, { 104, 94, 85, 75, 65, 56, 46, 36, 28, 20, 12}, { 105, 96, 86, 76, 67, 57, 47, 38, 29, 21, 13}, { 107, 97, 87, 78, 68, 58, 49, 39, 31, 22, 14}, { 108, 98, 89, 79, 69, 60, 50, 40, 32, 24, 15}, { 109, 100, 90, 80, 71, 61, 51, 42, 33, 25, 17},
            { 111, 101, 91, 82, 72, 62, 53, 43, 34, 26, 18}, { 112, 102, 93, 83, 73, 64, 54, 44, 35, 27, 19}, { 113, 104, 94, 84, 75, 65, 55, 45, 36, 28, 20}, { 115, 105, 95, 86, 76, 66, 56, 47, 37, 29, 21}, { 116, 106, 97, 87, 77, 68, 58, 48, 38, 30, 22}, { 117, 108, 98, 88, 79, 69, 59, 49, 40, 31, 23}, { 119, 109, 99, 90, 80, 70, 60, 51, 41, 32, 24}, { 120, 110, 101, 91, 81, 71, 62, 52, 42, 33, 25}, { 121, 112, 102, 92, 82, 73, 63, 53, 44, 35, 26}, { 123, 113, 103, 93, 84, 74, 64, 55, 45, 36, 28}, { 124, 114, 105, 95, 85, 75, 66, 56, 46, 37, 29}, { 125, 116, 106, 96, 86, 77, 67, 57, 48, 38, 30}, { 127, 117, 107, 97, 88, 78, 68, 59, 49, 39, 31},
            { 128, 118, 108, 99, 89, 79, 70, 60, 50, 41, 32}, { 129, 119, 110, 100, 90, 81, 71, 61, 52, 42, 33}, { 130, 121, 111, 101, 92, 82, 72, 63, 53, 43, 34}, { 132, 122, 112, 103, 93, 83, 74, 64, 54, 45, 35}, { 133, 123, 114, 104, 94, 85, 75, 65, 56, 46, 36}, { 134, 125, 115, 105, 96, 86, 76, 67, 57, 47, 38}, { 136, 126, 116, 107, 97, 87, 78, 68, 58, 49, 39}, { 137, 127, 118, 108, 98, 89, 79, 69, 60, 50, 40}, { 138, 129, 119, 109, 100, 90, 80, 71, 61, 51, 41}, { 140, 130, 120, 111, 101, 91, 82, 72, 62, 52, 43}, { 141, 131, 122, 112, 102, 93, 83, 73, 64, 54, 44}, { 142, 133, 123, 113, 104, 94, 84, 75, 65, 55, 45},
            { 144, 134, 124, 115, 105, 95, 86, 76, 66, 56, 47 }, { 145, 135, 126, 116, 106, 97, 87, 77, 67, 58, 48}, { 146, 137, 127, 117, 108, 98, 88, 78, 69, 59, 49}, { 148, 138, 128, 119, 109, 99, 89, 80, 70, 60, 51}, { 149, 139, 130, 120, 110, 101, 91, 81, 71, 62, 52}, { 150, 141, 131, 121, 112, 102, 92, 82, 73, 63, 53}, { 152, 142, 132, 123, 113, 103, 93, 84, 74, 64, 55}, { 153, 143, 134, 124, 114, 104, 95, 85, 75, 66, 56}, { 154, 145, 135, 125, 115, 106, 96, 86, 77, 67, 57}, { 156, 146, 136, 126, 117, 107, 97, 88, 78, 68, 59}, { 157, 147, 138, 128, 118, 108, 99, 89, 79, 70, 60}, { 158, 149, 139, 129, 119, 110, 100, 90, 81, 71, 61},
            { 160, 150, 140, 130, 121, 111, 101, 92, 82, 72, 63}, { 161, 151, 141, 132, 122, 112, 103, 93, 83, 74, 64}, { 162, 152, 143, 133, 123, 114, 104, 94, 85, 75, 65}, { 163, 154, 144, 134, 125, 115, 105, 96, 86, 76, 67}, { 165, 155, 145, 136, 126, 116, 107, 97, 87, 78, 68}, { 166, 156, 147, 137, 127, 118, 108, 98, 89, 79, 69}, { 167, 158, 148, 138, 129, 119, 109, 100, 90, 80, 71}, { 169, 159, 149, 140, 130, 120, 111, 101, 91, 82, 72}, { 170, 160, 151, 141, 131, 122, 112, 102, 92, 83, 73} };
            double[] SUTA = new double[50] { 2.7, 1.28, 2, 3.2, 3.4, 1.7, 3.4, 1.5, 2.7, 2.7, 2.4, 1, 3.175, 2.5, 1, 2.7, 2.7, 2.06, 1.89, 2.6, 2.42, 2.7, 0, 4, 2.376, 1.88, 1.25, 3, 1.2, 2.8, 1, 3.2, 1, 1.21, 2.7, 1.5, 2.4, 3.689, 1.46, 0.87, 4, 2.7, 2.7, 0, 1, 2.51, 0, 2.7, 3.05, 0 };
            double number1 = Convert.ToDouble(TextBox130.Text), number2 = Convert.ToDouble(TextBox132.Text), number3 = Convert.ToDouble(TextBox133.Text), number4 = Convert.ToDouble(TextBox134.Text), number5 = Convert.ToDouble(TextBox135.Text);
            if ((TextBox129.Text != "" && (TextBox53.Text != "" || TextBox131.Text != "" || TextBox54.Text != "" || TextBox55.Text != "")) || (TextBox130.Text == "" || TextBox132.Text == "" || TextBox133.Text == "" || TextBox134.Text == "" || TextBox135.Text == "") || (number1 < 0 || number2 < 0 || number3 < 0 || number4 < 0 || number5 < 0))
            {
                if (TextBox129.Text != "" && (TextBox53.Text != "" || TextBox131.Text != "" || TextBox54.Text != "" || TextBox55.Text != ""))
                    lblError5.Text += "Error: Only one of these two fields can be filled: (1) gross pay, (2) calculating gross pay by entering regular and overtime hours and rates. ";
                if (TextBox130.Text == "" || TextBox132.Text == "" || TextBox133.Text == "" || TextBox134.Text == "" || TextBox135.Text == "")
                    lblError5.Text += "Error: Every text box must be filled out, except 1 of 2 can be left blank between 'Weekly Pay' and 'Calculate Pay Based on Hours'.";
                if (number1 < 0 || number2 < 0 || number3 < 0 || number4 < 0 || number5 < 0)
                    lblError5.Text += "Error: Cannot input a negative number.";
            }
            else
            {
                try
                {
                    int dependents = Convert.ToInt32(TextBox130.Text);
                    double YTD = Convert.ToDouble(TextBox132.Text);
                    const double SS_TAX_RATE = 0.062;
                    const double MEDICARE_TAX_RATE = 0.0145;
                    double cityTaxRate = Convert.ToDouble(TextBox133.Text) / 100;
                    double schoolTaxRate = Convert.ToDouble(TextBox134.Text) / 100;
                    if (DropDownList7.SelectedValue == "Yes" && TextBox53.Text != "" && TextBox54.Text != "" && TextBox55.Text != "" && TextBox131.Text != "")
                    {
                        double regularHours = Convert.ToDouble(TextBox53.Text);
                        double basePay = Convert.ToDouble(TextBox131.Text);
                        double overtimeHours = Convert.ToDouble(TextBox54.Text);
                        double overtimePay = Convert.ToDouble(TextBox55.Text);
                        double regularIncome = regularHours * basePay;
                        double overtimeIncome = overtimeHours * overtimePay;
                        double grossPay = regularIncome + overtimeIncome;
                        double pay = grossPay;
                        Label95.Text += "$" + grossPay.ToString("N2") + "...from ($" + basePay + " * " + regularHours + " = $" + regularIncome.ToString("N2") + " regular income) + ($" + overtimePay + " * " + overtimeHours + " = $" + overtimeIncome.ToString("N2") + " overtime income) = $" + grossPay.ToString("N2");
                        double accumulated = pay + YTD;
                        double ssTax = 0.0, totalSSTax = 0.0, ytdSSTax = 0.0, totalYTDSSTax = 0.0;
                        if (YTD <= 132900 && accumulated <= 132900)
                        {
                            ssTax = pay * SS_TAX_RATE;
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = accumulated * SS_TAX_RATE;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$" + totalSSTax.ToString("N2") + " ($" + ssTax.ToString("N2") + " for the employee and $" + ssTax.ToString("N2") + " for the employer)...from $" + pay + " * " + SS_TAX_RATE;
                        }
                        if (YTD <= 132900 && accumulated >= 132900)
                        {
                            ssTax = (132900 - YTD) * SS_TAX_RATE;
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = 8239.80;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$" + totalSSTax.ToString("N2") + " ($" + ssTax.ToString("N2") + " for the employee and $" + ssTax.ToString("N2") + " for the employer)...from ($132,900 tax wage base - $" + YTD + ") * " + SS_TAX_RATE;
                        }
                        if (YTD > 132900)
                        {
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = 8239.80;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$0.00 (because year-to-date income has exceeded tax base of $132,900)";
                        }
                        double medicareTax = 0.0, totalMedicareTax = 0.0, ytdMedicareTax = 0.0, totalYTDMedicareTax = 0.0;
                        if (YTD <= 200000 && accumulated <= 200000)
                        {
                            medicareTax = pay * MEDICARE_TAX_RATE;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = accumulated * MEDICARE_TAX_RATE;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from $" + pay + " * " + MEDICARE_TAX_RATE;
                        }
                        if (YTD <= 200000 && accumulated >= 200000)
                        {
                            medicareTax = (200000 - YTD) * MEDICARE_TAX_RATE + (accumulated - 200000) * 0.009;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = 2900 + (accumulated - 200000) * 0.009;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from ($200,000 - $" + YTD + ") * " + MEDICARE_TAX_RATE + " + ($" + accumulated + " - $200,000) * 0.009";
                        }
                        if (YTD > 200000)
                        {
                            medicareTax = pay * 0.009;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = 2900 + (accumulated - 200000) * 0.009;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from $" + pay + " * 0.009 (the rate when your income exceeds $200,000)";
                        }
                        double suta = SUTA[DropDownList8.SelectedIndex] / 100;
                        double futa = 0.06 - suta;
                        if (suta == 0.00 || suta == 0.04)
                        {
                            if (suta == 0.00)
                            {
                                double averageRate = Convert.ToDouble(TextBox137.Text) / 100;
                                if (averageRate > 0.054)
                                    suta = 0.054;
                                else
                                    suta = averageRate;
                                futa = 0.06 - suta;
                                GetUnemploymentTaxes(pay, YTD, suta, futa, "Industrial");
                            }
                            if (suta == 0.04)
                            {
                                if (DropDownList8.SelectedValue == "Mississippi")
                                {
                                    int year = Convert.ToInt32(TextBox136.Text);
                                    if (year == 1)
                                        GetUnemploymentTaxes(pay, YTD, 0.012, 0.048, "Mississippi");
                                    if (year == 2)
                                        GetUnemploymentTaxes(pay, YTD, 0.013, 0.047, "Mississippi");
                                    if (year >= 3)
                                        GetUnemploymentTaxes(pay, YTD, 0.014, 0.046, "Mississippi");
                                }
                                if (DropDownList8.SelectedValue == "South Dakota")
                                {
                                    int year = Convert.ToInt32(TextBox136.Text);
                                    if (year == 1)
                                        GetUnemploymentTaxes(pay, YTD, 0.012, 0.048, "South Dakota");
                                    if (year == 2)
                                        GetUnemploymentTaxes(pay, YTD, 0.01, 0.05, "South Dakota");
                                    if (year >= 3)
                                        GetUnemploymentTaxes(pay, YTD, 0.01, 0.05, "South Dakota");
                                }
                            }
                        }
                        else
                        {
                            GetUnemploymentTaxes(pay, YTD, suta, futa, "Nothing");
                        }
                        double cityTax = pay * cityTaxRate;
                        double schoolTax = pay * schoolTaxRate;
                        double localTaxes = cityTax + schoolTax;
                        employerTaxes += localTaxes;
                        double totalCityTax = accumulated * cityTaxRate;
                        double totalSchoolTax = accumulated * schoolTaxRate;
                        YTDTaxes += totalCityTax + totalSchoolTax;
                        Label104.Text += "$" + localTaxes.ToString("N2") + " [$" + cityTax.ToString("N2") + " city tax ($" + pay + " * " + cityTaxRate + ") + $" + schoolTax.ToString("N2") + " school tax ($" + pay + " * " + schoolTaxRate + ")]";
                        if (DropDownList6.SelectedValue == "Married")
                        {
                            GetStateIncomeTax(pay, YTD, accumulated, true);
                            if (DropDownList5.SelectedValue == "Weekly")
                            {
                                double row = (pay - 205) / 11;
                                int row2 = Convert.ToInt32(Math.Floor(row)) - 1;
                                int federalIncomeTax = weeklyMarriedTax[row2, dependents];
                                employeeTaxes += federalIncomeTax;
                                double employeeTaxes2 = employeeTaxes + localTaxes;
                                double additionalWithholdings = Convert.ToDouble(TextBox135.Text);
                                double netPay = pay - employeeTaxes - additionalWithholdings;
                                double netPay2 = netPay - localTaxes; 
                                Label106.Text += "$" + netPay.ToString("N2") + "...from $" + pay.ToString("N2") + " gross pay - $" + employeeTaxes.ToString("N2") + " taxes - $" + additionalWithholdings + " additional withholdings (net pay is $" + netPay2.ToString("N2") + " if employee owes local taxes)";
                                Label88.Text += "$" + federalIncomeTax + " (by integrating your pay of $" + pay + " into the appropriate pay range, your single status, and your " + dependents + " number of dependents into the IRS Publication 15 Circular E withholding tables)";
                                Label105.Text += "$" + employeeTaxes.ToString("N2") + "...from $" + federalIncomeTax + " federal income tax + $" + stateTax.ToString("N2") + " state income tax + $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax (total employee taxes are $" + employeeTaxes2.ToString("N2") + " if employee owes local taxes";
                                Label109.Text += "$" + employerTaxes.ToString("N2") + "...from $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax + $" + stateUnemploymentTax.ToString("N2") + " state unemployment tax + $" + fedUnemploymentTax.ToString("N2") + " federal unemployment tax + $" + localTaxes.ToString("N2") + " local taxes";
                                Label107.Text += "$" + YTDTaxes.ToString("N2") + "...from $" + totalStateTax.ToString("N2") + " state income tax + $" + totalYTDSSTax.ToString("N2") + " Social Security tax ($" + ytdSSTax.ToString("N2") + " for both the employee and the employer) + $" + totalYTDMedicareTax.ToString("N2") + " Medicare tax ($" + ytdMedicareTax.ToString("N2") + " for both the employee and the employer) + $" + totalSUT.ToString("N2") + " state unemployment tax + $" + totalFUT.ToString("N2") + " federal unemployment tax + $" + totalCityTax.ToString("N2") + " city tax + $" + totalSchoolTax.ToString("N2") + " school tax (federal income tax could not be calculated)";
                            }
                        }
                        if (DropDownList6.SelectedValue == "Single")
                        {
                            GetStateIncomeTax(pay, YTD, accumulated, false);
                            if (DropDownList5.SelectedValue == "Weekly")
                            {
                                double row = (pay - 51) / 11;
                                int row2 = Convert.ToInt32(Math.Floor(row)) - 1;
                                int federalIncomeTax = weeklySingleTax[row2, dependents];
                                employeeTaxes += federalIncomeTax;
                                double employeeTaxes2 = employeeTaxes + localTaxes;
                                double additionalWithholdings = Convert.ToDouble(TextBox135.Text);
                                double netPay = pay - employeeTaxes - additionalWithholdings;
                                double netPay2 = netPay - localTaxes;
                                Label106.Text += "$" + netPay.ToString("N2") + "...from $" + pay.ToString("N2") + " gross pay - $" + employeeTaxes.ToString("N2") + " taxes - $" + additionalWithholdings + " additional withholdings (net pay is $" + netPay2.ToString("N2") + " if employee owes local taxes)";
                                Label88.Text += "$" + federalIncomeTax + " (by integrating your pay of $" + pay + " into the appropriate pay range, your single status, and your " + dependents + " number of dependents into the IRS Publication 15 Circular E withholding tables)";
                                Label105.Text += "$" + employeeTaxes.ToString("N2") + "...from $" + federalIncomeTax + " federal income tax + $" + stateTax.ToString("N2") + " state income tax + $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax";
                                Label109.Text += "$" + employerTaxes.ToString("N2") + "...from $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax + $" + stateUnemploymentTax.ToString("N2") + " state unemployment tax + $" + fedUnemploymentTax.ToString("N2") + " federal unemployment tax + $" + localTaxes.ToString("N2") + " local taxes";
                                Label107.Text += "$" + YTDTaxes.ToString("N2") + "...from $" + totalStateTax.ToString("N2") + " state income tax + $" + totalYTDSSTax.ToString("N2") + " Social Security tax ($" + ytdSSTax.ToString("N2") + " for both the employee and the employer) + $" + totalYTDMedicareTax.ToString("N2") + " Medicare tax ($" + ytdMedicareTax.ToString("N2") + " for both the employee and the employer) + $" + totalSUT.ToString("N2") + " state unemployment tax + $" + totalFUT.ToString("N2") + " federal unemployment tax + $" + totalCityTax.ToString("N2") + " city tax + $" + totalSchoolTax.ToString("N2") + " school tax (federal income tax could not be calculated)";
                            }
                        }
                    }
                    if (DropDownList7.SelectedValue == "No" && TextBox129.Text != "")
                    {
                        double pay = Convert.ToDouble(TextBox129.Text);
                        Label95.Text += "$" + pay;
                        double accumulated = pay + YTD;
                        double ssTax = 0.0, totalSSTax = 0.0, ytdSSTax = 0.0, totalYTDSSTax = 0.0;
                        if (YTD <= 132900 && accumulated <= 132900)
                        {
                            ssTax = pay * SS_TAX_RATE;
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = accumulated * SS_TAX_RATE;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$" + totalSSTax.ToString("N2") + " ($" + ssTax.ToString("N2") + " for the employee and $" + ssTax.ToString("N2") + " for the employer)...from $" + pay + " * " + SS_TAX_RATE;
                        }
                        if (YTD <= 132900 && accumulated >= 132900)
                        {
                            ssTax = (132900 - YTD) * SS_TAX_RATE;
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = 8239.80;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$" + totalSSTax.ToString("N2") + " ($" + ssTax.ToString("N2") + " for the employee and $" + ssTax.ToString("N2") + " for the employer)...from ($132,900 tax wage base - $" + YTD + ") * " + SS_TAX_RATE;
                        }
                        if (YTD > 132900)
                        {
                            employeeTaxes += ssTax;
                            employerTaxes += ssTax;
                            totalSSTax = ssTax * 2;
                            ytdSSTax = 8239.80;
                            totalYTDSSTax = ytdSSTax * 2;
                            YTDTaxes += totalYTDSSTax;
                            Label101.Text += "$0.00 (because year-to-date income has exceeded tax base of $132,900)";
                        }
                        double medicareTax = 0.0, totalMedicareTax = 0.0, ytdMedicareTax = 0.0, totalYTDMedicareTax = 0.0;
                        if (YTD <= 200000 && accumulated <= 200000)
                        {
                            medicareTax = pay * MEDICARE_TAX_RATE;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = accumulated * MEDICARE_TAX_RATE;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from $" + pay + " * " + MEDICARE_TAX_RATE;
                        }
                        if (YTD <= 200000 && accumulated >= 200000)
                        {
                            medicareTax = (200000 - YTD) * MEDICARE_TAX_RATE + (accumulated - 200000) * 0.009;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = 2900 + (accumulated - 200000) * 0.009;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from ($200,000 - $" + YTD + ") * " + MEDICARE_TAX_RATE + " + ($" + accumulated + " - $200,000) * 0.009";
                        }
                        if (YTD > 200000)
                        {
                            medicareTax = pay * 0.009;
                            totalMedicareTax = medicareTax * 2;
                            ytdMedicareTax = 2900 + (accumulated - 200000) * 0.009;
                            totalYTDMedicareTax = ytdMedicareTax * 2;
                            Label99.Text += "$" + totalMedicareTax.ToString("N2") + " ($" + medicareTax.ToString("N2") + " for the employee and $" + medicareTax.ToString("N2") + " for the employer)...from $" + pay + " * 0.009 (the rate when your income exceeds $200,000)";
                        }
                        double suta = SUTA[DropDownList8.SelectedIndex] / 100;
                        double futa = 0.06 - suta;
                        if (suta == 0.00 || suta == 0.04)
                        {
                            if (suta == 0.00)
                            {
                                double averageRate = Convert.ToDouble(TextBox137.Text) / 100;
                                if (averageRate > 0.054)
                                    suta = 0.054;
                                else
                                    suta = averageRate;
                                futa = 0.06 - suta;
                                GetUnemploymentTaxes(pay, YTD, suta, futa, "Industrial");
                            }
                            if (suta == 0.04)
                            {
                                if (DropDownList8.SelectedValue == "Mississippi")
                                {
                                    int year = Convert.ToInt32(TextBox136.Text);
                                    if (year == 1)
                                        GetUnemploymentTaxes(pay, YTD, 0.012, 0.048, "Mississippi");
                                    if (year == 2)
                                        GetUnemploymentTaxes(pay, YTD, 0.013, 0.047, "Mississippi");
                                    if (year >= 3)
                                        GetUnemploymentTaxes(pay, YTD, 0.014, 0.046, "Mississippi");
                                }
                                if (DropDownList8.SelectedValue == "South Dakota")
                                {
                                    int year = Convert.ToInt32(TextBox136.Text);
                                    if (year == 1)
                                        GetUnemploymentTaxes(pay, YTD, 0.012, 0.048, "South Dakota");
                                    if (year == 2)
                                        GetUnemploymentTaxes(pay, YTD, 0.01, 0.05, "South Dakota");
                                    if (year >= 3)
                                        GetUnemploymentTaxes(pay, YTD, 0.01, 0.05, "South Dakota");
                                }
                            }
                        }
                        else
                        {
                            GetUnemploymentTaxes(pay, YTD, suta, futa, "Nothing");
                        }
                        double cityTax = pay * cityTaxRate;
                        double schoolTax = pay * schoolTaxRate;
                        double localTaxes = cityTax + schoolTax;
                        employerTaxes += localTaxes;
                        double totalCityTax = accumulated * cityTaxRate;
                        double totalSchoolTax = accumulated * schoolTaxRate;
                        YTDTaxes += totalCityTax + totalSchoolTax;
                        Label104.Text += "$" + localTaxes.ToString("N2") + " [$" + cityTax.ToString("N2") + " city tax ($" + pay + " * " + cityTaxRate + ") + $" + schoolTax.ToString("N2") + " school tax ($" + pay + " * " + schoolTaxRate + ")]";
                        if (DropDownList6.SelectedValue == "Married")
                        {
                            GetStateIncomeTax(pay, YTD, accumulated, true);
                            if (DropDownList5.SelectedValue == "Weekly")
                            {
                                double row = (pay - 205) / 11;
                                int row2 = Convert.ToInt32(Math.Floor(row)) - 1;
                                int federalIncomeTax = weeklyMarriedTax[row2, dependents];
                                employeeTaxes += federalIncomeTax;
                                double employeeTaxes2 = employeeTaxes + localTaxes;
                                double additionalWithholdings = Convert.ToDouble(TextBox135.Text);
                                double netPay = pay - employeeTaxes - additionalWithholdings;
                                double netPay2 = netPay - localTaxes;
                                Label106.Text += "$" + netPay.ToString("N2") + "...from $" + pay.ToString("N2") + " gross pay - $" + employeeTaxes.ToString("N2") + " taxes - $" + additionalWithholdings + " additional withholdings (net pay is $" + netPay2.ToString("N2") + " if employee owes local taxes)";
                                Label88.Text += "$" + federalIncomeTax + " (by integrating your pay of $" + pay + " into the appropriate pay range, your single status, and your " + dependents + " number of dependents into the IRS Publication 15 Circular E withholding tables)";
                                Label105.Text += "$" + employeeTaxes.ToString("N2") + "...from $" + federalIncomeTax + " federal income tax + $" + stateTax.ToString("N2") + " state income tax + $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax";
                                Label109.Text += "$" + employerTaxes.ToString("N2") + "...from $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax + $" + stateUnemploymentTax.ToString("N2") + " state unemployment tax + $" + fedUnemploymentTax.ToString("N2") + " federal unemployment tax + $" + localTaxes.ToString("N2") + " local taxes";
                                Label107.Text += "$" + YTDTaxes.ToString("N2") + "...from $" + totalStateTax.ToString("N2") + " state income tax + $" + totalYTDSSTax.ToString("N2") + " Social Security tax ($" + ytdSSTax.ToString("N2") + " for both the employee and the employer) + $" + totalYTDMedicareTax.ToString("N2") + " Medicare tax ($" + ytdMedicareTax.ToString("N2") + " for both the employee and the employer) + $" + totalSUT.ToString("N2") + " state unemployment tax + $" + totalFUT.ToString("N2") + " federal unemployment tax + $" + totalCityTax.ToString("N2") + " city tax + $" + totalSchoolTax.ToString("N2") + " school tax (federal income tax could not be calculated)";
                            }
                        }
                        if (DropDownList6.SelectedValue == "Single")
                        {
                            if (DropDownList5.SelectedValue == "Weekly")
                            {
                                GetStateIncomeTax(pay, YTD, accumulated, false);
                                double row = (pay - 51) / 11;
                                int row2 = Convert.ToInt32(Math.Floor(row)) - 1;
                                int federalIncomeTax = weeklySingleTax[row2, dependents];
                                employeeTaxes += federalIncomeTax;
                                double employeeTaxes2 = employeeTaxes + localTaxes;
                                double additionalWithholdings = Convert.ToDouble(TextBox135.Text);
                                double netPay = pay - employeeTaxes - additionalWithholdings;
                                double netPay2 = netPay - localTaxes;
                                Label106.Text += "$" + netPay.ToString("N2") + "...from $" + pay.ToString("N2") + " gross pay - $" + employeeTaxes.ToString("N2") + " taxes - $" + additionalWithholdings + " additional withholdings (net pay is $" + netPay2.ToString("N2") + " if employee owes local taxes)";
                                Label88.Text += "$" + federalIncomeTax + " (by integrating your pay of $" + pay + " into the appropriate pay range, your single status, and your " + dependents + " number of dependents into the IRS Publication 15 Circular E withholding tables)";
                                Label105.Text += "$" + employeeTaxes.ToString("N2") + "...from $" + federalIncomeTax + " federal income tax + $" + stateTax.ToString("N2") + " state income tax + $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax";
                                Label109.Text += "$" + employerTaxes.ToString("N2") + "...from $" + ssTax.ToString("N2") + " Social Security tax + $" + medicareTax.ToString("N2") + " Medicare tax + $" + stateUnemploymentTax.ToString("N2") + " state unemployment tax + $" + fedUnemploymentTax.ToString("N2") + " federal unemployment tax + $" + localTaxes.ToString("N2") + " local taxes";
                                Label107.Text += "$" + YTDTaxes.ToString("N2") + "...from $" + totalStateTax.ToString("N2") + " state income tax + $" + totalYTDSSTax.ToString("N2") + " Social Security tax ($" + ytdSSTax.ToString("N2") + " for both the employee and the employer) + $" + totalYTDMedicareTax.ToString("N2") + " Medicare tax ($" + ytdMedicareTax.ToString("N2") + " for both the employee and the employer) + $" + totalSUT.ToString("N2") + " state unemployment tax + $" + totalFUT.ToString("N2") + " federal unemployment tax + $" + totalCityTax.ToString("N2") + " city tax + $" + totalSchoolTax.ToString("N2") + " school tax (federal income tax could not be calculated)";
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    lblError5.Text += "Error: Textbox input must be a number, i.e. no letters or special characters.";
                }
                catch (Exception er)
                {
                    lblError5.Text += er.Message;
                }
            }
        }

        private void GetUnemploymentTaxes(double pay, double YTD, double stateUnemploymentTaxRate, double fedUnemploymentTaxRate, string state)
        {
            double accumulated = pay + YTD;
            if (YTD <= 7000 && accumulated <= 7000)
            {
                fedUnemploymentTax = pay * fedUnemploymentTaxRate;
                stateUnemploymentTax = pay * stateUnemploymentTaxRate;
                totalFUT = accumulated * fedUnemploymentTaxRate;
                totalSUT = accumulated * stateUnemploymentTaxRate;
                employerTaxes += fedUnemploymentTax + stateUnemploymentTax;
                YTDTaxes += totalFUT + totalSUT;
                DisplayLabelText(state, pay, stateUnemploymentTax, fedUnemploymentTax, stateUnemploymentTaxRate, fedUnemploymentTaxRate);
            }
            if (YTD <= 7000 && accumulated >= 7000)
            {
                double taxableUT = 7000 - YTD;
                fedUnemploymentTax = taxableUT * fedUnemploymentTaxRate;
                stateUnemploymentTax = taxableUT * stateUnemploymentTaxRate;
                totalFUT = accumulated * fedUnemploymentTaxRate;
                totalSUT = accumulated * stateUnemploymentTaxRate;
                employerTaxes += fedUnemploymentTax + stateUnemploymentTax;
                YTDTaxes += totalFUT + totalSUT;
                Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from ($7000 - $" + YTD + ") * " + fedUnemploymentTaxRate;
                Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from ($7000 - $" + YTD + ") * " + stateUnemploymentTaxRate;
            }
            if (YTD > 7000)
            {
                Label102.Text += "$0 (because yearly earnings have exceeded $7,000 tax base)";
                Label103.Text += "$0 (because yearly earnings have exceeded $7,000 tax base)";
            }
        }

        private void DisplayLabelText(string state, double pay, double stateUnemploymentTax, double fedUnemploymentTax, double stateUnemploymentTaxRate, double fedUnemploymentTaxRate)
        {
            if (state == "Mississippi" || state == "South Dakota" || state == "Industrial" || state == "Minnesota" || state == "Utah" || state == "Washington" || state == "Wyoming")
            {
                if (state == "Mississippi")
                {
                    int year = Convert.ToInt32(TextBox136.Text);
                    if (year == 1)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.012, which is 0.048)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.012, Mississippi's tax rate for the 1st year of employment";
                    }
                    if (year == 2)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.013, which is 0.047)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.013, Mississippi's tax rate for the 2nd year of employment";
                    }
                    if (year >= 3)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.014, which is 0.046)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.014, Mississippi's tax rate for the 3rd year of employment and on";
                    }
                }
                if (state == "South Dakota")
                {
                    int year = Convert.ToInt32(TextBox136.Text);
                    if (year == 1)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.012, which is 0.048)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.012, South Dakota's tax rate for the 1st year of employment";
                    }
                    if (year == 2)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.01, which is 0.05)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.01, South Dakota's tax rate for the 2nd year of employment";
                    }
                    if (year >= 3)
                    {
                        Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - 0.01, which is 0.05)";
                        Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * 0.01, South Dakota's tax rate for the 3rd year of employment and on";
                    }
                }
                if (state == "Industrial" || state == "Minnesota" || state == "Utah" || state == "Washington" || state == "Wyoming")
                {
                    Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - " + stateUnemploymentTaxRate + ", which equals " + fedUnemploymentTaxRate + ")";
                    Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * " + stateUnemploymentTaxRate + ", " + DropDownList8.SelectedValue + "'s industrial average rate you stated for SUTA";
                }
            }
            else
            {
               Label102.Text += "$" + fedUnemploymentTax.ToString("N2") + "...from $" + pay + " * (0.06 - " + stateUnemploymentTaxRate + ", which equals " + fedUnemploymentTaxRate + ")";
                Label103.Text += "$" + stateUnemploymentTax.ToString("N2") + "...from $" + pay + " * " + stateUnemploymentTaxRate + ", " + DropDownList8.SelectedValue + "'s standard rate for SUTA";
            }
        }

        private void GetStateIncomeTax(double pay, double YTD, double accumulated, bool isMarried)
        {
            if (DropDownList8.SelectedValue == "Alabama")
            {
                if (isMarried)
                {
                    if (YTD <= 1000 && accumulated <= 1000)
                    {
                        stateTax = pay * 0.02;
                        totalStateTax = accumulated * 0.02;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.02 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD <= 1000 && accumulated >= 1000 && accumulated <= 6000)
                    {
                        stateTax = (1000 - YTD) * 0.02 + (accumulated - 1000) * 0.04;
                        totalStateTax = 20 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($1000 - $" + YTD + ") * 0.02 + ($" + accumulated + " - $1000) * 0.04 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD <= 1000 && accumulated >= 6000)
                    {
                        stateTax = (1000 - YTD) * 0.02 + 200 + (accumulated - 6000) * 0.05;
                        totalStateTax = 20 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($1000 - " + YTD + ") * 0.02 + ($6000 - $1000) * 0.04 + ($" + accumulated + " - $6000) * 0.05 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD >= 1000 && accumulated <= 6000)
                    {
                        stateTax = pay * 0.04;
                        totalStateTax = 20 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.04 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD >= 1000 && accumulated >= 6000)
                    {
                        stateTax = (6000 - YTD) * 0.04 + (accumulated - 6000) * 0.05;
                        totalStateTax = 220 + (accumulated - 6000) * 0.05;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($6000 - $" + YTD + ") * 0.04 + ($" + accumulated + " - $6000) * 0.05 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD > 6000)
                    {
                        stateTax = pay * 0.05;
                        totalStateTax = 220 + (accumulated - 6000) * 0.05;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.05 (this is using Alabama's state tax brackets)";
                    }
                }
                else
                {
                    if (YTD <= 500 && accumulated <= 500)
                    {
                        stateTax = pay * 0.02;
                        totalStateTax = accumulated * 0.02;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.02 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD <= 500 && accumulated >= 500 && accumulated <= 3000)
                    {
                        stateTax = (1000 - YTD) * 0.02 + (accumulated - 1000) * 0.04;
                        totalStateTax = 10 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($500 - $" + YTD + ") * 0.02 + ($" + accumulated + " - $500) * 0.04 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD <= 500 && accumulated >= 3000)
                    {
                        stateTax = (1000 - YTD) * 0.02 + 100 + (accumulated - 3000) * 0.05;
                        totalStateTax = 10 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($500 - " + YTD + ") * 0.02 + ($3000 - $500) * 0.04 + ($" + accumulated + " - $3000) * 0.05 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD >= 500 && accumulated <= 3000)
                    {
                        stateTax = pay * 0.04;
                        totalStateTax = 10 + (accumulated - 1000) * 0.04;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.04 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD >= 500 && accumulated >= 3000)
                    {
                        stateTax = (3000 - YTD) * 0.04 + (accumulated - 3000) * 0.05;
                        totalStateTax = 110 + (accumulated - 3000) * 0.05;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($3000 - $" + YTD + ") * 0.04 + ($" + accumulated + " - $3000) * 0.05 (this is using Alabama's state tax brackets)";
                    }
                    if (YTD > 3000)
                    {
                        stateTax = pay * 0.05;
                        totalStateTax = 110 + (accumulated - 3000) * 0.05;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.05 (this is using Alabama's state tax brackets)";
                    }
                } 
            }
            if (DropDownList8.SelectedValue == "Alaska")
            {
                Label100.Text += "$0.00 (Alaska does not impose an individual state income tax)";
            }
            if (DropDownList8.SelectedValue == "Arizona")
            {
                if (isMarried)
                {
                    if (YTD <= 22092 && accumulated <= 22092)
                    {
                        stateTax = pay * 0.0259;
                        totalStateTax = accumulated * 0.0259;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0259 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 22092 && accumulated >= 22092)
                    {
                        stateTax = (22092 - YTD) * 0.0259 + (accumulated - 22092) * 0.0288;
                        totalStateTax = 572.1828 + (accumulated - 22092) * 0.0288;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($22092 - $" + YTD + ") * 0.0259 + ($" + accumulated + " - $22092) * 0.0288 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 22092 && accumulated <= 55226)
                    {
                        stateTax = pay * 0.0288;
                        totalStateTax = 572.1828 + (accumulated - 22092) * 0.0288;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0288 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 55226 && accumulated >= 55226)
                    {
                        stateTax = (55226 - YTD) * 0.0288 + (accumulated - 55226) * 0.0336;
                        totalStateTax = 1526.442 + (accumulated - 55226) * 0.0336;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($55226 - $" + YTD + ") * 0.0288 + ($" + accumulated + " - $55226) * 0.0336 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 55226 && accumulated <= 110450)
                    {
                        stateTax = pay * 0.0336;
                        totalStateTax = 1526.442 + (accumulated - 55226) * 0.0336;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0336 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 110450 && accumulated >= 110450)
                    {
                        stateTax = (110450 - YTD) * 0.0336 + (accumulated - 110450) * 0.0424;
                        totalStateTax = 3381.9684 + (accumulated - 110450) * 0.0424;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($110450 - $" + YTD + ") * 0.0336 + ($" + accumulated + " - $110450) * 0.0424 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 110450 && accumulated <= 331346)
                    {
                        stateTax = pay * 0.0424;
                        totalStateTax = 3381.9684 + (accumulated - 110450) * 0.0424;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0424 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD > 331346)
                    {
                        stateTax = pay * 0.0454;
                        totalStateTax = 12747.9588 + (accumulated - 331346) * 0.0454;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0454 (this is using Arizona's state tax brackets)";
                    }
                }
                else
                {
                    if (YTD <= 11047 && accumulated <= 11047)
                    {
                        stateTax = pay * 0.0259;
                        totalStateTax = accumulated * 0.0259;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0259 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 11047 && accumulated >= 11047)
                    {
                        stateTax = (11047 - YTD) * 0.0259 + (accumulated - 11047) * 0.0288;
                        totalStateTax = 572.1828 + (accumulated - 11047) * 0.0288;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($11047 - $" + YTD + ") * 0.0259 + ($" + accumulated + " - $11047) * 0.0288 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 11047 && accumulated <= 27614)
                    {
                        stateTax = pay * 0.0288;
                        totalStateTax = 572.1828 + (accumulated - 11047) * 0.0288;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0288 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 27614 && accumulated >= 27614)
                    {
                        stateTax = (27614 - YTD) * 0.0288 + (accumulated - 27614) * 0.0336;
                        totalStateTax = 1526.442 + (accumulated - 27614) * 0.0336;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($27614 - $" + YTD + ") * 0.0288 + ($" + accumulated + " - $27614) * 0.0336 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 27614 && accumulated <= 55226)
                    {
                        stateTax = pay * 0.0336;
                        totalStateTax = 1526.442 + (accumulated - 27614) * 0.0336;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0336 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD <= 55226 && accumulated >= 55226)
                    {
                        stateTax = (55226 - YTD) * 0.0336 + (accumulated - 55226) * 0.0424;
                        totalStateTax = 3381.9684 + (accumulated - 55226) * 0.0424;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($55226 - $" + YTD + ") * 0.0336 + ($" + accumulated + " - $55226) * 0.0424 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD >= 55226 && accumulated <= 165674)
                    {
                        stateTax = pay * 0.0424;
                        totalStateTax = 3381.9684 + (accumulated - 55226) * 0.0424;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0424 (this is using Arizona's state tax brackets)";
                    }
                    if (YTD > 165674)
                    {
                        stateTax = pay * 0.0454;
                        totalStateTax = 12747.9588 + (accumulated - 165674) * 0.0454;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0454 (this is using Arizona's state tax brackets)";
                    }
                }
            }
            if (DropDownList8.SelectedValue == "Ohio")
            {
                if (isMarried == true || isMarried == false)
                {
                    if (YTD < 10850)
                    {
                        stateTax = 0.0;
                        totalStateTax = stateTax;
                        Label100.Text += "$0.00 (because your year-to-date income is below Ohio's first tax bracket of $10,850-$16,300)";
                    }
                    if (YTD >= 10850 && accumulated <= 16300)
                    {
                        stateTax = pay * 0.0198;
                        totalStateTax = stateTax;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0198 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 16300 && accumulated >= 16300)
                    {
                        stateTax = (16300 - YTD) * 0.0198 + (accumulated - 16300) * 0.02746;
                        totalStateTax = 107.91 + (accumulated - 16300) * 0.02746;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($16,300 - $" + YTD + ") * 0.0198 + ($" + accumulated + " - $16,300) * 0.02746 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD >= 16300 && accumulated <= 21750)
                    {
                        stateTax = pay * 0.02746;
                        totalStateTax = 107.91 + (accumulated - 16300) * 0.02746;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.02746 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 21750 && accumulated >= 21750)
                    {
                        stateTax = (21750 - YTD) * 0.02746 + (accumulated - 21750) * 0.02969;
                        totalStateTax = 257.567 + (accumulated - 21750) * 0.02969;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($21,750 - $" + YTD + ") * 0.02746 + ($" + accumulated + " - $21,750) * 0.02969 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD >= 21750 && accumulated <= 43450)
                    {
                        stateTax = pay * 0.02969;
                        totalStateTax = 257.567 + (accumulated - 21750) * 0.02969;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.02969 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 43450 && accumulated >= 43450)
                    {
                        stateTax = (43450 - YTD) * 0.02969 + (accumulated - 43450) * 0.03465;
                        totalStateTax = 901.84 + (accumulated - 43450) * 0.03465;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($43,450 - $" + YTD + ") * 0.02969 + ($" + accumulated + " - $43,450) * 0.03465 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD >= 43450 && accumulated <= 86900)
                    {
                        stateTax = pay * 0.03465;
                        totalStateTax = 901.84 + (accumulated - 43450) * 0.03465;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.03465 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 86900 && accumulated >= 86900)
                    {
                        stateTax = (86900 - YTD) * 0.03465 + (accumulated - 86900) * 0.0396;
                        totalStateTax = 2407.3825 + (accumulated - 86900) * 0.0396;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($86,900 - $" + YTD + ") * 0.03465 + ($" + accumulated + " - $86,900) * 0.0396 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD >= 86900 && accumulated <= 108700)
                    {
                        stateTax = pay * 0.0396;
                        totalStateTax = 2407.3825 + (accumulated - 86900) * 0.0396;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.0396 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 107800 && accumulated >= 107800)
                    {
                        stateTax = (107800 - YTD) * 0.0396 + (accumulated - 107800) * 0.04597;
                        totalStateTax = 2407.3825 + (accumulated - 107800) * 0.04597;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($107,800 - $" + YTD + ") * 0.04597 + ($" + accumulated + " - $107,800) * 0.04597 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD >= 107800 && accumulated <= 217400)
                    {
                        stateTax = pay * 0.04597;
                        totalStateTax = 3235.0225 + (accumulated - 107800) * 0.04597;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.04597 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD <= 217400 && accumulated >= 217400)
                    {
                        stateTax = (217400 - YTD) * 0.04597 + (accumulated - 217400) * 0.04997;
                        totalStateTax = 3235.0225 + (accumulated - 217400) * 0.04997;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from ($217,400 - $" + YTD + ") * 0.04597 + ($" + accumulated + " - $217,400) * 0.04997 (this is using Ohio's state tax brackets)";
                    }
                    if (YTD > 217400)
                    {
                        stateTax = pay * 0.04997;
                        totalStateTax = 8666.7615 + (accumulated - 217400) * 0.04997;
                        employeeTaxes += stateTax;
                        YTDTaxes += totalStateTax;
                        Label100.Text += "$" + stateTax.ToString("N2") + "...from $" + pay + " * 0.04997 (this is using Ohio's state tax brackets)";
                    }
                }
            }
        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList7.SelectedValue == "Yes")
            {
                Label91.Attributes.Add("style", "display: inline");
                Label92.Attributes.Add("style", "display: inline");
                Label93.Attributes.Add("style", "display: inline");
                Label94.Attributes.Add("style", "display: inline");
                TextBox53.Attributes.Add("style", "display: inline");
                TextBox54.Attributes.Add("style", "display: inline");
                TextBox55.Attributes.Add("style", "display: inline");
                TextBox131.Attributes.Add("style", "display: inline");
                Label91.Visible = true;
                Label92.Visible = true;
                Label93.Visible = true;
                Label94.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox131.Visible = true;
            }
            if (DropDownList7.SelectedValue == "No")
            {
                Label91.Attributes.Add("style", "display: none");
                Label92.Attributes.Add("style", "display: none");
                Label93.Attributes.Add("style", "display: none");
                Label94.Attributes.Add("style", "display: none");
                TextBox53.Attributes.Add("style", "display: none");
                TextBox54.Attributes.Add("style", "display: none");
                TextBox55.Attributes.Add("style", "display: none");
                TextBox131.Attributes.Add("style", "display: none");
                Label91.Visible = false;
                Label92.Visible = false;
                Label93.Visible = false;
                Label94.Visible = false;
                TextBox53.Visible = false;
                TextBox54.Visible = false;
                TextBox55.Visible = false;
                TextBox131.Visible = false;
            }
        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList8.SelectedValue == "Minnesota")
            {
                Label112.Visible = true;
                Label112.Text += DropDownList8.SelectedValue + ":";
                TextBox137.Visible = true;
                Label113.Visible = true;
                Label111.Visible = false;
                TextBox136.Visible = false;
            }
            if (DropDownList8.SelectedValue == "Mississippi")
            {
                Label111.Visible = true;
                TextBox136.Visible = true;
                Label112.Visible = false;
                TextBox137.Visible = false;
                Label113.Visible = false;
            }
            if (DropDownList8.SelectedValue == "South Dakota")
            {
                Label111.Visible = true;
                TextBox136.Visible = true;
                Label112.Visible = false;
                TextBox137.Visible = false;
                Label113.Visible = false;
            }
            if (DropDownList8.SelectedValue == "Utah")
            {
                Label112.Visible = true;
                Label112.Text += DropDownList8.SelectedValue + ":";
                TextBox137.Visible = true;
                Label113.Visible = true;
                Label111.Visible = false;
                TextBox136.Visible = false;
            }
            if (DropDownList8.SelectedValue == "Washington")
            {
                Label112.Visible = true;
                Label112.Text += DropDownList8.SelectedValue + ":";
                TextBox137.Visible = true;
                Label113.Visible = true;
                Label111.Visible = false;
                TextBox136.Visible = false;
            }
            if (DropDownList8.SelectedValue == "Wyoming")
            {
                Label112.Visible = true;
                Label112.Text += DropDownList8.SelectedValue + ":";
                TextBox137.Visible = true;
                Label113.Visible = true;
                Label111.Visible = false;
                TextBox136.Visible = false;
            }
            if (DropDownList8.SelectedValue != "Minnesota" && DropDownList8.SelectedValue != "Mississippi" && DropDownList8.SelectedValue != "South Dakota" && DropDownList8.SelectedValue != "Utah" && DropDownList8.SelectedValue != "Washington" && DropDownList8.SelectedValue != "Wyoming")
            {
                Label111.Visible = false;
                TextBox136.Visible = false;
                Label112.Visible = false;
                TextBox137.Visible = false;
                Label113.Visible = false;
            }
        }

        protected void GetFileEXE(object sender, CommandEventArgs e)
        {
            string file = e.CommandArgument.ToString();
            string filename = Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(filename);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.ContentType = "application/x-msdownload";
            Response.Flush();
            Response.WriteFile(fileInfo.FullName);
            Response.End();
        }

        protected void GetFileZIP(object sender, CommandEventArgs e)
        {
            string file = e.CommandArgument.ToString();
            string filename = Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(filename);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.ContentType = "application/x-zip-compressed";
            Response.Flush();
            Response.WriteFile(fileInfo.FullName);
            Response.End();
        }

        protected void GetFileMSI(object sender, CommandEventArgs e)
        {
            string file = e.CommandArgument.ToString();
            string filename = Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(filename);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.ContentType = "application/x-msi";
            Response.Flush();
            Response.WriteFile(fileInfo.FullName);
            Response.End();
        }
    }
}