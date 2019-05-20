using System;
using System.IO;
using static System.Math;

namespace WebApplication6.math
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = Cache["Statistics"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("~/math/Statistics.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Statistics", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("~/math/Statistics.aspx")));
                }
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            TextBox9.Visible = false;
            TextBox10.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
            TextBox13.Visible = false;
            TextBox14.Visible = false;
            TextBox23.Visible = false;
            TextBox36.Visible = false;
            TextBox37.Visible = false;
            TextBox41.Visible = false;
            TextBox53.Visible = false;
            TextBox54.Visible = false;
            TextBox55.Visible = false;
            TextBox56.Visible = false;
            TextBox57.Visible = false;
            TextBox58.Visible = false;
            TextBox59.Visible = false;
            TextBox60.Visible = false;
            TextBox61.Visible = false;
            TextBox62.Visible = false;
            TextBox63.Visible = false;
            TextBox64.Visible = false;
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
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox19.Text = "";
            TextBox23.Text = "";
            TextBox36.Text = "";
            TextBox37.Text = "";
            TextBox41.Text = "";
            TextBox53.Text = "";
            TextBox54.Text = "";
            TextBox55.Text = "";
            TextBox56.Text = "";
            TextBox57.Text = "";
            TextBox58.Text = "";
            TextBox59.Text = "";
            TextBox60.Text = "";
            TextBox61.Text = "";
            TextBox62.Text = "";
            TextBox63.Text = "";
            TextBox64.Text = "";
            int elements = Convert.ToInt32(TextBox65.Text);
            double[] array = new double[elements];
            if (elements == 1)
            {
                TextBox1.Visible = true;
            }
            if (elements == 2)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
            }
            if (elements == 3)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
            }
            if (elements == 4)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
            }
            if (elements == 5)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
            }
            if (elements == 6)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
            }
            if (elements == 7)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
            }
            if (elements == 8)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
            }
            if (elements == 9)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
            }
            if (elements == 10)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
            }
            if (elements == 11)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
            }
            if (elements == 12)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
            }
            if (elements == 13)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
            }
            if (elements == 14)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
            }
            if (elements == 15)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
            }
            if (elements == 16)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
            }
            if (elements == 17)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
            }
            if (elements == 18)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
            }
            if (elements == 19)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
            }
            if (elements == 20)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
            }
            if (elements == 21)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
            }
            if (elements == 22)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
            }
            if (elements == 23)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
            }
            if (elements == 24)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
            }
            if (elements == 25)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
            }
            if (elements == 26)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
                TextBox60.Visible = true;
            }
            if (elements == 27)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
                TextBox60.Visible = true;
                TextBox61.Visible = true;
            }
            if (elements == 28)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
                TextBox60.Visible = true;
                TextBox61.Visible = true;
                TextBox62.Visible = true;
            }
            if (elements == 29)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
                TextBox60.Visible = true;
                TextBox61.Visible = true;
                TextBox62.Visible = true;
                TextBox63.Visible = true;
            }
            if (elements == 30)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
                TextBox9.Visible = true;
                TextBox10.Visible = true;
                TextBox11.Visible = true;
                TextBox12.Visible = true;
                TextBox13.Visible = true;
                TextBox14.Visible = true;
                TextBox23.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox41.Visible = true;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
                TextBox57.Visible = true;
                TextBox58.Visible = true;
                TextBox59.Visible = true;
                TextBox60.Visible = true;
                TextBox61.Visible = true;
                TextBox62.Visible = true;
                TextBox63.Visible = true;
                TextBox64.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblValues.Text = "# of Values: ";
            lblMean.Text = "Mean: ";
            lblMedian.Text = "Median: ";
            lblRange.Text = "Range: ";
            lblIQR.Text = "IQR (Interquartile Range): ";
            lblOutlier.Text = "Lower and upper outliers: ";
            lblVariance.Text = "Variance: ";
            lblSD.Text = "Standard deviation: ";
            lblZScore.Text = "Z-score of entered value: ";
            lblPercentile.Text = "Percentile of entered value: ";
            int elements = Convert.ToInt32(TextBox65.Text);
            lblValues.Text += Convert.ToInt32(elements);
            double[] array = new double[elements];
            if (elements == 1)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
            }
            if (elements == 2)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
            }
            if (elements == 3)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
            }
            if (elements == 4)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
            }
            if (elements == 5)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
            }
            if (elements == 6)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
            }
            if (elements == 7)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
            }
            if (elements == 8)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
            }
            if (elements == 9)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
            }
            if (elements == 10)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
            }
            if (elements == 11)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
            }
            if (elements == 12)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
            }
            if (elements == 13)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
            }
            if (elements == 14)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
            }
            if (elements == 15)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
            }
            if (elements == 16)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
            }
            if (elements == 17)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
            }
            if (elements == 18)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
            }
            if (elements == 19)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
            }
            if (elements == 20)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
            }
            if (elements == 21)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
            }
            if (elements == 22)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
            }
            if (elements == 23)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
            }
            if (elements == 24)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
            }
            if (elements == 25)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
            }
            if (elements == 26)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
                array[25] = Convert.ToDouble(TextBox60.Text);
            }
            if (elements == 27)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
                array[25] = Convert.ToDouble(TextBox60.Text);
                array[26] = Convert.ToDouble(TextBox61.Text);
            }
            if (elements == 28)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
                array[25] = Convert.ToDouble(TextBox60.Text);
                array[26] = Convert.ToDouble(TextBox61.Text);
                array[27] = Convert.ToDouble(TextBox62.Text);
            }
            if (elements == 29)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
                array[25] = Convert.ToDouble(TextBox60.Text);
                array[26] = Convert.ToDouble(TextBox61.Text);
                array[27] = Convert.ToDouble(TextBox62.Text);
                array[28] = Convert.ToDouble(TextBox63.Text);
            }
            if (elements == 30)
            {
                array[0] = Convert.ToDouble(TextBox1.Text);
                array[1] = Convert.ToDouble(TextBox2.Text);
                array[2] = Convert.ToDouble(TextBox3.Text);
                array[3] = Convert.ToDouble(TextBox4.Text);
                array[4] = Convert.ToDouble(TextBox5.Text);
                array[5] = Convert.ToDouble(TextBox6.Text);
                array[6] = Convert.ToDouble(TextBox7.Text);
                array[7] = Convert.ToDouble(TextBox8.Text);
                array[8] = Convert.ToDouble(TextBox9.Text);
                array[9] = Convert.ToDouble(TextBox10.Text);
                array[10] = Convert.ToDouble(TextBox11.Text);
                array[11] = Convert.ToDouble(TextBox12.Text);
                array[12] = Convert.ToDouble(TextBox13.Text);
                array[13] = Convert.ToDouble(TextBox14.Text);
                array[14] = Convert.ToDouble(TextBox23.Text);
                array[15] = Convert.ToDouble(TextBox36.Text);
                array[16] = Convert.ToDouble(TextBox37.Text);
                array[17] = Convert.ToDouble(TextBox41.Text);
                array[18] = Convert.ToDouble(TextBox53.Text);
                array[19] = Convert.ToDouble(TextBox54.Text);
                array[20] = Convert.ToDouble(TextBox55.Text);
                array[21] = Convert.ToDouble(TextBox56.Text);
                array[22] = Convert.ToDouble(TextBox57.Text);
                array[23] = Convert.ToDouble(TextBox58.Text);
                array[24] = Convert.ToDouble(TextBox59.Text);
                array[25] = Convert.ToDouble(TextBox60.Text);
                array[26] = Convert.ToDouble(TextBox61.Text);
                array[27] = Convert.ToDouble(TextBox62.Text);
                array[28] = Convert.ToDouble(TextBox63.Text);
                array[29] = Convert.ToDouble(TextBox64.Text);
            }
            double value = 0;
            for (int i = 0; i < elements; i++)
                value += array[i];
            double mean = value / elements;
            lblMean.Text += mean.ToString("F3");
            Array.Sort(array);
            if (elements % 4 == 0)
            {
                int subscript = elements / 2;
                double median = (array[subscript - 1] + array[subscript]) / 2;
                lblMedian.Text += median;
                double first = elements * .25;
                double third = elements * .75;
                int firstQuartile = Convert.ToInt32(first);
                int thirdQuartile = Convert.ToInt32(third);
                double IQR = ((array[thirdQuartile] + array[thirdQuartile - 1]) / 2) - ((array[firstQuartile] + array[firstQuartile - 1]) / 2);
                double Third = (array[thirdQuartile] + array[thirdQuartile - 1]) / 2;
                double First = (array[firstQuartile] + array[firstQuartile - 1]) / 2;
                lblIQR.Text += IQR + " (" + Third + " - " + First + ")";
                double constant = IQR * 1.5;
                double upperOutlier = array[elements - 1] + constant;
                double lowerOutlier = array[0] - constant;
                lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
            }
            else
            {
                if (elements % 2 == 0)
                {
                    int subscript = (elements - 1) / 2;
                    double median = (array[subscript - 1] + array[subscript]) / 2;
                    lblMedian.Text += median;
                    double first = (elements * .25) - .5;
                    int firstQuartile = Convert.ToInt32(first);
                    double third = (elements * .75) - .5;
                    int thirdQuartile = Convert.ToInt32(third);
                    double IQR = array[thirdQuartile] - array[firstQuartile];
                    lblIQR.Text += IQR + " (" + array[thirdQuartile] + " - " + array[firstQuartile] + ")";
                    double constant = IQR * 1.5;
                    double upperOutlier = array[elements - 1] + constant;
                    double lowerOutlier = array[0] - constant;
                    lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                }
                if ((elements - 1) % 4 == 0)
                {
                    int subscript = (elements - 1) / 2;
                    double median = array[subscript];
                    lblMedian.Text += median;
                    double first = (elements * .25) - .25;
                    int firstQuartile = Convert.ToInt32(first);
                    double third = (elements * .75) + .25;
                    int thirdQuartile = Convert.ToInt32(third);
                    double IQR = ((array[thirdQuartile] + array[thirdQuartile - 1]) / 2) - ((array[firstQuartile] + array[firstQuartile - 1]) / 2);
                    double Third = (array[thirdQuartile] + array[thirdQuartile - 1]) / 2;
                    double First = (array[firstQuartile] + array[firstQuartile - 1]) / 2;
                    lblIQR.Text += IQR + " (" + Third + " - " + First + ")";
                    double constant = IQR * 1.5;
                    double upperOutlier = array[elements - 1] + constant;
                    double lowerOutlier = array[0] - constant;
                    lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                }
                if ((elements + 1) % 4 == 0)
                {
                    int subscript = (elements - 1) / 2;
                    double median = array[subscript];
                    lblMedian.Text += median;
                    double first = (elements * .25) - .75;
                    int firstQuartile = Convert.ToInt32(first);
                    double third = (elements * .75) - .25;
                    int thirdQuartile = Convert.ToInt32(third);
                    double IQR = array[thirdQuartile] - array[firstQuartile];
                    lblIQR.Text += IQR + " (" + array[thirdQuartile] + " - " + array[firstQuartile] + ")";
                    double constant = IQR * 1.5;
                    double upperOutlier = array[elements - 1] + constant;
                    double lowerOutlier = array[0] - constant;
                    lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                }
            }
            double range = array[elements - 1] - array[0];
            lblRange.Text += range + " (" + array[elements - 1] + " - " + array[0] + ")";
            double total = 0;
            for (int index = 0; index < array.Length; index++)
            {
                double difference = Abs(array[index] - mean);
                double square = Pow(difference, 2);
                total += square;
            }
            double variance = total / array.Length;
            lblVariance.Text += variance.ToString("F3");
            double standard = Sqrt(variance);
            lblSD.Text += "+-" + standard.ToString("F3");
            double Z = Convert.ToDouble(TextBox19.Text);
            double Zscore = (Z - mean) / standard;
            lblZScore.Text += Zscore.ToString("F2");
            int greater = 0;
            for (int count = 0; count < array.Length; count++)
            {
                if (Z > array[count])
                {
                    greater++;
                }
                if (count == array.Length - 1)
                {
                    double percentile = (greater * 100) / (array.Length - 1);
                    lblPercentile.Text += percentile + "th percentile";
                }
            }
        }

        protected void btnContents_Click(object sender, EventArgs e)
        {
            // Setting text of label and text boxes to null so they are blank the next time the button is clicked
            lblValues.Text = "# of Values: ";
            lblMean.Text = "Mean: ";
            lblMedian.Text = "Median: ";
            lblRange.Text = "Range: ";
            lblIQR.Text = "IQR (Interquartile Range): ";
            lblOutlier.Text = "Lower and upper outliers: ";
            lblVariance.Text = "Variance: ";
            lblSD.Text = "Standard deviation: ";
            lblZScore.Text = "Z-score of entered value: ";
            lblPercentile.Text = "Percentile of entered value: ";
            TextBox66.Text = "";
            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.FileName);         // Obtaining file selected from FileUpload control
                string fullPath = Server.MapPath(FileUpload1.FileName);                     // Finding path of user on local machine
                fullPath = fullPath.Remove(fullPath.Length - fileName.Length - 9);          // Removing the file name and "Website\" part of path
                fullPath = fullPath.Replace(@"\", @"\\");                                   // Replacing single backslashes with double backslashes
                string pathAndFile = fullPath + fileName;                                   // Concatenating path and file name to get full path of destination of file
                int count = 0, counter = 0;                                                 // Initializing loop counters to zero
                if (File.Exists(pathAndFile))                                               // If statement testing if the file exists, using the string variable
                {
                    try
                    {
                        StreamReader inFile = new StreamReader(pathAndFile);       // Declaring object from StreamReader of the file
                        while ((fileName = inFile.ReadLine()) != null)             // While loop testing if null when reaching end of file
                        {
                            count++;                                               // Incrementing loop counter
                        }
                        inFile.Close();                                            // Closing stream reader so memory is not wasted
                        double[] textFile = new double[count];                     // Setting integer array equal to size of number of read lines in file
                        StreamReader file = new StreamReader(pathAndFile);         // Declaring object from StreamReader of the file
                        while ((fileName = file.ReadLine()) != null)               // While loop testing if null when reaching end of file
                        {
                            textFile[counter] = Convert.ToDouble(fileName);        // Setting integer-cast variable equal to array index
                            counter++;                                             // Incrementing loop counter
                        }
                        file.Close();                                              // Closing stream reader so memory is not wasted
                        double total = 0;                                          // Initializing accumulator to zero
                        for (int index = 0; index < textFile.Length; index++)      // For loop going through size of the array
                            total += textFile[index];                              // Adding array's values to accumulator
                        double average = total / textFile.Length;                  // Double-precision variable for calculating average
                        lblValues.Text += Convert.ToString(textFile.Length);       // Showing number of values in text box
                        lblMean.Text += average.ToString("F3");                    // Showing the average, formatted to two decimal places
                        Array.Sort(textFile);
                        if (textFile.Length % 4 == 0)
                        {
                            int subscript = textFile.Length / 2;
                            double median = (textFile[subscript - 1] + textFile[subscript]) / 2;
                            lblMedian.Text += median;
                            double first = textFile.Length * .25;
                            double third = textFile.Length * .75;
                            int firstQuartile = Convert.ToInt32(first);
                            int thirdQuartile = Convert.ToInt32(third);
                            double IQR = ((textFile[thirdQuartile] + textFile[thirdQuartile - 1]) / 2) - ((textFile[firstQuartile] + textFile[firstQuartile - 1]) / 2);
                            double Third = (textFile[thirdQuartile] + textFile[thirdQuartile - 1]) / 2;
                            double First = (textFile[firstQuartile] + textFile[firstQuartile - 1]) / 2;
                            lblIQR.Text += IQR + " (" + Third + " - " + First + ")";
                            double constant = IQR * 1.5;
                            double upperOutlier = textFile[textFile.Length - 1] + constant;
                            double lowerOutlier = textFile[0] - constant;
                            lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                        }
                        else
                        {
                            if (textFile.Length % 2 == 0)
                            {
                                int subscript = (textFile.Length - 1) / 2;
                                double median = (textFile[subscript - 1] + textFile[subscript]) / 2;
                                lblMedian.Text += median;
                                double first = (textFile.Length * .25) - .5;
                                int firstQuartile = Convert.ToInt32(first);
                                double third = (textFile.Length * .75) - .5;
                                int thirdQuartile = Convert.ToInt32(third);
                                double IQR = textFile[thirdQuartile] - textFile[firstQuartile];
                                lblIQR.Text += IQR + " (" + textFile[thirdQuartile] + " - " + textFile[firstQuartile] + ")";
                                double constant = IQR * 1.5;
                                double upperOutlier = textFile[textFile.Length - 1] + constant;
                                double lowerOutlier = textFile[0] - constant;
                                lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                            }
                            if ((textFile.Length - 1) % 4 == 0)
                            {
                                int subscript = (textFile.Length - 1) / 2;
                                double median = textFile[subscript];
                                lblMedian.Text += median;
                                double first = (textFile.Length * .25) - .25;
                                int firstQuartile = Convert.ToInt32(first);
                                double third = (textFile.Length * .75) + .25;
                                int thirdQuartile = Convert.ToInt32(third);
                                double IQR = ((textFile[thirdQuartile] + textFile[thirdQuartile - 1]) / 2) - ((textFile[firstQuartile] + textFile[firstQuartile - 1]) / 2);
                                double Third = (textFile[thirdQuartile] + textFile[thirdQuartile - 1]) / 2;
                                double First = (textFile[firstQuartile] + textFile[firstQuartile - 1]) / 2;
                                lblIQR.Text += IQR + " (" + Third + " - " + First + ")";
                                double constant = IQR * 1.5;
                                double upperOutlier = textFile[textFile.Length - 1] + constant;
                                double lowerOutlier = textFile[0] - constant;
                                lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                            }
                            if ((textFile.Length + 1) % 4 == 0)
                            {
                                int subscript = (textFile.Length - 1) / 2;
                                double median = textFile[subscript];
                                lblMedian.Text += median;
                                double first = (textFile.Length * .25) - .75;
                                int firstQuartile = Convert.ToInt32(first);
                                double third = (textFile.Length * .75) - .25;
                                int thirdQuartile = Convert.ToInt32(third);
                                double IQR = textFile[thirdQuartile] - textFile[firstQuartile];
                                lblIQR.Text += IQR + " (" + textFile[thirdQuartile] + " - " + textFile[firstQuartile] + ")";
                                double constant = IQR * 1.5;
                                double upperOutlier = textFile[textFile.Length - 1] + constant;
                                double lowerOutlier = textFile[0] - constant;
                                lblOutlier.Text += lowerOutlier + " and " + upperOutlier;
                            }
                        }
                        double range = textFile[textFile.Length - 1] - textFile[0];
                        lblRange.Text += range + " (" + textFile[textFile.Length - 1] + " - " + textFile[0] + ")";
                        double total2 = 0;
                        for (int index = 0; index < textFile.Length; index++)
                        {
                            double difference = Abs(textFile[index] - average);
                            double square = Pow(difference, 2);
                            total2 += square;
                        }
                        double variance = total2 / textFile.Length;
                        lblVariance.Text += variance.ToString("F3");
                        double standard = Sqrt(variance);
                        lblSD.Text += "+-" + standard.ToString("F3");
                        double Z = Convert.ToDouble(TextBox66.Text);
                        double Zscore = (Z - average) / standard;
                        lblZScore.Text += Zscore.ToString("F2");
                        int greater = 0;
                        for (int index = 0; index < textFile.Length; index++)
                        {
                            if (Z > textFile[index])
                            {
                                greater++;
                            }
                            if (count == textFile.Length - 1)
                            {
                                double percentile = (greater * 100) / (textFile.Length - 1);
                                lblPercentile.Text += percentile + "th percentile";
                            }
                        }
                    }
                    catch (FileNotFoundException except)           // Catch block for FormatException with except object
                    {
                        lblError.Text = except.Message;            // Showing message that the data type was invalid (not integer)
                    }
                    catch (InvalidDataException)                   // Catch block for FormatException
                    {
                        lblError.Text = "Only numbers, no other characters, can be in file";     // Telling user file has invalid data type (not an integer)
                    }
                    catch (EndOfStreamException invalid)           // Catch clause for EndOfStreamException
                    {
                        lblError.Text = invalid.Message;           // Telling user cannot read anymore data since end of file
                    }
                    catch (IOException error)                      // Catch block for IOExceptionError with error object
                    {
                        lblError.Text = error.Message;             // Displaying prewritten message to user that file couldn't be reached
                    }
                    catch (Exception er)                           // Catch clause for generic exception
                    {
                        lblError.Text = "Error: " + er.Message;    // Telling user error and what went wrong
                    }
                }
                else
                {
                    lblError.Text = "File unavailable." + pathAndFile;           // Else statement when File.Exists() is false, saying file is unavailable
                }
            }
            else
                lblError.Text = "File upload could not retrieve file.";  // FileUpload control could not retrieve file
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblWays.Text = "Number of different ways: ";
            lblError6.Text = "";
            int perm1 = Convert.ToInt32(txtPerm.Text);
            int perm2 = int.Parse(txtPerm2.Text);
            if ((perm1 < perm2) || (perm1 > 19 || perm2 > 19))
            {
                if (perm1 < perm2)
                    lblError6.Text += "Error. Possibilities cannot exceed values. ";
                if (perm1 > 19 || perm2 > 19)
                    lblError6.Text += "Error. Values cannot exceed 19.";
            }
            else
            {
                long factorial = 1, factorial2 = 1;
                for (int index = perm1; index > 0; index--)
                    factorial *= index;
                int difference = perm1 - perm2;
                for (int count = difference; count > 0; count--)
                    factorial2 *= count;
                long permutation = factorial / factorial2;
                lblWays.Text += permutation.ToString("N0");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblWays2.Text = "Number of different ways: ";
            lblError5.Text = "";
            int comb1 = Convert.ToInt32(txtComb.Text);
            int comb2 = int.Parse(txtComb2.Text);
            long factorial3 = 1, factorial4 = 1, factorial5 = 1;
            if (comb1 < comb2 || comb1 > 19 || comb2 > 19)
            {
                if (comb1 < comb2)
                    lblError5.Text += "Error. Possibilities cannot exceed values. ";
                if (comb1 > 19 || comb2 > 19)
                    lblError5.Text += "Error. Values cannot exceed 19.";
            }
            else
            {
                for (int index1 = comb1; index1 >= 1; index1--)
                    factorial3 *= index1;
                int diversion = comb1 - comb2;
                for (int count1 = 1; count1 < diversion; count1++)
                    factorial4 *= count1;
                for (int count2 = 1; count2 < comb2; count2++)
                    factorial5 *= count2;
                long combination = factorial3 / (factorial4 * factorial5);
                lblWays2.Text += combination.ToString("N0");
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            lblProbability.Text = "Probability: ";
            lblError7.Text = "";
            int portion1 = Convert.ToInt32(TextBox15.Text);
            int subset1 = Convert.ToInt32(TextBox16.Text);
            int portion2 = Convert.ToInt32(TextBox17.Text);
            int subset2 = Convert.ToInt32(TextBox18.Text);
            int portion = portion1 + portion2;
            int total = subset1 + subset2;
            if (portion1 > subset1 || portion2 > subset2 || total > 19)
            {
                if (portion1 > subset1 || portion2 > subset2)
                    lblError7.Text += "Error. Possibilities cannot exceed totals. ";
                if (total > 19)
                    lblError7.Text += "Total of boys and girls cannot exceed 19.";
            }
            else
            {
                long factorial1 = 1, factorial2 = 1, factorial3 = 1, factorial4 = 1,
                    factorial5 = 1, factorial6 = 1, factorial7 = 1, factorial8 = 1,
                    factorial9 = 1;
                int diversion = subset1 - portion1;
                int difference = subset2 - portion2;
                int diversion2 = total - portion;
                for (int index = subset1; index > 0; index--)
                    factorial1 *= index;
                for (int index1 = diversion; index1 > 0; index1--)
                    factorial2 *= index1;
                for (int index2 = portion1; index2 > 0; index2--)
                    factorial3 *= index2;
                for (int count = subset2; count > 0; count--)
                    factorial4 *= count;
                for (int count1 = difference; count1 > 0; count1--)
                    factorial5 *= count1;
                for (int count2 = portion2; count2 > 0; count2--)
                    factorial6 *= count2;
                for (int i = total; i > 0; i--)
                    factorial7 *= i;
                for (int j = diversion2; j > 0; j--)
                    factorial8 *= j;
                for (int k = portion; k > 0; k--)
                    factorial9 *= k;
                double possibilities = ((factorial1 / (factorial2 * factorial3) *
                    (factorial4 / (factorial5 * factorial6))));
                double totalPoss = (factorial7 / (factorial8 * factorial9));
                double probability = (possibilities / totalPoss) * 100;
                lblProbability.Text += possibilities + "/" + totalPoss + " or " + probability.ToString("F4") + "%";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            lblZero.Text = "Probability of zero drawn in first category: ";
            lblOne.Text = "Probability of one drawn in first category: ";
            lblTwo.Text = "Probability of two drawn in first category: ";
            lblZero1.Text = "Probability of zero drawn in second category: ";
            lblOne1.Text = "Probability of one drawn in second category: ";
            lblTwo1.Text = "Probability of two drawn in second category: ";
            lblThree.Text = "Probability of three drawn in first category: ";
            lblThree1.Text = "Probability of three drawn in second category: ";
            lblExpected.Text = "Expected value of first category: ";
            lblExpected1.Text = "Expected value of second category: ";
            int total = Convert.ToInt32(TextBox20.Text);
            int subset1 = Convert.ToInt32(TextBox21.Text);
            int subset2 = Convert.ToInt32(TextBox22.Text);
            int draws = 0;
            int subsets = subset1 + subset2;
            if ((subsets != total) || (total < 0 || subset1 < 0 || subset2 < 0))
            {
                if (subsets != total)
                    lblError4.Text = "Error. Two categories added up must equal total.";
                if (total < 0 || subset1 < 0 || subset2 < 0)
                    lblError4.Text = "Error. No values can be negative.";
            }
            else
            {
                if (DropDownList2.SelectedValue == "Yes")
                {
                    if (DropDownList1.SelectedValue == "2")
                    {
                        draws = 2;
                        double zero1 = Pow(subset2, draws);
                        double zero2 = Pow(total, draws);
                        double one1 = subset1 * subset2 * draws;
                        double two1 = Pow(subset1, draws);
                        lblZero.Text += zero1 + "/" + zero2;
                        lblOne.Text += one1 + "/" + zero2;
                        lblTwo.Text += two1 + "/" + zero2;
                        lblZero1.Text += two1 + "/" + zero2;
                        lblOne1.Text += one1 + "/" + zero2;
                        lblTwo1.Text += zero1 + "/" + zero2;
                        double expected = (0 * zero1) + (1 * one1) + (2 * two1);
                        double fraction = expected / zero2;
                        lblExpected.Text += expected + "/" + zero2 + " or " + fraction.ToString("F3");
                        double expected2 = one1 + (2 * zero1);
                        double fraction2 = expected2 / zero2;
                        lblExpected1.Text += expected2 + "/" + zero2 + " or " + fraction2.ToString("F3");
                    }
                    else if (DropDownList1.SelectedValue == "3")
                    {
                        draws = 3;
                        double zero1 = Pow(subset2, draws);
                        double zero2 = Pow(total, draws);
                        double one1 = subset1 * Pow(subset2, 2) * draws;
                        double two1 = Pow(subset1, 2) * subset2 * draws;
                        double three1 = Pow(subset1, draws);
                        lblZero.Text += zero1 + "/" + zero2;
                        lblOne.Text += one1 + "/" + zero2;
                        lblTwo.Text += two1 + "/" + zero2;
                        lblThree.Text += three1 + "/" + zero2;
                        lblZero1.Text += three1 + "/" + zero2;
                        lblOne1.Text += two1 + "/" + zero2;
                        lblTwo1.Text += one1 + "/" + zero2;
                        lblThree1.Text += zero1 + "/" + zero2;
                        double expected1 = (0 * zero1) + (1 * one1) + (2 * two1) + (3 * three1);
                        double fraction = expected1 / zero2;
                        lblExpected.Text += expected1 + "/" + zero2 + " or " + fraction.ToString("F3");
                        double expected2 = two1 + (2 * one1) + (3 * zero1);
                        double fraction2 = expected2 / zero2;
                        lblExpected1.Text += expected2 + "/" + zero2 + " or " + fraction2.ToString("F3");
                    }
                }
                if (DropDownList2.SelectedValue == "No")
                {
                    if (DropDownList1.SelectedValue == "2")
                    {
                        draws = 2;
                        double zero1 = subset2 * (subset2 - 1);
                        double zero2 = total * (total - 1);
                        double one1 = subset1 * subset2 * draws;
                        double two1 = subset1 * (subset1 - 1);
                        lblZero.Text += zero1 + "/" + zero2;
                        lblOne.Text += one1 + "/" + zero2;
                        lblTwo.Text += two1 + "/" + zero2;
                        lblZero1.Text += two1 + "/" + zero2;
                        lblOne1.Text += one1 + "/" + zero2;
                        lblTwo1.Text += zero1 + "/" + zero2;
                        double expected = (0 * zero1) + (1 * one1) + (2 * two1);
                        double fraction = expected / zero2;
                        lblExpected.Text += expected + "/" + zero2 + " or " + fraction.ToString("F3");
                        double expected2 = one1 + (2 * zero1);
                        double fraction2 = expected2 / zero2;
                        lblExpected1.Text += expected2 + "/" + zero2 + " or " + fraction2.ToString("F3");
                    }
                    else if (DropDownList1.SelectedValue == "3")
                    {
                        draws = 3;
                        double zero1 = subset2 * (subset2 - 1) * (subset2 - 2);
                        double zero2 = total * (total - 1) * (total - 2);
                        double one1 = subset1 * subset2 * (subset2 - 1) * draws;
                        double two1 = subset2 * subset1 * (subset1 - 1) * draws;
                        double three1 = subset1 * (subset1 - 1) * (subset1 - 2);
                        lblZero.Text += zero1 + "/" + zero2;
                        lblOne.Text += one1 + "/" + zero2;
                        lblTwo.Text += two1 + "/" + zero2;
                        lblThree.Text += three1 + "/" + zero2;
                        lblZero1.Text += three1 + "/" + zero2;
                        lblOne1.Text += two1 + "/" + zero2;
                        lblTwo1.Text += one1 + "/" + zero2;
                        lblThree1.Text += zero1 + "/" + zero2;
                        double expected = (0 * zero1) + (1 * one1) + (2 * two1) + (3 * three1);
                        double fraction = expected / zero2;
                        lblExpected.Text += expected + "/" + zero2 + " or " + fraction.ToString("F3");
                        double expected2 = two1 + (2 * one1) + (3 * zero1);
                        double fraction2 = expected2 / zero2;
                        lblExpected1.Text += expected2 + "/" + zero2 + " or " + fraction2.ToString("F3");
                    }
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            lblOr.Text = "P(A U B): ";
            lblGiven.Text = "P(A / B): ";
            double pa1 = Convert.ToDouble(TextBox24.Text);
            double pa2 = Convert.ToDouble(TextBox25.Text);
            double pb1 = Convert.ToDouble(TextBox26.Text);
            double pb2 = Convert.ToDouble(TextBox27.Text);
            double and1 = Convert.ToDouble(TextBox28.Text);
            double and2 = Convert.ToDouble(TextBox29.Text);
            double[] array = { pa2, pb2, and2 };
            Array.Sort(array);
            double numerator = 0.0;
            double division1 = array[2] / array[1];
            double division2 = array[2] / array[0];
            if ((pa2 == pb2) && (pb2 == and2))
            {
                numerator = pa1 + pb1 - and1;
                lblOr.Text += numerator + "/" + pb2;
                lblGiven.Text += and1 + "/" + pb1;
            }
            else
            {
                if ((array[0] == array[1]) || array[1] == array[2])
                {
                    if (array[1] == array[2])
                    {
                        if (pa2 == pb2)
                        {
                            double and3 = division2 * and1;
                            numerator = pa1 + pb1 - and3;
                            lblGiven.Text += and3.ToString("F2") + "/" + pb1.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                        if (pa2 == and2)
                        {
                            double pb3 = division2 * pb1;
                            numerator = pa1 + pb3 - and1;
                            lblGiven.Text += and1.ToString("F2") + "/" + pb3.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                        if (pb2 == and2)
                        {
                            double pa3 = division2 * pa1;
                            numerator = pa3 + pb1 - and1;
                            lblGiven.Text += and1.ToString("F2") + "/" + pb1.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                    }
                    if (array[0] == array[1])
                    {
                        if (pa2 == pb2)
                        {
                            double pa3 = division2 * pa1;
                            double pb3 = division2 * pb1;
                            numerator = pa3 + pb3 - and1;
                            lblGiven.Text += and1.ToString("F2") + "/" + pb3.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                        if (pa2 == and2)
                        {
                            double pa3 = division2 * pa1;
                            double and3 = division2 * and1;
                            numerator = pa3 + pb1 - and3;
                            lblGiven.Text += and3.ToString("F2") + "/" + pb1.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                        if (pb2 == and2)
                        {
                            double pb3 = division2 * pb1;
                            double and3 = division2 * and1;
                            numerator = pa1 + pb3 - and3;
                            lblGiven.Text += and1.ToString("F2") + "/" + pb1.ToString("F2");
                            lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                        }
                    }
                }
                else
                {
                    if (division1 == (and2 / pa2) && division2 == (and2 / pb2))
                    {
                        double pb3 = pb1 * division2;
                        numerator = (pa1 * division1) + pb3 - and1;
                        lblGiven.Text += and1.ToString("F2") + "/" + pb3.ToString("F2");
                    }
                    if (division2 == (and2 / pa2) && division1 == (and2 / pb2))
                    {
                        double pb3 = pb1 * division1;
                        numerator = (pa1 * division2) + pb3 - and1;
                        lblGiven.Text += and1.ToString("F2") + "/" + pb3.ToString("F2");
                    }
                    if (division1 == (pb2 / pa2) && division2 == (pb2 / and2))
                    {
                        double and3 = and1 * division2;
                        numerator = (pa1 * division1) - and3 + pb1;
                        lblGiven.Text += and3.ToString("F2") + "/" + pb1.ToString("F2");
                    }
                    if (division2 == (pb2 / pa2) && division1 == (pb2 / and2))
                    {
                        double and3 = and1 * division1;
                        numerator = (pa1 * division2) - and3 + pb1;
                        lblGiven.Text += and3.ToString("F2") + "/" + pb1.ToString("F2");
                    }
                    if (division1 == (pa2 / pb2) && division2 == (pa2 / and2))
                    {
                        double pb3 = pb1 * division1;
                        double and3 = and1 * division2;
                        numerator = pb3 - and3 + pa1;
                        lblGiven.Text += and3.ToString("F2") + "/" + pb3.ToString("F2");
                    }
                    if (division2 == (pa2 / pb2) && division1 == (pa2 / and2))
                    {
                        double pb3 = pb1 * division2;
                        double and3 = and1 * division1;
                        numerator = pb3 - and3 + pa1;
                        lblGiven.Text += and3.ToString("F2") + "/" + pb3.ToString("F2");
                    }
                    lblOr.Text += numerator.ToString("F2") + "/" + array[2];
                }
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            double totalbase = Convert.ToDouble(TextBox30.Text);
            double height = Convert.ToDouble(TextBox31.Text) / Convert.ToDouble(TextBox44.Text);
            double medbase = Convert.ToDouble(TextBox32.Text);
            double smallbase = Convert.ToDouble(TextBox33.Text);
            if (height > 1)
                lblError.Text = "Error. Height cannot be greater than 1.";
            double medheight = medbase / (totalbase * (1 / height));
            double smallheight = smallbase / (totalbase * (1 / height));
            double total = 0.5 * totalbase * height;
            if (total < 0.99 || total > 1.01)
                lblError.Text += "Error. Area must equal 1 (so, base * height must equal 2).";
            double medarea = 0.5 * medbase * height;
            double smallarea = 0.5 * smallbase * medheight;
            double shaded = medarea - smallarea;
            double medarea2 = 0.5 * medbase * medheight;
            double smallarea2 = 0.5 * smallbase * smallheight;
            lblTotal.Text += total;
            lblSecond.Text += medarea2.ToString("F3");
            lblSmallest.Text += smallarea2.ToString("F3");
            lblShade.Text += shaded.ToString("F3") + " [from 1/2(" + medbase + ")(" + height.ToString("F3") + ") - 1/2(" + smallbase + ")(" + medheight.ToString("F3") + ")]";
            lblMedHeight.Text += medheight.ToString("F3");
            lblSmallHeight.Text += smallheight.ToString("F3");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            lblX.Text = "x: ";
            lblShaded.Text = "Base of shaded area: ";
            double base1 = Convert.ToDouble(TextBox34.Text);
            double base2 = Convert.ToDouble(TextBox35.Text);
            double area = Convert.ToDouble(TextBox38.Text) / Convert.ToDouble(TextBox45.Text);
            double start = Convert.ToDouble(TextBox52.Text);
            double theBase = base2 - base1;
            double height = 1 / theBase;
            double shadedarea = area / height;
            double x = theBase * area;
            double realX;
            double area2 = area * 100;
            if (DropDownList3.SelectedIndex == 0)
            {
                realX = start + x;
                lblX.Text += realX.ToString("F2") + ", so the " + area2.ToString("F3") + "th percentile, or " + area2.ToString("F3") + "% of packages, weigh less than " + realX.ToString("F2") + " pounds";
                lblShaded.Text += shadedarea.ToString("F2");
            }
            if (DropDownList3.SelectedIndex == 1)
            {
                realX = start + x;
                lblX.Text += realX.ToString("F2") + ", so the " + area2.ToString("F3") + "th percentile, or " + area2.ToString("F3") + "% of packages, weigh at most " + realX.ToString("F2") + " pounds";
                lblShaded.Text += shadedarea.ToString("F2");
            }
            if (DropDownList3.SelectedIndex == 2)
            {
                realX = start - x;
                lblX.Text += realX.ToString("F2") + ", so the " + area2.ToString("F3") + "th percentile, or " + area2.ToString("F3") + "% of packages, weigh more than " + realX.ToString("F2") + " pounds";
                lblShaded.Text += shadedarea.ToString("F2");
            }
            if (DropDownList3.SelectedIndex == 3)
            {
                realX = start - x;
                lblX.Text += realX.ToString("F2") + ", so the " + area2.ToString("F3") + "th percentile, or " + area2.ToString("F3") + "% of packages, weigh at least " + realX.ToString("F2") + " pounds";
                lblShaded.Text += shadedarea.ToString("F2");
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            double base1 = Convert.ToDouble(TextBox39.Text);
            double base2 = Convert.ToDouble(TextBox40.Text);
            double area = Convert.ToDouble(TextBox42.Text) / Convert.ToDouble(TextBox43.Text);
            double theBase = base2 - base1;
            double height = 1 / theBase;
            double shadedarea = area / height;
            double x = theBase / (2 / area);
            double x2 = 2 * x;
            double realX1 = base1 + x;
            double realX2 = base2 - x;
            lblX2.Text += realX1 + " or " + realX2;
            lblShaded2.Text += x2.ToString("F2");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            lblDifferent.Text = "Number of different outcomes: ";
            lblError3.Text = "";
            int subjects = Convert.ToInt32(TextBox46.Text);
            int periods = Convert.ToInt32(TextBox47.Text);
            int difference = periods - subjects;
            if (difference != 1 || subjects > 19)
            {
                if (difference != 1)
                    lblError3.Text += "Error. Must have one more period than subject. ";
                if (subjects > 19)
                    lblError3.Text += "Error. # of subjects cannot exceed 19.";
            }
            else
            {
                long factorial = 1;
                for (int index = subjects; index > 0; index--)
                    factorial *= index;
                double possibilities = periods * factorial;
                lblDifferent.Text += possibilities.ToString("N0");
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            lblOutcomes.Text = "Number of possible outcomes: ";
            lblError8.Text = "";
            int digits = Convert.ToInt32(TextBox48.Text);
            int letters = Convert.ToInt32(TextBox49.Text);
            int digits2 = Convert.ToInt32(TextBox50.Text);
            int letters2 = Convert.ToInt32(TextBox51.Text);
            if (digits > digits2 || letters > letters2 || digits > 19 || digits2 > 19 || letters > 19 || letters2 > 19)
            {
                if (digits > digits2 || letters > letters2)
                    lblError8.Text += "Error. Possibilities cannot exceed totals. ";
                if (digits > 19 || digits2 > 19 || letters > 19 || letters2 > 19)
                    lblError8.Text += "Error. Values cannot exceed 19.";
            }
            long factorial1 = 1, factorial2 = 1, factorial3 = 1, factorial4 = 1;
            for (int index = digits; index > 0; index--)
                factorial1 *= index;
            for (int count = letters; count > 0; count--)
                factorial2 *= count;
            for (int index1 = digits2; index1 > 0; index1--)
                factorial3 *= index1;
            for (int count1 = letters2; count1 > 0; count1--)
                factorial4 *= count1;
            double perm1 = factorial3 / factorial1;
            double perm2 = factorial4 / factorial2;
            double outcomes = perm1 * perm2;
            lblOutcomes.Text += outcomes.ToString("N0");
        }
    }
}
