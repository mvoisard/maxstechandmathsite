<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Calculus.aspx.cs" Inherits="WebApplication6.math.Calculus" %>

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
    <link href="data:image/x-icon;base64,AAABAAEAEBAAAAAAAABoBQAAFgAAACgAAAAQAAAAIAAAAAEACAAAAAAAAAEAAAAAAAAAAAAAAAEAAAAAAAAAAAAA/4QAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAAAAAAAAAAAAAAAAEAAQAAAAAAAAAAAAAAAAAAAAEAAAAAAAAAAAABAAAAAAABAAAAAAAAAAAAAAEAAAAAAQABAAEAAAEBAAABAAAAAAEAAQABAAEAAQAAAQAAAAABAAABAAABAAEAAQABAAAAAQABAAEAAAEBAAEAAQAAAAEAAQABAAAAAQABAAEAAAABAAAAAAAAAAEAAAAAAAAAAQAAAAAAAAABAAAAAAAAAAEAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAQABAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAL//AABf/wAA3/cAAN/7AADVmwAA1VsAANtVAADVlQAA1dUAAN/fAADf3wAA3/8AAN//AADX/wAA7/8AAP//AAA=" rel="icon" type="image/x-icon" />
    <title>Calculus | Max's T&M Site</title>
    <link rel="canonical" href="https://maxstechandmathsite.azurewebsites.net/Home"/>
    <link href="/Style/StyleSheet4.css" rel="stylesheet" />
    <link href="/Style/StyleSheet3.css" rel="stylesheet" />
    <link href="/Style/ml-navigation-bar.css" rel="stylesheet" />
</head>
    <script>
        if ('serviceWorker' in navigator) {
          // sw.js can literally be empty, but must exist
          navigator.serviceWorker.register('Scripts/sw.js');
        }
    </script>
<body style="background-image: url(/Images/Background7.jpeg); background-size: cover; width: 100%; font-size:1.5em">
    <form id="form2" runat="server">
    <header><img src="/Images/Logo.PNG"; style="width: 100%" height="300"/>
        <div id="Header">
            <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/Images/Calculus.png" style="padding-bottom:12px" />Calculus
        </div>
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
            <li><a onclick="createCookie('Algebra', 'yes', 0)" href="Algebra.aspx">Algebra</a></li>
            <li><a onclick="createCookie('Trigonometry', 'yes', 0)" href="Trigonometry.aspx">Trigonometry</a></li>
            <li><a onclick="createCookie('Statistics', 'yes', 0)" href="Statistics.aspx">Statistics</a></li>
            <li class="active"><a onclick="createCookie('Calculus', 'yes', 0)" href="Calculus.aspx">Calculus</a></li>
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
     <main>
        <br />
        <div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="font-weight: 700" Text="Basics" class="MobileFont" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        Enter funct<span class="_Tgc">ion:&nbsp;</span><asp:TextBox ID="TextBox18" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox19" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox20" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox21" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;at x =
        <asp:TextBox ID="TextBox17" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Find Limit" Height="35px" />
        <br />
        <asp:Label ID="lblLimit" runat="server" Text="Limit: " class="MobileFont" Font-Bold="True" Font-Size="Medium"></asp:Label>
        <br />
        <asp:Label ID="lblTangent" runat="server" Text="Tangent  line to function: " class="MobileFont" Font-Bold="True" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="/Images/Derivative.png" />
        <br />
        <br />
        Enter function to calculate derivative:&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox2" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox12" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox13" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox10" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Differentiate" Height="35px" />
        &nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red" class="MobileFont"></asp:Label>
        <br />
        <asp:Label ID="lblDerivative" runat="server" Text="First derivative: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="lblDerivative2" runat="server" Text="Second derivative: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="lblDerivative3" runat="server" Text="Third derivative: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <br />
        Enter function to calculate integral:&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox4" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp; +
        <asp:TextBox ID="TextBox14" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox15" runat="server" Width="45px" Height="35px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox11" runat="server" Width="45px" Height="35px"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox16" runat="server" Width="45px" Height="35px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Integrate" Height="35px" />
        &nbsp;<asp:Label ID="lblError2" runat="server" ForeColor="Red" class="MobileFont"></asp:Label>
        <br />
        <asp:Label ID="lblIntegral" runat="server" Text="First integral: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="lblIntegral2" runat="server" Text="Second integral: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="lblIntegral3" runat="server" Text="Third integral: " class="MobileFont" Font-Bold="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Derivatives" class="MobileFont" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Product Rule" ForeColor="#3333CC"></asp:Label>
        <br />
        Enter function: <asp:TextBox ID="TextBox22" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox23" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;*
        <asp:TextBox ID="TextBox24" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox25" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Submit" Height="35px" />
        <br />
        <asp:Label ID="lblMultiply" runat="server" Text="Product rule derivative: " Font-Bold="True" ForeColor="Black" class="MobileFont" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Quotient Rule" Font-Bold="True" Font-Size="X-Large" ForeColor="#3333CC"></asp:Label>
        <strong><br />
        </strong>Enter function:
        <asp:TextBox ID="TextBox26" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox27" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="TextBox28" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox29" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Submit" Height="35px" />
        <br />
        <asp:Label ID="lblQuotient" runat="server" Text="Quotient rule derivative: " Font-Bold="True" ForeColor="Black" class="MobileFont" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Power Rule" Font-Bold="True" Font-Size="X-Large" ForeColor="#3333CC"></asp:Label>
        <strong><br />
        </strong>Enter function: (<asp:TextBox ID="TextBox30" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox31" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;+
        <asp:TextBox ID="TextBox32" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        x^<asp:TextBox ID="TextBox34" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
        )^<asp:TextBox ID="TextBox33" runat="server" Width="45px" ForeColor="Black" Height="35px"></asp:TextBox>
&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Submit" ForeColor="Black" Height="35px" />
        <br />
        <asp:Label ID="lblPower" runat="server" Text="Power rule derivative: " Font-Bold="True" ForeColor="Black" class="MobileFont" Font-Size="Medium"></asp:Label>
        <br />
        <br />
    </main>
    </form>
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
    &nbsp;<a href="https://twitter.com/crownequipment" target="_blank" tabindex="-1"><i><img src="/Images/Twitter.png" alt="/Images/Twitter" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.flickr.com/photos/crownequipment" target="_blank" tabindex="-1"><i><img src="/Images/Instagram.png" alt="/Images/Instagram" width="30" height="30"/></i>
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
</body>
</html>