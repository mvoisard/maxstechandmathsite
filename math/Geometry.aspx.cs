using System;
using System.IO;
using static System.Math;

namespace WebApplication6.math
{
    public partial class Geometry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = Cache["Geometry"] as string;
            if (string.IsNullOrEmpty(fileContent))
            {
                using (StreamReader sr = File.OpenText(Server.MapPath("~/math/Geometry.aspx")))
                {
                    fileContent = sr.ReadToEnd();
                    Cache.Insert("Geometry", fileContent, new System.Web.Caching.CacheDependency(Server.MapPath("~/math/Geometry.aspx")));
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblArea.Text = "Area: ";
            lblHypotenuse.Text = "Hypotenuse: ";
            lblSin.Text = "Sine: ";
            lblCos.Text = "Cosine: ";
            lblTan.Text = "Tangent: ";
            lblCosecant.Text = "Cosecant: ";
            lblSecant.Text = "Secant: ";
            lblCotangent.Text = "Cotangent: ";
            lblSine.Text = "Sine/secant angle measure: ";
            lblCosine.Text = "Cosine/cosecant angle measure: ";
            lblTangent.Text = "Tangent angle measure: ";
            double heightopp = Convert.ToDouble(txtHeight.Text);
            double lengthadj = Convert.ToDouble(txtLength.Text);
            double area = (heightopp * lengthadj) / 2;
            lblArea.Text += area;
            double hypotenuse = Pow(heightopp, 2) + Pow(lengthadj, 2);
            double hypotenuse1 = Sqrt(hypotenuse);
            lblHypotenuse.Text += hypotenuse1.ToString("F3");
            double sine = heightopp / hypotenuse1;
            double cosine = lengthadj / hypotenuse1;
            double tangent = sine / cosine;
            double cosecant = 1 / sine;
            double secant = 1 / cosine;
            double cotangent = cosecant / secant;
            lblSin.Text += heightopp + "/" + hypotenuse1.ToString("F3") + " or " + sine.ToString("F4");
            lblCos.Text += lengthadj + "/" + hypotenuse1.ToString("F3") + " or " + cosine.ToString("F4");
            lblTan.Text += heightopp + "/" + lengthadj + " or " + tangent.ToString("F4");
            double sineMeasure = 180 / PI * Asin(sine);
            lblSine.Text += sineMeasure.ToString("F4");
            double cosineMeasure = 90 - sineMeasure;
            lblCosine.Text += cosineMeasure.ToString("F4");
            lblTangent.Text += "90";
            lblCosecant.Text += hypotenuse1.ToString("F3") + "/" + heightopp + " or " + cosecant.ToString("F4");
            lblSecant.Text += hypotenuse1.ToString("F3") + "/" + lengthadj + " or " + secant.ToString("F4");
            lblCotangent.Text += lengthadj + "/" + heightopp + " or " + cotangent.ToString("F4");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(TextBox1.Text);
            double height = Convert.ToDouble(TextBox2.Text);
            double volume = (PI * Pow(radius, 2) * height) / 3;
            double side = Pow(radius, 2) + Pow(height, 2);
            double side1 = Sqrt(side);
            double surfaceArea = (PI * radius * side1) + (PI * Pow(radius, 2));
            lblSide.Text += side1.ToString("F3");
            lblConeVolume.Text += volume.ToString("F3");
            lblConeSurfaceArea.Text += surfaceArea.ToString("F3");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblSide.Text = "Side (cone side): ";
            lblConeVolume.Text = "Volume of cone: ";
            lblConeSurfaceArea.Text = "Surface area of cone: ";
            lblCylinderSA.Text = "Surface area of cylinder: ";
            lblCylinderVolume.Text = "Volume of cylinder: ";
            double radius = Convert.ToDouble(TextBox3.Text);
            double height = Convert.ToDouble(TextBox4.Text);
            double surfaceArea = (2 * PI * Pow(radius, 2)) + (2 * PI * radius * height);
            double volume = PI * Pow(radius, 2) * height;
            lblCylinderSA.Text += surfaceArea.ToString("F3");
            lblCylinderVolume.Text += volume.ToString("F3");
            ;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double degrees = Convert.ToDouble(TextBox5.Text);
            double radius = Convert.ToDouble(TextBox6.Text);
            double length = (degrees / 360) * (2 * PI * radius);
            double area = (degrees / 360) * (PI * radius * radius);
            lblArcLength.Text += length.ToString("F3");
            lblArcArea.Text += area.ToString("F3");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            double radiusA = Convert.ToDouble(txtRadiusA.Text);
            double radiusB = Convert.ToDouble(txtRadiusB.Text);
            double surfaceArea = PI * radiusA * radiusB;
            lblEllipseSA.Text += surfaceArea.ToString("F3");
            double circumference = PI * (3 * radiusA + 3 * radiusB - Sqrt((radiusA + 3 * radiusB) * (3 * radiusA + radiusB)));
            lblCircumference.Text += circumference.ToString("F4");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double radius1 = Convert.ToDouble(txtRadius1.Text);
            double radius2 = Convert.ToDouble(txtRadius2.Text);
            double radius3 = Convert.ToDouble(txtRadius3.Text);
            double volume = (4 * PI * radius1 * radius2 * radius3) / 3;
            lblEllipsoid.Text += volume.ToString("F3");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtSide.Text);
            double area = (2 * Pow(side, 2)) * (1 + Sqrt(2));
            lblOctagon.Text += area.ToString("F2");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            lblChordD.Text = "Chord D: ";
            lblW.Text = "Chord W: ";
            lblT.Text = "Tangent line T: ";
            lblX2.Text = "Chord X: ";
            double chordA = Convert.ToDouble(txtChordA.Text);
            double chordB = Convert.ToDouble(txtChordB.Text);
            double chordC = Convert.ToDouble(txtChordC.Text);
            double chordD = (chordA * chordB) / chordC;
            lblChordD.Text += chordD.ToString("F2");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            double degrees = Convert.ToDouble(txtDegrees.Text);
            double degreesX = (360 - degrees) / 2;
            lblX.Text += degreesX.ToString("F2");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength2.Text);
            double width = Convert.ToDouble(txtWidth.Text);
            double area = length * width;
            lblArea2.Text += area;
            double perimeter = 2 * length + 2 * width;
            lblPerimeter.Text += perimeter;
            double diagonal = Pow(length, 2) + Pow(width, 2);
            lblDiagonal.Text += "√" + diagonal + " or " + Sqrt(diagonal).ToString("F4");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(txtCube.Text);
            double surface = 6 * Pow(side, 2);
            lblCube1.Text += surface;
            double area = Pow(side, 3);
            lblCube2.Text += area;
            lblDiagonal2.Text += side + "√3";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            int sides = Convert.ToInt32(TextBox7.Text);
            double length = Convert.ToDouble(TextBox8.Text);
            if (sides < 3)
            {
                lblType.ForeColor = System.Drawing.Color.Red;
                lblType.Text += "Error. Polygon must have at least 3 sides.";
            }
            if (sides == 3)
                lblType.Text += "Triangle";
            if (sides == 4)
                lblType.Text += "Quadrilateral (rectangle, square, parallelogram, rhombus, trapezoid)";
            if (sides == 5)
                lblType.Text += "Pentagon";
            if (sides == 6)
                lblType.Text += "Hexagon";
            if (sides == 7)
                lblType.Text += "Heptagon";
            if (sides == 8)
                lblType.Text += "Octagon";
            if (sides == 9)
                lblType.Text += "Nonagon";
            if (sides == 10)
                lblType.Text += "Decagon";
            if (sides > 10)
                lblType.Text += sides + "-agon";
            double total = (sides - 2) * 180;
            double sideAngles = ((sides - 2) * 180) / sides;
            lblSideAngle.Text += sideAngles.ToString("F3") + " degrees (total degrees = " + total + ")";
            double perimeter = sides * length;
            double apothem = length / (2 * Tan(3.141592654 / sides));
            double area = (apothem * perimeter) / 2;
            lblPolygonArea.Text += area.ToString("F3");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            double diagonal1 = Convert.ToDouble(txtDiagonal1.Text);
            double diagonal2 = Convert.ToDouble(txtDiagonal2.Text);
            double area = 0.5 * (diagonal1 * diagonal2);
            lblRhombus.Text += area.ToString("F2");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtTrapHeight.Text);
            double base1 = Convert.ToDouble(txtBase1.Text);
            double base2 = Convert.ToDouble(txtBase2.Text);
            double area = (0.5 * height) * (base1 + base2);
            lblTrapezoid.Text += area.ToString("F2");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            lblChordD.Text = "Chord D: ";
            lblW.Text = "Chord W: ";
            lblT.Text = "Tangent line T: ";
            lblX2.Text = "Chord X: ";
            double x = Convert.ToDouble(TextBox9.Text);
            double y = Convert.ToDouble(TextBox10.Text);
            double z = Convert.ToDouble(TextBox11.Text);
            double xy = (x + y) * y;
            double w = (xy - Pow(z, 2)) / z;
            lblW.Text += w.ToString("F2");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            lblChordD.Text = "Chord D: ";
            lblW.Text = "Chord W: ";
            lblT.Text = "Tangent line T: ";
            lblX2.Text = "Chord X: ";
            double x = Convert.ToDouble(TextBox12.Text);
            double y = Convert.ToDouble(TextBox13.Text);
            double xy = (x + y) * y;
            double t = Sqrt(xy);
            lblT.Text += t.ToString("F2") + " or √" + xy;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            lblChordD.Text = "Chord D: ";
            lblW.Text = "Chord W: ";
            lblT.Text = "Tangent line T: ";
            lblX2.Text = "Chord X: ";
            double y = Convert.ToDouble(TextBox17.Text);
            double t = Convert.ToDouble(TextBox18.Text);
            double x = (Pow(t, 2) / y) - y;
            lblX2.Text += x.ToString("F3");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(TextBox19.Text);
            double area = side * side;
            double perimeter = side * 4;
            lblSquareArea.Text += area.ToString("F3");
            lblPerimeter2.Text += perimeter.ToString("F3");
            lblSquareDiagonal.Text += side + "√2";
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(TextBox20.Text);
            double height = Convert.ToDouble(TextBox21.Text);
            double area = Base * height;
            lblParallelogram.Text += area.ToString("F3");
        }
    }
}
