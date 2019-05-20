using System;
using System.IO;
using static System.Math;

namespace WebApplication6.math
{
    public partial class Calculus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = Cache["Calculus"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("Calculus.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Calculus", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("Calculus.aspx")));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblDerivative.Text = "First derivative: ";
            lblDerivative2.Text = "Second derivative: ";
            lblDerivative3.Text = "Third derivative: ";
            double coefficient = Convert.ToDouble(TextBox1.Text);
            double exponent = Convert.ToDouble(TextBox2.Text);
            double coefficient20 = Convert.ToDouble(TextBox12.Text);
            double exponent20 = Convert.ToDouble(TextBox13.Text);
            double x = Convert.ToDouble(TextBox10.Text);
            double coefficient2, coefficient3, coefficient4, coefficient21, coefficient22,
                coefficient23, exponent2, exponent3, exponent4, exponent21, exponent22, exponent23;
            if (coefficient == 0)
                exponent = 0;
            if (coefficient20 == 0)
                exponent20 = 0;
            if (exponent == 1 || exponent20 == 1)
                lblError.Text = "Error. Exponents cannot be 1.";
            else
            {
                if (exponent == 0 || exponent20 == 0)
                {
                    if (exponent == 0 && exponent20 != 0)
                    {
                        coefficient21 = coefficient20 * exponent20;
                        exponent21 = exponent20 - 1;
                        lblDerivative.Text += coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x;
                        if (exponent20 == 2 || exponent20 == 3 || exponent20 == 4)
                        {
                            if (exponent20 == 2)
                            {
                                lblDerivative2.Text += coefficient21.ToString("F5");
                                lblDerivative3.Text += "0";
                            }
                            if (exponent20 == 3)
                            {
                                coefficient22 = coefficient21 * exponent21;
                                exponent22 = exponent21 - 1;
                                lblDerivative2.Text += coefficient22.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient22.ToString("F5");
                            }
                            if (exponent20 == 4)
                            {
                                coefficient22 = coefficient21 * exponent21;
                                exponent22 = exponent21 - 1;
                                lblDerivative2.Text += coefficient22.ToString("F5") + "x^2";
                                coefficient23 = coefficient22 * exponent22;
                                lblDerivative3.Text += coefficient23.ToString("F5") + "x";
                            }
                        }
                        else
                        {
                            coefficient22 = coefficient21 * exponent21;
                            exponent22 = exponent21 - 1;
                            lblDerivative2.Text += coefficient22.ToString("F5") + "x^" + Convert.ToString(exponent22);
                            coefficient23 = coefficient22 * exponent22;
                            exponent23 = exponent22 - 1;
                            lblDerivative3.Text += coefficient23.ToString("F5") + "x^" + Convert.ToString(exponent23);
                        }
                    }
                    if (exponent != 0 && exponent20 == 0)
                    {
                        coefficient2 = coefficient * exponent;
                        exponent2 = exponent - 1;
                        lblDerivative.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + x;
                        if (exponent == 2 || exponent == 3 || exponent == 4)
                        {
                            if (exponent == 2)
                            {
                                lblDerivative2.Text += coefficient2.ToString("F5");
                                lblDerivative3.Text += "0";
                            }
                            if (exponent == 3)
                            {
                                coefficient3 = coefficient2 * exponent2;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient3.ToString("F5");
                            }
                            if (exponent == 4)
                            {
                                coefficient4 = coefficient2 * exponent2;
                                exponent3 = exponent2 - 1;
                                lblDerivative2.Text += coefficient4.ToString("F5") + "x^2";
                                coefficient23 = coefficient4 * exponent3;
                                lblDerivative3.Text += coefficient23.ToString("F5") + "x";
                            }
                        }
                        else
                        {
                            coefficient3 = coefficient2 * exponent2;
                            exponent3 = exponent2 - 1;
                            lblDerivative2.Text += coefficient3.ToString("F5") + "x^" + Convert.ToString(exponent3);
                            coefficient4 = coefficient3 * exponent3;
                            exponent4 = exponent3 - 1;
                            lblDerivative3.Text += coefficient4.ToString("F5") + "x^" + Convert.ToString(exponent4);
                        }
                    }
                    if (exponent == 0 && exponent20 == 0)
                    {
                        lblDerivative.Text += x;
                        lblDerivative2.Text += "0";
                        lblDerivative3.Text += "0";
                    }
                }
                else
                {
                    coefficient2 = coefficient * exponent;
                    exponent2 = exponent - 1;
                    coefficient21 = coefficient20 * exponent20;
                    exponent21 = exponent20 - 1;
                    coefficient3 = coefficient2 * exponent2;
                    exponent3 = exponent2 - 1;
                    coefficient22 = coefficient21 * exponent21;
                    exponent22 = exponent21 - 1;
                    coefficient4 = coefficient3 * exponent3;
                    exponent4 = exponent3 - 1;
                    coefficient23 = coefficient22 * exponent22;
                    exponent23 = exponent22 - 1;
                    if (exponent == 2 || exponent == 3 || exponent == 4 || exponent20 == 2 || exponent20 == 3 || exponent20 == 4)
                    {
                        if (exponent20 != 2 && exponent20 != 3 && exponent20 != 4)
                        {
                            if (exponent == 2)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x + " + coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x;
                                lblDerivative2.Text += coefficient2.ToString("F5") + " + " + coefficient22.ToString("F5") + "x^" + Convert.ToString(exponent22);
                                lblDerivative3.Text += coefficient23.ToString("F5") + "x^" + Convert.ToString(exponent23);
                            }
                            if (exponent == 3)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^2 + " + coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x + " + coefficient22.ToString("F5") + "x^" + Convert.ToString(exponent22);
                                lblDerivative3.Text += coefficient3.ToString("F5") + " + " + coefficient23.ToString("F5") + "x^" + Convert.ToString(exponent23);
                            }
                            if (exponent == 4)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^3 + " + coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^2 + " + coefficient22.ToString("F5") + "x^" + Convert.ToString(exponent22);
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x + " + coefficient23.ToString("F5") + "x^" + Convert.ToString(exponent23);
                            }
                        }
                        if (exponent != 2 && exponent != 3 && exponent != 4)
                        {
                            if (exponent20 == 2)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^" + Convert.ToString(exponent3) + " + " + coefficient21.ToString("F5");
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x^" + Convert.ToString(exponent4);
                            }
                            if (exponent20 == 3)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^2 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^" + Convert.ToString(exponent3) + " + " + coefficient22.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x^" + Convert.ToString(exponent4) + coefficient22.ToString("F5");
                            }
                            if (exponent20 == 4)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^3 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^" + Convert.ToString(exponent3) + " + " + coefficient22.ToString("F5") + "x^2";
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x^" + Convert.ToString(exponent4) + coefficient23.ToString("F5") + "x";
                            }
                        }
                        if ((exponent == 2 || exponent == 3 || exponent == 4) && (exponent20 == 2 || exponent20 == 3 || exponent20 == 4))
                        {
                            if (exponent == 2 && exponent20 == 2)
                            {
                                double coefficient10 = coefficient2 + coefficient21;
                                lblDerivative.Text += coefficient2.ToString("F5") + "x + " + coefficient21.ToString("F5") + "x + " + x;
                                lblDerivative2.Text += coefficient2.ToString("F5") + " + " + coefficient21.ToString("F5") + " (or " + coefficient10 + ")";
                                lblDerivative3.Text += "0";
                            }
                            if (exponent == 2 && exponent20 == 3)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x + " + coefficient21.ToString("F5") + "x^2 + " + x;
                                lblDerivative2.Text += coefficient2.ToString("F5") + " + " + coefficient22.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient22.ToString("F5");
                            }
                            if (exponent == 2 && exponent20 == 4)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x + " + coefficient21.ToString("F5") + "x^3 + " + x;
                                lblDerivative2.Text += coefficient2.ToString("F5") + " + " + coefficient22.ToString("F5") + "x^2";
                                lblDerivative3.Text += coefficient23.ToString("F5");
                            }
                            if (exponent == 3 && exponent20 == 2)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^2 + " + coefficient21.ToString("F5") + "x + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x + " + coefficient21.ToString("F5");
                                lblDerivative3.Text += coefficient3.ToString("F5");
                            }
                            if (exponent == 3 && exponent20 == 3)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^2 + " + coefficient21.ToString("F5") + "x^2 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x + " + coefficient22.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient3.ToString("F5") + " + " + coefficient22.ToString("F5");
                            }
                            if (exponent == 3 && exponent20 == 4)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^2 + " + coefficient21.ToString("F5") + "x^3 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x + " + coefficient22.ToString("F5") + "x^2";
                                lblDerivative3.Text += coefficient3.ToString("F5") + " + " + coefficient23.ToString("F5") + "x";
                            }
                            if (exponent == 4 && exponent20 == 2)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^3 + " + coefficient21.ToString("F5") + "x + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^2 + " + coefficient21.ToString("F5");
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x";
                            }
                            if (exponent == 4 && exponent20 == 3)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^3 + " + coefficient21.ToString("F5") + "x^2 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^2 + " + coefficient22.ToString("F5") + "x";
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x + " + coefficient22.ToString("F5");
                            }
                            if (exponent == 4 && exponent20 == 4)
                            {
                                lblDerivative.Text += coefficient2.ToString("F5") + "x^3 + " + coefficient21.ToString("F5") + "x^3 + " + x;
                                lblDerivative2.Text += coefficient3.ToString("F5") + "x^2 + " + coefficient22.ToString("F5") + "x^2";
                                lblDerivative3.Text += coefficient4.ToString("F5") + "x + " + coefficient23.ToString("F5") + "x";
                            }
                        }
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblIntegral.Text = "First integral: ";
            lblIntegral2.Text = "Second integral: ";
            lblIntegral3.Text = "Third integral: ";
            double coefficient = Convert.ToDouble(TextBox3.Text);
            double exponent = Convert.ToDouble(TextBox4.Text);
            double coefficient20 = Convert.ToDouble(TextBox14.Text);
            double exponent20 = Convert.ToDouble(TextBox15.Text);
            double x = Convert.ToDouble(TextBox11.Text);
            double constant = Convert.ToDouble(TextBox16.Text);
            double exponent2, coefficient2, exponent21, coefficient21, x2, exponent3,
                coefficient3, exponent22, coefficient22, x3, constant2, exponent4,
                coefficient4, exponent23, coefficient23, x4, constant3;
            if (coefficient == 0)
                exponent = 0;
            if (coefficient20 == 0)
                exponent20 = 0;
            if (exponent == 1 || exponent20 == 1)
                lblError2.Text = "Error. Exponents cannot be 1.";
            else
            {
                if (exponent == 0 || exponent20 == 0)
                {
                    if (exponent == 0 && exponent20 != 0)
                    {
                        if (exponent20 == -1 || exponent20 == -2 || exponent20 == -3)
                        {
                            if (exponent20 == -1)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    lblIntegral.Text += Abs(coefficient20) + "ln(|x|) + C";
                                    lblIntegral2.Text += Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + C";
                                    lblIntegral3.Text += "None";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    x2 = x / 2;
                                    lblIntegral.Text += Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    lblIntegral.Text += Abs(coefficient20) + "ln(|x|) + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                            if (exponent20 == -2)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    coefficient21 = coefficient20 / -1;
                                    lblIntegral.Text += coefficient21 + "x^-1 + C";
                                    lblIntegral2.Text += Abs(coefficient21) + "ln(|x|) + C";
                                    lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + C";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    coefficient21 = coefficient20 / -1;
                                    x2 = x / 2;
                                    lblIntegral.Text += coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    coefficient21 = coefficient20 / -1;
                                    lblIntegral.Text += coefficient21 + "x^-1 + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += Abs(coefficient21) + "ln(|x|) + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    coefficient21 = coefficient20 / -1;
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                            if (exponent20 == -3)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    coefficient21 = coefficient20 / -2;
                                    coefficient22 = coefficient21 / -1;
                                    lblIntegral.Text += coefficient21 + "x^-2 + C";
                                    lblIntegral2.Text += coefficient22 + "x^-1 + C";
                                    lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + C";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    coefficient21 = coefficient20 / -2;
                                    coefficient22 = coefficient21 / -1;
                                    x2 = x / 2;
                                    lblIntegral.Text += coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    coefficient21 = coefficient20 / -2;
                                    coefficient22 = coefficient21 / -1;
                                    lblIntegral.Text += coefficient21 + "x^-2 + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += coefficient22 + "x^-1 + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    coefficient21 = coefficient20 / -2;
                                    coefficient22 = coefficient21 / -1;
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                        }
                        else
                        {
                            exponent21 = exponent20 + 1;
                            coefficient21 = coefficient20 / exponent21;
                            x2 = x / 2;
                            if (x == 0 && constant == 0)
                            {
                                lblIntegral.Text += coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + C";
                                exponent22 = exponent21 + 1;
                                coefficient22 = coefficient21 / exponent22;
                                lblIntegral2.Text += coefficient22.ToString("F5") + "x^" + exponent22 + " + C";
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral3.Text += coefficient23.ToString("F5") + "x^" + exponent23 + " + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                lblIntegral.Text += coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x2.ToString("F5") + "x^2 + C";
                                exponent22 = exponent21 + 1;
                                coefficient22 = coefficient21 / exponent22;
                                x3 = x2 / 3;
                                lblIntegral2.Text += coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + C";
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                x4 = x3 / 4;
                                lblIntegral3.Text += coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                lblIntegral.Text += coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + constant + "x + C";
                                exponent22 = exponent21 + 1;
                                coefficient22 = coefficient21 / exponent22;
                                constant2 = constant / 2;
                                lblIntegral2.Text += coefficient22.ToString("F5") + "x^" + exponent22 + " + " + constant2.ToString("F5") + "x^2 + C";
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                constant3 = constant2 / 3;
                                lblIntegral3.Text += coefficient23.ToString("F5") + "x^" + exponent23 + " + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                lblIntegral.Text += coefficient21.ToString("F5") + "x^" + Convert.ToString(exponent21) + " + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                exponent22 = exponent21 + 1;
                                coefficient22 = coefficient21 / exponent22;
                                x3 = x2 / 3;
                                constant2 = constant / 2;
                                lblIntegral2.Text += coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                x4 = x3 / 4;
                                constant3 = constant2 / 3;
                                lblIntegral3.Text += coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                    }
                    if (exponent != 0 && exponent20 == 0)
                    {
                        if (exponent == -1 || exponent == -2 || exponent == -3)
                        {
                            if (exponent == -1)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    lblIntegral.Text += Abs(coefficient) + "ln(|x|) + C";
                                    lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + C";
                                    lblIntegral3.Text += "None";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    x2 = x / 2;
                                    lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                            if (exponent == -2)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    coefficient2 = coefficient / -1;
                                    lblIntegral.Text += coefficient2 + "x^-1 + C";
                                    lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + C";
                                    lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + C";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    coefficient2 = coefficient / -1;
                                    x2 = x / 2;
                                    lblIntegral.Text += coefficient2 + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    coefficient2 = coefficient / -1;
                                    lblIntegral.Text += coefficient2 + "x^-1 + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    coefficient2 = coefficient / -1;
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += coefficient2 + "x^-1 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                            if (exponent == -3)
                            {
                                if (x == 0 && constant == 0)
                                {
                                    coefficient2 = coefficient / -2;
                                    coefficient3 = coefficient2 / -1;
                                    lblIntegral.Text += coefficient2 + "x^-2 + C";
                                    lblIntegral2.Text += coefficient3 + "x^-1 + C";
                                    lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + C";
                                }
                                if (x != 0 && constant == 0)
                                {
                                    coefficient2 = coefficient / -2;
                                    coefficient3 = coefficient2 / -1;
                                    x2 = x / 2;
                                    lblIntegral.Text += coefficient2 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                    x3 = x2 / 3;
                                    lblIntegral2.Text += coefficient3 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                    x4 = x3 / 4;
                                    lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + x4 + "x^4 + C";
                                }
                                if (x == 0 && constant != 0)
                                {
                                    coefficient2 = coefficient / -2;
                                    coefficient3 = coefficient2 / -1;
                                    lblIntegral.Text += coefficient2 + "x^-2 + " + constant + "x + C";
                                    constant2 = constant / 2;
                                    lblIntegral2.Text += coefficient3 + "x^-1 + " + constant2 + "x^2 + C";
                                    constant3 = constant2 / 3;
                                    lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + constant3 + "x^3 + C";
                                }
                                if (x != 0 && constant != 0)
                                {
                                    coefficient2 = coefficient / -2;
                                    coefficient3 = coefficient2 / -1;
                                    x2 = x / 2;
                                    x3 = x2 / 3;
                                    x4 = x3 / 4;
                                    constant2 = constant / 2;
                                    constant3 = constant2 / 3;
                                    lblIntegral.Text += coefficient2 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                    lblIntegral2.Text += coefficient3 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                                    lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                                }
                            }
                        }
                        else
                        {
                            exponent2 = exponent + 1;
                            coefficient2 = coefficient / exponent2;
                            x2 = x / 2;
                            if (x == 0 && constant == 0)
                            {
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + C";
                                exponent3 = exponent2 + 1;
                                coefficient3 = coefficient2 / exponent3;
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + C";
                                exponent4 = exponent3 + 1;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + x2.ToString("F5") + "x^2 + C";
                                exponent3 = exponent2 + 1;
                                coefficient3 = coefficient2 / exponent3;
                                x3 = x2 / 3;
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + x3.ToString("F5") + "x^3 + C";
                                exponent4 = exponent3 + 1;
                                coefficient4 = coefficient3 / exponent4;
                                x4 = x3 / 4;
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + constant + "x + C";
                                exponent3 = exponent2 + 1;
                                coefficient3 = coefficient2 / exponent3;
                                constant2 = constant / 2;
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + constant2.ToString("F5") + "x^2 + C";
                                exponent4 = exponent3 + 1;
                                coefficient4 = coefficient3 / exponent4;
                                constant3 = constant2 / 3;
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                exponent3 = exponent2 + 1;
                                coefficient3 = coefficient2 / exponent3;
                                x3 = x2 / 3;
                                constant2 = constant / 2;
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                exponent4 = exponent3 + 1;
                                coefficient4 = coefficient3 / exponent4;
                                x4 = x3 / 4;
                                constant3 = constant2 / 3;
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                    }
                    if (exponent == 0 && exponent20 == 0)
                    {
                        if (x == 0 && constant == 0)
                        {
                            lblIntegral.Text += "0";
                            lblIntegral2.Text += "0";
                            lblIntegral3.Text += "0";
                        }
                        if (x != 0 && constant == 0)
                        {
                            x2 = x / 2;
                            x3 = x2 / 3;
                            x4 = x3 / 4;
                            lblIntegral.Text += x2.ToString("F5") + "x^2 + C";
                            lblIntegral2.Text += x3.ToString("F5") + "x^3 + C";
                            lblIntegral3.Text += x4.ToString("F5") + "x^4 + C";
                        }
                        if (x == 0 && constant != 0)
                        {
                            constant2 = constant / 2;
                            constant3 = constant2 / 3;
                            lblIntegral.Text += constant + "x + C";
                            lblIntegral2.Text += constant2 + "x^2 + C";
                            lblIntegral3.Text += constant3 + "x^3 + C";
                        }
                        if (x != 0 && constant != 0)
                        {
                            x2 = x / 2;
                            lblIntegral.Text += x2.ToString("F5") + "x^2 + " + constant + "x + C";
                            x3 = x / 3;
                            constant2 = constant / 2;
                            lblIntegral2.Text += x3.ToString("F5") + "x^3 + " + constant2 + "x^2 + C";
                            x4 = x / 4;
                            constant3 = constant / 3;
                            lblIntegral3.Text += x4.ToString("F5") + "x^4 + " + constant3 + "x^3 + C";
                        }
                    }
                }
                else
                {
                    if ((exponent == -1 || exponent == -2 || exponent == -3) || (exponent20 == -1 || exponent20 == -2 || exponent20 == -3))
                    {
                        if (exponent == -1 && exponent20 != -1 && exponent20 != -2 && exponent20 != -3)
                        {
                            if (x == 0 && constant == 0)
                            {
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + C";
                                lblIntegral3.Text += "None";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += x4 + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += coefficient23.ToString("F5") + "x^" + exponent23 + " + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                exponent23 = exponent22 + 1;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2 + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3 + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += x4 + "x^4 + " + constant3 + "x^3 + C";
                            }
                        }
                        if (exponent20 == -1 && (exponent != -1 && exponent != -2 && exponent != -3))
                        {
                            if (x == 0 && constant == 0)
                            {
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + Abs(coefficient20) + "ln(|x|) + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4;
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += x4 + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + Abs(coefficient20) + "ln(|x|) + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += constant3 + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += x4 + "x^4 + " + constant3 + "x^3 + C";
                            }
                        }
                        if (exponent == -1 && exponent20 == -1)
                        {
                            if (x == 0 && constant == 0)
                            {
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + Abs(coefficient20) + "ln(|x|) + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + C";
                                lblIntegral3.Text += "None";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += x4 + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + Abs(coefficient20) + "ln(|x|) + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += constant3 + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -1 && exponent20 == -2)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^-1 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient21) + "ln(|x|) + C";
                                lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^-1 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient21) + "ln(|x|) + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21.ToString("F5") + "x^-1 + " + x2 + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + Abs(coefficient21) + "ln(|x|) + " + x3 + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4 + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -1 && exponent20 == -3)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21 + "x^-2 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22 + "x^-1 + C";
                                lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21 + "x^-2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22 + "x^-1 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += Abs(coefficient) + "ln(|x|) + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient) + "xln(|x|) - " + Abs(coefficient) + "x + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient22) + "ln(|x|) + " + x4 + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -2 && (exponent20 != -1 && exponent20 != -2 && exponent20 != -3))
                        {
                            if (x == 0 && constant == 0)
                            {
                                exponent2 = exponent + 1;
                                coefficient2 = coefficient / exponent2;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                exponent2 = exponent + 1;
                                coefficient2 = coefficient / exponent2;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent2 = exponent + 1;
                                coefficient2 = coefficient / exponent2;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent2 = exponent + 1;
                                coefficient2 = coefficient / exponent2;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent20 == -2 && (exponent != -1 && exponent != -2 && exponent != -3))
                        {
                            if (x == 0 && constant == 0)
                            {
                                exponent21 = exponent20 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-1 + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient21) + "ln(|x|) + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                exponent21 = exponent20 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent21 = exponent20 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-1 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient21) + "ln(|x|) + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                exponent21 = exponent20 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -2 && exponent20 == -1)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + Abs(coefficient20) + "ln(|x|) + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + Abs(coefficient20) + "ln(|x|) + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -2 && exponent20 == -2)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-1 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient21) + "ln(|x|) + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-1 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient21) + "ln(|x|) + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -2 && exponent20 == -3)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-2 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22 + "x^-1 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient22) + "ln(|x|) + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22 + "x^-1 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient22) + "ln(|x|) + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-1 + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += Abs(coefficient2) + "ln(|x|) + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient2) + "xln(|x|) - " + Abs(coefficient2) + "x + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -3 && (exponent20 != -1 && exponent20 != -2 && exponent20 != -3))
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                exponent21 = exponent20 + 1;
                                exponent22 = exponent21 + 1;
                                exponent23 = exponent22 + 1;
                                coefficient21 = coefficient20 / exponent21;
                                coefficient22 = coefficient21 / exponent22;
                                coefficient23 = coefficient22 / exponent23;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent20 == -3 && (exponent != -1 && exponent != -2 && exponent != -3))
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-2 + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22 + "x^-1 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient22) + "ln(|x|) + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22 + "x^-1 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient22) + "ln(|x|) + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                exponent2 = exponent + 1;
                                exponent3 = exponent2 + 1;
                                exponent4 = exponent3 + 1;
                                coefficient2 = coefficient / exponent2;
                                coefficient3 = coefficient2 / exponent3;
                                coefficient4 = coefficient3 / exponent4;
                                lblIntegral.Text += coefficient2.ToString("F5") + "x^" + exponent2 + " + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -3 && exponent20 == -1)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + Abs(coefficient20) + "ln(|x|) + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + Abs(coefficient20) + "ln(|x|) + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + Abs(coefficient20) + "ln(|x|) + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + Abs(coefficient20) + "ln(|x|) + " + x2 + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient20) + "xln(|x|) - " + Abs(coefficient20) + "x + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + x4 + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -3 && exponent20 == -2)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-1 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient21) + "ln(|x|) + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-1 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient21) + "ln(|x|) + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-1 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + Abs(coefficient21) + "ln(|x|) + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient21) + "xln(|x|) - " + Abs(coefficient21) + "x + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                        if (exponent == -3 && exponent20 == -3)
                        {
                            if (x == 0 && constant == 0)
                            {
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-2 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22 + "x^-1 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient22) + "ln(|x|) + C";
                            }
                            if (x != 0 && constant == 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + C";
                            }
                            if (x == 0 && constant != 0)
                            {
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22 + "x^-1 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient22) + "ln(|x|) + " + constant3.ToString("F5") + "x^3 + C";
                            }
                            if (x != 0 && constant != 0)
                            {
                                x2 = x / 2;
                                x3 = x2 / 3;
                                x4 = x3 / 4;
                                constant2 = constant / 2;
                                constant3 = constant2 / 3;
                                coefficient2 = coefficient / -2;
                                coefficient3 = coefficient2 / -1;
                                coefficient21 = coefficient20 / -2;
                                coefficient22 = coefficient21 / -1;
                                lblIntegral.Text += coefficient2 + "x^-2 + " + coefficient21 + "x^-2 + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                                lblIntegral2.Text += coefficient3 + "x^-1 + " + coefficient22 + "x^-1 + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                                lblIntegral3.Text += Abs(coefficient3) + "ln(|x|) + " + Abs(coefficient22) + "ln(|x|) + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                            }
                        }
                    }
                    else
                    {
                        if (x == 0 && constant == 0)
                        {
                            exponent2 = exponent + 1;
                            coefficient2 = coefficient / exponent2;
                            exponent21 = exponent20 + 1;
                            coefficient21 = coefficient20 / exponent21;
                            lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + C";
                            exponent3 = exponent2 + 1;
                            coefficient3 = coefficient2 / exponent3;
                            exponent22 = exponent21 + 1;
                            coefficient22 = coefficient21 / exponent22;
                            lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + C";
                            exponent4 = exponent3 + 1;
                            coefficient4 = coefficient3 / exponent4;
                            exponent23 = exponent22 + 1;
                            coefficient23 = coefficient22 / exponent23;
                            lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + C";
                        }
                        if (x != 0 && constant == 0)
                        {
                            exponent2 = exponent + 1;
                            coefficient2 = coefficient / exponent2;
                            exponent21 = exponent20 + 1;
                            coefficient21 = coefficient20 / exponent21;
                            x2 = x / 2;
                            lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + C";
                            exponent3 = exponent2 + 1;
                            coefficient3 = coefficient2 / exponent3;
                            exponent22 = exponent21 + 1;
                            coefficient22 = coefficient21 / exponent22;
                            x3 = x2 / 3;
                            lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + C";
                            exponent4 = exponent3 + 1;
                            coefficient4 = coefficient3 / exponent4;
                            exponent23 = exponent22 + 1;
                            coefficient23 = coefficient22 / exponent23;
                            x4 = x3 / 4;
                            lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + C";
                        }
                        if (x == 0 && constant != 0)
                        {
                            exponent2 = exponent + 1;
                            coefficient2 = coefficient / exponent2;
                            exponent21 = exponent20 + 1;
                            coefficient21 = coefficient20 / exponent21;
                            lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + constant + "x + C";
                            exponent3 = exponent2 + 1;
                            coefficient3 = coefficient2 / exponent3;
                            exponent22 = exponent21 + 1;
                            coefficient22 = coefficient21 / exponent22;
                            constant2 = constant / 2;
                            lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + constant2.ToString("F5") + "x^2 + C";
                            exponent4 = exponent3 + 1;
                            coefficient4 = coefficient3 / exponent4;
                            exponent23 = exponent22 + 1;
                            coefficient23 = coefficient22 / exponent23;
                            constant3 = constant2 / 3;
                            lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + constant3.ToString("F5") + "x^3 + C";
                        }
                        if (x != 0 && constant != 0)
                        {
                            exponent2 = exponent + 1;
                            coefficient2 = coefficient / exponent2;
                            exponent21 = exponent20 + 1;
                            coefficient21 = coefficient20 / exponent21;
                            x2 = x / 2;
                            lblIntegral.Text += coefficient2.ToString("F5") + "x^" + Convert.ToString(exponent2) + " + " + coefficient21.ToString("F5") + "x^" + exponent21 + " + " + x2.ToString("F5") + "x^2 + " + constant + "x + C";
                            exponent3 = exponent2 + 1;
                            coefficient3 = coefficient2 / exponent3;
                            exponent22 = exponent21 + 1;
                            coefficient22 = coefficient21 / exponent22;
                            x3 = x2 / 3;
                            constant2 = constant / 2;
                            lblIntegral2.Text += coefficient3.ToString("F5") + "x^" + exponent3 + " + " + coefficient22.ToString("F5") + "x^" + exponent22 + " + " + x3.ToString("F5") + "x^3 + " + constant2.ToString("F5") + "x^2 + C";
                            exponent4 = exponent3 + 1;
                            coefficient4 = coefficient3 / exponent4;
                            exponent23 = exponent22 + 1;
                            coefficient23 = coefficient22 / exponent23;
                            x4 = x3 / 4;
                            constant3 = constant2 / 3;
                            lblIntegral3.Text += coefficient4.ToString("F5") + "x^" + exponent4 + " + " + coefficient23.ToString("F5") + "x^" + exponent23 + " + " + x4.ToString("F5") + "x^4 + " + constant3.ToString("F5") + "x^3 + C";
                        }
                    }
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            lblLimit.Text = "Limit: ";
            lblTangent.Text = "Tangent line to function: ";
            double limit = Convert.ToDouble(TextBox17.Text);
            double leading = Convert.ToDouble(TextBox18.Text);
            double exponent = Convert.ToDouble(TextBox19.Text);
            double x = Convert.ToDouble(TextBox20.Text);
            double constant = Convert.ToDouble(TextBox21.Text);
            double multiply = Pow(limit, exponent);
            double limit2 = leading * multiply + limit * x + constant;
            double derivative1 = exponent * leading;
            double function = derivative1 * Pow(limit, exponent - 1) + x * limit;
            if (limit > 0)
            {
                if (TextBox17.Text != "∞")
                    lblTangent.Text += "y = " + function.ToString("N3") + "(x - " + limit + ") + " + limit2.ToString("N3");
                if (TextBox17.Text == "∞")
                    lblTangent.Text += "y = " + x + "(x - " + limit + ") + " + constant;
            }
            if (limit < 0)
            {
                if (TextBox17.Text != "-∞")
                {
                    double limit3 = -limit;
                    lblTangent.Text += "y = " + function.ToString("N3") + "(x + " + limit3 + ") + " + limit2.ToString("N3");
                }
                if (TextBox17.Text == "-∞")
                {
                    double limit3 = -limit;
                    lblTangent.Text += "y = " + x + "(x + ∞) + " + constant;
                }
            }
            if (TextBox17.Text == "∞" || TextBox17.Text == "-∞")
                lblLimit.Text = "Limit of x → " + limit + ": " + constant;
            else
                lblLimit.Text = "Limit of x → " + limit + ": " + limit2.ToString("N3");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            lblMultiply.Text = "Product rule derivative: ";
            double coefficient1 = Convert.ToDouble(TextBox22.Text);
            double exponent1 = Convert.ToDouble(TextBox23.Text);
            double coefficient2 = Convert.ToDouble(TextBox24.Text);
            double exponent2 = Convert.ToDouble(TextBox25.Text);
            double coefficient11 = coefficient1 * exponent1;
            double coefficient21 = coefficient2 * exponent2;
            double coefficient12 = coefficient11 * coefficient2;
            double exponent00 = exponent1 - 1;
            double exponent01 = exponent2 - 1;
            double exponent11 = exponent00 + exponent2;
            double coefficient22 = coefficient1 * coefficient21;
            double exponent21 = exponent01 + exponent1;
            double coefficient17 = coefficient12 + coefficient22;
            lblMultiply.Text += coefficient17 + "x^" + exponent11 + " [from (" + coefficient11 + "x^" + exponent00 + ")(" + coefficient2 + "x^" + exponent2 + ") + (" + coefficient1 + "x^" + exponent1 + ")(" + coefficient21 + "x^" + exponent01 + ") = " + coefficient12 + "x^" + exponent11 + " + " + coefficient22 + "x^" + exponent11 + "]";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            lblQuotient.Text = "Quotient rule derivative: ";
            double coefficient1 = Convert.ToDouble(TextBox26.Text);
            double exponent1 = Convert.ToDouble(TextBox27.Text);
            double coefficient2 = Convert.ToDouble(TextBox28.Text);
            double exponent2 = Convert.ToDouble(TextBox29.Text);
            double exponent3 = exponent2 * 2;
            double coefficient11 = coefficient1 * exponent1;
            double exponent11 = (exponent1 - 1) + exponent2;
            double coefficient17 = (coefficient11 * coefficient2) - (coefficient1 * (coefficient2 * exponent2));
            if (exponent11 < exponent3)
            {
                double exponent4 = exponent3 - exponent11;
                lblQuotient.Text += "(" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent2 + ")^2, or (" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent3 + "), or (" + coefficient17 + " / " + coefficient2 + "x^" + exponent4 + ")";
            }
            if (exponent3 < exponent11)
            {
                double exponent4 = exponent11 - exponent3;
                double division = coefficient17 / coefficient2;
                lblQuotient.Text += "(" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent2 + ")^2, or (" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent3 + "), or (" + coefficient17 + "x^" + exponent4 + ") / " + coefficient2 + ", or " + division + "x^" + exponent4;
            }
            if (exponent3 == exponent11)
            {
                double division = coefficient17 / coefficient2;
                lblQuotient.Text += "(" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent2 + ")^2, or (" + coefficient17 + "x^" + exponent11 + ") / (" + coefficient2 + "x^" + exponent3 + "), or " + division;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            lblPower.Text = "Power rule derivative: ";
            double coefficient1 = Convert.ToDouble(TextBox30.Text);
            double exponent1 = Convert.ToDouble(TextBox31.Text);
            double coefficient2 = Convert.ToDouble(TextBox32.Text);
            double exponent2 = Convert.ToDouble(TextBox34.Text);
            double exponent3 = Convert.ToDouble(TextBox33.Text);
            double derivative = coefficient1 * exponent1;
            double derivative2 = coefficient2 * exponent2;
            double newpower = exponent1 - 1;
            double newpower2 = exponent2 - 1;
            double exponent4 = exponent3 - 1;
            lblPower.Text += exponent3 + "(" + coefficient1 + "x^" + exponent1 + " + " + coefficient2 + "x^" + exponent2 + ")^" + exponent4 + "(" + derivative + "x^" + newpower + " + " + derivative2 + "x^" + newpower2 + ")";
        }
    }
}