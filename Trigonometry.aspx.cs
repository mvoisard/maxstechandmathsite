using System;
using System.IO;
using static System.Math;

namespace WebApplication6.math
{
    public partial class Trigonometry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = Cache["Trigonometry"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("Trigonometry.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Trigonometry", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("Trigonometry.aspx")));
                }
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            lblAngle1.Text = "Angle C measure: ";
            lblSide.Text = "Side b length: ";
            lblSide1.Text = "Side c length: ";
            double angleA = Convert.ToDouble(TextBox75.Text);
            double angleB = Convert.ToDouble(TextBox76.Text);
            double sidea = Convert.ToDouble(TextBox77.Text);
            double sideb = (sidea * Sin(angleB * (PI / 180))) / Sin(angleA * (PI / 180));
            double angleC = 180 - angleA - angleB;
            double sidec = (sidea * Sin(angleC * (PI / 180)) / Sin(angleA * (PI / 180)));
            lblAngle1.Text += angleC.ToString("F3");
            lblSide.Text += sideb.ToString("F3");
            lblSide1.Text += sidec.ToString("F3");
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            lblSide2.Text = "Side ? length: ";
            lblAngle2.Text = "Angle B measure: ";
            lblAngle3.Text = "Angle C measure: ";
            double sidea = Convert.ToDouble(TextBox78.Text);
            double sideb = Convert.ToDouble(TextBox79.Text);
            double angleA = Convert.ToDouble(TextBox80.Text);
            double angleB = 180 / PI * Asin(sideb * Sin(angleA * (PI / 180)) / sidea);
            double angleC = 180 - angleA - angleB;
            double sidec = (sidea * Sin(angleC * (PI / 180)) / Sin(angleA * (PI / 180)));
            double angle = 180 - angleB;
            lblSide2.Text += sidec.ToString("F3");
            lblAngle2.Text += angleB.ToString("F3");
            lblAngle3.Text += angleC.ToString("F3");
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            lblAngle4.Text = "Angle A measure: ";
            lblAngle5.Text = "Angle B measure: ";
            lblAngle6.Text = "Angle C measure: ";
            double side1 = Convert.ToDouble(TextBox81.Text);
            double side2 = Convert.ToDouble(TextBox82.Text);
            double side3 = Convert.ToDouble(TextBox83.Text);
            double cosine = (Pow(side1, 2) - Pow(side2, 2) + Pow(side3, 2)) / (2 * side1 * side3);
            double angleB = 180 / PI * Acos(cosine);
            double angleA = 180 / PI * Asin((side1 * Sin(angleB * (PI / 180))) / side2);
            double angleC = 180 - angleA - angleB;
            lblAngle4.Text += angleA.ToString("F3");
            lblAngle5.Text += angleB.ToString("F3");
            lblAngle6.Text += angleC.ToString("F3");
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            lblRadians.Text = "Radians: ";
            double degrees = Convert.ToDouble(TextBox84.Text);
            double radians = degrees * (PI / 180);
            double degrees2 = 180 / degrees;
            double degrees3 = degrees / 60;
            double degrees4 = degrees / 45;
            string radian = "";
            if (degrees % 90 != 0 && degrees % 180 != 0)
                radian = degrees3.ToString("F4") + "π / 3 or " + degrees4.ToString("F4") + "π / 4";
            if (degrees % 90 == 0 && degrees % 180 != 0)
            {
                double pi = degrees / 90;
                radian = pi + "π / 2";
            }
            if (degrees % 180 == 0)
            {
                double pi = degrees / 180;
                radian = pi + "C";
            }
            lblRadians.Text += radian + " or π / " + degrees2 + " or " + radians.ToString("F4");
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            lblDegrees.Text = "Degrees: ";
            double numerator = Convert.ToDouble(TextBox85.Text);
            double denominator = Convert.ToDouble(TextBox99.Text);
            double degrees = (numerator * 180) / denominator;
            lblDegrees.Text += degrees.ToString("F3");
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            lblAmplitude.Text = "Amplitude: ";
            lblPeriod.Text = "Period: ";
            lblPhase.Text = "Phase shift: ";
            lblMidline.Text = "Midline / Vertical shift: y = ";
            lblVAsymptotes.Text = "Vertical asymptotes: x = ";
            double amplitude = Abs(Convert.ToDouble(TextBox100.Text));
            double coefficient = Abs(Convert.ToDouble(TextBox102.Text));
            double phase = Convert.ToDouble(TextBox101.Text);
            double vertical = Convert.ToDouble(TextBox103.Text);
            lblAmplitude.Text += amplitude;
            double period1 = 2 / coefficient;
            double period2 = (2 * PI) / coefficient;
            if (DropDownList7.SelectedIndex == 0 || DropDownList7.SelectedIndex == 1)
            {
                lblVAsymptotes.Text = "Vertical asymptotes: None";
                if (period1 == 1)
                    lblPeriod.Text += "π";
                if (period1 > 1)
                    lblPeriod.Text += period1.ToString("F2") + "π or " + period2.ToString("F3");
                if (period1 < 1)
                {
                    if (coefficient % 2 == 0)
                    {
                        double coefficient2 = coefficient / 2;
                        lblPeriod.Text += "π / " + coefficient2 + " or " + period2.ToString("F3");
                    }
                    if (coefficient % 2 == 1)
                        lblPeriod.Text += "2π / " + coefficient + " or " + period2.ToString("F3");
                    if (coefficient % 2 != 0 && coefficient % 2 != 1)
                        lblPeriod.Text += "2π / " + coefficient + " or " + period2.ToString("F3");
                }
            }
            else
            {
                double period3 = PI / coefficient;
                if (coefficient == 1)
                    lblPeriod.Text += "π or " + period3.ToString("F3");
                else
                    lblPeriod.Text += "π / " + coefficient + " or " + period3.ToString("F3");
                if ((phase % 2 != 0 || coefficient % 2 != 0) && (phase % 4 != 0 ||
                    coefficient % 4 != 0) && (phase % 8 != 0 || coefficient % 8 != 0)
                    && (phase % 16 != 0 || coefficient % 16 != 0))
                {
                    if (phase < 0)
                    {
                        if (coefficient != 1)
                        {
                            if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            {
                                double phase2 = phase + .5;
                                lblVAsymptotes.Text += phase2 + "π / " + coefficient + " + kπ / " + coefficient;
                            }
                            else
                                lblVAsymptotes.Text += phase + "π / " + coefficient + " + kπ / " + coefficient;
                        }
                        else
                        {
                            if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            {
                                double phase2 = phase + .5;
                                lblVAsymptotes.Text += phase2 + "π + kπ";
                            }
                            else
                                lblVAsymptotes.Text += phase + "π + kπ";
                        }
                    }
                    if (phase > 0)
                    {
                        double phase3 = -phase;
                        if (coefficient != 1)
                        {
                            if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            {
                                double phase2 = -(phase + .5);
                                lblVAsymptotes.Text += phase2 + "π / " + coefficient + " + kπ / " + coefficient;
                            }
                            else
                                lblVAsymptotes.Text += phase3 + "π / " + coefficient + " + kπ / " + coefficient;
                        }
                        else
                        {
                            if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            {
                                double phase2 = -(phase + .5);
                                lblVAsymptotes.Text += phase2 + "π + kπ";
                            }
                            else
                                lblVAsymptotes.Text += phase3 + "π + kπ";
                        }
                    }
                    if (phase == 0)
                    {
                        lblPhase.Text += "None";
                        if (DropDownList7.SelectedIndex == 3 || DropDownList7.SelectedIndex == 5)
                            if (coefficient == 1)
                                lblVAsymptotes.Text += "0 + kπ";
                            else
                                lblVAsymptotes.Text += "0 + kπ / " + coefficient;
                        if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            if (coefficient == 1)
                                lblVAsymptotes.Text += "-π / 2 + kπ";
                            else
                                lblVAsymptotes.Text += "-π / 2 + kπ / " + coefficient;
                    }
                }
                if (phase % 2 == 0 && coefficient % 2 == 0)
                {
                    if (phase == 0)
                    {
                        lblPhase.Text += "None";
                        if (DropDownList7.SelectedIndex == 3 || DropDownList7.SelectedIndex == 5)
                            if (coefficient == 1)
                                lblVAsymptotes.Text += "0 + kπ";
                            else
                                lblVAsymptotes.Text += "0 + kπ / " + coefficient;
                        if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                            if (coefficient == 1)
                                lblVAsymptotes.Text += "-π / 2 + kπ";
                            else
                                lblVAsymptotes.Text += "-π / 2 + kπ / " + coefficient;
                    }
                    else
                    {
                        if ((phase % 2 == 0 && coefficient % 2 == 0) && (phase % 4 != 0 || coefficient % 4 != 0) && (phase % 8 != 0 || coefficient % 8 != 0) && (phase % 16 != 0 || coefficient % 16 != 0))
                        {
                            if (phase < 0)
                            {
                                double phase2 = phase / 2;
                                double coefficient2 = coefficient / 2;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                            else
                            {
                                double phase2 = -(phase / 2);
                                double coefficient2 = coefficient / 2;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                        }
                        if ((phase % 2 == 0 && coefficient % 2 == 0) && (phase % 4 == 0 && coefficient % 4 == 0) && (phase % 8 != 0 || coefficient % 8 != 0) && (phase % 16 != 0 || coefficient % 16 != 0))
                        {
                            if (phase < 0)
                            {
                                double phase2 = phase / 4;
                                double coefficient2 = coefficient / 4;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                            else
                            {
                                double phase2 = -(phase / 4);
                                double coefficient2 = coefficient / 4;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                        }
                        if ((phase % 2 == 0 && coefficient % 2 == 0) && (phase % 4 == 0 && coefficient % 4 == 0) && (phase % 8 == 0 && coefficient % 8 == 0) && (phase % 16 != 0 || coefficient % 16 != 0))
                        {
                            if (phase < 0)
                            {
                                double phase2 = phase / 8;
                                double coefficient2 = coefficient / 8;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                            else
                            {
                                double phase2 = -(phase / 8);
                                double coefficient2 = coefficient / 8;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                        }
                        if ((phase % 2 == 0 && coefficient % 2 == 0) && (phase % 4 == 0 && coefficient % 4 == 0) && (phase % 8 == 0 && coefficient % 8 == 0) && (phase % 16 == 0 && coefficient % 16 == 0))
                        {
                            if (phase < 0)
                            {
                                double phase2 = phase / 16;
                                double coefficient2 = coefficient / 16;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 + .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                            else
                            {
                                double phase2 = -(phase / 16);
                                double coefficient2 = coefficient / 16;
                                if (coefficient2 != 1)
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π / " + coefficient2 + " + kπ / " + coefficient;
                                }
                                else
                                {
                                    if (DropDownList7.SelectedIndex == 2 || DropDownList7.SelectedIndex == 4)
                                    {
                                        double phase3 = phase2 - .5;
                                        lblVAsymptotes.Text += phase3 + "π + kπ / " + coefficient;
                                    }
                                    else
                                        lblVAsymptotes.Text += phase2 + "π + kπ / " + coefficient;
                                }
                            }
                        }
                    }
                }
            }
            if (phase > 0)
            {
                double phase2 = phase / coefficient;
                double phase3 = (phase * PI) / coefficient;
                lblPhase.Text += phase2.ToString("F2") + "π (or " + phase3.ToString("F3") + ") to the left";
            }
            if (phase < 0)
            {
                double phase2 = Abs(phase / coefficient);
                double phase3 = Abs((phase * PI) / coefficient);
                lblPhase.Text += phase2.ToString("F2") + "π (or " + phase3.ToString("F3") + ") to the right";
            }
            lblMidline.Text += vertical;
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            lblSinNormal.Text = "Sine: ";
            lblCosNormal.Text = "Cosine: ";
            lblTanNormal.Text = "Tangent: ";
            lblCosecant.Text = "Cosecant: ";
            lblSecant.Text = "Secant: ";
            lblCotangent.Text = "Cotangent: ";
            double radians = Convert.ToDouble(TextBox104.Text);
            double radians2 = radians * (PI / 180);
            double sinenormal = Sin(radians2);
            double cosinenormal = Cos(radians2);
            double tangentnormal = Tan(radians2);
            double cosecant = 1 / sinenormal;
            double secant = 1 / cosinenormal;
            double cotangent = 1 / tangentnormal;
            double sine = Sin(radians);
            double cosine = Cos(radians);
            double tangent = Tan(radians);
            double cosecant1 = 1 / sine;
            double secant1 = 1 / cosine;
            double cotangent1 = 1 / tangent;
            if (DropDownList8.SelectedIndex == 0)
            {
                if (cosinenormal > -0.0001 && cosinenormal < 0.0001)
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sinenormal.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosinenormal.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = undefined";
                    lblCosecant.Text += "Csc(" + radians + ") = " + cosecant.ToString("F3");
                    lblSecant.Text += "Sec(" + radians + ") = undefined";
                    lblCotangent.Text += "Cot(" + radians + ") = " + cotangent.ToString("F3");
                }
                if (sinenormal > -0.0001 && sinenormal < 0.0001)
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sinenormal.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosinenormal.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = " + tangentnormal.ToString("F3");
                    lblCosecant.Text += "Csc(" + radians + ") = undefined";
                    lblSecant.Text += "Sec(" + radians + ") = " + secant.ToString("F3");
                    lblCotangent.Text += "Cot(" + radians + ") = undefined";
                }
                if (!(cosinenormal > -0.0001 && cosinenormal < 0.0001) && !(sinenormal > -0.0001 && sinenormal < 0.0001))
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sinenormal.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosinenormal.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = " + tangentnormal.ToString("F3");
                    lblCosecant.Text += "Csc(" + radians + ") = " + cosecant.ToString("F3");
                    lblSecant.Text += "Sec(" + radians + ") = " + secant.ToString("F3");
                    lblCotangent.Text += "Cot(" + radians + ") = " + cotangent.ToString("F3");
                }
            }
            else
            {
                if (cosine < 0.01 && cosine > -0.01)
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sine.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosine.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = undefined";
                    lblCosecant.Text += "Csc(" + radians + ") = " + cosecant1.ToString("F3");
                    lblSecant.Text += "Sec(" + radians + ") = undefined";
                    lblCotangent.Text += "Cot(" + radians + ") = " + cotangent1.ToString("F3");
                }
                if (sine < 0.01 && sine > -0.01)
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sine.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosine.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = " + tangent.ToString("F3");
                    lblCosecant.Text += "Csc(" + radians + ") = undefined";
                    lblSecant.Text += "Sec(" + radians + ") = " + secant1.ToString("F3");
                    lblCotangent.Text += "Cot(" + radians + ") = undefined";
                }
                if (!(cosine > -0.01 && cosine < 0.01) && !(sine > -0.01 && sine < 0.01))
                {
                    lblSinNormal.Text += "Sin(" + radians + ") = " + sine.ToString("F3");
                    lblCosNormal.Text += "Cos(" + radians + ") = " + cosine.ToString("F3");
                    lblTanNormal.Text += "Tan(" + radians + ") = " + tangent.ToString("F3");
                    lblCosecant.Text += "Csc(" + radians + ") = " + cosecant1.ToString("F3");
                    lblSecant.Text += "Sec(" + radians + ") = " + secant1.ToString("F3");
                    lblCotangent.Text += "Cot(" + radians + ") = " + cotangent1.ToString("F3");
                }
            }
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            double angle1 = Convert.ToDouble(TextBox105.Text);
            double meters = Convert.ToDouble(TextBox106.Text);
            double angle2 = Convert.ToDouble(TextBox107.Text);
            if (angle2 < angle1)
                lblError2.Visible = true;
            else
            {
                double tangent1 = Tan(angle1 * (PI / 180));
                double tangent2 = Tan(angle2 * (PI / 180));
                double ang1TimesDistance = tangent1 * meters;
                double shore = ang1TimesDistance / (tangent2 - tangent1);
                double peak = shore * tangent2;
                lblDistance2.Text += shore.ToString("F2") + " meters";
                lblPeak.Text += peak.ToString("F2") + " meters";
            }
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            double rpm = Convert.ToDouble(TextBox108.Text);
            double diameter = Convert.ToDouble(TextBox109.Text);
            double multiply = (rpm * 2) / 60;
            double radians = multiply * PI;
            lblAngular.Text += radians.ToString("F2") + " (" + multiply.ToString("F2") + "π) rad/sec";
            double linear = (rpm * diameter) / 60;
            double linear2 = linear * PI;
            double mph = (linear2 * 3600) / 160934;
            lblLinear.Text += linear2.ToString("F2") + " (" + linear.ToString("F2") + "π) cm/sec or " + mph.ToString("F2") + " mph";
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            double mph = Convert.ToDouble(TextBox110.Text);
            double diameter = Convert.ToDouble(TextBox111.Text);
            double cmsec = (mph * 160934) / 60;
            double rpm = cmsec / (diameter * PI);
            double multiply = (rpm * 2) / 60;
            double radians = multiply * PI;
            lblAngular2.Text += radians.ToString("F2") + " (" + multiply.ToString("F2") + "π) rad/sec";
            lblRPM.Text += rpm.ToString("F2") + " rpm";
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            lblSinCsc.Text = "Sin-1 / Sec-1: ";
            lblCosSec.Text = "Cos-1 / Csc-1: ";
            lblTanCot.Text = "Tan-1 / Cot-1: ";
            double value = Convert.ToDouble(TextBox112.Text);
            if (value < -1 || value > 1)
                lblError.Text = "Error. Value must be between -1 and 1.";
            else
            {
                double sine = (180 / PI) * Asin(value);
                double cosine = (180 / PI) * Acos(value);
                double tangent = (180 / PI) * Atan(value);
                double cotangent = 90 - tangent;
                double sine2 = 180 - sine;
                double cosine2 = 360 - cosine;
                double cosine3 = -(cosine);
                double tangent2 = 180 + tangent;
                double tangent3 = tangent - 180;
                double cotangent2 = 180 + cotangent;
                double cotangent3 = cotangent - 180;
                lblSinCsc.Text += sine.ToString("F2") + " or " + sine2.ToString("F2") + " degrees";
                lblCosSec.Text += cosine.ToString("F2") + " or (" + cosine2.ToString("F2") + "/" + cosine3.ToString("F2") + ") degrees";
                lblTanCot.Text += tangent.ToString("F2") + " or (" + tangent2.ToString("F2") + "/" + tangent3.ToString("F2") + ") degrees and Cot-1(" + value + "): " + cotangent.ToString("F2") + " or (" + cotangent2.ToString("F2") + "/" + cotangent3.ToString("F2") + ") degrees";
            }
        }

        protected void Button34_Click1(object sender, EventArgs e)
        {
            lblS1.Text = "Side a proportional length: ";
            lblS2.Text = "Side b proportional length: ";
            lblS3.Text = "Side c proportional length: ";
            double angle1 = Convert.ToDouble(TextBox113.Text);
            double angle2 = Convert.ToDouble(TextBox114.Text);
            double angle3 = Convert.ToDouble(TextBox115.Text);
            if ((angle1 + angle2 + angle3) > 180.05 || (angle1 + angle2 + angle3) < 179.95)
                lblError4.Text = "Error. Angles must add to equal 180.";
            double degrees1 = angle1 * (PI / 180);
            double degrees2 = angle2 * (PI / 180);
            double degrees3 = angle3 * (PI / 180);
            double side1 = Sin(degrees1);
            double side2 = Sin(degrees2);
            double side3 = Sin(degrees3);
            lblS1.Text += side1.ToString("F3");
            lblS2.Text += side2.ToString("F3");
            lblS3.Text += side3.ToString("F3");
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            lblDouble.Text = "Double-angle formula: ";
            double number = Convert.ToDouble(TextBox124.Text);
            if (DropDownList9.SelectedIndex == 0)
            {
                double result = Sin((2 * number) * (PI / 180));
                lblDouble.Text += "2sin" + number + " * cos" + number + " or " + result.ToString("F3");
            }
            if (DropDownList9.SelectedIndex == 1)
            {
                double result = Cos((2 * number) * (PI / 180));
                lblDouble.Text += "cos(" + number + ")^2 - sin(" + number + ")^2 or " + result.ToString("F3");
            }
            if (DropDownList9.SelectedIndex == 2)
            {
                double result = Tan((2 * number) * (PI / 180));
                lblDouble.Text += "[2tan" + number + "] / [1 - tan(" + number + ")^2] or " + result.ToString("F3");
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            lblHalf.Text = "Half-angle formula: ";
            double value = Convert.ToDouble(TextBox125.Text);
            if (DropDownList10.SelectedIndex == 0)
            {
                double result = Sin((value / 2) * (PI / 180));
                lblHalf.Text += "+-√(1 - cos" + value + " / 2), or " + result.ToString("F3");
            }
            if (DropDownList10.SelectedIndex == 1)
            {
                double result = Cos((value / 2) * (PI / 180));
                lblHalf.Text += "+-√(1 + cos" + value + " / 2), or " + result.ToString("F3");
            }
            if (DropDownList10.SelectedIndex == 2)
            {
                double result = Tan((value / 2) * (PI / 180));
                lblHalf.Text += "(1 - cos" + value + ") / sin" + value + ", or " + result.ToString("F3");
            }
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            lblSumDif.Text = "Sum and Difference formula: ";
            double number = Convert.ToDouble(TextBox126.Text);
            double number2 = Convert.ToDouble(TextBox127.Text);
            if (DropDownList12.SelectedIndex == 0)
            {
                if (DropDownList11.SelectedIndex == 0)
                {
                    double result = Cos((number + number2) * (PI / 180));
                    lblSumDif.Text += "cos" + number + "cos" + number2 + " - sin" + number + "sin" + number2 + ", or " + result.ToString("F3");
                }
                if (DropDownList11.SelectedIndex == 1)
                {
                    double result = Sin((number + number2) * (PI / 180));
                    lblSumDif.Text += "sin" + number + "cos" + number2 + " + cos" + number + "sin" + number2 + ", or " + result.ToString("F3");
                }
                if (DropDownList11.SelectedIndex == 2)
                {
                    double result = Tan((number + number2) * (PI / 180));
                    lblSumDif.Text += "(tan" + number + " + tan" + number2 + ") / (1 - tan" + number + "tan" + number2 + "), or " + result.ToString("F3");
                }
            }
            if (DropDownList12.SelectedIndex == 1)
            {
                if (DropDownList11.SelectedIndex == 0)
                {
                    double result = Cos((number - number2) * (PI / 180));
                    lblSumDif.Text += "cos" + number + "cos" + number2 + " + sin" + number + "sin" + number2 + ", or " + result.ToString("F3");
                }
                if (DropDownList11.SelectedIndex == 1)
                {
                    double result = Sin((number - number2) * (PI / 180));
                    lblSumDif.Text += "sin" + number + "cos" + number2 + " - cos" + number + "sin" + number2 + ", or " + result.ToString("F3");
                }
                if (DropDownList11.SelectedIndex == 2)
                {
                    double result = Tan((number - number2) * (PI / 180));
                    lblSumDif.Text += "(tan" + number + " - tan" + number2 + ") / (1 + tan" + number + "tan" + number2 + "), or " + result.ToString("F3");
                }
            }
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            lblSumProd.Text = "Product-to-Sum formula: ";
            double value = Convert.ToDouble(TextBox130.Text);
            double value2 = Convert.ToDouble(TextBox131.Text);
            if (DropDownList15.SelectedIndex == 0 && DropDownList16.SelectedIndex == 0)
            {
                if (DropDownList17.SelectedIndex == 0)
                {
                    if (value2 < 0)
                    {
                        double result = Cos(value * (PI / 180)) + Cos(value2 * (PI / 180));
                        lblSumProd.Text += "2cos[(" + value + " + " + value2 + ") / 2] * cos[(" + value + " - (" + value2 + ")) / 2], or " + result.ToString("F3");
                    }
                    else
                    {
                        double result = Sin(value * (PI / 180)) + Sin(value2 * (PI / 180));
                        lblSumProd.Text += "2sin[(" + value + " + " + value2 + ") / 2] * cos[(" + value + " - " + value2 + ") / 2], or " + result.ToString("F3");
                    }
                }
                if (DropDownList17.SelectedIndex == 1)
                {
                    if (value2 < 0)
                    {
                        double result = Cos(value * (PI / 180)) + Cos(value2 * (PI / 180));
                        lblSumProd.Text += "2cos[(" + value + " + " + value2 + ") / 2] * cos[(" + value + " - (" + value2 + ")) / 2], or " + result.ToString("F3");
                    }
                    else
                    {
                        double result = Sin(value * (PI / 180)) - Sin(value2 * (PI / 180));
                        lblSumProd.Text += "2sin[(" + value + " - " + value2 + ") / 2] * cos[(" + value + " + " + value2 + ") / 2], or " + result.ToString("F3");
                    }
                }
            }
            if (DropDownList15.SelectedIndex == 1 && DropDownList16.SelectedIndex == 1)
            {
                if (DropDownList17.SelectedIndex == 0)
                {
                    if (value2 < 0)
                    {
                        double result = Cos(value * (PI / 180)) + Cos(value2 * (PI / 180));
                        lblSumProd.Text += "2cos[(" + value + " + " + value2 + ") / 2] * cos[(" + value + " - (" + value2 + ")) / 2], or " + result.ToString("F3");
                    }
                    else
                    {
                        double result = Cos(value * (PI / 180)) + Cos(value2 * (PI / 180));
                        lblSumProd.Text += "2cos[(" + value + " + " + value2 + ") / 2] * cos[(" + value + " - " + value2 + ") / 2], or " + result.ToString("F3");
                    }
                }
                if (DropDownList17.SelectedIndex == 1)
                {
                    if (value2 < 0)
                    {
                        double result = Cos(value * (PI / 180)) - Cos(value2 * (PI / 180));
                        lblSumProd.Text += "-2sin[(" + value + " + " + value2 + ") / 2] * sin[(" + value + " - (" + value2 + ")) / 2], or " + result.ToString("F3");
                    }
                    else
                    {
                        double result = Cos(value * (PI / 180)) - Cos(value2 * (PI / 180));
                        lblSumProd.Text += "-2sin[(" + value + " + " + value2 + ") / 2] * sin[(" + value + " - " + value2 + ") / 2], or " + result.ToString("F3");
                    }
                }
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            lblProdSum.Text = "Product-to-Sum formula: ";
            double value = Convert.ToDouble(TextBox128.Text);
            double value2 = Convert.ToDouble(TextBox129.Text);
            if (DropDownList13.SelectedIndex == 0 && DropDownList14.SelectedIndex == 0)
            {
                if (value2 < 0)
                {
                    double result = Sin(value * (PI / 180)) * Sin(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[cos(" + value + " - (" + value2 + ")) - cos(" + value + " + " + value2 + ")], or " + result.ToString("F3");
                }
                else
                {
                    double result = Sin(value * (PI / 180)) * Sin(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[cos(" + value + " - " + value2 + ") - cos(" + value + " + " + value2 + ")], or " + result.ToString("F3");
                }
            }
            if (DropDownList13.SelectedIndex == 1 && DropDownList14.SelectedIndex == 1)
            {
                if (value2 < 0)
                {
                    double result = Cos(value * (PI / 180)) * Cos(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[cos(" + value + " - (" + value2 + ")) + cos(" + value + " + " + value2 + ")], or " + result.ToString("F3");
                }
                else
                {
                    double result = Cos(value * (PI / 180)) * Cos(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[cos(" + value + " - " + value2 + ") + cos(" + value + " + " + value2 + ")], or " + result.ToString("F3");
                }
            }
            if (DropDownList13.SelectedIndex == 0 && DropDownList14.SelectedIndex == 1)
            {
                if (value2 < 0)
                {
                    double result = Sin(value * (PI / 180)) * Cos(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[sin(" + value + " + " + value2 + ") + sin(" + value + " - (" + value2 + "))], or " + result.ToString("F3");
                }
                else
                {
                    double result = Sin(value * (PI / 180)) * Cos(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[sin(" + value + " + " + value2 + ") + sin(" + value + " - " + value2 + ")], or " + result.ToString("F3");
                }
            }
            if (DropDownList13.SelectedIndex == 1 && DropDownList14.SelectedIndex == 0)
            {
                if (value2 < 0)
                {
                    double result = Sin(value * (PI / 180)) * Cos(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[sin(" + value + " + " + value2 + ") + sin(" + value + " - (" + value2 + "))], or " + result.ToString("F3");
                }
                else
                {
                    double result = Cos(value * (PI / 180)) * Sin(value2 * (PI / 180));
                    lblProdSum.Text += "1/2[sin(" + value + " + " + value2 + ") - sin(" + value + " - " + value2 + ")], or " + result.ToString("F3");
                }
            }
        }
    }
}