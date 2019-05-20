<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Statistics.aspx.cs" Inherits="WebApplication6.math.Statistics" %>

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
    <link id="page_favicon" href="data:image/x-icon;base64,R0lGODlhEAAQAPAAAAAAAAAAACH5BAkFAAEAIf8LTkVUU0NBUEUyLjADAQAAACwAAAAAEAAQAAAC5wQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAKAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQEAAAAAAAAAAAAAAAAAAAEBAAAAAAAAAAAAAAADAwABAQAAAAAAAAAAAAAAAwMAAQEAAAAAAAAAAAAAAAMDAAEBAAAAAAAAAAAAAAADAwABAQAFBQAAAAAAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABAIAAAAAAAAAAAAAAAAEAgAAAAAAAAAAAAAAAAQCAAAAAAAAAAAAIDBABAIAAAAAAAAAAAAAAADAwABAQAAAAAAAAAAAAAAAwMAAQEAAAAAAAAAAAAAAAMDAAEBAAAAAAAAAAAAAAADAwABAQAAAAAAAAAAAAAAAwMAAQEABQUAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAwDAAAAAAAAAAAAAAAIDBAAAAAAAAAAAAAAAAgMEAAAAAAAAAAAAAAACAwQAAAAAAAAAAAAAAAIDBABAIAAAAAAAAAAAAAAADAwABAQAAAAAAAAAAAAAAAwMAAQEAAAAAAAQEAAAAAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6jgDAAAAAAAAAGAMAAAAAAAAAAAAwDAAAAAAAAAAAAAAwDAAAAAAAAAAAAAAAIDBAAAAAAAAAAAAAAAAgMEAAAAAAAAAAAAAAACAwQAAAAAAAACAQAAAAIDBAAAAAAAAAAAEBAAAAAADAwAAAAAAAAAABAQAAAAAAwMAAAAAAAAAAAQEAAAAAAMDAAEBAAAAAAAEBAAAAAADAwABAQAAAAAABAQAAAAAAwMAAQEABQUAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAQAAAAIDBAAAAAAAAAIBAAAAAgMEAAAAAAAAAgEAAAACAwQAAAAAAAACAQAAAAIDBAAAAAAAAAAAEBAAAAAADAwABAQAAAAAABAQAAgIAAwMAAQEAAAAAAAQEAAICAAMDAAEBAAAAAAAEBAACAgADAwABAQAAAAAABAQAAgIAAwMAAQEAAAAAAAQEAAICAAMDAAEBAAAAAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAEIAAGAMAAAAAAAQBAAAwDAAAAAAAAAQBAAAwDAAAAAAAACAQAAAAIDBAAAAAAAAAIBAAAAAgMEAAAAAAAAAgEAAAACAwQAQCAAAAACAQAAIBIDBABAIAAAAAAAEBAACAgADAwABAQAAAAAABAQAAgIAAwMAAQEAAAAAAAQEAAICAAMDAAEBAAAAAAAEBAACAgADAwABAQAAAAAABAQAAgIAAwMAAQEABQUAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAEIAAAAAAAAAAAAQBAAAAAAAAAAAAAAQBAAAAAAAQQAAAACAQAAAAAAAABAIAAAAAIBAAAAAAAAAEAgAAAAAgEAAAACAwQAQCAAAAACAQAAAAIDBABAIAAAAAAAEBAAAAAADAwABAQAAAAAABAQAAgIAAwMAAQEAAAAAAAQEAAICAAMDAAEBAAAAAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQBAAAAAAAAAAAAACAQAAAAAAAAAAAAAAAAIBAAAAAAAAAAAAAAAAAgEAAAAAAAAAAAAAAAACAQAAAAAAAABAIAAAAAAAEBAAAAAAAAAABAQAAAAAABAQAAAAAAAAAAQEAAAAAAAQEAAAAAAMDAAEBAAAAAAAEBAAAAAADAwABAQAAAAAABAQAAgIAAwMAAQEAAAAAAAQEAAICAAMDAAEBAAUFAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAAh+QQJBQAGACwAAAAAEAAQAIIAAAAA/w0AhP//AAD/AOb/6gAAAAAAAAAD6ggAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAQAAAAAAAAAAAAAAAAAAEBAAAAAAAAAAAAAAAAAAABAQAAAAAAAAAAAAAAAAAAAQEAAAAAAAAAAEBAAAAAAAEBAAAAAAAAAABAQAAAAAABAQAAAAAAAAAAQEAAAAAAAQEAAAAAAMDAAEBAAAAAAAEBAACAgADAwABAQAFBQAABAQAAgIAAwMAAQEABQUAACBAAIAAAQASAAA7" rel="icon" type="image/x-icon" />
    <link rel="canonical" href="https://maxstechandmathsite.azurewebsites.net/Home"/>
    <title>Statistics | Max's T&M Site</title>
    <link href="/Style/StyleSheet4.css" rel="stylesheet" />
    <link href="/Style/StyleSheet3.css" rel="stylesheet" />
    <link href="/Style/ml-navigation-bar.css" rel="stylesheet" />
</head>
<body style="background-image: url(/Images/OrangeBackground.jpg); background-size: cover">
    <form id="form2" runat="server">
    <img src="/Images/Logo.PNG"; width="1920" height="300"/>
    <div id="Header">
        &nbsp;<asp:Image ID="Image14" runat="server" Height="80px" ImageUrl="~/Images/Statistics2.png" style="padding-bottom:24px" />
        Statistics</div>
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
            <li class="active"><a onclick="createCookie('Statistics', 'yes', 0)" href="Statistics.aspx">Statistics</a></li>
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
        <div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
        <br />
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Data grouping into graphs and charts"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image7" runat="server" ImageUrl="/Images/Pie.jpg" />
        <br />
        <br />
        Categorical data is put into bar graphs and pie charts. Bar graphs are easier to read than pie charts. You mustn&#39;t use pictures for bars, bars must be the same width, and they must start at 0. Pie charts are good for emphasizing a category&#39;s relation to the whole. They must add to 100%. If it doesn&#39;t add to 100%, thenyou must put in &quot;Other&quot; (although you shouldn&#39;t because it doesn&#39;t emphasize category relations to wholes) and bar graphs can only have &quot;Other&quot; for other categories, not quantity ranges, which will be discussed next. Conditional distributions are percentages of a category out of a total, which is the marginal distribution (the total count). Frequency tables show much data there is, whereas relative frequency tables show percentages (hence, bar graphs vs. pie charts and marginal distributions vs. conditional distributions).<br />
        <br />
        <asp:Image ID="Image8" runat="server" Height="150px" ImageUrl="/Images/DotPlot.png" />
&nbsp;<asp:Image ID="Image2" runat="server" Height="150px" ImageUrl="/Images/Stemplot.PNG" />
&nbsp;
        <asp:Image ID="Image9" runat="server" Height="150px" ImageUrl="/Images/Histogram.png" />
        <asp:Image ID="Image10" runat="server" Height="150px" ImageUrl="/Images/Line.png" />
        <br />
        <br />
        Quantitative data uses data structures like dot plots and stem plots (aka stem-and-leaf plots. Dot plots have stacked dots of the counts of each number and stem plots showed the amount of values by multiples of ten. Both are good for small quantities of data, and stem plots can do percentages where the stem is i.e. 11 and the leaf is i.e. 47 for 11.47%. Also are histograms which show the frequency of certain data ranges (width of bars, which all touch, cover the ranges). Line graphs show data over time. All of the graphs, charts, and tables mentioned can be depicted in an x-y fashion of Q* C (quantitative vs. categorical), C * Q, Q * Q, and C * C. All quantitative data has a shape, center, and spread. The shape can be skewed and have peaks, clusters, and gaps. The center is the median and the spread is the range. <br />
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="/Images/Quartiles.PNG" />
&nbsp;&nbsp;<asp:Image ID="Image6" runat="server" Height="220px" ImageUrl="/Images/Variance.PNG" />
        &nbsp;&nbsp;<asp:Image ID="Image13" runat="server" Height="220px" ImageUrl="/Images/Zscore.png" />
        <br />
        <br />
        How many data values will you enter? (30 max)
        &nbsp;<asp:TextBox ID="TextBox65" runat="server" Width="30px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="OK"/>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter the data values:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox11" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox12" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox13" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox14" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox23" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox36" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox37" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox41" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox53" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox54" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox55" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox56" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox57" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox58" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox59" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox60" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox61" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox62" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox63" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox64" runat="server" Width="30px" Visible="false"></asp:TextBox>
        <br />
        Please enter one of the data values from the set so a z-score and percentile can be calculated: <asp:TextBox ID="TextBox19" runat="server" Width="30px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK"/>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="If you have more than 30 data values to enter, please submit a text (.txt) file of the data values using the Browse... button below. It must be a .txt file, it can only contain numbers as characters (i.e. no letters or symbols), and each number must be separated onto a new different line." Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" Width="1974px" />
        Please enter one of the data values from the set so a z-score and percentile can be calculated: <asp:TextBox ID="TextBox66" runat="server" Width="30px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnContents" runat="server" Text="Get Numbers of Text File" OnClick="btnContents_Click" />
        <br />
        <br />
        <asp:Label ID="lblValues" runat="server" Text="# of Values: "></asp:Label>
        <br />
        <asp:Label ID="lblMean" runat="server" Text="Mean: "></asp:Label>
        <br />
        <asp:Label ID="lblMedian" runat="server" Text="Median: "></asp:Label>
        <br />
        <asp:Label ID="lblRange" runat="server" Text="Range: "></asp:Label>
        <br />
        <asp:Label ID="lblIQR" runat="server" Text="IQR (Interquartile Range): "></asp:Label>
        <br />
        <asp:Label ID="lblOutlier" runat="server" Text="Lower and upper outliers: "></asp:Label>
        <br />
        <asp:Label ID="lblVariance" runat="server" Text="Variance: "></asp:Label>
        <br />
        <asp:Label ID="lblSD" runat="server" Text="Standard deviation: "></asp:Label>
        <br />
        <asp:Label ID="lblZScore" runat="server" Text="Z-score of entered value: "></asp:Label>
        <br />
        <asp:Label ID="lblPercentile" runat="server" Text="Percentile of entered value: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Probabilities"></asp:Label>
        <br />
&nbsp;<asp:Image ID="Image3" runat="server" Height="220px" ImageUrl="/Images/Tree.PNG" />
        <br />
        <br />
        Enter number of total values:
        <asp:TextBox ID="TextBox20" runat="server" Width="25px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Are the values being replaced after each draw?"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>
        <br />
        Enter number of first category values: <asp:TextBox ID="TextBox21" runat="server" Width="25px"></asp:TextBox>
        <br />
        Enter number of second category values:
        <asp:TextBox ID="TextBox22" runat="server" Width="25px"></asp:TextBox>
        <br />
        Number of draws:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Submit" />
        &nbsp;<asp:Label ID="lblError4" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblZero" runat="server" Text="Probability of zero drawn in first category: "></asp:Label>
        <br />
        <asp:Label ID="lblOne" runat="server" Text="Probability of one drawn in first category: "></asp:Label>
        <br />
        <asp:Label ID="lblTwo" runat="server" Text="Probability of two drawn in first category: "></asp:Label>
        <br />
        <asp:Label ID="lblThree" runat="server" Text="Probability of three drawn in first category: "></asp:Label>
        <br />
        <asp:Label ID="lblZero1" runat="server" Text="Probability of zero drawn in second category: "></asp:Label>
        <br />
        <asp:Label ID="lblOne1" runat="server" Text="Probability of one drawn in second category: "></asp:Label>
        <br />
        <asp:Label ID="lblTwo1" runat="server" Text="Probability of two drawn in second category: "></asp:Label>
        <br />
        <asp:Label ID="lblThree1" runat="server" Text="Probability of three drawn in second category: "></asp:Label>
        <br />
        <asp:Label ID="lblExpected" runat="server" Text="Expected value of first category: "></asp:Label>
        <br />
        <asp:Label ID="lblExpected1" runat="server" Text="Expected value of second category: "></asp:Label>
        <br />
        <br />
&nbsp;<asp:Image ID="Image5" runat="server" Height="200px" ImageUrl="/Images/PAUB.PNG" />
        <br />
        <br />
        Example: Two dice are rolled. 36 outcomes are possible. The probability of A could be that the number of outcomes where the sum of the two dice is prime.&nbsp; There are 15 such outcomes.&nbsp; The probability of B could be that the product of the two dice is prime.&nbsp; There are 6 such outcomes. The probablity of A intersection of B would be the values where the sum and product of the two dice are both prime.&nbsp; Those rolls would be 1,2 and 2,1 with a sum of 3 and a product of 2; both prime. 2/36. The probablity of A union B is the set containing numbers belonging to either set.&nbsp; For the dice probability this would be 15 plus 6, then subtract the 2 values that are in both. 19/36.<br />
        <asp:Label ID="Label3" runat="server" Text="Enter P(A): "></asp:Label>
        <asp:TextBox ID="TextBox24" runat="server" Width="25px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="/"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox25" runat="server" Width="25px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Enter P(B): "></asp:Label>
        <asp:TextBox ID="TextBox26" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" Text="/"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox27" runat="server" Width="25px"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="lblAnd" runat="server" Text="P (A ∩ B): "></asp:Label>
        <asp:TextBox ID="TextBox28" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Label runat="server" Font-Bold="True" Font-Size="Large" Text="/"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox29" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblOr" runat="server" Text="P(A U B): "></asp:Label>
        <br />
        <asp:Label ID="lblGiven" runat="server" Text="P (A / B): "></asp:Label>
        <br />
        <br />
        <strong>For all values below, only a <span class="auto-style2">maximum of 19</span> is allowed.</strong><br />
        Enter permutation:
        <asp:TextBox ID="txtPerm" runat="server" Width="25px"></asp:TextBox>
&nbsp;values with
        <asp:TextBox ID="txtPerm2" runat="server" Width="25px"></asp:TextBox>
&nbsp;orderly possibilities. <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        &nbsp;<asp:Label ID="lblError6" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblWays" runat="server" Text="Number of different ways: "></asp:Label>
        <br />
        Enter combination: <asp:TextBox ID="txtComb" runat="server" Width="25px"></asp:TextBox>
&nbsp;values with
        <asp:TextBox ID="txtComb2" runat="server" Width="25px"></asp:TextBox>
&nbsp;unorderly possibilities. <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
        &nbsp;<asp:Label ID="lblError5" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblWays2" runat="server" Text="Number of different ways: "></asp:Label>
        <br />
        A committee is to be selected, enter numbers to calculate probability that&nbsp; <span class="auto-style1">  <asp:TextBox ID="TextBox15" runat="server" Width="25px"></asp:TextBox>
        </span>&nbsp;out of the <span class="auto-style1">
        <asp:TextBox ID="TextBox16" runat="server" Width="25px" CssClass="auto-style1"></asp:TextBox>
        &nbsp;boys could be randomly chosen</span> and <span class="auto-style1">
        <asp:TextBox ID="TextBox17" runat="server" Width="25px" CssClass="auto-style1" Font-Bold="False" Font-Underline="False"></asp:TextBox>
        </span>&nbsp;out of <span class="auto-style1">
        <asp:TextBox ID="TextBox18" runat="server" Width="25px" CssClass="auto-style1"></asp:TextBox>
        </span>&nbsp;girls could be randomly chosen. <span class="auto-style1"><asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" CssClass="auto-style1" />
        &nbsp;<asp:Label ID="lblError7" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblProbability" runat="server" Text="Probability: "></asp:Label>
        <br />
        Enter a number of subjects: <asp:TextBox ID="TextBox46" runat="server" Width="20px"></asp:TextBox>
&nbsp;to happen in a certain number of periods:
        <asp:TextBox ID="TextBox47" runat="server" Width="20px"></asp:TextBox>
        , with one more period than subject, so one subject happens across two periods.
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Submit" />
        &nbsp;<asp:Label ID="lblError3" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblDifferent" runat="server" Text="Number of different outcomes: "></asp:Label>
        <br />
        A serial number can have
        <asp:TextBox ID="TextBox48" runat="server" Width="20px"></asp:TextBox>
&nbsp;digits out of
        <asp:TextBox ID="TextBox50" runat="server" Width="20px"></asp:TextBox>
&nbsp;allowed and
        <asp:TextBox ID="TextBox49" runat="server" Width="20px"></asp:TextBox>
&nbsp;letters out of
        <asp:TextBox ID="TextBox51" runat="server" Width="20px"></asp:TextBox>
&nbsp;allowed and none can be repeated.
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Submit" />
        &nbsp;<asp:Label ID="lblError8" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblOutcomes" runat="server" Text="Number of possible outcomes: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Distributions" Font-Size="X-Large"></asp:Label>
        <br />
        <strong>Uniform Distributions<br />
        <asp:Image ID="Image12" runat="server" ImageUrl="/Images/Uniform.png" />
        <br />
        </strong>The chance that a package weighs 11 pounds from 10-18 is (11-10) / (18 - 10) = 1/8. All of the values are the same on a uniform distribution (all chances would be 1/8), unlike triangular distributions and standard distributions, which have peaks and curves.<strong>
        </strong>The chance of weighing between 14 and 15.5 pounds is 1.5 / 8 = 3/16 = .1875.<strong><br />
        <br />
        </strong>Enter endpoints of entire base (i.e. 4, 12):
        <asp:TextBox ID="TextBox34" runat="server" Width="20px"></asp:TextBox>
        ,
        <asp:TextBox ID="TextBox35" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter point where shaded area starts (i.e. 6):
        <asp:TextBox ID="TextBox52" runat="server" Width="25px"></asp:TextBox>
&nbsp;<asp:Label ID="lblError1" runat="server" ForeColor="Red"></asp:Label>
        <br />
        P(X <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>&lt;</asp:ListItem>
            <asp:ListItem>&lt;=</asp:ListItem>
            <asp:ListItem>&gt;</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
&nbsp;x) = [area]
        <asp:TextBox ID="TextBox38" runat="server" Width="20px"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="TextBox45" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Submit" />
&nbsp;<br />
        <asp:Label ID="lblX" runat="server" Text="x: "></asp:Label>
        <br />
        <asp:Label ID="lblShaded" runat="server" Text="Base of shaded area: "></asp:Label>
        <br />
        <br />
        Enter endpoints of entire base (i.e. 0, 8):
        <asp:TextBox ID="TextBox39" runat="server" Width="20px"></asp:TextBox>
        ,
        <asp:TextBox ID="TextBox40" runat="server" Width="20px"></asp:TextBox>
        <br />
        P(X &lt; x or x &lt; X) = [area]
        <asp:TextBox ID="TextBox42" runat="server" Width="20px"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="TextBox43" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Submit" />
&nbsp;<asp:Label ID="lblError2" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lblX2" runat="server" Text="x: "></asp:Label>
        <br />
        <asp:Label ID="lblShaded2" runat="server" Text="Base of shaded area: "></asp:Label>
        <br />
        <br />
        <strong>Triangular Distributions<br />
        </strong>
        <asp:Image ID="Image11" runat="server" ImageUrl="/Images/Triangular.png" />
        <br />
        <br />
        Enter total base of triangle:
        <asp:TextBox ID="TextBox30" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        Enter height of triangle:
        <asp:TextBox ID="TextBox31" runat="server" Width="20px"></asp:TextBox>
        &nbsp;/
        <asp:TextBox ID="TextBox44" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter larger base of largest triangle in triangle: <asp:TextBox ID="TextBox32" runat="server" Width="20px"></asp:TextBox>
        <br />
        Enter smaller base of smallest triangle in triangle:
        <asp:TextBox ID="TextBox33" runat="server" Width="20px"></asp:TextBox>
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Submit" />
        <br />
        <asp:Label ID="lblTotal" runat="server" Text="Total area of triangle: "></asp:Label>
        <br />
        <asp:Label ID="lblMedHeight" runat="server" Text="Height of medium triangle: "></asp:Label>
        <br />
        <asp:Label ID="lblSmallHeight" runat="server" Text="Height of smallest triangle: "></asp:Label>
        <br />
        <asp:Label ID="lblSecond" runat="server" Text="Area of second largest triangle: "></asp:Label>
        <br />
        <asp:Label ID="lblSmallest" runat="server" Text="Area of smallest triangle: "></asp:Label>
        <br />
        <asp:Label ID="lblShade" runat="server" Text="Area of shaded area: "></asp:Label>
        <br />
        <br />
    </div>
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
</body>
</html>