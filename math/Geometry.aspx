<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Geometry.aspx.cs" Inherits="WebApplication6.math.Geometry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async="async" src="https://www.googletagmanager.com/gtag/js?id=UA-135557572-1"></script>
    <script>
      window.dataLayer = window.dataLayer || [];
      function gtag(){dataLayer.push(arguments);}
      gtag('js', new Date());
      gtag('config', 'UA-135557572-1', { 'optimize_id': 'GTM-WDKRBS3'});
    </script>
    <!-- Google Tag Manager -->
    <script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
        new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
        j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
        'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
        })(window, document, 'script', 'dataLayer', 'GTM-N5KXG2Z');

        (function() {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();

        gtag('event', 'login', { 'method': 'Google' });
        // Creates a timeout to call submitForm after one second.
        setTimeout(submitForm, 1000);
        // Keeps track of whether or not the form has been submitted.
        // This prevents the form from being submitted twice in cases
        // where the event callback function fires normally.
        var formSubmitted = false;
        function submitForm() {
            if (!formSubmitted) {
                formSubmitted = true;
                form.submit();
            }
        }
        var form = document.getElementById('signup-form');
        // Add a listener for the "submit" event.
        form.addEventListener('submit', function(event) {
          // Prevent the browser from submitting the form
          // and thus unloading the current page.
          event.preventDefault();
          // Send the event to Google Analytics and
          // resubmit the form once the hit is done.
          gtag('event', 'signup_form_complete', {
            'event_callback': function() {
              form.submit();
            }
          });
        });
    </script>
    <!-- End Google Tag Manager -->
    <script async="" defer="" src="//survey.g.doubleclick.net/async_survey?site=xp6xgahi7ejimgm2yd57tnr7du"></script>
    <script async="async" src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
    <script>
      (adsbygoogle = window.adsbygoogle || []).push({
        google_ad_client: "ca-pub-8887116012216502",
        enable_page_level_ads: true
      });
    </script>
    <!--[if lt IE 9]>
    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js">
    </script>
    <![endif]-->
    <title>Geometry | Max's T&M Site</title>
    <link href="data:image/x-icon;base64,AAABAAEAEBAAAAEACABoBQAAFgAAACgAAAAQAAAAIAAAAAEACAAAAAAAAAEAAAAAAAAAAAAAAAEAAAAAAABayf8AXMn/AAYI3QB+1fYABAbhAAkG4QD//P8ABAPtAP///wD9/fwAWsn9ABQJ4QAEBOMAy9b+AP///gAJBOMABwLnAAQF4AA0JOcA/P/9AGLJ/AAGBOIA/v/9APv/9gD//v8AwsrzAGTI/gAECOAA//74AAIH2wCV2fkA/v7+AP/+9wAECuEA+/3/ACYj3wBcn/8Ac2r0AIja+wD7+/UAAQHlAKng/gAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAgIIw8FAiEYCAgICAgICAgcHQQEBAQEBA0ICAgICAgOEAQEBAQEBAQRJwgICAgIEgQEBAQEBAQEBAQICAgICBUEBAQEBAQEBAQECAgICAgEBAQEBAQEBAQEBAgICAgIGwQEBAQEBAQEBAQICAgICAcEBAQEAQEBAQEBAQEBAQAXBAQEBCQBAQEBAQEBAQETCAsEBAQMCgEBAQEBAQEDCAgIJQQEBCgBAQEBAQEUHwgICAgIBhkiAAEBAQEBCAgICAgICAgICBYBAQEBHggICAgICAgICAgIKQEBGggICAgICAgICAgICAgBASAICAgICAgICAgICAgICSYICAgICAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=" rel="icon" type="image/x-icon" />
    <link rel="canonical" href="https://maxstechandmathsite.azurewebsites.net/Home"/>
    <link href="/Style/StyleSheet4.css" rel="stylesheet" />
    <link href="/Style/StyleSheet3.css" rel="stylesheet" />
    <link href="/Style/ml-navigation-bar.css" rel="stylesheet" />
</head>
<body style="background-image: url(/Images/BlueBackground.jpg); background-size: cover; text-align: left">
    <form id="form1" runat="server">
    <img src="/Images/Logo.PNG"; width="1920" height="300"/>
    <div id="Header">
        &nbsp;<asp:Image ID="Image32" runat="server" Height="80px" ImageUrl="~/Images/Geometry.png" style="padding-bottom:24px"/>
        Geometry</div>
    <nav>
        <ul id="ml-navigation-bar-2">
	    <li><a onclick="createCookie('Home', 'yes', 0)" href="/Home.aspx">Home</a></li>
	    <li><a onclick="createCookie('About', 'yes', 0)" href="/About.aspx">About</a></li>
        <li><a><span>Technology</span></a>
	    <ul>
            <li><a onclick="createCookie('Manufacturing', 'yes', 0)" href="/technology/Manufacturing.aspx">Manufacturing</a></li>
		    <li><a><span>Machines</span></a>
		    <ul>
			    <li><a onclick="createCookie('Big Machines', 'yes', 0)" href="/technology/machines/Big Machines.aspx">Big Machines</a></li>
			    <li><a onclick="createCookie('Little Machines', 'yes', 0)" href="/technology/machines/Little Machines.aspx">Little Machines</a></li>
		    </ul>
		    </li>		
		    <li><a onclick="createCookie('Electronics', 'yes', 0)" href="/technology/Electronics.aspx">Electronics</a></li>
            <li><a onclick="createCookie('Tools', 'yes', 0)" href="/technology/Tools.aspx">Tools</a></li>
	    </ul>
	    </li>
	    <li><a><span>Science</span></a>
	    <ul>
		    <li><a onclick="createCookie('Physics', 'yes', 0)" href="/science/Physics.aspx">Physics</a></li>
		    <li><a onclick="createCookie('Chemistry', 'yes', 0)" href="/science/Chemistry.aspx">Chemistry</a></li>
		    <li><a onclick="createCookie('Biology', 'yes', 0)" href="/science/Biology.aspx">Biology</a></li>
	    </ul>
	    </li>
	    <li><a><span>Math</span></a>
	    <ul>
		    <li class="active"><a onclick="createCookie('Geometry', 'yes', 0)" href="Geometry.aspx">Geometry</a></li>
            <li><a onclick="createCookie('Algebra', 'yes', 0)" href="Algebra.aspx">Algebra</a></li>
            <li><a onclick="createCookie('Trigonometry', 'yes', 0)" href="Trigonometry.aspx">Trigonometry</a></li>
            <li><a onclick="createCookie('Statistics', 'yes', 0)" href="Statistics.aspx">Statistics</a></li>
            <li><a onclick="createCookie('Calculus', 'yes', 0)" href="Calculus.aspx">Calculus</a></li>
	    </ul>
	    </li>
        <li><a onclick="createCookie('Random', 'yes', 0)" href="/Random.aspx">Random</a></li>
	    <li><a onclick="createCookie('Blog', 'yes', 0)" href="/Blog.aspx">Blog</a></li>
	    <li><a onclick="createCookie('Contact', 'yes', 0)" href="/Contact.aspx">Contact</a></li>
        <li><a><span>Other</span></a>
            <ul>
                <li><a onclick="createCookie('Privacy Policy', 'yes', 0)" href="/PrivacyPolicy.html">Privacy Policy</a></li>
                <li><a onclick="createCookie('Terms of Service', 'yes', 0)" href="/TermsOfService.html">Terms Of Service</a></li>
                <li><a onclick="createCookie('Help', 'yes', 0)" href="/Help.html">Help</a></li>
                <li><a onclick="createCookie('Sitemap', 'yes', 0)" href="/Sitemap.html">Site Map</a></li>
            </ul>
        </li>
			<div class="search-field">
                <input type="text" onclick="this.value='';" onfocus="this.select()" onblur="this.value=!this.value?'Search':this.value;" value="Search" />
			    <input class="search-button" type="image" src="/Images/search-icon-2.png" />
            </div>
        </ul>
        </nav>
        <script>
            function createCookie(name,value,days) {
            if (days) {
                var date = new Date();
                date.setTime(date.getTime()+(days*24*60*60*1000));
                var expires = "; expires="+date.toGMTString();
            }
            else var expires = "";
            document.cookie = name+"="+value+expires+"; path=/";
            }

            window.onscroll = function() {myFunction()};
            var navbar = document.getElementById("ml-navigation-bar-2");
            var sticky = navbar.offsetTop;

            function myFunction() {
              if (window.pageYOffset >= sticky) {
                  navbar.classList.add("sticky");
                  navbar.style.margin = "0px 20%";
              } else {
                navbar.classList.remove("sticky");
              }
            }
        </script>
        <br />
        <br />
        <br />
        <div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
        <br />
        <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Large" Text="Triangles"></asp:Label>
        <br />
        <br />
        To calculate the area of a triangle, do half the base times the height. Every right triangle has three sides a, b, and c, with a being the adjacent (touching) side to the right angle, b being the opposite, and c being the longest side and the diagonal, or the hypotenuse. To calculate hypotenuse, do the square root of a^2 + b^2, and you will see standard triangles come, such as 3-4-5 [√(3^2 + 4^2) = √(9 + 16) = √(25) = hypotenuse of 5], 5-12-13 [√(5^2 + 12^2) = √(25 + 144) = √(169) = 13], 8-17-15, 7-24-25, as well as 20-21-29. Sine, cosine, and tangent are used to calculate angles A, B, and C. Sine is opposite/hypotenuse, cosine is adjacent/hypotenuse, and tangent is opposite/adjacent or sine/cosine. In the 3-4-5 triangle, the sine would be 3 / 5, cosine would be 4 / 5, and tangent would be 3 / 4. You would only need to punch in the calculator inverse sine, or sin-1(3/5), then do 90 minus sin-1(3/5) to get cosine angle, and the tangent angle is always 90 since it is a right triangle. 
        These angles would be 36.87, 53.13, and 90. Standard triangles with degree-to-side ratios to know are 30-60-90 (with sides 1, √3, and 2 in that order) and 45-45-90 (1, 1, √2). Cosecant is the opposite of sine, so it is expressed as hypotenuse/opposite and 1/sin. Secant is hypotenuse/adjacent or 1/cos and cotangent is adjacent/opposite or 1/tan or cosine/sine. In the 3-4-5 triangle, these values would be csc = 5 / 3, sec = 5 / 4, and cot = 4 / 3. Cosecant <em>angle measures</em> (not sides) always equal the cosine angle, and secant angles equal sine angles. <br />
        <br />
        <asp:Image ID="Image20" runat="server" Height="190px" ImageUrl="/Images/TriangleArea.png" />
&nbsp;<asp:Image ID="Image21" runat="server" Height="190px" ImageUrl="/Images/Pythagorean2.png" />
&nbsp;<asp:Image ID="Image22" runat="server" Height="190px" ImageUrl="/Images/SOHCAHTOA.png" />
        &nbsp;<asp:Image ID="Image23" runat="server" Height="190px" ImageUrl="/Images/Cosecant.png" />
        <br />
        <asp:Label ID="lblHeight" runat="server" Text="Enter height of right triangle:"></asp:Label>
        <asp:TextBox ID="txtHeight" runat="server" Width="20px"></asp:TextBox>
        <asp:Label ID="lblLength" runat="server" Text="Enter length of right triangle:"></asp:Label>
        <asp:TextBox ID="txtLength" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblArea" runat="server" Text="Area: "></asp:Label>
        <br />
        <asp:Label ID="lblHypotenuse" runat="server" Text="Hypotenuse: "></asp:Label>
        <br />
        <asp:Label ID="lblSin" runat="server" Text="Sine: "></asp:Label>
        <br />
        <asp:Label ID="lblCos" runat="server" Text="Cosine: "></asp:Label>
        <br />
        <asp:Label ID="lblTan" runat="server" Text="Tangent: "></asp:Label>
        <br />
        <asp:Label ID="lblCosecant" runat="server" Text="Cosecant: "></asp:Label>
        <br />
        <asp:Label ID="lblSecant" runat="server" Text="Secant: "></asp:Label>
        <br />
        <asp:Label ID="lblCotangent" runat="server" Text="Cotangent: "></asp:Label>
        <br />
        <asp:Label ID="lblSine" runat="server" Text="Sine/secant angle measure: "></asp:Label>
        <br />
        <asp:Label ID="lblCosine" runat="server" Text="Cosine/cosecant angle measure: "></asp:Label>
        <br />
        <asp:Label ID="lblTangent" runat="server" Text="Tangent angle measure: "></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image28" runat="server" ImageUrl="/Images/Centers.gif" />
        <br />
        <br />
        All of the figures are examples of triangle centers.
        The centroid of a circle consists of a drawn line from a corner of the triangle through the opposite side&#39;s middle - the <span class="auto-style1">median</span>. The circumcenter has a <span class="auto-style1">perpendicular bisector</span> that is drawn from a right angle from each side&#39;s middle. An orthocenter has lines going at right angles from sides, in what are known as <span class="auto-style1">altitudes</span>. Lastly, the incenter has an <span class="auto-style1">angle bisector</span> drawn from a corner so that it splits the <em>angle</em>, not the <em>side</em>, in half. Going from top to bottom, the dots of these triangle centers are orthocenter, incenter, centroid, circumcenter.
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Font-Size="Large" style="font-weight: 700" Text="Quadrilaterals"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image29" runat="server" Height="190px" ImageUrl="/Images/Square.png" />
&nbsp;<asp:Image ID="Image15" runat="server" ImageUrl="/Images/Diagonal.jpg" Height="190px" />
        &nbsp;<asp:Image ID="Image30" runat="server" Height="190px" ImageUrl="/Images/Parallelogram.jpg" />
&nbsp;<asp:Image ID="Image18" runat="server" ImageUrl="/Images/Rhombus.jpg" />
&nbsp;<asp:Image ID="Image19" runat="server" ImageUrl="/Images/TrapezoidArea.jpg" Height="190px" />
        &nbsp;
        <br />
        A square&#39;s area is calculated by squaring the side&#39;s length, also expressed as length * width or base * height. The perimeter is adding all sides, or side * 4. The length of the diagonal is side√2, applying the 45-45-90 triangle rule for the diagonal/hypotenuse. A square has sides of the same length, but a rectangle does not, so one side cannot be squared - it is length * width only for rectangles. Perimeter is calculated as 2L + 2W, or 2(L + W). The diagonal applies the same concept as solving for a triangle&#39;s hypotenuse, once again: √(L^2 + W^2).
        To solve for a parallelogram, do base * height. Height can be calculated by drawing a triangle <span class="auto-style1">inside</span> this quadrilateral, calculating sides to get height using given angles or standard triangles like 3-4-5 and 5-12-13. For example, given a diagonal side of 5 (or in a triangle, a hypotenuse) and base of 3, the height must be 4. To solve for a rhombus, do the side * height by drawing a triangle <span class="auto-style1">outside</span> of the quadrilateral while touching it, and apply triangle caclulations to get height again. Another way to solve for rhombus area is to multiply the product of the two diagonals by 1/2.<br />
        <br />
        Enter side of square:
        <asp:TextBox ID="TextBox19" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter base of parallelogram:
        <asp:TextBox ID="TextBox20" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Enter height of parallelogram:
        <asp:TextBox ID="TextBox21" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblSquareArea" runat="server" Text="Area: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblParallelogram" runat="server" Text="Area: "></asp:Label>
        <br />
        <asp:Label ID="lblPerimeter2" runat="server" Text="Perimeter: "></asp:Label>
        <br />
        <asp:Label ID="lblSquareDiagonal" runat="server" Text="Diagonal length: "></asp:Label>
        <br />
        <br />
        Enter length of rectangle: <asp:TextBox ID="txtLength2" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;Enter diagonal 1 of rhombus:
        <asp:TextBox ID="txtDiagonal1" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Enter height of trapezoid:
        <asp:TextBox ID="txtTrapHeight" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter width of rectangle:
        <asp:TextBox ID="txtWidth" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter diagonal 2 of rhombus:
        <asp:TextBox ID="txtDiagonal2" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Enter base 1 of trapzoid:
        <asp:TextBox ID="txtBase1" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Enter base 2 of trapezoid:
        <asp:TextBox ID="txtBase2" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Label ID="lblArea2" runat="server" Text="Area: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblRhombus" runat="server" Text="Area: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblPerimeter" runat="server" Text="Perimeter: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTrapezoid" runat="server" Text="Area: "></asp:Label>
        <br />
        <asp:Label ID="lblDiagonal" runat="server" Text="Diagonal length: "></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Large" Text="Abnormal geometric figures"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl="/Images/Pyramid.jpg" Width="300px" />
&nbsp;
        <asp:Image ID="Image2" runat="server" Height="300px" ImageUrl="/Images/Cylinder.gif" Width="300px" />
        <br />
        Enter Radius (r) of Cone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Radius of Cylinder:<br />
        <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter Height (h) of Cone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Height of Cylinder:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblSide" runat="server" Text="Side (cone side): "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCylinderSA" runat="server" Text="Surface area of cylinder: "></asp:Label>
        <br />
        <asp:Label ID="lblConeSurfaceArea" runat="server" Text="Surface area of cone: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCylinderVolume" runat="server" Text="Volume of cylinder: "></asp:Label>
        <br />
        <asp:Label ID="lblConeVolume" runat="server" Text="Volume of cone: "></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image11" runat="server" ImageUrl="/Images/Cube.jpg" />
        &nbsp;<asp:Image ID="Image31" runat="server" Height="150px" ImageUrl="/Images/Cube Diagonal.png" />
        <br />
        Enter Side (s) of Cube:
        <asp:TextBox ID="txtCube" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblCube1" runat="server" Text="Surface area of cube: "></asp:Label>
        <br />
        <asp:Label ID="lblCube2" runat="server" Text="Volume of cube: "></asp:Label>
        <br />
        <asp:Label ID="lblDiagonal2" runat="server" Text="Diagonal length of cube: "></asp:Label>
        <br />
        <br />
        Length * width * height also for volume and diagonal - write in explanation<br />
        <br />
        <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Large" Text="Lines and Angles"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Image ID="Image17" runat="server" Height="280px" ImageUrl="/Images/Transversal.png" />
        &nbsp;<asp:Image ID="Image27" runat="server" Height="280px" ImageUrl="/Images/Transversals2.png" />
        <br />
        <br />
        Transversals are diagonals that cross (intersect) parallel lines, usually two, and angles can be determined with certain pairs. Corresponding angles share the same side of the transversal. Interior angles are on the sides closest to the parallel lines and exterior angles are on the outside, farthest away. Alternate interior and exterior angles are opposite, or alternate, of each other. Corresponding angles, alternate interior angles, and alternate exterior angles all equal each other. Vertical angles are opposite angles by intersecting lines, forming an &quot;X&quot; with two V&#39;s, and both angles having the same measure. This is the common application in solving for transversals.<br />
        <br />
&nbsp;<asp:Image ID="Image25" runat="server" Height="280px" ImageUrl="/Images/Complementary.jpg" />
&nbsp;<asp:Image ID="Image26" runat="server" Height="280px" ImageUrl="/Images/Complementary2.jpg" />
        <br />
        <br />
        Complementary angles are two angles that add up to 90, or a right triangle, as seen in the picture above to the right. Supplementary angles add up to 180, so they are straight angles and also linear pair angles. So, if one angle is 120, the other must be 60. Adjacent angles have a common side and vertex, but don&#39;t overlap. Therefore, given two angles that add up to 110 and one is 70, the other must be 40. Vertical angles are seen once again.<br />
        <br />
        <asp:Label ID="Label22" runat="server" Font-Size="Large" style="font-weight: 700" Text="Circles"></asp:Label>
        <br />
        &nbsp;<br />
        <asp:Image ID="Image3" runat="server" ImageUrl="/Images/Arc.jpg" Width="400px" Height="280px" />
&nbsp;<asp:Image ID="Image4" runat="server" Height="280px" ImageUrl="/Images/Circle.gif" Width="400px" />
        <br />
        <br />
        From the arc length formula, n/360 * Pi(r)^2 is the integral to find the arc area, and therefore arc length is the derivative of arc area. Also is <span>θ = s / r (theta, or angle = side / radius) and s = θr.</span> Thus is were <span>θ</span> = 2π comes from - where the equation is 2πr / r , or circumference / radius, and both radii cancel out. In the right picture, x would equal 50 degrees because (360 - 260) / 2 = 50.<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter degrees of arc:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Text="Enter degrees outside of two tangent lines: "></asp:Label>
        <asp:TextBox ID="txtDegrees" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter radius of arc:"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Submit" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblX" runat="server" Text="Degrees of x: "></asp:Label>
        <br />
        <asp:Label ID="lblArcLength" runat="server" Text="Length of arc: "></asp:Label>
        <br />
        <asp:Label ID="lblArcArea" runat="server" Text="Area of arc sector: "></asp:Label>
        <br />
        <br />
&nbsp;<asp:Image ID="Image5" runat="server" ImageUrl="/Images/Circles.jpg" />
        <br />
        <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Figure 1"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Figure 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Figure 3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Figure 3</strong><br />
        <asp:Label ID="Label13" runat="server" Text="chord a:"></asp:Label>
        <asp:TextBox ID="txtChordA" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; chord x:
        <asp:TextBox ID="TextBox9" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; chord x:
        <asp:TextBox ID="TextBox12" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; secant line y:
        <asp:TextBox ID="TextBox17" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Label ID="Label14" runat="server" Text="chord b:"></asp:Label>
        <asp:TextBox ID="txtChordB" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; secant line y:
        <asp:TextBox ID="TextBox10" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;secant line y:
        <asp:TextBox ID="TextBox13" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;tangent line t:
        <asp:TextBox ID="TextBox18" runat="server" Width="20px"></asp:TextBox>
        <br />
        <asp:Label ID="Label15" runat="server" Text="chord c:"></asp:Label>
        <asp:TextBox ID="txtChordC" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; secant line z:
        <asp:TextBox ID="TextBox11" runat="server" Width="20px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Submit" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblT" runat="server" Text="Tangent line T: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblX2" runat="server" Text="Chord X: "></asp:Label>
        <br />
        <asp:Label ID="lblChordD" runat="server" Text="Chord D: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblW" runat="server" Text="Chord W: "></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image6" runat="server" ImageUrl="/Images/Ellipse.gif" Width="390px" Height="150px" />
&nbsp;
        <asp:Image ID="Image7" runat="server" ImageUrl="/Images/Ellipsoid.png" Height="150px" />
&nbsp;<br />
        <br />
        <asp:Image ID="Image9" runat="server" ImageUrl="/Images/Volume.png" />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Ellipse"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Ellipsoid"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Label ID="Label7" runat="server" Text="Radius a:"></asp:Label>
&nbsp;<asp:TextBox ID="txtRadiusA" runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Radius 1:"></asp:Label>
        <asp:TextBox ID="txtRadius1" runat="server" Width="30px"></asp:TextBox>
        &nbsp;<br />
&nbsp;<asp:Label ID="Label8" runat="server" Text="Radius b:"></asp:Label>
&nbsp;<asp:TextBox ID="txtRadiusB" runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Radius 2:"></asp:Label>
        <asp:TextBox ID="txtRadius2" runat="server" Width="30px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Radius 3:"></asp:Label>
        <asp:TextBox ID="txtRadius3" runat="server" Width="30px"></asp:TextBox>
        <br />
        <asp:Label ID="lblEllipseSA" runat="server" Text="Surface area of ellipse: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblCircumference" runat="server" Font-Bold="False" Text="Approximate circumference of ellipse: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEllipsoid" runat="server" Text="Volume of ellipsoid: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Large" Text="Polygons"></asp:Label>
        <br />
        <br />
        <strong>Octagon</strong><br />
        <asp:Image ID="Image8" runat="server" ImageUrl="/Images/Octagon.png" Width="150px" />
        <asp:Image ID="Image10" runat="server" ImageUrl="/Images/Area.png" />
        <br />
        <br />
        Enter side length of octagon:
        <asp:TextBox ID="txtSide" runat="server" Width="30px"></asp:TextBox>
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblOctagon" runat="server" Text="Area of octagon: "></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image12" runat="server" Height="200px" ImageUrl="/Images/PolygonAngles.jpg" />
        <br />
        <br />
&nbsp;<asp:Image ID="Image13" runat="server" Height="200px" ImageUrl="/Images/PolygonArea1.jpg" />
&nbsp;<asp:Image ID="Image14" runat="server" Height="200px" ImageUrl="/Images/PolygonArea2.jpg" />
        <br />
        <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="The 180 in the formula is really π (3.14159) in the calculation."></asp:Label>
        <br />
        <br />
        Enter number of sides of polygon:
        <asp:TextBox ID="TextBox7" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter length of sides of polygon:
        <asp:TextBox ID="TextBox8" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblType" runat="server" Text="Type of polygon: "></asp:Label>
        <br />
        <asp:Label ID="lblSideAngle" runat="server" Text="Side angle measures of polygon: "></asp:Label>
        <br />
        <asp:Label ID="lblPolygonArea" runat="server" Text="Area of polygon: "></asp:Label>
        <br />
        <br />
<footer>
  <div class="footer iparsys parsy">
        <div class="column">
  <div class="container-fluid background-black ">
    <div class="container background-black ">
        <div class="clearfix row background-black everyDevice text-white   padding-2x-top  padding-4x-bottom" style="background-image: url('');background-repeat: no-repeat; background-size: cover; background-position: center center;">
            <div class="col-sm-3 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="richtext">
<div class=" padding-2x-top   width-100 ">
  <h6><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Connect with Us</b></h6>

</div>
<div class="clearfix"></div></div>
    <div class="textwithicon"><div>
    <div class="icon-column    "><i><img src="/Images/Media.jpg" alt="Social Media" height="20" width="20"/></i></div>
    <div class="text-column    ">
        <a href="/content/en-us/forklift-dealers" .html>
            <div>
    <p>Social Media</p>
</div>
        </a>
    </div>
</div></div>
    <div class="textwithicon"><div>
    <div>
    <a href="#" data-toggle="modal" data-target="#modal-contact-form" data-querystring="areaOfInterest=generalInquiry">
        <div class="icon-column    "><i><img src="/Images/Contact.jpg" alt="Contact Us" height="20" width="20"/></i></div>
        <div class="text-column    ">
    <a href="mailto:max.voisard@gmail.com?subject=Email+Max+your+Questions">
            <div>
    <p>max.voisard@gmail.com</p></div>
            </a>
        </div>
    </a>
</div>
</div></div>
    <div class="textwithicon"><div>
    <div class="icon-column    "><i><img src="/Images/Telephone.jpg" alt="Call" height="20" width="20"/></i></div>
    <div class="text-column    ">
        <a href="tel:4196292311">
            <div>
    <p>937-638-4972</p>
</div>
        </a>
    </div>
</div></div>
</div>
                </div>
            </div>
            <div class="col-sm-3 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="richtext">
<div class=" padding-2x-top   width-100 ">
  <h6><b>About Us</b></h6>

</div>
<div class="clearfix"></div></div>
    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="/content/en-us/about-us" .html>
            <div>
    <p>Site Map</p>
</div>
        </a>
    </div>
</div></div>
    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">  
        <a href="http://www.crown.com/en-us/about-us.html#whereweare">
            <div>
    <p>Blog</p>
</div>
        </a>
    </div>
</div></div>
    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="http://news.crown.com/blog-entries/" target="_blank">
            <div>
    <p>Terms and Conditions</p>
</div>
        </a>
    </div>
</div></div>
    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="/content/en-us/careers" .html>
            <div>
    <p>Privacy Policy</p>
</div>
        </a>
    </div>
</div></div>
</div>

                </div>
            </div>
            <div class="col-sm-3 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="richtext">
<div class=" padding-2x-top   width-100 ">
  <h6><b>Other</b></h6></div></div>
    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="/content/en-us/manuals-safety-labels" .html>
        <div>
            <p>Help</p>
        </div>
            </a>
    </div>
    </div>
    </div>

        <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="/content/en-us/manuals-safety-labels" .html>
            <div>         
    <p>Mission</p>
    </div>
            </a>
    </div>
    </div>
    </div>

    <div class="textwithicon"><div>
    <div class="text-column-no-padding    ">
        <a href="/content/en-us/operator-manuals" .html>
            <div>
    <p>Ads</p>
</div>
        </a>
    </div>
</div></div>
                </div>
            </div>
        </div>
            <div class="col-sm-3 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="richtext">
<div class=" padding-2x-top   width-100 ">
  <h6><b>Site Search</b></h6>
</div>
<div class="clearfix"></div></div>
    <div class="sitesearchbox">
  <form action="/en-us/search-results.html" accept-charset="UTF-8">
    <label for="sitesearch">
      <i class="fa fa-search sitesearch-icon"></i> 
      <span class="sr-only">
        Search
      </span>
    </label>
      <input id="sitesearch" runat="server" class="sitesearch" maxlength="2048" name="q" placeholder="Search This Site"/>
      <input id="myButton" runat="server" type="submit" name="myButton" value="Search" />
  </form>            
</div>
</div>
                </div>
            </div>
        </div>
    </div>
  </div>
</div>
        <div class="column">
  <div class="container-fluid background-black ">
    <div class="container background-black ">
        <div class="clearfix row background-black everyDevice text-white     " style="background-image: url('');background-repeat: no-repeat; background-size: cover; background-position: center center;">
            <div class="col-sm-8 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="richtext">
<div class="    width-100 text-left">
Copyright &copy; <span id="year"><script type="text/javascript">document.getElementById('year').appendChild(document.createTextNode(new Date().getFullYear()))</script></span> Max Voisard. All rights reserved.
</div>
<div class="clearfix"></div></div>
</div>
                </div>
            </div>
            <div class="col-sm-4 ">
                <div class="container-inner">
                  <div class="parsys">
    <div class="socialicons"><div>
    <ul id="footer-column_0-column2-socialicons-connect-list" role="group">
        <li>
    <a href="https://www.facebook.com/pages/Crown-Equipment-Corporation/488045240370?ref=aymt_homepage_panel" target="_blank" tabindex="-1">
        <i><img src="/Images/Facebook.jpg" alt="Facebook" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://twitter.com/crownequipment" target="_blank" tabindex="-1"><i><img src="/Images/Twitter.png" alt="Twitter" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.flickr.com/photos/crownequipment" target="_blank" tabindex="-1"><i><img src="/Images/Instagram.png" alt="Instagram" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.linkedin.com/company/crown-equipment-corporation" target="_blank" tabindex="-1"><i><img src="/Images/LinkedIn.png" alt="LinkedIn" width="30" height="30"/></i>
    </a>
&nbsp;</li>
        <li>
    <a href="https://plus.google.com/103248524698165801838/posts" target="_blank" tabindex="-1">
        <i><img src="/Images/Google.png" alt="Google" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.youtube.com/user/CrownEquipment" target="_blank" tabindex="-1"><i><img src="/Images/YouTube.png" alt="YouTube" width="30" height="30"/></i>
    </a>
</li>
    </ul>
</div>
</div></div>
</div>
                </div>
            </div>
        </div>
    </div>
  </div>
</div>     
        <div class="new section">
</div>   
        <div class="iparys_inherited"><div class="par">
</div>
</div>
  <div><div class="cookiepolicy">
<script>
    jQuery(document).ready(function () {
        Crown.Components.CookiePolicy.checkCookiePolicyStatus();
    });
</script></div>
</div>
</footer>
    </form>
</body>
</html>
