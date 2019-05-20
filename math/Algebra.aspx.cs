using System;
using System.IO;
using static System.Math;

namespace WebApplication6.math
{
    public partial class Algebra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = Cache["Algebra"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("Algebra.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Algebra", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("Algebra.aspx")));
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(TextBox7.Text);
            double product = Convert.ToDouble(TextBox8.Text);
            double exponent = 0.0;
            if (Base < 0)
                lblError3.Text += "Error. Base cannot be negative.";
            else
            {
                if (product > 0)
                    exponent = Log(product) / Log(Base);
                if (product < 0)
                    exponent = Pow(Base, product);
                lblExponent.Text += exponent.ToString("F4");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double product = Convert.ToDouble(TextBox10.Text);
            double exponent = 0.0;
            if (product > 0)
                exponent = Log(product) / Log(2.718281828);
            else
                exponent = Pow(2.71828, product);
            lblExponent2.Text += exponent.ToString("F8");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtX1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double y1 = Convert.ToDouble(txtY1.Text);
            double y2 = Convert.ToDouble(txtY2.Text);
            double midpoint1 = (x1 + x2) / 2;
            double midpoint2 = (y1 + y2) / 2;
            string midpoint = "(" + midpoint1 + ", " + midpoint2 + ")";
            lblMidpoint.Text += midpoint;
            double slope = (y2 - y1) / (x2 - x1);
            lblSlope.Text += slope;
            lblSlope2.Text += slope + "x + " + Convert.ToDouble(txtStart.Text);
            double yUno = 0.0, xUno = 0.0, multiply = 0.0;
            if (y1 > 0)
                yUno = -y1;
            else
                yUno = y1;
            if (x1 > 0)
            {
                xUno = -x1;
                multiply = xUno * slope;
            }
            else
            {
                xUno = x1;
                multiply = xUno * slope;
            }
            double xyUno = -yUno + multiply;
            lblSlope3.Text += "y" + yUno + " = " + slope + "(x" + xUno + ") or " + "y = " + slope + "x + " + xyUno;
            double distance = Sqrt(Pow((x2 - x1), 2) + Pow((y2 - y1), 2));
            lblDistance.Text += distance.ToString("F3");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(TextBox13.Text);
            double pvalue = Convert.ToDouble(TextBox12.Text);
            double k = Convert.ToDouble(TextBox15.Text);
            lblVertex.Text += "(" + h + ", " + k + ")";
            double p = pvalue / 4;
            double focus, directrix;
            if (pvalue < 0)
            {
                focus = k - Abs(p);
                directrix = k + Abs(p);
            }
            else
            {
                focus = k + Abs(p);
                directrix = k - Abs(p);
            }
            lblFocus.Text += "(" + h + ", " + focus + ")";
            lblDirectrix.Text += "y = " + directrix;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(TextBox21.Text);
            double pvalue = Convert.ToDouble(TextBox20.Text);
            double k = Convert.ToDouble(TextBox19.Text);
            lblVertex2.Text += "(" + h + ", " + k + ")";
            double p = pvalue / 4;
            double focus, directrix;
            if (pvalue < 0)
            {
                focus = h - Abs(p);
                directrix = h + Abs(p);
            }
            else
            {
                focus = h + Abs(p);
                directrix = h - Abs(p);
            }
            lblFocus2.Text += "(" + focus + ", " + k + ")";
            lblDirectrix2.Text += "x = " + directrix;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            double focusX = Convert.ToDouble(TextBox16.Text);
            double focusY = Convert.ToDouble(TextBox17.Text);
            double directrix = Convert.ToDouble(TextBox18.Text);
            if (DropDownList1.SelectedIndex == 0)
            {
                double vertexX = (focusX + directrix) / 2;
                lblVertex3.Text += "(" + vertexX + ", " + focusY + ")";
                if (directrix > focusX)
                {
                    double pvalue = 4 * ((directrix - focusX) / 2);
                    lblFunction.Text += "(y - (" + focusY + "))^2 = -" + pvalue + "(x - (" + vertexX + "))";
                }
                else if (focusX > directrix)
                {
                    double pvalue = 4 * ((focusX - directrix) / 2);
                    lblFunction.Text += "(y - (" + focusY + "))^2 = " + pvalue + "(x - (" + vertexX + "))";
                }
            }
            if (DropDownList1.SelectedIndex == 1)
            {
                double vertexY = (focusY + directrix) / 2;
                lblVertex3.Text += "(" + focusX + ", " + vertexY + ")";
                if (directrix > focusY)
                {
                    double pvalue = 4 * ((directrix - focusY) / 2);
                    lblFunction.Text += "(x - (" + focusX + "))^2 = -" + pvalue + "(y - (" + vertexY + "))";
                }
                if (focusY > directrix)
                {
                    double pvalue = 4 * ((focusY - directrix) / 2);
                    lblFunction.Text += "(x - (" + focusX + "))^2 = " + pvalue + "(y - (" + vertexY + "))";
                }
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(TextBox22.Text);
            double value2 = Convert.ToDouble(TextBox23.Text);
            double value3 = Convert.ToDouble(TextBox24.Text);
            double difference = value1 - value2;
            double difference2 = -(value1) - value2;
            double diversion1 = value3 - value2;
            double diversion2 = -(value3) - value2;
            string range1 = "", range2 = "", range3 = "";
            if (DropDownList2.SelectedIndex == 0)
                if (value1 < 0)
                    range1 = difference + ")U(" + difference2 + ", ";
                else
                    range1 = difference2 + ")U(" + difference + ", ";
            if (DropDownList2.SelectedIndex == 1)
                if (value1 < 0)
                    range1 = difference + "]U[" + difference2 + ", ";
                else
                    range1 = difference2 + "]U[" + difference + ", ";
            if (DropDownList3.SelectedIndex == 0)
            {
                if (value2 < 0)
                {
                    range2 = "(" + diversion1 + ", ";
                    range3 = diversion2 + ")";
                }
                else
                {
                    range2 = "(" + diversion2 + ", ";
                    range3 = diversion1 + ")";
                }
            }
            if (DropDownList3.SelectedIndex == 1)
            {
                if (value2 < 0)
                {
                    range2 = "[" + diversion1 + ", ";
                    range3 = diversion2 + "]";
                }
                else
                {
                    range2 = "[" + diversion2 + ", ";
                    range3 = diversion1 + "]";
                }
            }
            string range = range2 + range1 + range3;
            lblRange.Text += range;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            lblPolynomial3.Text = "Polynomial function: ";
            lblPolynomial.Text = "Polynomial function's zeros: ";
            lblVertex4.Text = "Vertex: ";
            lblDiscriminant.Text = "Discriminant: ";
            double leadingTerm = Convert.ToDouble(TextBox26.Text);
            double leadingCoefficient = Convert.ToDouble(TextBox25.Text);
            double constantTerm = Convert.ToDouble(TextBox27.Text);
            double discriminant = Pow(leadingCoefficient, 2) - (4 * leadingTerm * constantTerm);
            double discriminant2;
            double vertexX = -(leadingCoefficient) / (2 * leadingTerm);
            double vertexY = (leadingTerm * Pow(vertexX, 2)) + (leadingCoefficient * vertexX) + constantTerm;
            string vertex = "(" + vertexX.ToString("F3") + ", " + vertexY.ToString("F3") + ")";
            if (discriminant < 0)
            {
                lblPolynomial3.Text += "N/A";
                discriminant2 = -(discriminant);
                lblDiscriminant.Text += Sqrt(discriminant2).ToString("F3") + "i or √(" + discriminant + ")";
                double newValue = -discriminant / 4;
                lblPolynomial.Text += "x = " + vertexX.ToString("F3") + " + i√(" + newValue + ") and x = " + vertexX.ToString("F3") + " - i√(" + newValue + ")";
            }
            else
            {
                discriminant2 = discriminant;
                lblDiscriminant.Text += Sqrt(discriminant2).ToString("F3") + " or √(" + discriminant + ")";
                double x1 = (-leadingCoefficient + Sqrt(discriminant2)) / (2 * leadingTerm);
                double x2 = (-leadingCoefficient - Sqrt(discriminant2)) / (2 * leadingTerm);
                lblPolynomial.Text += "x = " + x1.ToString("F4") + " and x = " + x2.ToString("F4");
                if (x1 > 0) { x1 -= (x1 * 2); }
                else { x1 += (-x1 * 2); }
                if (x2 > 0) { x2 -= (x2 * 2); }
                else { x2 += (-x2 * 2); }
                double x11 = x1 * leadingTerm;
                lblPolynomial3.Text += leadingTerm + "(x + " + x1.ToString("F3") + ")(x + " + x2.ToString("F3") + ") or (" + leadingTerm + "x + " + x11.ToString("F3") + ")(x + " + x2.ToString("F3") + ")";
            }
            lblVertex4.Text += vertex;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(TextBox28.Text);
            double number1 = Convert.ToDouble(TextBox29.Text);
            double x2 = Convert.ToDouble(TextBox30.Text);
            double y = Convert.ToDouble(TextBox31.Text);
            double number2 = Convert.ToDouble(TextBox32.Text);
            double rand1 = -(y * number1) + number2;
            double realX = rand1 / (x2 + (y * -x1));
            double realY = number1 - (x1 * realX);
            lblX.Text += realX.ToString("F3");
            lblY.Text += realY.ToString("F3");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            lblPolynomial2.Text = "Original function: ";
            lblVertical.Text = "Vertical asymptote(s): ";
            lblHorizontal.Text = "Horizontal asymptote: ";
            lblSlant.Text = "Slant asymptote: ";
            lblHoles.Text = "Hole(s): ";
            lblXInt.Text = "x-intercept: ";
            lblYInt.Text = "y-intercepts: ";
            lblDomain.Text = "Domain: ";
            lblRanger.Text = "Range: ";
            double coefficient1 = Convert.ToDouble(TextBox37.Text);
            double exponent1 = Convert.ToDouble(TextBox33.Text);
            double constant1 = Convert.ToDouble(TextBox40.Text);
            double coefficient2 = Convert.ToDouble(TextBox38.Text);
            double exponent2 = Convert.ToDouble(TextBox39.Text);
            double constant2 = Convert.ToDouble(TextBox34.Text);
            double coefficient3 = Convert.ToDouble(TextBox41.Text);
            double exponent3 = Convert.ToDouble(TextBox42.Text);
            double constant3 = Convert.ToDouble(TextBox35.Text);
            double coefficient4 = Convert.ToDouble(TextBox44.Text);
            double exponent4 = Convert.ToDouble(TextBox43.Text);
            double constant4 = Convert.ToDouble(TextBox36.Text);
            double va1 = 0.0, va2 = 0.0;
            double constant30 = -constant3, constant40 = -constant4;
            string radical = "", radical2 = "";
            int signal = 0, signal2 = 0, Signal = 0, Signal2 = 0, message = 0;
            if (exponent3 == 1)
                va1 = -(constant3) / coefficient3;
            else
            {
                if (constant3 < 0 && coefficient3 > 0)
                {
                    if (exponent3 % 2 == 0)
                    {
                        va1 = Pow(-constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = +-" + va1.ToString("F3") + " [x = +- " + exponent3 + "√(" + InRadical + ") or " + exponent3 + "√(" + constant30 + "/" + coefficient3 + ")]";
                        signal = 1;
                    }
                    else
                    {
                        va1 = Pow(-constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + " [x = +- " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                    }
                }
                if (constant3 > 0 && coefficient3 > 0)
                {
                    if (exponent3 % 2 == 0)
                    {
                        va1 = Pow(constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + "i [x = " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                        signal = 2;
                    }
                    else
                    {
                        va1 = -Pow(constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + " [x = " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                    }
                }
                if (constant3 > 0 && coefficient3 < 0)
                {
                    if (exponent3 % 2 == 0)
                    {
                        va1 = Pow(-constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = +-" + va1.ToString("F3") + " [x = +- " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                        signal = 1;
                    }
                    else
                    {
                        va1 = Pow(-constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + " [x = " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                    }
                }
                if (constant3 < 0 && coefficient3 < 0)
                {
                    if (exponent3 % 2 == 0)
                    {
                        va1 = Pow(constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + "i [x = " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                        signal = 2;
                    }
                    else
                    {
                        va1 = -Pow(constant3 / coefficient3, 1 / exponent3);
                        double InRadical = -(constant3) / coefficient3;
                        radical = "x = " + va1.ToString("F3") + " [x = " + exponent3 + "√(" + InRadical + ") or √(" + constant30 + "/" + coefficient3 + ")]";
                    }
                }
            }
            if (exponent4 == 1)
                va2 = -(constant4) / coefficient4;
            else
            {
                if (constant4 < 0 && coefficient4 > 0)
                {
                    if (exponent4 % 2 == 0)
                    {
                        va2 = Pow(-constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = +-" + va2.ToString("F3") + " [x = +- " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                        signal2 = 1;
                    }
                    else
                    {
                        va2 = Pow(-constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + " [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                    }
                }
                if (constant4 > 0 && coefficient4 > 0)
                {
                    if (exponent4 % 2 == 0)
                    {
                        va2 = Pow(constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + "i [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                        signal2 = 2;
                    }
                    else
                    {
                        va2 = -Pow(constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + " [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                    }
                }
                if (constant4 > 0 && coefficient4 < 0)
                {
                    if (exponent4 % 2 == 0)
                    {
                        va2 = Pow(-constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = +-" + va2.ToString("F3") + " [x = +- " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                        signal2 = 1;
                    }
                    else
                    {
                        va2 = Pow(-constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + " [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                    }
                }
                if (constant4 < 0 && coefficient4 < 0)
                {
                    if (exponent4 % 2 == 0)
                    {
                        va2 = Pow(constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + "i [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                        signal2 = 2;
                    }
                    else
                    {
                        va2 = -Pow(constant4 / coefficient4, 1 / exponent4);
                        double inRadical = -(constant4) / coefficient4;
                        radical2 = "x = " + va2.ToString("F3") + " [x = " + exponent4 + "√(" + inRadical + ") or " + exponent4 + "√(" + constant40 + "/" + coefficient4 + ")]";
                    }
                }
            }
            double va11 = -va1;
            double va21 = -va2;
            double product1 = coefficient1 * coefficient2;
            double product2 = coefficient3 * coefficient4;
            double addition = exponent1 + exponent2;
            double addition2 = exponent3 + exponent4;
            double difference = addition - addition2;
            double product3 = (coefficient1 * constant2) + (coefficient2 * constant1);
            double product4 = constant1 * constant2;
            double product5 = constant3 * constant4;
            double product6 = (coefficient3 * constant4) + (coefficient4 * constant3);
            double difference2 = product3 - product6;
            string part1 = "", part2 = "";
            if (exponent1 == 1 && exponent2 == 1)
                part1 = "(" + product1 + "x^" + addition + " + " + product3 + "x + " + product4 + ")";
            else
            {
                if (exponent1 != 1 && exponent2 == 1)
                {
                    double ab1 = constant2 * coefficient1;
                    double ab2 = constant1 * coefficient2;
                    part1 = "(" + product1 + "x^" + addition + " + " + ab1 + "x^" + exponent1 + " + " + ab2 + "x + " + product4 + ")";
                }
                if (exponent1 == 1 && exponent2 != 1)
                {
                    double ab1 = constant2 * coefficient1;
                    double ab2 = constant1 * coefficient2;
                    part1 = "(" + product1 + "x^" + addition + " + " + ab1 + "x + " + ab2 + "x^" + exponent2 + " + " + product4 + ")";
                }
                if (exponent1 != 1 && exponent2 != 1)
                {
                    if (exponent1 != exponent2)
                    {
                        double ab1 = constant2 * coefficient1;
                        double ab2 = constant1 * coefficient2;
                        part1 = "(" + product1 + "x^" + addition + " + " + ab1 + "x^" + exponent1 + " + " + ab2 + "x^" + exponent2 + " + " + product4 + ")";
                    }
                    else
                    {
                        double ab1 = constant2 * coefficient1;
                        double ab2 = constant1 * coefficient2;
                        double total = ab1 + ab2;
                        part1 = "(" + product1 + "x^" + addition + " + " + total + "x^" + exponent1 + " + " + product4 + ")";
                    }
                }
            }
            if (exponent3 == 1 && exponent4 == 1)
                part2 = product2 + "x^" + addition2 + " + " + product6 + "x + " + product5 + ")";
            else
            {
                if (exponent3 != 1 && exponent4 == 1)
                {
                    double ab1 = constant4 * coefficient3;
                    double ab2 = constant3 * coefficient4;
                    part2 = "(" + product2 + "x^" + addition2 + " + " + ab1 + "x^" + exponent3 + " + " + ab2 + "x + " + product5 + ")";
                }
                if (exponent3 == 1 && exponent4 != 1)
                {
                    double ab1 = constant4 * coefficient3;
                    double ab2 = constant3 * coefficient4;
                    part2 = "(" + product2 + "x^" + addition2 + " + " + ab1 + "x + " + ab2 + "x^" + exponent4 + " + " + product5 + ")";
                }
                if (exponent3 != 1 && exponent4 != 1)
                {
                    if (exponent3 != exponent4)
                    {
                        double ab1 = constant4 * coefficient3;
                        double ab2 = constant3 * coefficient4;
                        part2 = "(" + product2 + "x^" + addition2 + " + " + ab1 + "x^" + exponent3 + " + " + ab2 + "x^" + exponent4 + " + " + product5 + ")";
                    }
                    else
                    {
                        double ab1 = constant2 * coefficient1;
                        double ab2 = constant1 * coefficient2;
                        double total = ab1 + ab2;
                        part2 = "(" + product2 + "x^" + addition2 + " + " + total + "x^" + exponent4 + " + " + product5 + ")";
                    }
                }
            }
            lblPolynomial2.Text += part1 + " / " + part2;
            double ha = product1 / product2;
            if (addition == addition2)
            {
                lblHorizontal.Text += "y = " + ha;
                lblRanger.Text += "(-∞, " + ha + ")U(" + ha + ", ∞)";
            }
            if (addition < addition2)
            {
                lblHorizontal.Text += "y = 0";
                lblRanger.Text += "(-∞, 0)U(0, ∞)";
            }
            if (addition > addition2)
            {
                lblHorizontal.Text += "None";
                lblRanger.Text += "(-∞, ∞)";
            }
            double constant = -(constant1);
            double Constant = -(constant2);
            double yint = 0.0, yint2 = 0.0;
            string yint1 = "", Yint2 = "";
            string xint = "(0, " + product4 + "/" + product5 + ")";
            lblXInt.Text += xint;
            if (exponent1 == 1)
            {
                yint = constant / coefficient1;
                yint1 = "(" + yint + " [" + constant + "/" + coefficient1 + "], 0)";
            }
            if (exponent1 != 1)
            {
                if (constant1 < 0 && coefficient1 > 0)
                {
                    if (exponent1 % 2 == 0)
                    {
                        yint = Pow(-constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(+-" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                        Signal = 1;
                    }
                    else
                    {
                        yint = Pow(-constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                    }
                }
                if (constant1 > 0 && coefficient1 > 0)
                {
                    if (exponent1 % 2 == 0)
                    {
                        yint = Pow(constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + "i [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                        Signal = 2;
                    }
                    else
                    {
                        yint = -Pow(constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                    }
                }
                if (constant1 > 0 && coefficient1 < 0)
                {
                    if (exponent1 % 2 == 0)
                    {
                        yint = Pow(-constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(+-" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                        Signal = 1;
                    }
                    else
                    {
                        yint = Pow(-constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                    }
                }
                if (constant1 < 0 && coefficient1 < 0)
                {
                    if (exponent1 % 2 == 0)
                    {
                        yint = Pow(constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + "i [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                        Signal = 2;
                    }
                    else
                    {
                        yint = -Pow(constant1 / coefficient1, 1 / exponent1);
                        yint1 = "(" + yint.ToString("F3") + " [" + exponent1 + "√(" + constant + "/" + coefficient1 + ")], 0)";
                    }
                }
            }
            if (exponent2 == 1)
            {
                yint2 = Constant / coefficient2;
                Yint2 = " and (" + yint2 + " [" + Constant + "/" + coefficient2 + "], 0)";
            }
            if (exponent2 != 1)
            {
                if (constant2 < 0 && coefficient2 > 0)
                {
                    if (exponent2 % 2 == 0)
                    {
                        yint2 = Pow(-constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (+-" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                        Signal2 = 1;
                    }
                    else
                    {
                        yint2 = Pow(-constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                    }
                }
                if (constant2 > 0 && coefficient2 > 0)
                {
                    if (exponent2 % 2 == 0)
                    {
                        yint2 = Pow(constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + "i [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                        Signal2 = 2;
                    }
                    else
                    {
                        yint2 = -Pow(constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                    }
                }
                if (constant2 > 0 && coefficient2 < 0)
                {
                    if (exponent2 % 2 == 0)
                    {
                        yint2 = Pow(-constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (+-" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                        Signal2 = 1;
                    }
                    else
                    {
                        yint2 = Pow(-constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                    }
                }
                if (constant2 < 0 && coefficient2 < 0)
                {
                    if (exponent2 % 2 == 0)
                    {
                        yint2 = Pow(constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + "i [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                        Signal2 = 2;
                    }
                    else
                    {
                        yint2 = -Pow(constant2 / coefficient2, 1 / exponent2);
                        Yint2 = " and (" + yint2.ToString("F3") + " [" + exponent2 + "√(" + Constant + "/" + coefficient2 + ")], 0)";
                    }
                }
            }
            lblYInt.Text += yint1 + Yint2 + " Signal: " + Signal + " Signal2: " + Signal2 + " signal: " + signal + " signal2: " + signal2;
            if (difference == 1)
                lblSlant.Text += "x + " + difference2;
            else
                lblSlant.Text += "None";
            if (((yint == va1) || (yint == va2)) && ((yint2 == va1) || (yint2 == va2)))
            {
                if ((exponent3 != 1 && constant3 > 0) && exponent4 == 1)
                {
                    lblHoles.Text += "x = " + va1 + "i and x = " + va2;
                    lblVertical.Text += "None";
                    lblDomain.Text += "(-∞, ∞)";
                }
                if (exponent3 == 1 && (exponent4 != 1 && constant4 > 0))
                {
                    lblHoles.Text += "x = " + va1 + "and x = " + va2 + "i";
                    lblVertical.Text += "None";
                    lblDomain.Text += "(-∞, ∞)";
                }
                if ((exponent3 != 1 && constant3 > 0) && (exponent4 != 1 && constant4 > 0))
                {
                    lblHoles.Text += "x = " + va1 + "i and x = " + va2 + "i";
                    lblVertical.Text += "None";
                    lblDomain.Text += "(-∞, ∞)";
                }
                else
                {
                    lblHoles.Text += "x = " + va1 + " and x = " + va2;
                    lblVertical.Text += "None";
                    lblDomain.Text += "(-∞, ∞)";
                }
            }
            else
            {
                if (((yint == va1) || (yint == va2)) && ((yint2 != va1) || (yint2 != va2)))
                {
                    if (yint == va1)
                    {
                        if (exponent3 == 1 && exponent4 == 1)
                        {
                            lblHoles.Text += "x = " + va1.ToString("F3");
                            lblVertical.Text += "x = " + va2.ToString("F3");
                            lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                        }
                        if (exponent3 != 1 && exponent4 == 1)
                        {
                            lblHoles.Text += radical;
                            lblVertical.Text += "x = " + va2.ToString("F3");
                            lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                        }
                        if (exponent3 == 1 && exponent4 != 1)
                        {
                            if (signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (signal2 == 1)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (signal2 == 2)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                            }
                        }
                        if (exponent3 != 1 && exponent4 != 1)
                        {
                            if (signal2 == 0)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (signal2 == 1)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (signal2 == 2)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                            }
                        }
                    }
                    if (yint == va2)
                    {
                        if (exponent4 == 1 && exponent3 == 1)
                        {
                            lblHoles.Text += "x = " + va2.ToString("F3");
                            lblVertical.Text += "x = " + va1.ToString("F3");
                            lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                        }
                        if (exponent4 != 1 && exponent3 == 1)
                        {
                            lblHoles.Text += radical2;
                            lblVertical.Text += "x = " + va1.ToString("F3");
                            lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                        }
                        if (exponent4 == 1 && exponent3 != 1)
                        {
                            if (signal == 0)
                            {
                                lblHoles.Text += "x = " + va2.ToString("F3");
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                            if (signal == 1)
                            {
                                lblHoles.Text += "x = " + va2;
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                            if (signal == 2)
                            {
                                lblHoles.Text += "x = " + va2;
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                            }
                        }
                        if (exponent4 != 1 && exponent3 != 1)
                        {
                            if (signal == 0)
                            {
                                lblHoles.Text += "x = " + radical;
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                            if (signal == 1)
                            {
                                lblHoles.Text += radical2;
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                            if (signal == 2)
                            {
                                lblHoles.Text += radical2;
                                lblVertical.Text += radical;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                            }
                        }
                    }
                }
                if (((yint != va1) || (yint != va2)) && ((yint2 == va1) || (yint2 == va2)))
                {
                    if (yint2 == va1)
                    {
                        if (signal2 == 0 && signal == 0)
                        {
                            message = 2;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical.Replace("+-", "");
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1 + Yint2.Replace("+-", "-");
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                if (va1 < va2)
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (va1 > va2)
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                if (va1 == va2)
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 1 && signal == 0)
                        {
                            message = 3;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                if (Abs(va2) < Abs(va1))
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                if (Abs(va2) > Abs(va1))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (Abs(va2) == Abs(va1))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 2 && signal == 0)
                        {
                            message = 1;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                                lblYInt.Text = "y-intercepts: " + yint1;
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical.Replace("+-", "");
                                lblVertical.Text += radical2;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                                lblYInt.Text = "y-intercepts: " + yint1 + Yint2.Replace("+-", "-");
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 0 && signal == 1)
                        {
                            message = 4;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblYInt.Text = "y-intercepts: " + yint1;
                                if (exponent4 != 1)
                                    lblVertical.Text += radical.Replace("+-", "-") + " and " + radical2;
                                else
                                    lblVertical.Text += radical.Replace("+-", "-") + " and x = " + va2;
                                if (va2 > va11)
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (va2 < va11)
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", ∞)";
                                if (va2 == va11)
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical;
                                if (exponent4 != 1)
                                    lblVertical.Text += radical2;
                                else
                                    lblVertical.Text += "x = " + va2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                if (exponent4 != 1)
                                    lblVertical.Text += radical + " and " + radical2;
                                else
                                    lblVertical.Text += radical + " and x = " + va2;
                                if (Abs(va2) < va1)
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                if (va2 > va1)
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (va2 < va11)
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                if (va2 == va1 || va2 == va11)
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 1 && signal == 1)
                        {
                            message = 5;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblVertical.Text += radical.Replace("+-", "-") + " and " + radical2;
                                if (Abs(va1) < Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (Abs(va1) > Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (Abs(va1) == Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                if (Abs(va1) < Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                if (Abs(va1) > Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                if (Abs(va1) == Abs(va2))
                                    lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 2 && signal == 1)
                        {
                            message = 6;
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va1.ToString("F3");
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblVertical.Text += radical.Replace("+-", "-") + " and " + radical2;
                                lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += radical2;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal2 == 0 && signal == 2)
                        {
                            message = 7;
                            if (Signal2 != 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and x = " + va2.ToString("F3");
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                            else
                            {
                                lblHoles.Text += radical;
                                lblVertical.Text += "x = " + va2.ToString("F3");
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                        }
                    }
                    if (yint2 == va2)
                    {
                        if (signal == 0 && signal2 == 0)
                        {
                            if (message != 2)
                            {
                                if (Signal2 == 0)
                                {
                                    lblHoles.Text += "x = " + va2.ToString("F3");
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 1)
                                {
                                    lblHoles.Text += "x = " + va2.ToString("F3");
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1 + Yint2.Replace("+-", "-");
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += radical + " and " + radical2;
                                    if (va1 < va2)
                                        lblDomain.Text += "(-∞, " + va1.ToString("F2") + ")U(" + va1.ToString("F2") + ", " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", ∞)";
                                    if (va1 > va2)
                                        lblDomain.Text += "(-∞, " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", " + va1.ToString("F2") + ")U(" + va1.ToString("F2") + ", ∞)";
                                    if (va1 == va2)
                                        lblDomain.Text += "(-∞, " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 0 && signal2 == 1)
                        {
                            if (message != 3)
                            {
                                if (Signal2 == 0)
                                {
                                    lblHoles.Text += "x = " + va2.ToString("F3");
                                    lblVertical.Text += "x = " + va1.ToString("F3") + " and " + radical2.Replace("+-", "-");
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    if (va1 > va21)
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (va1 < va21)
                                        lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", ∞)";
                                    if (va1 == va21)
                                        lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 1)
                                {
                                    lblHoles.Text += radical2;
                                    lblVertical.Text += "x = " + va1.ToString("F3");
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += "x = " + va1.ToString("F3") + " and " + radical2;
                                    if (va1 < va2 && va1 > va21)
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                    if (va1 > va2)
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (va1 < va21)
                                        lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                    if (va1 == va2 || va1 == va21)
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 0 && signal2 == 2)
                        {
                            if (message != 1)
                            {
                                if (Signal2 != 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += "x = " + va1.ToString("F3") + " and " + radical2;
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += radical2;
                                    lblVertical.Text += "x = " + va1.ToString("F3");
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 1 && signal2 == 0)
                        {
                            if (message != 4)
                            {
                                if (Signal2 != 2)
                                {
                                    lblHoles.Text += radical2.Replace("+-", "");
                                    lblVertical.Text += radical + " and x = -" + va2.ToString("F3");
                                    lblYInt.Text = "y-intercepts: " + yint1 + Yint2.Replace("+-", "-");
                                    if (va2 < Abs(va1))
                                        lblDomain.Text += "(-∞, " + va21.ToString("F3") + ")U(" + va21.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (va2 > Abs(va1))
                                        lblDomain.Text += "(-∞, " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va21.ToString("F3") + ")U(" + va21.ToString("F3") + ", ∞)";
                                    if (va2 == Abs(va1))
                                    {
                                        lblDomain.Text = "Domain: (-∞, " + va21.ToString("F3") + ")U(" + va21.ToString("F3") + ", ∞)";
                                        lblVertical.Text = "Vertical asymptote(s): " + radical.Replace("+-", "");
                                    }
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += radical + " and " + radical2;
                                    if (Abs(va2) < Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (Abs(va2) > Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                    if (Abs(va2) == Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 1 && signal2 == 1)
                        {
                            if (message != 5)
                            {
                                if (Signal2 == 0)
                                {
                                    lblHoles.Text += radical2.Replace("+-", "");
                                    lblVertical.Text += radical + " and x = -" + va2.ToString("F3");
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    if (Abs(va2) < Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (Abs(va2) > Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (Abs(va2) == Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 1)
                                {
                                    lblHoles.Text += radical2;
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += radical + " and " + radical2;
                                    if (Abs(va2) < Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                    if (Abs(va2) > Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                    if (Abs(va2) == Abs(va1))
                                        lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 1 && signal2 == 2)
                        {
                            if (message != 6)
                            {
                                if (Signal2 != 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += radical + " and " + radical2;
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                                else
                                {
                                    lblHoles.Text += radical2;
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 2 && signal2 == 0)
                        {
                            if (message != 7)
                            {
                                if (Signal2 == 0)
                                {
                                    lblHoles.Text += "x = " + va2.ToString("F3");
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                                }
                                if (Signal2 == 1)
                                {
                                    lblHoles.Text += "x = " + va2.ToString("F3");
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1 + Yint2.Replace("+-", "-");
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                                }
                                if (Signal2 == 2)
                                {
                                    lblHoles.Text += "None";
                                    lblVertical.Text += radical + " and x = " + va2.ToString("F3");
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                                }
                            }
                        }
                        if (signal == 2 && signal2 == 1)
                        {
                            if (Signal2 == 0)
                            {
                                lblHoles.Text += "x = " + va2.ToString("F3");
                                lblVertical.Text += radical;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", ∞)";
                            }
                            if (Signal2 == 1)
                            {
                                lblHoles.Text += radical2;
                                lblVertical.Text += radical;
                                lblYInt.Text = "y-intercepts: " + yint1;
                                lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            }
                        }
                        if (signal == 2 && signal2 == 2)
                        {
                            if (Signal2 != 2)
                            {
                                lblHoles.Text += "None";
                                lblVertical.Text += radical + " and " + radical2;
                                if (va1 < va2)
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, ∞)";
                                if (va1 > va2)
                                    lblDomain.Text += "(-∞, " + va2.ToString("F3") + "i)U(" + va2.ToString("F3") + "i, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                                if (va1 == va2)
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                            }
                            if (Signal2 == 2)
                            {
                                if (message == 1)
                                {
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                }
                                else
                                {
                                    lblHoles.Text += radical2;
                                    lblVertical.Text += radical;
                                    lblYInt.Text = "y-intercepts: " + yint1;
                                    lblDomain.Text += "(-∞, " + va1.ToString("F3") + "i)U(" + va1.ToString("F3") + "i, ∞)";
                                }
                            }
                        }
                    }
                }
                if ((yint2 != va1) && (yint2 != va2) && (yint != va1) && (yint != va2))
                {
                    if (exponent3 == 1 && exponent4 == 1)
                        lblVertical.Text += "x = " + va1 + " and x = " + va2;
                    if (exponent3 != 1 && exponent4 == 1)
                    {
                        if (signal2 == 0 && Signal == 1 && signal != 0 && va21 == yint)
                        {
                            lblHoles.Text += "x = " + va2;
                            lblVertical.Text += radical;
                            lblYInt.Text = "y-intercepts: " + yint1.Replace("+-", "") + Yint2;
                            lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                        }
                        else
                            lblVertical.Text += radical + " and x = " + va2;
                    }
                    if (exponent3 == 1 && exponent4 != 1)
                        lblVertical.Text += "x = " + va1 + " and " + radical2;
                    if (exponent3 != 1 && exponent4 != 1)
                    {
                        if (signal == 1 && Signal2 == 0 && exponent4 != 1 && va11 == yint2)
                        {
                            lblHoles.Text += radical.Replace("+-", "-");
                            lblVertical.Text += radical2 + " and x = " + va1.ToString("F3");
                            lblYInt.Text = "y-intercepts: " + yint1;
                            if (va1 < Abs(va2))
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", ∞)";
                            else
                                lblDomain.Text += "(-∞, -" + va2.ToString("F3") + ")U(-" + va2.ToString("F3") + ", " + va2.ToString("F3") + ")U(" + va2.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                        }
                        if (signal2 == 0 && Signal == 1 && signal != 0 && va21 == yint)
                        {
                            lblHoles.Text += radical2.Replace("+-", "-");
                            lblVertical.Text += radical;
                            lblYInt.Text = "y-intercepts: " + yint1.Replace("+-", "") + Yint2;
                            lblDomain.Text += "(-∞, -" + va1.ToString("F3") + ")U(-" + va1.ToString("F3") + ", " + va1.ToString("F3") + ")U(" + va1.ToString("F3") + ", ∞)";
                        }
                        if (va21 != yint && va21 != yint2 && va11 != yint && va11 != yint2)
                        {
                            lblVertical.Text += radical + " and " + radical2;
                            lblHoles.Text += "None";
                        }
                    }
                    if (lblDomain.Text == "Domain: ")
                    {
                        if (va1 < va2)
                            lblDomain.Text += "(-∞, " + va1.ToString("F2") + ")U(" + va1.ToString("F2") + ", " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", ∞)";
                        if (va1 > va2)
                            lblDomain.Text += "(-∞, " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", " + va1.ToString("F2") + ")U(" + va1.ToString("F2") + ", ∞)";
                        if (va1 == va2)
                            lblDomain.Text += "(-∞, " + va2.ToString("F2") + ")U(" + va2.ToString("F2") + ", ∞)";
                    }
                }
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            lblInverse.Text = "F-1(x) [inverse function]: ";
            double numerator = Convert.ToDouble(TextBox45.Text);
            double denominator = Convert.ToDouble(TextBox46.Text);
            string inverse = "(" + denominator + "x - " + numerator + ") / (x - 1)";
            lblInverse.Text += inverse;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(TextBox47.Text);
            double w = Convert.ToDouble(TextBox48.Text);
            double magnitude = Pow(v, 2) + Pow(w, 2);
            double mag2 = Sqrt(magnitude);
            lblMagnitude.Text += mag2.ToString("F3") + " or " + "√(" + magnitude + ")";
            double cosine = 180 / PI * Acos(v / mag2);
            double sin = 90 - cosine;
            lblCos.Text += cosine.ToString("F3") + " degrees";
            lblSin.Text += sin.ToString("F3") + " degrees";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            double vx = Convert.ToDouble(TextBox49.Text);
            double vy = Convert.ToDouble(TextBox55.Text);
            double wx = Convert.ToDouble(TextBox50.Text);
            double wy = Convert.ToDouble(TextBox56.Text);
            double numerator = (vx * wx) + (vy * wy);
            double magnitudev = Pow(vx, 2) + Pow(vy, 2);
            double magnitudew = Pow(wx, 2) + Pow(wy, 2);
            double magv = Sqrt(magnitudev);
            double magw = Sqrt(magnitudew);
            double cosine = 180 / PI * Acos(numerator / (magv * magw));
            double sine = 90 - cosine;
            lblV.Text += magv.ToString("F3") + " or " + "√(" + magnitudev + ")";
            lblW.Text += magw.ToString("F3") + " or " + "√(" + magnitudew + ")";
            lblCosine.Text += cosine.ToString("F3") + " degrees";
            lblSine.Text += sine.ToString("F3") + " degrees";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            double vi = Convert.ToDouble(TextBox57.Text);
            double vj = Convert.ToDouble(TextBox58.Text);
            double wi = Convert.ToDouble(TextBox59.Text);
            double wj = Convert.ToDouble(TextBox60.Text);
            double ab = (vi * wj) + (vj * wi);
            double i2 = vi * wi;
            double j2 = vj * wj;
            double i = vi + wi;
            double j = vj + wj;
            lblVW.Text += i2 + "i^2 + " + j2 + "j^2 + " + ab + "ij";
            lblVplusW.Text += i + "i + " + j + "j";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            lblF1.Text = "F1: ";
            lblF2.Text = "F2: ";
            lblF.Text = "F: ";
            lblForce.Text = "Resultant force: ";
            lblDirection.Text = "Direction: ";
            double F1pounds = Convert.ToDouble(TextBox51.Text);
            double F2pounds = Convert.ToDouble(TextBox52.Text);
            double F1direction = Convert.ToDouble(TextBox53.Text);
            double F2direction = Convert.ToDouble(TextBox54.Text);
            double degrees = (90 - F1direction) * (PI / 180);
            double degrees2 = (90 - F2direction) * (PI / 180);
            double F1 = F1pounds * Cos(degrees);
            double F1part2 = F1pounds * Sin(degrees);
            double F2 = F2pounds * Cos(degrees2);
            double F2part2 = F2pounds * Sin(degrees2);
            double power = F1pounds * F1direction;
            double power2 = F2pounds * F2direction;
            double power3 = F1pounds * (90 - F1direction);
            double power4 = F2pounds * (90 - F2direction);
            double Fi, Fj, magnitude, angle, angle2;
            if (DropDownList6.SelectedIndex == 0 && DropDownList18.SelectedIndex == 0)
            {
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = F1 + F2;
                    Fj = F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    lblDirection.Text += "N" + angle.ToString("F3") + DropDownList5.SelectedValue + " [from cos-1(| " + Fi.ToString("F3") + " | / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2 + "° in NE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = -F1 + F2;
                    Fj = F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power2 > power)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    else
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = F1 - F2;
                    Fj = F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power > power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    else
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = -F1 - F2;
                    Fj = F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Abs(Fi), 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                }
            }
            if (DropDownList6.SelectedIndex == 0 && DropDownList18.SelectedIndex == 1)
            {
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = F1 + F2;
                    Fj = F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4)
                        lblDirection.Text += "N" + angle.ToString("F3") + DropDownList5.SelectedValue + " [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + DropDownList5.SelectedValue + " [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = -F1 + F2;
                    Fj = F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4 && power > power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    if (power3 < power4 && power > power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                    if (power3 > power4 && power < power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    if (power3 < power4 && power < power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = F1 - F2;
                    Fj = F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4 && power > power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    if (power3 < power4 && power > power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                    if (power3 > power4 && power < power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    if (power3 < power4 && power < power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = -F1 - F2;
                    Fj = F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Abs(Fi), 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + " + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
            }
            if (DropDownList6.SelectedIndex == 1 && DropDownList18.SelectedIndex == 0)
            {
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = F1 + F2;
                    Fj = -F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4)
                        lblDirection.Text += "N" + angle.ToString("F3") + DropDownList5.SelectedValue + " [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + DropDownList5.SelectedValue + " [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = -F1 + F2;
                    Fj = -F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4 && power > power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    if (power3 < power4 && power > power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                    if (power3 > power4 && power < power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    if (power3 < power4 && power < power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = F1 - F2;
                    Fj = -F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4 && power > power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NE quadrant]";
                    if (power3 < power4 && power > power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                    if (power3 > power4 && power < power2)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    if (power3 < power4 && power < power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = -F1 - F2;
                    Fj = -F1part2 + F2part2;
                    magnitude = Sqrt(Pow(Abs(Fi), 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + " + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power3 > power4)
                        lblDirection.Text += "N" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (above x-axis) of " + angle2.ToString("F3") + "° in NW quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
            }
            if (DropDownList6.SelectedIndex == 1 && DropDownList18.SelectedIndex == 1)
            {
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = F1 + F2;
                    Fj = -F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 0)
                {
                    Fi = -F1 + F2;
                    Fj = -F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power2 > power)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 0 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = F1 - F2;
                    Fj = -F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    if (power > power2)
                        lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                    else
                        lblDirection.Text += "S" + angle.ToString("F3") + "E [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SE quadrant]";
                }
                if (DropDownList5.SelectedIndex == 1 && DropDownList19.SelectedIndex == 1)
                {
                    Fi = -F1 - F2;
                    Fj = -F1part2 - F2part2;
                    magnitude = Sqrt(Pow(Fi, 2) + Pow(Fj, 2));
                    angle = 90 - ((180 / PI) * Acos(Abs(Fi) / magnitude));
                    angle2 = 90 - angle;
                    lblF1.Text += "-" + F1.ToString("F3") + "x + -" + F1part2.ToString("F3") + "y";
                    lblF2.Text += "-" + F2.ToString("F3") + "x + -" + F2part2.ToString("F3") + "y";
                    lblF.Text += Fi.ToString("F3") + "x + " + Fj.ToString("F3") + "y";
                    lblForce.Text += magnitude.ToString("F3") + " pounds [√(" + Fi.ToString("F3") + "^2 + " + Fj.ToString("F3") + "^2)]";
                    lblDirection.Text += "S" + angle.ToString("F3") + "W [from cos-1(|" + Fi.ToString("F3") + "| / " + magnitude.ToString("F3") + ") to get reference angle (below x-axis) of " + angle2.ToString("F3") + "° in SW quadrant]";
                }
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(TextBox61.Text);
            double interest = Convert.ToDouble(TextBox62.Text) / 100;
            double time = Convert.ToDouble(TextBox63.Text);
            double earnings = principal * Pow((1 + interest), time);
            double earnings2 = principal * Pow(2.71828, (interest * time));
            double totalInterest = earnings - principal;
            double monthlyPayment = earnings / (time * 12);
            lblPrincipal.Text += earnings.ToString("C2") + " (so, total interest is " + totalInterest.ToString("C2") + " and monthly payment is " + monthlyPayment.ToString("C2") + ")";
            lblContinuous.Text += earnings2.ToString("C2");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(TextBox64.Text);
            double interest = Convert.ToDouble(TextBox65.Text) / 100;
            double compound = Convert.ToDouble(TextBox66.Text);
            double time = Convert.ToDouble(TextBox67.Text);
            double earnings = principal * Pow(1 + (interest / compound), compound * time);
            double totalInterest = earnings - principal;
            double monthlyPayment = earnings / (time * 12);
            lblPrincipal2.Text += earnings.ToString("C2") + " (so, total interest is " + totalInterest.ToString("C2") + " and monthly payment is " + monthlyPayment.ToString("C2") + ")";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            double mg = Convert.ToDouble(TextBox68.Text);
            double half = Convert.ToDouble(TextBox69.Text);
            double years = Convert.ToDouble(TextBox70.Text);
            double milligrams = mg * Pow(2.71828, (-0.693 * years) / half);
            lblMill.Text += milligrams.ToString("F3");
        }

        protected void Button20_Click1(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(TextBox71.Text);
            double temp2 = Convert.ToDouble(TextBox72.Text);
            double cooling = -Convert.ToDouble(TextBox73.Text);
            double minutes = Convert.ToDouble(TextBox74.Text);
            double kelvins = (temp1 + 459.67) / 1.8;
            double kelvins2 = (temp2 + 459.67) / 1.8;
            double seconds = minutes * 60;
            double temperature = kelvins2 + ((kelvins - kelvins2) * Pow(2.71828, cooling * seconds));
            double celsius = temperature - 273.15;
            double fahrenheit = celsius * 1.8 + 32;
            lblFahrenheit.Text += fahrenheit.ToString("F3") + " F";
            lblCelsius.Text += celsius.ToString("F3") + " C";
            lblKelvins.Text += temperature.ToString("F3") + " K";
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            double mcoefficient1 = Convert.ToDouble(TextBox86.Text);
            double mcoefficient2 = Convert.ToDouble(TextBox87.Text);
            double dcoefficient = Convert.ToDouble(TextBox88.Text);
            string exponent1 = Convert.ToString(TextBox97.Text);
            string exponent2 = Convert.ToString(TextBox98.Text);
            string exponent3 = Convert.ToString(TextBox89.Text);
            string property = exponent1 + "log" + mcoefficient1 + "x + " + exponent2 +
                "log" + mcoefficient2 + "y - " + exponent3 + "log" + dcoefficient + "x";
            lblProperty.Text += property;
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            double exponent1 = Convert.ToDouble(TextBox94.Text);
            double mcoefficient = Convert.ToDouble(TextBox91.Text);
            double exponent2 = Convert.ToDouble(TextBox95.Text);
            double mcoefficient2 = Convert.ToDouble(TextBox92.Text);
            string exponent3 = Convert.ToString(TextBox96.Text);
            double dcoefficient = Convert.ToDouble(TextBox93.Text);
            double product = mcoefficient * mcoefficient2;
            double addition = exponent1 + exponent2;
            string regular = "log(" + mcoefficient + "x^" + exponent1 + " * " +
                mcoefficient2 + "x^" + exponent2 + ") / " + "log" + dcoefficient +
                "y^" + exponent3 + ", or simplified as log(" + product + "x^" +
                addition + " / " + dcoefficient + "y^" + exponent3 + ")";
            lblRegular.Text += regular;
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            double x2 = Convert.ToDouble(TextBox116.Text);
            double x = Convert.ToDouble(TextBox117.Text);
            double x1 = Convert.ToDouble(TextBox118.Text);
            double constant = Convert.ToDouble(TextBox119.Text);
            double value = Convert.ToDouble(TextBox120.Text);
            double fogx1 = x2 * x1;
            double fogx2 = (x2 * (x1 * constant * 2)) + (x * x1);
            double fogx3 = x * constant + (constant * constant);
            double fogx4 = fogx1 * x1;
            double gofx = x * x1;
            double fogvalue = x1 * value + constant;
            double fogvalue2 = x2 * Pow(fogvalue, 2) + (x * fogvalue);
            double gofvalue = x2 * Pow(value, 2) + (x * value);
            double gofvalue2 = x1 * gofvalue + constant;
            lblFogx.Text += fogx4 + "x^2 + " + fogx2 + "x + " + fogx3;
            lblGofx.Text += fogx1 + "x^2 + " + gofx + "x + " + constant;
            lblFog3.Text = "(f o g)(" + value + "): " + fogvalue2;
            lblGof3.Text = "(g o f)(" + value + "): " + gofvalue2;
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            lblReduced.Text = "Reduced form: ";
            double coefficient = Convert.ToDouble(TextBox123.Text);
            double exponentX = Convert.ToDouble(TextBox121.Text);
            double exponentY = Convert.ToDouble(TextBox122.Text);
            double coefficient2 = Pow(coefficient, 0.33333);
            double exponentX1 = exponentX / 3;
            double exponentY1 = exponentY / 3;
            double exponentX3 = 1, exponentY3 = 1;
            for (int count = 0; count < 100; count++)
            {
                if (exponentX1 > count && exponentX1 < count + 1)
                    exponentX3 = count;
                if (exponentX1 == count)
                    exponentX3 = exponentX1;
                if (exponentY1 > count && exponentY1 < count + 1)
                    exponentY3 = count;
                if (exponentY1 == count)
                    exponentY3 = exponentY1;
            }
            double exponentX2 = exponentX % 3;
            double exponentY2 = exponentY % 3;
            if (coefficient2 % 2 == 0.00 || coefficient2 % 2 == 1.00)
            {
                lblReduced.Text += coefficient2 + "x^" + exponentX3 + "y^" + exponentY3 + " * 3√(x^" + exponentX2 + "y^" + exponentY2 + ")";
            }
            else
            {
                for (int index = 2; index < 100; index++)
                {
                    double cubed = Pow(index, 3);
                    if (coefficient % cubed == 0)
                    {
                        double division = coefficient / cubed;
                        lblReduced.Text += index + "x^" + exponentX3 + "y^" + exponentY3 + " * 3√(" + division + "x^" + exponentX2 + "y^" + exponentY2 + ")";
                    }
                }
                if (lblReduced.Text == "Reduced form: ")
                    lblReduced.Text += coefficient2.ToString("F3") + "x^" + exponentX1.ToString("F3") + "y^" + exponentY1.ToString("F3");
            }
        }

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
