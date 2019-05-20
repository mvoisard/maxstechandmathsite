<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Algebra.aspx.cs" Inherits="WebApplication6.math.Algebra" %>

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
    <title>Algebra | Max's T&M Site</title>
    <link id="page_favicon" href="data:image/x-icon;base64,R0lGODlhEAAQAPEBAAcICP///8zMzAAAACH5BAkUAAIAIf8LTkVUU0NBUEUyLjADAQAAACwAAAAAEAAQAAACEpSPqcvtD6OcDNiLM6C8+w8KBQAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCE5yPqcvtD6NcYQaAs96z+w+GSwEAIfkECRQAAwAsAAAAABAAEACBBwgIFF6j////zMzMAhWcj6nL7R4eitJQeTHYvPsKhuJIlgUAIfkECRQAAwAsAAAAABAAEACBBwgIFF6j////zMzMAhecj6nLneEQjGfSYWPWoPsPXuJIluZZAAAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCF5yPqcud4RCEcdBqcdYB+A+G2kiW5okVACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIZnI+py8Hp3DNxHmlp1nsEAIbi2JXmiaZbAQAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCG5yPqaE9wdxhUb5rTc2Y7xwA4kiW3Imm6so2BQAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCGpyPqaE9wdxhVL5rTcyad/8A4kiW4Imm6uoVACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIfnI+poT3B3GFUvmti01lyvIQbQJZBiQLWyrbuC8dIAQAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCIJyPqaE9wdxhVL5rYtNZcryEG0CWQYkCzme17gvHclMAACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIhnI+poT3B3GFUvmti01lyvITfA5RmAKBm6YzWC8fyTCsFACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIhnI+poT3B3GFUvmti01lyvIRQEgDmWZan6XzWC8fyTDcFACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIinI+poT3B3GFUvmti01lyvIRQEgDmWaYn4ESfBcfyTNdIAQAh+QQJFAADACwAAAAAEAAQAIEHCAgUXqP////MzMwCI5yPqaE9wdxhVL5rYtNZcryEUBIA5lmmJ+BEnwXCsUzXtlQAACH5BAkUAAMALAAAAAAQABAAgQcICBReo////8zMzAIjnI+poT3B3GFUvmti01lyvIRQEgDmWaYn4ESVNX0eTNf2bRQAIfkECRQAAwAsAAAAABAAEACBBwgIFF6j////zMzMAiWcj6mhPcHcYVS+a2LTWXK8hND0AOYZAGmqAk5Efa/8WvaN500BACH5BAlkAAMALAAAAAAQABAAgQcICBReo////8zMzAImnI+poT3B3GFUvmti01lynEDLo1HAiQaAqq6AE1EfPMPWjed6UwAAOw==" rel="icon" type="image/x-icon" />
    <link rel="canonical" href="https://maxstechandmathsite.azurewebsites.net/Home"/>
    <link href="/Style/StyleSheet4.css" rel="stylesheet" />
    <link href="/Style/StyleSheet3.css" rel="stylesheet" />
    <link href="/Style/StyleSheet5.css" rel="stylesheet" />
    <link href="/Style/ml-navigation-bar.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Droid+Sans" rel="stylesheet" />
    <link rel="stylesheet" href="/Style/Dashboard.css" />
</head>
<body style="background-image: url(/Images/GreenBackground.jpg); background-size: cover">
    <form id="form2" runat="server">
        <header>
            <section id="contents" class="navbar navbar-default">
                <div class="container-fluid">
                  <div class="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                      <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">My profile <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                          <li><a href="#"><i class="fa fa-user-o fw"></i> My account</a></li>
                          <li><a href="#"><i class="fa fa-envelope-o fw"></i> My inbox</a></li>
                          <li><a href="#"><i class="fa fa-question-circle-o fw"></i> Help</a></li>
                          <li role="separator" class="divider"></li>
                          <li><a href="#"><i class="fa fa-sign-out"></i> Log out</a></li>
                        </ul>
                      </li>
                      <li><a href="#"><i class="fa fa-comments"></i><span>23</span></a></li>
                      <li><a href="#"><i class="fa fa-bell-o"></i><span>98</span></a></li>
                      <li><a href="#"><i data-show="show-side-navigation1" class="fa fa-bars show-side-btn"></i></a></li>
                    </ul>
                  </div>
                </div>
            </section>
            <aside class="side-nav" id="show-side-navigation1">
              <i class="fa fa-bars close-aside hidden-sm hidden-md hidden-lg" data-close="show-side-navigation1"></i>
              <div class="heading">
                <img src="/Images/PictureOfMe.jpg" alt="Profile Picture" />
                <div class="info">
                  <h3><a href="#">Max Voisard</a></h3>
                  <p>Site creator and administrator.</p>
                </div>
              </div>
              <ul class="categories">
                <li><i class="fa fa-envelope-open-o fa-fw"></i><a href="#"> Messages <span class="num dang">56</span></a></li>
                <li><i class="fa fa-gears"></i><a href="#"> Settings <span class="num prim">6</span></a>
                  <ul class="side-nav-dropdown">
                    <li><a href="#">Lorem ipsum</a></li>
                    <li><a href="#">ipsum dolor</a></li>
                    <li><a href="#">dolor ipsum</a></li>
                    <li><a href="#">amet consectetur</a></li>
                    <li><a href="#">ipsum dolor sit</a></li>
                  </ul>
                </li>
                <li><i class="fa fa-laptop fa-fw"></i><a href="#"> About Algebra Page <span class="num succ">43</span></a></li>
                <li><i class="fa fa-comments-o fa-fw"></i><a href="#"> Support</a></li>
              </ul>
            </aside>
            <img src="/Images/Logo.PNG"; style="width: 80%" height="355"/>
            <div id="Header">&nbsp;<asp:Image ID="Image34" runat="server" Height="90px" ImageUrl="~/Images/Algebra.png" Width="90px" style="padding-bottom:20px"/>Algebra</div>
        </header>
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
            <li class="active"><a onclick="createCookie('Algebra', 'yes', 0)" href="Algebra.aspx">Algebra</a></li>
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
        <input type="search" />
        <br />
        <div id="google_translate_element"></div>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
        <script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
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
        <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Logarithms"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp; Logarithm written structure</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Logarithm property rules"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label16" runat="server" Font-Bold="True" Text="Example"></asp:Label>
        <br />
        <asp:Image ID="Image31" runat="server" Height="180px" ImageUrl="/Images/Log.jpg" />
&nbsp;<asp:Image ID="Image5" runat="server" ImageUrl="/Images/LogRules.png" />
&nbsp;<asp:Image ID="Image6" runat="server" Height="180px" ImageUrl="/Images/LogExample.png" />
        <br />
        Enter regular logarithm formula: log(<asp:TextBox ID="TextBox86" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox97" runat="server" Width="25px"></asp:TextBox>
&nbsp;*
        <asp:TextBox ID="TextBox87" runat="server" Width="25px"></asp:TextBox>
        y^<asp:TextBox ID="TextBox98" runat="server" Width="25px"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="TextBox88" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox89" runat="server" Width="25px"></asp:TextBox>
        )
        <asp:Button ID="Button26" runat="server" OnClick="Button26_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblProperty" runat="server" Text="Logarithm expressed with property rules: "></asp:Label>
        <br />
        <br />
        Enter logarithm defined with property rules: <asp:TextBox ID="TextBox94" runat="server" Width="25px"></asp:TextBox>
        log<asp:TextBox ID="TextBox91" runat="server" Width="25px"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox95" runat="server" Width="25px"></asp:TextBox>
        log<asp:TextBox ID="TextBox92" runat="server" Width="25px"></asp:TextBox>
        x -
        <asp:TextBox ID="TextBox96" runat="server" Width="25px"></asp:TextBox>
        log<asp:TextBox ID="TextBox93" runat="server" Width="25px"></asp:TextBox>
        y
        <asp:Button ID="Button27" runat="server" OnClick="Button27_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblRegular" runat="server" Text="Regular and simplified logarithm formulas: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Logarithms (log)"></asp:Label>
        <br />
        Enter base: <asp:TextBox ID="TextBox7" runat="server" Width="25px">10</asp:TextBox>
        <br />
        Enter product:
        <asp:TextBox ID="TextBox8" runat="server" Width="30px"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblExponent" runat="server" Text="Exponent: "></asp:Label>
        <br />
        <asp:Label ID="lblError3" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Image ID="Image32" runat="server" ImageUrl="/Images/Ln.jpg" />
&nbsp;<asp:Image ID="Image33" runat="server" Height="190px" ImageUrl="/Images/NaturalLog.jpg" />
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Natural logarithms (ln)"></asp:Label>
        <br />
        Enter product:
        <asp:TextBox ID="TextBox10" runat="server" Width="30px"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblExponent2" runat="server" Text="Exponent: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Graphs"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Graph formulas"></asp:Label>
        <br />
        <asp:Image ID="Image7" runat="server" ImageUrl="/Images/Midpoint.jpg" Height="140px" />
&nbsp;<asp:Image ID="Image8" runat="server" Height="140px" ImageUrl="/Images/Slope.png" />
&nbsp;<asp:Image ID="Image9" runat="server" Height="140px" ImageUrl="/Images/Distance.png" />
        <br />
        x-coordinate:
        <asp:TextBox ID="txtX1" runat="server" Width="25px"></asp:TextBox>
        ,
        <asp:TextBox ID="txtX2" runat="server" Width="25px"></asp:TextBox>
        <br />
        y-coordinate:
        <asp:TextBox ID="txtY1" runat="server" Width="25px"></asp:TextBox>
        ,
        <asp:TextBox ID="txtY2" runat="server" Width="25px"></asp:TextBox>
        <br />
        y-intercept: <asp:TextBox ID="txtStart" runat="server" Width="25px"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="lblMidpoint" runat="server" Text="Midpoint: "></asp:Label>
        <br />
        <asp:Label ID="lblSlope" runat="server" Text="Slope: "></asp:Label>
        <br />
        <asp:Label ID="lblSlope2" runat="server" Text="Slope-intercept form: "></asp:Label>
        <br />
        <asp:Label ID="lblSlope3" runat="server" Text="Point-slope form: "></asp:Label>
        <br />
        <asp:Label ID="lblDistance" runat="server" Text="Distance: "></asp:Label>
        <br />
        <br />
        <strong>Sample graphs<br />
        </strong>
        <asp:Image ID="Image24" runat="server" ImageUrl="/Images/InverseGraph.png" />
&nbsp;<asp:Image ID="Image25" runat="server" Height="176px" ImageUrl="/Images/AbsGraph.png" />
&nbsp;<asp:Image ID="Image26" runat="server" Height="176px" ImageUrl="/Images/RadicalGraph.png" />
&nbsp;<asp:Image ID="Image27" runat="server" Height="176px" ImageUrl="/Images/SquaredCubed.png" />
&nbsp;<asp:Image ID="Image28" runat="server" Height="176px" ImageUrl="/Images/LogGraph.png" />
        <br />
        <br />
        <strong>Focus and directrix<br />
        </strong>
        <asp:Image ID="Image10" runat="server" ImageUrl="/Images/Focus.jpg" />
        <br />
        Enter function: (x - [h]<asp:TextBox ID="TextBox13" runat="server" Width="25px"></asp:TextBox>
        )^2 = [number]<asp:TextBox ID="TextBox12" runat="server" Width="25px"></asp:TextBox>
        (y - [k]<asp:TextBox ID="TextBox15" runat="server" Width="25px"></asp:TextBox>
        )
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Calculate" />
        <br />
        <asp:Label ID="lblVertex" runat="server" Text="Vertex: "></asp:Label>
        <br />
        <asp:Label ID="lblFocus" runat="server" Text="Focus: "></asp:Label>
        <br />
        <asp:Label ID="lblDirectrix" runat="server" Text="Directrix: "></asp:Label>
        <br />
        <br />
        Enter function: (y - [k]<asp:TextBox ID="TextBox19" runat="server" Width="25px"></asp:TextBox>
        )^2 = [number]<asp:TextBox ID="TextBox20" runat="server" Width="25px"></asp:TextBox>
        (x - [h]<asp:TextBox ID="TextBox21" runat="server" Width="25px"></asp:TextBox>
        )
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Calculate" />
        <br />
        <asp:Label ID="lblVertex2" runat="server" Text="Vertex: "></asp:Label>
        <br />
        <asp:Label ID="lblFocus2" runat="server" Text="Focus: "></asp:Label>
        <br />
        <asp:Label ID="lblDirectrix2" runat="server" Text="Directrix: "></asp:Label>
        <br />
        <br />
        Enter focus: <asp:TextBox ID="TextBox16" runat="server" Width="25px"></asp:TextBox>
&nbsp;,
        <asp:TextBox ID="TextBox17" runat="server" Width="25px"></asp:TextBox>
        <br />
        Enter directrix:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>x</asp:ListItem>
            <asp:ListItem>y</asp:ListItem>
        </asp:DropDownList>
&nbsp;=
        <asp:TextBox ID="TextBox18" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblVertex3" runat="server" Text="Vertex: "></asp:Label>
        <br />
        <asp:Label ID="lblFunction" runat="server" Text="Equation: "></asp:Label>
&nbsp;<br />
        <br />
        <strong>Absolute value<br />
        <asp:Image ID="Image12" runat="server" ImageUrl="/Images/Absolute.png" />
        <br />
        <br />
        </strong>
        <asp:TextBox ID="TextBox22" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>&lt;</asp:ListItem>
            <asp:ListItem>&lt;=</asp:ListItem>
        </asp:DropDownList>
&nbsp;<strong>|</strong> x +
        <asp:TextBox ID="TextBox23" runat="server" Width="25px"></asp:TextBox>
&nbsp;<strong>| </strong>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>&lt;</asp:ListItem>
            <asp:ListItem>&lt;=</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="TextBox24" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblRange" runat="server" Text="Range: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Working with Polynomials/Functions"></asp:Label>
        <br />
        <br />
        <strong>Factoring into polynomial functions<br />
        <asp:Image ID="Image11" runat="server" ImageUrl="/Images/Quadratic.png" />
        <br />
        </strong>In the image above, the -b/2a part of the quadratic formula calculates the x-coordinate of the vertex and the √(b^2 - 4ac) is the discriminant. To calculate the y-coordinate of the vertex, plug the result of the x-coordinate into the function. <br />
        <strong>
        <br />
        <asp:TextBox ID="TextBox26" runat="server" Width="25px"></asp:TextBox>
        </strong>x^2 <strong>+ </strong>
        <asp:TextBox ID="TextBox25" runat="server" Width="25px"></asp:TextBox>
&nbsp;x +
        <asp:TextBox ID="TextBox27" runat="server" Width="25px"></asp:TextBox>
&nbsp;= 0
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblPolynomial3" runat="server" Text="Polynomial function: "></asp:Label>
        <br />
        <asp:Label ID="lblPolynomial" runat="server" Text="Polynomial function's zeros: "></asp:Label>
        <br />
        <asp:Label ID="lblVertex4" runat="server" Text="Vertex: "></asp:Label>
        <br />
        <asp:Label ID="lblDiscriminant" runat="server" Text="Discriminant: "></asp:Label>
        <br />
        <br />
        *2(x^2 + 16) = 0 would be written as 2(x + 4i)(x - 4i), solving for i, where 4i * -4i = -16i^2, and because i^2 = -1, -16i^2 = -16(-1) = 16<br />
        <br />
        <strong>Solve by substitution</strong><br />
        <asp:TextBox ID="TextBox28" runat="server" Width="25px"></asp:TextBox>
        x + y =
        <asp:TextBox ID="TextBox29" runat="server" Width="25px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox30" runat="server" Width="25px"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox31" runat="server" Width="25px"></asp:TextBox>
        y =
        <asp:TextBox ID="TextBox32" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblX" runat="server" Text="X: "></asp:Label>
        <br />
        <asp:Label ID="lblY" runat="server" Text="Y: "></asp:Label>
        <br />
        <br />
        <strong>f o g and g o f<br />
        <br />
        </strong>f(x) =
        <asp:TextBox ID="TextBox116" runat="server" Width="30px"></asp:TextBox>
        x^2 +
        <asp:TextBox ID="TextBox117" runat="server" Width="30px"></asp:TextBox>
        x<br />
        g(x) =
        <asp:TextBox ID="TextBox118" runat="server" Width="30px"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox119" runat="server" Width="30px"></asp:TextBox>
        <strong>
        <br />
        </strong>Enter value:
        <asp:TextBox ID="TextBox120" runat="server" Width="30px"></asp:TextBox>
        <strong>&nbsp;<asp:Button ID="Button35" runat="server" OnClick="Button35_Click" Text="Submit" />
        <br />
        </strong>
        <asp:Label ID="lblFogx" runat="server" Text="(f o g)(x): "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblGofx" runat="server" Text="(g o f)(x): "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblFog3" runat="server" Text="(f o g)(value): "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblGof3" runat="server" Text="(g o f)(value): "></asp:Label>
        <strong>
        <br />
        <br />
        Input-output functions [F(x) and F-1(x)]<br />
        <asp:Image ID="Image15" runat="server" ImageUrl="/Images/EvenOdd.png" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>(<asp:TextBox ID="TextBox37" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox33" runat="server" Width="25px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox40" runat="server" Width="25px"></asp:TextBox>
        )(<asp:TextBox ID="TextBox38" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox39" runat="server" Width="25px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox34" runat="server" Width="25px"></asp:TextBox>
        )<br />
        F(x) =&nbsp;
        <asp:Label ID="Label20" runat="server" Text="________________________________"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<asp:TextBox ID="TextBox41" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox42" runat="server" Width="25px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox35" runat="server" Width="25px"></asp:TextBox>
        )(<asp:TextBox ID="TextBox44" runat="server" Width="25px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox43" runat="server" Width="25px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox36" runat="server" Width="25px"></asp:TextBox>
        )&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Submit" />
        <strong>
        <br />
        <br />
        </strong>
        <asp:Label ID="lblPolynomial2" runat="server" Text="Original function: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblVertical" runat="server" Text="Vertical asymptote(s): "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblHorizontal" runat="server" Text="Horizontal asymptote: "></asp:Label>
        <br />
        <asp:Label ID="lblSlant" runat="server" Text="Slant asymptote: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblHoles" runat="server" Text="Hole(s): "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblXInt" runat="server" Text="x-intercept: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblYInt" runat="server" Text="y-intercepts: "></asp:Label>
        <br />
        <asp:Label ID="lblDomain" runat="server" Text="Domain: "></asp:Label>
        <br />
        <asp:Label ID="lblRanger" runat="server" Text="Range: "></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; x +<strong>
        <asp:TextBox ID="TextBox45" runat="server" Width="25px"></asp:TextBox>
        <br />
        </strong>Enter function [f(x)]: &nbsp;<strong>_______<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>x +<strong>
        <asp:TextBox ID="TextBox46" runat="server" Width="25px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Submit" />
        <br />
        </strong>
        <asp:Label ID="lblInverse" runat="server" Text="F-1(x) [inverse function]: "></asp:Label>
        <strong><br />
        <br />
        Polynomial Division<br />
        <asp:Image ID="Image29" runat="server" Height="220px" ImageUrl="/Images/LongDivision.jpg" />
&nbsp;<asp:Image ID="Image30" runat="server" Height="220px" ImageUrl="/Images/SyntheticDivision.jpg" />
        <br />
        <br />
        <asp:Label ID="Label23" runat="server" Font-Size="Large" ForeColor="Red" Text="Cubic roots"></asp:Label>
        <br />
        </strong>
        <br />
        <span class="nowrap"><sup style="margin-right: -0.5em; vertical-align: 0.8em;">3</sup>√(</span><asp:TextBox ID="TextBox123" runat="server" Width="25px"></asp:TextBox>
        x<strong>^<asp:TextBox ID="TextBox121" runat="server" Width="25px"></asp:TextBox>
        </strong>y^<asp:TextBox ID="TextBox122" runat="server" Width="25px"></asp:TextBox>
        )<strong>
        <asp:Button ID="Button36" runat="server" OnClick="Button36_Click" Text="Reduce" />
        <br />
        </strong>
        <asp:Label ID="lblReduced" runat="server" Text="Reduced form: "></asp:Label>
        <strong>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Font-Size="Large" ForeColor="Red" Text="Vectors"></asp:Label>
        <br />
        <asp:Image ID="Image13" runat="server" ImageUrl="/Images/Vector.png" Height="160px" />
        &nbsp;<asp:Image ID="Image14" runat="server" ImageUrl="/Images/Vector2.png" Height="160px" />
        <br />
        <br />
        </strong>Enter length of vector v in terms of i (adjacent) and j (opposite): <asp:TextBox ID="TextBox47" runat="server" Width="25px"></asp:TextBox>
        i +
        <asp:TextBox ID="TextBox48" runat="server" Width="25px"></asp:TextBox>
        j
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblMagnitude" runat="server" Text="Magnitude: "></asp:Label>
        <br />
        <asp:Label ID="lblCos" runat="server" Text="Cosine angle: "></asp:Label>
        <br />
        <asp:Label ID="lblSin" runat="server" Text="Sine angle: "></asp:Label>
        <br />
        <br />
        Enter location (x, y) of end of vector v:
        <asp:TextBox ID="TextBox49" runat="server" Width="25px"></asp:TextBox>
        ,
        <asp:TextBox ID="TextBox55" runat="server" Width="25px"></asp:TextBox>
        <br />
        Enter location (x, y) of end of vector w:
        <asp:TextBox ID="TextBox50" runat="server" Width="25px"></asp:TextBox>
        ,
        <asp:TextBox ID="TextBox56" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblV" runat="server" Text="Magnitude of v: "></asp:Label>
        <br />
        <asp:Label ID="lblW" runat="server" Text="Magnitude of w: "></asp:Label>
        <br />
        <asp:Label ID="lblCosine" runat="server" Text="Cosine angle: "></asp:Label>
        <br />
        <asp:Label ID="lblSine" runat="server" Text="Sine angle: "></asp:Label>
        <br />
        <br />
        Enter vector v in terms of i and j:
        <asp:TextBox ID="TextBox57" runat="server" Width="25px"></asp:TextBox>
        i +
        <asp:TextBox ID="TextBox58" runat="server" Width="25px"></asp:TextBox>
        j<br />
        Enter vector w in terms of i and j:
        <asp:TextBox ID="TextBox59" runat="server" Width="25px"></asp:TextBox>
        i +
        <asp:TextBox ID="TextBox60" runat="server" Width="25px"></asp:TextBox>
        j
        <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblVW" runat="server" Text="v * w: "></asp:Label>
        <br />
        <asp:Label ID="lblVplusW" runat="server" Text="v + w: "></asp:Label>
        <br />
        <br />
        Enter magnitude, in pounds, of vector F1: 
        <asp:TextBox ID="TextBox51" runat="server" Width="25px"></asp:TextBox>
&nbsp;pounds<br />
        Enter magnitude of vector F2: <asp:TextBox ID="TextBox52" runat="server" Width="25px"></asp:TextBox>
&nbsp;pounds<br />
        Enter direction (like bearing, or angle in degrees, on a compass) of F1:
        <asp:DropDownList ID="DropDownList6" runat="server">
            <asp:ListItem>N</asp:ListItem>
            <asp:ListItem>S</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox53" runat="server" Width="25px"></asp:TextBox>
        <asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem>E</asp:ListItem>
            <asp:ListItem>W</asp:ListItem>
        </asp:DropDownList>
        <br />
        Enter direction of F2: <asp:DropDownList ID="DropDownList18" runat="server">
            <asp:ListItem>N</asp:ListItem>
            <asp:ListItem>S</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox54" runat="server" Width="25px"></asp:TextBox>
        <asp:DropDownList ID="DropDownList19" runat="server">
            <asp:ListItem>E</asp:ListItem>
            <asp:ListItem>W</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="Submit" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="lblF1" runat="server" Text="F1: "></asp:Label>
        <br />
        <asp:Label ID="lblF2" runat="server" Text="F2: "></asp:Label>
        <br />
        <asp:Label ID="lblF" runat="server" Text="F: "></asp:Label>
        <br />
        <asp:Label ID="lblForce" runat="server" Text="Resultant force: "></asp:Label>
        <br />
        <asp:Label ID="lblDirection" runat="server" Text="Direction: "></asp:Label>
&nbsp;<br />
        <strong>
        <br />
        <asp:Label ID="Label21" runat="server" Font-Size="Large" ForeColor="Red" Text="Exponential growth and decay equations"></asp:Label>
&nbsp;<br />
        <asp:Image ID="Image17" runat="server" ImageUrl="/Images/Interest.png" Height="180px" />
&nbsp;<asp:Image ID="Image18" runat="server" Height="180px" ImageUrl="/Images/Radioactive.png" />
&nbsp;<asp:Image ID="Image19" runat="server" ImageUrl="/Images/Cooling.png" Height="180px" />
        <br />
        </strong>For all of the the loan calculations below, be aware that they are calculations for a <span class="auto-style2"><strong>deferred loan</strong></span>. In other words, they are calculators for the earnings/payments and accrued interest of a deferred loan payment plan, where one lump sum is paid at the end of the specified term of years. The loans we are used to, like with home mortgages and auto loans, are <span class="auto-style2"><strong>amortized loans</strong></span>, where fixed payments, or installments, or paid throughout. Don&#39;t confuse the two. For an amortized loan calculator, see the
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Random.aspx">Random</asp:HyperLink><i class="material-icons">open_in_new</i>
&nbsp;page.<strong><br />
        <br />
        </strong>Enter principal or (bacterial / human) population: <asp:TextBox ID="TextBox61" runat="server" Width="55px"></asp:TextBox>
        <br />
        Enter interest rate or (bacterial / human) population growth rate:
        <asp:TextBox ID="TextBox62" runat="server" Width="30px"></asp:TextBox>
        %<br />
        Enter number of years:
        <asp:TextBox ID="TextBox63" runat="server" Width="25px"></asp:TextBox>
        <strong>&nbsp;<asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Submit" />
        <br />
        </strong>
        <asp:Label ID="lblPrincipal" runat="server" Text="Principal after said years: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblContinuous" runat="server" Text="Principal if compounded continuously / bacterial or human population after said time: "></asp:Label>
        <strong>
        <br />
        <br />
        </strong>Enter principal: $<asp:TextBox ID="TextBox64" runat="server" CssClass="auto-style1" Width="55px"></asp:TextBox>
        <br />
        Enter interest rate:
        <asp:TextBox ID="TextBox65" runat="server" Width="35px"></asp:TextBox>
        %<br />
        Enter times compounded per year:
        <asp:TextBox ID="TextBox66" runat="server" Width="25px"></asp:TextBox>
        <br />
        Enter number of years:
        <asp:TextBox ID="TextBox67" runat="server" Width="25px"></asp:TextBox>
        <strong>&nbsp;<asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="Submit" />
        <br />
        </strong>
        <asp:Label ID="lblPrincipal2" runat="server" Text="Principal after said years: "></asp:Label>
        <strong>
        <br />
        <br />
        </strong>Enter milligrams of radioactive substance:
        <asp:TextBox ID="TextBox68" runat="server" Width="30px"></asp:TextBox>
&nbsp;mg<br />
        Enter half-life of the sample: <asp:TextBox ID="TextBox69" runat="server" Width="30px"></asp:TextBox>
&nbsp;years<br />
        Enter # of years of decay:
        <asp:TextBox ID="TextBox70" runat="server" Width="30px"></asp:TextBox>
        <strong>&nbsp;<asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="Submit" />
        <br />
        </strong>
        <asp:Label ID="lblMill" runat="server" Text="Milligrams left after said years: "></asp:Label>
        <strong>
        <br />
        <br />
        </strong>Enter temperature of substance, in Fahrenheit:
        <asp:TextBox ID="TextBox71" runat="server" Width="50px"></asp:TextBox>
        <span class="st">°</span>F<br />
        Enter surrounding temperature, in Fahrenheit:
        <asp:TextBox ID="TextBox72" runat="server" Width="50px"></asp:TextBox>
        <span class="st">°</span>F<br />
        Enter cooling constant: -<asp:TextBox ID="TextBox73" runat="server" Width="50px"></asp:TextBox>
        /second<strong><br />
        </strong>Enter time to cool down:<strong>
        <asp:TextBox ID="TextBox74" runat="server" Width="25px"></asp:TextBox>
&nbsp;</strong>minutes
        <asp:Button ID="Button20" runat="server" OnClick="Button20_Click1" Text="Submit" />
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblFahrenheit" runat="server" Text="Temperature in Fahrenheit after said minutes: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblCelsius" runat="server" Text="Temperature in Celsius after said minutes: "></asp:Label>
        <strong>
        <br />
        </strong>
        <asp:Label ID="lblKelvins" runat="server" Text="Temperature in Kelvins after said minutes: "></asp:Label>
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
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.bundle.js"></script>
    <script src="Scripts/Dashboard.js"></script>
</body>
</html>
