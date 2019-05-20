<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Trigonometry.aspx.cs" Inherits="WebApplication6.math.Trigonometry" %>

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

        (function () {
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
    <link href="data:image/x-icon;base64,AAABAAEAEBACAAAAAACwAAAAFgAAACgAAAAQAAAAIAAAAAEAAQAAAAAAQAAAAAAAAAAAAAAAAgAAAAAAAAAA+/8AAAD+AAAAAAAAAAAAGHgAADx8AAA+fAAAHnAAAA5wAAAOcAAADnAAAA5wAAAOcAAAP/wAAD/8AAA//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" rel="icon" type="image/x-icon" />
    <title>Trigonometry | Max's T&M Site</title>
    <link rel="canonical" href="/Home.aspx"/>
    <link href="/Style/StyleSheet4.css" rel="stylesheet" />
    <link href="/Style/StyleSheet3.css" rel="stylesheet" />
    <link href="/Style/ml-navigation-bar.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:700' rel='stylesheet' type='text/css'>
</head>
<body style="background-image: url(/Images/GreenBackground2.jpg); background-size: cover">
    <img src="/Images/Logo.PNG"; width="1920" height="300"/>
    <div id="Header">
        &nbsp;<asp:Image ID="Image5" runat="server" Height="90px" ImageUrl="~/Images/Trig.png" style="padding-bottom:20px"/>
        Trigonometry</div>
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
		    <li><a onclick="createCookie('Geometry', 'yes', 0)" href="Geometry.aspx">Geometry</a></li>
            <li><a onclick="createCookie('Algebra', 'yes', 0)" href="Algebra.aspx">Algebra</a></li>
            <li class="active"><a onclick="createCookie('Trigonometry', 'yes', 0)" href="Trigonometry.aspx">Trigonometry</a></li>
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
        <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script><br />
        <asp:Image ID="Image33" runat="server" ImageUrl="/Images/Conversion.png" />
        <br />
        <br />
        Enter degrees:
        <asp:TextBox ID="TextBox84" runat="server" Width="30px"></asp:TextBox>
&nbsp;<asp:Button ID="Button24" runat="server" OnClick="Button24_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblRadians" runat="server" Text="Radians: "></asp:Label>
        <br />
        <br />
        Enter radians:
        <asp:TextBox ID="TextBox85" runat="server" Width="20px"></asp:TextBox>
        <b><span class="texhtml">π</span></b><strong> / </strong>
        <asp:TextBox ID="TextBox99" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button25" runat="server" OnClick="Button25_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblDegrees" runat="server" Text="Degrees: "></asp:Label>
        <strong>
        <br />
        <br />
&nbsp;<asp:Image ID="Image35" runat="server" Height="190px" ImageUrl="/Images/Table.png" />
        &nbsp;<asp:Image ID="Image34" runat="server" Height="190px" ImageUrl="/Images/ASTC.jpg" />
        <br />
        <br />
        </strong>
        Enter
        <asp:DropDownList ID="DropDownList8" runat="server" CssClass="auto-style7">
            <asp:ListItem>Degrees</asp:ListItem>
            <asp:ListItem>Radians</asp:ListItem>
        </asp:DropDownList>
        :
        <asp:TextBox ID="TextBox104" runat="server" Width="40px" CssClass="auto-style7"></asp:TextBox>
        &nbsp;<asp:Button ID="Button29" runat="server" OnClick="Button29_Click" Text="Submit" CssClass="auto-style7" />
        &nbsp;<asp:Label ID="lblError3" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblSinNormal" runat="server">Sine: </asp:Label>
        <br />
        <asp:Label ID="lblCosNormal" runat="server">Cosine:  </asp:Label>
        <br />
        <asp:Label ID="lblTanNormal" runat="server">Tangent: </asp:Label>
        <br />
        <asp:Label ID="lblCosecant" runat="server" Text="Cosecant: "></asp:Label>
        <br />
        <asp:Label ID="lblSecant" runat="server" Text="Secant: "></asp:Label>
        <br />
        <asp:Label ID="lblCotangent" runat="server" Text="Cotangent: "></asp:Label>
        <br />
        <br />
        Enter value between -1 and 1: <asp:TextBox ID="TextBox112" runat="server" Width="25px" CssClass="auto-style7"></asp:TextBox>
        &nbsp;<asp:Button ID="Button33" runat="server" OnClick="Button33_Click" Text="Submit" CssClass="auto-style7" />
        &nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblSinCsc" runat="server" Text="Sin-1 / Sec-1: "></asp:Label>
        <br />
        <asp:Label ID="lblCosSec" runat="server" Text="Cos-1 / Csc-1: "></asp:Label>
        <br />
        <asp:Label ID="lblTanCot" runat="server" Text="Tan-1 / Cot-1: "></asp:Label>
        <strong>
        <br />
        <br />
        Graphs<br />
        <asp:Image ID="Image29" runat="server" Height="300px" ImageUrl="/Images/SinCosTan.jpg" Width="500px" />
&nbsp;<asp:Image ID="Image30" runat="server" Height="300px" ImageUrl="/Images/ThreeInverse.jpg" Width="500px" />
        &nbsp;<asp:Image ID="Image36" runat="server" Height="300px" ImageUrl="/Images/Amplitude.png" />
        <br />
        <br />
        </strong>
        Enter function:
        y
        =
        <asp:TextBox ID="TextBox100" runat="server" Width="20px" CssClass="auto-style6"></asp:TextBox>
        <asp:DropDownList ID="DropDownList7" runat="server" CssClass="auto-style6">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
            <asp:ListItem>tan</asp:ListItem>
            <asp:ListItem>csc</asp:ListItem>
            <asp:ListItem>sec</asp:ListItem>
            <asp:ListItem>cot</asp:ListItem>
        </asp:DropDownList>
        (<asp:TextBox ID="TextBox102" runat="server" Width="20px" CssClass="auto-style6"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox101" runat="server" CssClass="auto-style6" Width="20px"></asp:TextBox> <span class="texhtml">π<b>) </b> </span>+
        <asp:TextBox ID="TextBox103" runat="server" Width="20px" CssClass="auto-style6"></asp:TextBox>
&nbsp;<asp:Button ID="Button28" runat="server" OnClick="Button28_Click" style="height: 26px" Text="Submit" CssClass="auto-style6" />
        <br />
        <asp:Label ID="lblAmplitude" runat="server" Text="Amplitude: "></asp:Label>
        <br />
        <asp:Label ID="lblPeriod" runat="server" Text="Period: "></asp:Label>
        <br />
        <asp:Label ID="lblPhase" runat="server" Text="Phase shift: "></asp:Label>
        <br />
        <asp:Label ID="lblMidline" runat="server" Text="Midline / vertical shift: "></asp:Label>
        <br />
        <asp:Label ID="lblVAsymptotes" runat="server" Text="Vertical asymptotes: "></asp:Label>
        <strong>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Solving for oblique triangles (you also could for right triangles)"></asp:Label>
        <br />
        <asp:Image ID="Image3" runat="server" ImageUrl="/Images/LawOfSines.jpg" />
&nbsp;<asp:Image ID="Image4" runat="server" Height="180px" ImageUrl="/Images/LawOfCosines.png" />
        <br />
        <br />
        </strong>
        <span class="auto-style4">AAA (Angle-Angle-Angle)</span><br />
        Enter angle A:
        <asp:TextBox ID="TextBox113" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter angle B: <asp:TextBox ID="TextBox114" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter angle C:
        <asp:TextBox ID="TextBox115" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
&nbsp;<asp:Button ID="Button34" runat="server" OnClick="Button34_Click1" Text="Submit" CssClass="auto-style5" />
&nbsp;<asp:Label ID="lblError4" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblS1" runat="server" Text="Side a proportional length: "></asp:Label>
        <br />
        <asp:Label ID="lblS2" runat="server" Text="Side b proportional length: "></asp:Label>
        <br />
        <asp:Label ID="lblS3" runat="server" Text="Side c proportional length: "></asp:Label>
        <br />
        <br />
        <span class="auto-style4">ASA (Angle-Side-Angle)</span><br />
        Enter angle A:
        <asp:TextBox ID="TextBox75" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter angle B:
        <asp:TextBox ID="TextBox76" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter side a:
        <asp:TextBox ID="TextBox77" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        &nbsp;<asp:Button ID="Button21" runat="server" OnClick="Button21_Click" Text="Submit" CssClass="auto-style5" />
        <br />
        <asp:Label ID="lblAngle1" runat="server" Text="Angle C measure: "></asp:Label>
        <br />
        <asp:Label ID="lblSide" runat="server" Text="Side b length: "></asp:Label>
        <br />
        <asp:Label ID="lblSide1" runat="server" Text="Side c length: "></asp:Label>
        <br />
        <br />
        <span class="auto-style4">SSA (Side-Side-Angle - Ambiguous Case)</span><br />
        Enter side a:
        <asp:TextBox ID="TextBox78" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter side b:
        <asp:TextBox ID="TextBox79" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter angle A:
        <asp:TextBox ID="TextBox80" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        &nbsp;<asp:Button ID="Button22" runat="server" Text="Submit" OnClick="Button22_Click" CssClass="auto-style5" />
        <br />
        <asp:Label ID="lblSide2" runat="server" Text="Side c length: "></asp:Label>
        <br />
        <asp:Label ID="lblAngle2" runat="server" Text="Angle B measure: "></asp:Label>
        <br />
        <asp:Label ID="lblAngle3" runat="server" Text="Angle C measure: "></asp:Label>
        <br />
        <br />
        <span class="auto-style4">SSS (Side-Side-Side)</span><br />
        Enter side a:
        <asp:TextBox ID="TextBox81" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter side b:
        <asp:TextBox ID="TextBox82" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
        <br />
        Enter side c:
        <asp:TextBox ID="TextBox83" runat="server" Width="30px" CssClass="auto-style5"></asp:TextBox>
&nbsp;<asp:Button ID="Button23" runat="server" Text="Submit" OnClick="Button23_Click" Font-Underline="False" CssClass="auto-style5" />
        <br />
        <asp:Label ID="lblAngle4" runat="server" Text="Angle A measure: "></asp:Label>
        <br />
        <asp:Label ID="lblAngle5" runat="server" Text="Angle B measure: "></asp:Label>
        <br />
        <asp:Label ID="lblAngle6" runat="server" Text="Angle C measure: "></asp:Label>
        <strong>
        <br />
        <br />
        Formulas<br />
        <asp:Image ID="Image1" runat="server" ImageUrl="/Images/Angles.jpg" />
        &nbsp;<asp:Image ID="Image16" runat="server" ImageUrl="/Images/Pythagorean.jpg" Height="190px" />
        &nbsp;<asp:Image ID="Image22" runat="server" Height="190px" ImageUrl="/Images/Even.png" />
        &nbsp;<asp:Image ID="Image2" runat="server" ImageUrl="/Images/CosSinTan.png" Height="190px" />
        &nbsp;<br />
&nbsp;<asp:Image ID="Image21" runat="server" ImageUrl="/Images/SumToProduct.png" Height="190px" />
        <asp:Image ID="Image20" runat="server" Height="190px" ImageUrl="/Images/ProductToSum.jpg" />
        <br />
        </strong>
        <br />
        Express all of the values below in <span class="auto-style4"><strong>degrees</strong></span>.<br />
        <br />
        <asp:DropDownList ID="DropDownList9" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
            <asp:ListItem>tan</asp:ListItem>
        </asp:DropDownList>
        2 *
        <asp:TextBox ID="TextBox124" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button37" runat="server" OnClick="Button37_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblDouble" runat="server" Text="Double-angle formula: "></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList10" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
            <asp:ListItem>tan</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox125" runat="server" Width="25px"></asp:TextBox>
&nbsp;/ 2
        <asp:Button ID="Button38" runat="server" OnClick="Button38_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblHalf" runat="server" Text="Half-angle formula: "></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList11" runat="server">
            <asp:ListItem>cos</asp:ListItem>
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>tan</asp:ListItem>
        </asp:DropDownList>
        (<asp:TextBox ID="TextBox126" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:DropDownList ID="DropDownList12" runat="server" Width="35px">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="TextBox127" runat="server" Width="25px"></asp:TextBox>
        )
        <asp:Button ID="Button39" runat="server" OnClick="Button39_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblSumDif" runat="server" Text="Sum and Difference formula: "></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList15" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox130" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:DropDownList ID="DropDownList17" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList16" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox131" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button41" runat="server" Text="Submit" OnClick="Button41_Click" />
        <br />
        <asp:Label ID="lblSumProd" runat="server" Text="Sum-to-Product formula: "></asp:Label>
        <br />
            <br />
        <asp:DropDownList ID="DropDownList13" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox128" runat="server" Width="25px"></asp:TextBox>
        <asp:DropDownList ID="DropDownList14" runat="server">
            <asp:ListItem>sin</asp:ListItem>
            <asp:ListItem>cos</asp:ListItem>
            <asp:ListItem>tan</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox129" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button40" runat="server" OnClick="Button40_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblProdSum" runat="server" Text="Product-to-Sum formula: "></asp:Label>
        <br />
        <br />
        <span style="color: #FFFFFF"><strong>Real-life examples</strong><br />
        A research ship finds that the angle of elevation of a volcanic island peak is
        </span>
        <asp:TextBox ID="TextBox105" runat="server" Width="30px"></asp:TextBox>
        <span class="st" data-hveid="100" data-ved="0ahUKEwjc16in8vbUAhUq04MKHedyCUEQ4EUIZDAM" style="color: #FFFFFF"><em>°</em>. After the ship has moved</span>
        <asp:TextBox ID="TextBox106" runat="server" Width="30px"></asp:TextBox>
&nbsp;<span style="color: #FFFFFF">meters, the angle of elevation is</span>
        <asp:TextBox ID="TextBox107" runat="server" Width="30px"></asp:TextBox>
        <span class="st" data-hveid="100" data-ved="0ahUKEwjc16in8vbUAhUq04MKHedyCUEQ4EUIZDAM" style="color: #FFFFFF"><em>°</em>.</span>
        <asp:Button ID="Button30" runat="server" OnClick="Button30_Click" Text="Submit" />
&nbsp;<asp:Label ID="lblError2" runat="server" ForeColor="Red" Text="Error. Second angle of elevation cannot be lower than first." Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblDistance2" runat="server" Text="Distance from shore before moving: " Font-Bold="True" ForeColor="White"></asp:Label>
        <br />
        <asp:Label ID="lblPeak" runat="server" Text="Height of peak: " Font-Bold="True" ForeColor="White"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image32" runat="server" ImageUrl="/Images/rpm.png" />
        <br />
        <br />
        <span style="color: #FFFFFF">The wheel of a machine is rotating at</span>
        <asp:TextBox ID="TextBox108" runat="server" Width="35px"></asp:TextBox>
&nbsp;<span style="color: #FFFFFF">rpm (revolutions per minute) and the diameter of the wheel is</span>
        <asp:TextBox ID="TextBox109" runat="server" Width="30px"></asp:TextBox>
&nbsp;<span style="color: #FFFFFF">cm.</span>
        <asp:Button ID="Button31" runat="server" OnClick="Button31_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblAngular" runat="server" Text="Angular speed: " Font-Bold="True" ForeColor="White"></asp:Label>
        <br />
        <asp:Label ID="lblLinear" runat="server" Text="Linear speed: " Font-Bold="True" ForeColor="White"></asp:Label>
        <br />
        <br />
        <span style="color: #FFFFFF">A car is traveling at</span>
        <asp:TextBox ID="TextBox110" runat="server" Width="35px"></asp:TextBox>
&nbsp;<span style="color: #FFFFFF">mph. The diameter of each of its tires is</span>
        <asp:TextBox ID="TextBox111" runat="server" Width="30px"></asp:TextBox>
&nbsp;<span style="color: #FFFFFF">cm.</span>
        <asp:Button ID="Button32" runat="server" OnClick="Button32_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblAngular2" runat="server" Text="Angular speed of tires: " Font-Bold="True" ForeColor="White"></asp:Label>
        <br />
        <asp:Label ID="lblRPM" runat="server" Text="Revolutions per minute of tires: " Font-Bold="True" ForeColor="White"></asp:Label>
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
    <p>&nbsp;&nbsp;max.voisard@gmail.com</p></div>
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
    <label for="sitesearch">
      <i class="fa fa-search sitesearch-icon"></i> 
      <span class="sr-only">
        Search
      </span>
    </label>
      <input id="sitesearch" runat="server" class="sitesearch" maxlength="2048" name="q" placeholder="Search This Site"/>
      <input id="myButton" runat="server" type="submit" name="myButton" value="Search" style="color: black"/>            
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