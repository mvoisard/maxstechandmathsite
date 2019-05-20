<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication6.Home" %>

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
        setTimeout(submitForm, 1000);
        // Keeps track of whether or not the form has been submitted.

        gtag('event', 'login', { 'method': 'Google' });
        // Creates a timeout to call submitForm after one second.
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
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script>
      $(function(){
        if (navigator.userAgent.match(/(iPod|iPhone|iPad|Android)/)) {
          $('#ios-notice').removeClass('hidden');
          $('.parallax-container').height( $(window).height() * 0.5 | 0 );
        } else {
          $(window).resize(function(){
            var parallaxHeight = Math.max($(window).height() * 0.7, 200) | 0;
            $('.parallax-container').height(parallaxHeight);
          }).trigger('resize');
        }
      });
    </script>
    <script src="/Scripts/parallax.min.js"></script>
    <script>
      (adsbygoogle = window.adsbygoogle || []).push({
        google_ad_client: "ca-pub-8887116012216502",
        enable_page_level_ads: true
      });
    </script>
    <script type="application/ld+json"> { "@context" : "http://schema.org", "@type" : "SoftwareApplication", "name" : "Max's Technology and Math Website", "image" : "https://maxstechandmathsite.azurewebsites.net/Images/Science.jpg", "url" : "http://maxstechandmathsite.azurewebsites.net", "author" : { "@type" : "Person", "name" : "Max Voisard" }, "datePublished" : "2019-03-05", "publisher" : { "@type" : "Organization", "name" : "max.voisard@gmail.com" }, "applicationCategory" : "STEM", "operatingSystem" : "Windows", "requirements" : "high school/college students seeking an engineering profession, or just anybody interested in the scientific world", "screenshot" : "https://maxstechandmathsite.azurewebsites.net/Home" } </script>
    <title>Home | Max's Tech and Math Site</title>
    <link href="data:image/x-icon;base64,AAABAAEAEBAQAAEABAAoAQAAFgAAACgAAAAQAAAAIAAAAAEABAAAAAAAgAAAAAAAAAAAAAAAEAAAAAAAAAAAAAAAcICCAIqdoQB0tcwAUJu1AKCg8gCT0OYANzfmAOvt0wCx4fIA0tbWABER9QAAAAAAAAAAAAAAAAAAAAAAAzMzMzMzMzADmZmZlESZMAOZmZmURJkwA5mZmZREmTADmYipkUSZMAOZgqmURJkwA5mCqZREmTBTaaqplESWNXU2mZmZmWNXt1NpmZmWNXsLdTaZmWNXsAC3U2mWNXsAAAt1OZNXsAAAALdTNXsAAAAAC3VXsAAAAAAAt3sAAACAAQAAgAEAAIABAACAAQAAgAEAAIABAACAAQAAAAAAAAAAAAAAAAAAgAEAAMADAADgBwAA8A8AAPgfAAD8PwAA" rel="icon" type="image/x-icon" />
    <link rel="stylesheet" href="Style/Stylesheet.css" />
    <link rel="stylesheet" href="Style/fontawesome.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" />
    <link href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Raleway:200,100,400" rel="stylesheet" type="text/css" />
<!--[if lt IE 9]>
<script src="http://html5shim.googlecode.com/svn/trunk/html5.js">
</script>
<![endif]-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta name="keywords" content="STEM Education Math Science Technology Machines Industrial Manufacturing Electronics"/>
    <meta name="description" content="This website offers insights into math, industrial processes & machines, science - from physics to chemistry to biology, and overall, a STEM education."/>
    <meta name="author" content="Max Voisard" />
    <meta name="copyright" content="Max Voisard" />
    <meta name="application-name" content="Max's Tech and Math Site" />
    <meta name="contact" content="max.voisard@gmail.com" />
    <meta name="reply-to" content="max.voisard@gmail.com" />
    <meta name="language" content="English" />
    <meta name="content-language" content="English" />
    <meta name="google-site-verification" content="iO6FPNQGOnq5iAEyBpnsxVJ6Bh1oxZQ4s71s6-vcneE" />
    <meta name="googlebot" content="noodp" />
    <meta name="robots" content="index, follow" />
    <meta name="generator" content="Visual Studio 2017" />
    <meta name="MobileOptimized" content="width" />
    <meta name="HandheldFriendly" content="true" />
    <meta name="mobile-web-app-capable" content="yes" />
    <meta name="msapplication-TileColor" content="#ffffff" />
    <meta name="msapplication-TileImage" content="favicon.ico" />
    <meta name="theme-color" content="#7CFC00" />
    <meta name="thumbnail" content="favicon.ico" />
    <meta property="fb:app_id" content="108355726669362" />
    <meta property="og:locale" content="en_US" />
    <meta property="og:url" content="http://maxstechandmathsite.azurewebsites.net/Home" />
    <meta property="og:type" content="website" />
    <meta property="og:title" content="Home" />
    <meta property="og:description" content="A website with education on technology, science, and math." />
    <meta property="og:image" content="Images/Wrench.png" />
    <meta property="og:site_name" content="Max's Tech And Math Site" />
    <meta property="og:email" content="max.voisard@gmail.com"/>
    <meta property="og:phone_number" content="937-638-4972"/>
    <meta property="og:street-address" content="11383 Marshall Rd"/>
    <meta property="og:locality" content="Versailles"/>
    <meta property="og:region" content="OH"/>
    <meta property="og:postal-code" content="45380"/>
    <meta name="twitter:card" content="summary_large_image" />
    <meta name="twitter:description" content="A website with education on technology, science, and math." />
    <meta name="twitter:title" content="STEM" />
    <meta name="twitter:image" content="Images/favicon.ico" />
    <meta http-equiv="Content-Type" content="text/html;charset=UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta http-equiv="Set-Cookie" content="SessionID=38afes7a8; Expires=Tue, 31 Dec 2019 11:59:59 GMT; Secure; HttpOnly; Path=/" />
    <meta http-equiv="content-disposition" content="inline; filename=Complete Business Guide.docx" />
    <meta http-equiv="Cache-control" content="public" />
    <meta http-equiv="Cache-control" content="max-age=3600" />
    <meta http-equiv="page-enter" content="revealtrans(duration=3.0,transition=1)" />
    <meta http-equiv="page-exit" content="revealtrans(duration=3.0,transition=1)" />
</head>
<body style="background: url(Images/BackgroundImage.jpg) no-repeat center center fixed; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: 110% 110%">
    <!-- Google Tag Manager (noscript) -->
    <noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-N5KXG2Z"
    height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
    <!-- End Google Tag Manager (noscript) -->
	<div id="wrapper">
	<header><h1 style="background-image: url(Images/sunset.jpg)">Max's Technology and Math Website</h1></header>
    <!-- prefix free to deal with vendor prefixes -->
    <script src="http://thecodeplayer.com/uploads/js/prefixfree-1.0.7.js" type="text/javascript"></script>
    <script>
        $(document).ready(function(){
	    $("#accordian h3").click(function(){
		    //slide up all the link lists
		    $("#accordian ul ul").slideUp();
		    //slide down the link list below the h3 clicked - only if its closed
		    if(!$(this).next().is(":visible"))
		    {
			    $(this).next().slideDown();
		    }
	    })
    })
    </script>
    <nav>
        <div id="accordian">
	    <ul>
            <li><h3 class="active"><img src="Images/home-icon-dark.png" style="height: 22px" /> Home</h3></li>
            <li><a href="About.aspx" style="text-decoration: none"><h3><img src="Images/AboutIcon.png" style="height: 22px" /> About</h3></a></li>
		    <li>
			    <h3><img src="Images/Technology2.png" style="height: 22px" /> Tech <img src="Images/down-arrow.png" style="height: 22px" /></h3>
			    <ul>
				    <li><a href="technology/Manufacturing.aspx">Manufacturing</a></li>
				    <li><a href="technology/machines/Big Machines.aspx">Big Machines</a></li>
				    <li><a href="technology/machines/Small Machines.aspx">Small Machines</a></li>
				    <li><a href="technology/Electronics.aspx">Electronics</a></li>
                    <li><a href="technology/Tools.aspx">Tools</a></li>
			    </ul>
		    </li>
		    <!-- we will keep this LI open by default -->
		    <li>
			    <h3><img src="Images/Science.png" style="height: 22px" /> Science <img src="Images/down-arrow.png" style="height: 22px" /></h3>
			    <ul>
				    <li><a href="science/Physics.aspx">Physics</a></li>
				    <li><a href="science/Chemistry.aspx">Chemistry</a></li>
				    <li><a href="science/Biology.aspx">Biology</a></li>
			    </ul>
		    </li>
		    <li>
			    <h3><img src="Images/MathIcon.png" style="height: 22px" /> Math <img src="Images/down-arrow.png" style="height: 22px" /></h3>
			    <ul>
				    <li><a href="math/Geometry.aspx">Geometry</a></li>
				    <li><a href="math/Algebra.aspx">Algebra</a></li>
				    <li><a href="math/Trigonometry.aspx">Trigonometry</a></li>
				    <li><a href="math/Statistics.aspx">Statistics</a></li>
				    <li><a href="math/Calculus.aspx">Calculus</a></li>
			    </ul>
		    </li>
            <li><a href="Random.aspx" style="text-decoration: none"><h3><img src="Images/Random.png" style="height: 22px" /> Random</h3></a></li>
            <li><a href="Blog.html" style="text-decoration: none"><h3><img src="Images/Blog.gif" style="height: 22px" /> Blog</h3></a></li>
            <li><a href="Contact.aspx" style="text-decoration: none"><h3><img src="Images/ContactIcon.png" style="height: 22px" /> Contact</h3></a></li>
		    <li>
			    <h3><img src="Images/Other.png" style="height: 22px" /> Other <img src="Images/down-arrow.png" style="height: 22px" /></h3>
			    <ul>
				    <li><a href="PrivacyPolicy.html">Privacy Policy</a></li>
				    <li><a href="TermsOfService">Terms Of Service</a></li>
				    <li><a href="Help.html">Help</a></li>
				    <li><a href="Sitemap.html">Sitemap</a></li>
			    </ul>
		    </li>
	    </ul>
    </div>
    </nav>
<!-- #region Jssor Slider Begin -->
<!-- Generator: Jssor Slider Maker -->
<script src="Scripts/jssor.slider-27.5.0.min.js" type="text/javascript"></script>
<script type="text/javascript">
    jssor_1_slider_init = function() {

        var jssor_1_SlideoTransitions = [
          [{b:0,d:1000,x:890,y:10}],
          [{b:1000,d:1000,x:890,y:40}],
          [{b:0,d:1000,x:543,y:90}],
          [{b:0,d:1000,x: 512,y:33}],
          [{b:0,d:1000,x:517,y:35}],
          [{b:0,d:1000,x:-50,y:223}],
          [{b:-1,d:1,rX:350,e:{rX:7}},{b:0,d:1000,x:-502,y:-33}],
          [{b:0,d:1000,x:-500,y:-33}],
          [{b:0,d:1000,x:-90,y:-305}],
          [{b:0,d:1000,x:-92,y:-300}]
        ];

        var jssor_1_options = {
          $AutoPlay: 1,
          $CaptionSliderOptions: {
            $Class: $JssorCaptionSlideo$,
            $Transitions: jssor_1_SlideoTransitions
          },
          $ArrowNavigatorOptions: {
            $Class: $JssorArrowNavigator$
          },
          $BulletNavigatorOptions: {
            $Class: $JssorBulletNavigator$
          },
          $ThumbnailNavigatorOptions: {
            $Class: $JssorThumbnailNavigator$,
            $Orientation: 2
          }
        };

        var jssor_1_slider = new $JssorSlider$("jssor_1", jssor_1_options);

        /*#region responsive code begin*/

        var MAX_WIDTH = 858;

        function ScaleSlider() {
            var containerElement = jssor_1_slider.$Elmt.parentNode;
            var containerWidth = containerElement.clientWidth;

            if (containerWidth) {
                var expectedWidth = Math.min(MAX_WIDTH || containerWidth, containerWidth);
                jssor_1_slider.$ScaleWidth(expectedWidth);
            }
            else {
                window.setTimeout(ScaleSlider, 30);
            }
        }

        ScaleSlider();

        $Jssor$.$AddEvent(window, "load", ScaleSlider);
        $Jssor$.$AddEvent(window, "resize", ScaleSlider);
        $Jssor$.$AddEvent(window, "orientationchange", ScaleSlider);
        /*#endregion responsive code end*/
    };
</script>
    <main>
    <script>
        var TxtRotate = function(el, toRotate, period) {
          this.toRotate = toRotate;
          this.el = el;
          this.loopNum = 0;
          this.period = parseInt(period, 10) || 2000;
          this.txt = '';
          this.tick();
          this.isDeleting = false;
        };

        TxtRotate.prototype.tick = function() {
          var i = this.loopNum % this.toRotate.length;
          var fullTxt = this.toRotate[i];

          if (this.isDeleting) {
            this.txt = fullTxt.substring(0, this.txt.length - 1);
          } else {
            this.txt = fullTxt.substring(0, this.txt.length + 1);
          }

          this.el.innerHTML = '<span class="wrap">'+this.txt+'</span>';

          var that = this;
          var delta = 300 - Math.random() * 100;

          if (this.isDeleting) { delta /= 2; }

          if (!this.isDeleting && this.txt === fullTxt) {
            delta = this.period;
            this.isDeleting = true;
          } else if (this.isDeleting && this.txt === '') {
            this.isDeleting = false;
            this.loopNum++;
            delta = 500;
          }

          setTimeout(function() {
            that.tick();
          }, delta);
        };

        window.onload = function() {
          var elements = document.getElementsByClassName('txt-rotate');
          for (var i=0; i<elements.length; i++) {
            var toRotate = elements[i].getAttribute('data-rotate');
            var period = elements[i].getAttribute('data-period');
            if (toRotate) {
              new TxtRotate(elements[i], JSON.parse(toRotate), period);
            }
          }
          // INJECT CSS
          var css = document.createElement("style");
          css.type = "text/css";
          css.innerHTML = ".txt-rotate > .wrap { border-right: 0.08em solid #666 }";
          document.body.appendChild(css);
        };
    </script>
    <div id="app">
        Your Home for
          <span
             class="txt-rotate"
             data-period="2000"
             data-rotate='[ "Science", "Technology", "Engineering", "Math", "STEM!" ]'>
          </span>
    </div>
    <div id="jssor_1" style="position:relative;margin-right:20px;top:0px;left:0px;width:858px;height:380px;overflow:hidden;visibility:hidden;">
    <!-- Loading Screen -->
    <div data-u="loading" class="jssorl-004-double-tail-spin" style="position:absolute;top:0px;left:0px;text-align:center;background-color:rgba(0,0,0,0.7);">
        <img style="margin-top:-19px;position:relative;top:50%;width:38px;height:38px;" src="/Images/double-tail-spin.svg" />
    </div>
    <div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:858px;height:380px;overflow:hidden;">
        <div>
            <img data-u="image" src="/Images/STEM.png" />
            <div data-t="0" style="position:absolute;top:19px;left:-204px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; font-weight: 900; font-size: 1em">Learn STEM<br />
                </div>
            </div>
            <div data-t="1" style="position:absolute;top:62px;left:-206px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; font-weight: 900; font-size: 1em">Quickly</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/science-s96x48.jpg" />
                <span class="ti">Science and Math</span><br />
                <span class="d">Mapping of site</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/industrialmachinery.jpg" />
            <div data-t="2" style="position:absolute;top:21px;left:-212px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; background-color: #ff3300">By Learning about Industrial Machines</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/industrialmachinery-s96x48.jpg" />
                <span class="ti">Industrial Machines</span><br />
                <span class="d">Learn manufacturing</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/electronics.jpg" />
            <img data-t="3" style="position:absolute;top:4px;left:-156px;width:114px;height:66px;max-width:114px;" src="/Images/light-bulb.png" />
            <div data-t="4" style="position:absolute;top:75px;left:-203px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; background-color: #ff3300">Electronics</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/electronics-s96x48.jpg" />
                <span class="ti">Electronics</span><br />
                <span class="d">Learn electricity</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/Algebra.jpg" />
            <div data-t="5" style="position:absolute;top:-47px;left:408px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; background-color: #ff3300">Algebra</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/algebra-s96x48.jpg" />
                <span class="ti">Algebra</span><br />
                <span class="d">Learn functions</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/trigonometry.png" />
            <img data-t="6" style="position:absolute;top:42px;left:989px;width:74px;height:66px;max-width:74px;" src="/Images/trig.png" />
            <div data-t="7" style="position:absolute;top:55px;left:1063px;width:225px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; background-color: #ff3300">Trigonometry</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/trigonometry-s96x48.png" />
                <span class="ti">Trigonometry</span><br />
                <span class="d">Measure triangles</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/statistics.jpg" />
            <img data-t="8" style="position:absolute;top:398px;left:410px;width:68px;height:82px;max-width:68px;" src="/Images/statistics.png" />
            <div data-t="9" style="position:absolute;top:420px;left:489px;width:200px;height:40px;font-size:32px;color:#000000;line-height:1.2;text-align:center;">
                <div style="color: #000099; background-color: #ffff66">Statistics</div>
            </div>
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/statistics-s96x48.jpg" />
                <span class="ti">Statistics</span><br />
                <span class="d">Learn data mining</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/physics.png" />
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/physics-s96x48.png" />
                <span class="ti">Physics</span><br />
                <span class="d">Learn Physics</span>
            </div>
        </div>
        <div>
            <img data-u="image" src="/Images/chemistry.jpg" />
            <div data-u="thumb">
                <img data-u="thumb" class="i" src="/Images/chemistry-s96x48.jpg" />
                <span class="ti">Chemistry</span><br />
                <span class="d">Learn Chemistry</span>
            </div>
        </div>
    </div>
    <!-- Thumbnail Navigator -->
    <div data-u="thumbnavigator" class="jssort121" style="position:absolute;left:0px;top:0px;width:268px;height:380px;overflow:hidden;cursor:default;" data-autocenter="2" data-scale-left="0.75">
        <div data-u="slides">
            <div data-u="prototype" class="p" style="width:268px;height:68px;">
                <div data-u="thumbnailtemplate" class="t"></div>
            </div>
        </div>
    </div>
    <!-- Bullet Navigator -->
    <div data-u="navigator" class="jssorb108" style="position:absolute;bottom:12px;right:12px;" data-autocenter="1" data-scale="0.5" data-scale-bottom="0.75">
        <div data-u="prototype" class="i" style="width:16px;height:16px;">
            <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
                <circle class="b" cx="8000" cy="8000" r="5800"></circle>
            </svg>
        </div>
    </div>
    <!-- Arrow Navigator -->
    <div data-u="arrowleft" class="jssora112" style="width:55px;height:55px;top:0px;left:25px;" data-autocenter="2" data-scale="0.75" data-scale-left="0.75">
        <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
            <path class="a" d="M4576,7719.7l5678-5677.8c81.3-81.2,174.8-121.9,280.3-121.9c105.6,0,199,40.8,280.3,121.9 l609.1,609.2c81.3,81.2,121.8,174.5,121.8,280.3c0,105.8-40.5,199-121.8,280.3L6635.2,8000.1l4788.4,4788.5 c81.3,81.2,121.8,174.7,121.8,280.1c0,105.7-40.5,199.2-121.8,280.4l-609.2,609c-81.2,81.3-174.7,121.8-280.3,121.8 c-105.5,0-199-40.6-280.3-121.8L4576.3,8280.4c-81.2-81.2-121.8-174.7-121.8-280.3C4454.5,7894.5,4494.8,7801.1,4576,7719.7z"></path>
        </svg>
    </div>
    <div data-u="arrowright" class="jssora112" style="width:55px;height:55px;top:0px;right:25px;" data-autocenter="2" data-scale="0.75" data-scale-right="0.75">
        <svg viewbox="0 0 16000 16000" style="position:absolute;top:0;left:0;width:100%;height:100%;">
            <path class="a" d="M11424,7719.7L5746,2041.9c-81.3-81.2-174.8-121.9-280.3-121.9c-105.6,0-199,40.8-280.3,121.9 l-609.1,609.2c-81.3,81.2-121.8,174.5-121.8,280.3c0,105.8,40.5,199,121.8,280.3l4788.4,4788.4l-4788.4,4788.5 c-81.3,81.2-121.8,174.7-121.8,280.1c0,105.7,40.5,199.2,121.8,280.4l609.2,609c81.2,81.3,174.7,121.8,280.3,121.8 c105.5,0,199-40.6,280.3-121.8l5677.7-5677.8c81.2-81.2,121.8-174.7,121.8-280.3C11545.5,7894.5,11505.2,7801.1,11424,7719.7z"></path>
        </svg>
    </div>
</div>
<script type="text/javascript">jssor_1_slider_init();</script>
<!-- #endregion Jssor Slider End -->
	<div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
    <iframe id="STEMmotivation" width="856" height="300" src="https://www.youtube.com/embed/zgB-Diy8imo?rel=0?version=3&autoplay=1&loop=1" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" style="border: solid 1px #37474F" allowfullscreen></iframe>
        <br />
    <script>
        $(window).scroll(function () {
    $('.animation-test').each(function () {
        var imagePos = $(this).offset().top;
        var imageHeight = $(this).height();
        var topOfWindow = $(window).scrollTop();

        if (imagePos < topOfWindow + imageHeight && imagePos + imageHeight > topOfWindow) {
            $(this).addClass("slideRight");
        } else {
            $(this).removeClass("slideRight");
        }
    });
});
    </script>
<div class="parallax" id="trans1">
  <div class="txt right">
    &#9874;Technology&#9874;
  </div>
  <div style="clear:both;"></div>
  <div class="txt right sub">
    Building Solutions Builds Character<br/>
    But They Always Come From Good Design
  </div>
</div>
<div class="content">
  <img style="float:right;margin-top:10px;margin-right:15px;" src="/Images/Technology.png" alt="Technology"/>
  <h2>TECHNOLOGY</h2>
  <p>Learn about the production/assembly processes and functions of many common technological products, ranging from industrial machines to electronics to handheld tools. Manufacturing processes cover the common techniques used to create products like casting, machining, and pressing. Machines are mostly industrial and include lathes, mills, saws, and broaching machines. Electronics include capacitors, resistors, and transformers, and finally, there are widgets like hammers, screwdrivers, and wrenches for tools - all of these items are explored in depth on how they are made and how they function.</p>
  <div class="animation-test element-to-hide">
      <div class="container">
          <div class="gallery">
            <div class="Container"><a class="gallery-item" href="technology/Manufacturing.aspx"><img src="Images/Manufacturing.jpg" title="Manufacturing" alt="Manufacturing" /><div class="centered" style="color: white">MANUFACTURING</div><span class="text-wrapper"><span class="name">Manufacturing</span><span class="title">Learn industrial processes</span></span></a></div>
            <div class="Container"><a class="gallery-item" href="technology/machines/Big Machines.aspx"><img src="Images/BigMachine.jpg" title="Big Machines" alt="Big Machines" /><div class="centered" style="color: white">BIG MACHINES</div><span class="text-wrapper"><span class="name">Big Machines</span><span class="title">Make gargantuan apparatuses</span></span></a></div>
            <div class="Container"><a class="gallery-item" href="technology/machines/Small Machines.aspx"><img src="Images/LittleMachine.jpg" title="Small Machines" alt="Small Machines" /><div class="centered" style="color: white">SMALL MACHINES</div><span class="text-wrapper"><span class="name">Small Machines</span><span class="title">Make smaller appliances</span></span></a></div>
            <br />
            <div class="Container"><a class="gallery-item2" href="technology/Electronics.aspx"><img src="Images/Electronics2.jpg" title="Electronics" alt="Electronics" /><div class="centered" style="color: white">ELECTRONICS</div><span class="text-wrapper2"><span class="name">Electronics</span><span class="title">Learn electricity</span></span></a></div>
            <div class="Container"><a class="gallery-item2" href="technology/Tools.aspx"><img src="Images/Tools.jpg" title="Tools" alt="Tools" /><div class="centered" style="color: white">TOOLS</div><span class="text-wrapper2"><span class="name">Tools</span><span class="title">Make handheld tools</span></span></a></div>
            <br />
          </div>
       </div>
   </div>
</div>
<div class="parallax" id="trans2">
  <div class="txt left">
    &#215;Mathematics&#247;
  </div>
  <div style="clear:both;"></div>
  <div class="txt left sub">
    The Propelling Engine of... 
    <br />Measuring & Logistics
  </div>
</div>
<!--<div class="Container">
  <div class="centered">Centered</div>
</div>-->
<div class="content right">
  <img style="float:left;margin-top:10px;margin-left:15px;width:322px;height:250px;" src="/Images/Abacus.jpg" alt="Abacus"/>
  <h2>MATHEMATICS</h2>
  <p>Make calculating mathematical formulas and equations second nature from our in-depth analysis of the subjects of geometry, algebra, trigonometry, statistics, and calculus. Geometry covers measurement of all shapes from triangles to rectangles to polygons. The algebra section includes education on logarithms, functions, and exponential growth. Trigonometry calculates angle measures, side lengths, and formulas like product-to-sum formulas. Statistics covers data measures like charts and graphs, probabilities, and distributions, and finally is the Calculus section, which goes over entities like derivatives, integrals, and differentials.</p>
  <div class="animation-test element-to-hide">
      <div class="container2">
          <div class="gallery">
            <div class="Container"><a class="gallery-item" href="math/Geometry.aspx"><img src="Images/Geometry2.jpg" title="Geometry" alt="Geometry" /><div class="centered">GEOMETRY</div><span class="text-wrapper"><span class="name">Geometry</span><span class="title">Learn measuring of shapes</span></span></a></div>
            <div class="Container"><a class="gallery-item" href="math/Algebra.aspx"><img src="Images/Algebra2.png" title="Algebra" alt="Algebra" /><div class="centered">ALGEBRA</div><span class="text-wrapper"><span class="name">Algebra</span><span class="title">Learn functions and expressions</span></span></a></div>
            <div class="Container"><a class="gallery-item" href="math/Trigonometry.aspx"><img src="Images/Trigonometry2.png" title="Trigonometry" alt="Trigonometry" /><div class="centered">TRIGONOMETRY</div><span class="text-wrapper"><span class="name">Trigonometry</span><span class="title">Learn measuring of triangles</span></span></a></div>
            <br />
            <div class="Container"><a class="gallery-item2" href="math/Statistics.aspx"><img src="Images/Statistics2.jpg" title="Statistics" alt="Statistics" /><div class="centered">STATISTICS</div><span class="text-wrapper2"><span class="name">Statistics</span><span class="title">Learn probabilities and distributions</span></span></a></div>
            <div class="Container"><a class="gallery-item2" href="math/Calculus.aspx"><img src="Images/Calculus2.jpg" title="Calculus" alt="Calculus" /><div class="centered">CALCULUS</div><span class="text-wrapper2"><span class="name">Calculus</span><span class="title">Learn derivatives and integrals</span></span></a></div>
            <br />
          </div>
       </div>
  </div>
</div>
<div class="parallax" id="trans3">
  <div class="txt left">
    Science
  </div>
  <div style="clear:both;"></div>
  <div class="txt left sub">
    The science of today is<br />
    the technology of tomorrow.
  </div>
</div>

<div class="content">
  <img style="float:right;margin-top:10px;margin-right:15px;" src="/Images/Atom.png" alt="Atom"/>
  <h2>SCIENCE</h2>
  <p>Gain knowledge on the systematic structure of the physical and natural world and its interactivity with us through the subjects of physics, chemistry, and biology. The Physics section entails a multitude of formulas, including ones for velocity, momentum, and energy. Chemistry doesn't only cover equations for chemical reactions, like with molarity, reaction rates, and thermochemistry, but  also goes in detail with how chemicals are extracted and processed. Biology goes over the basics like cells, genes, and DNA, but also goes over how biological agents are obtained and produced and has calculators for the Punnett Square, photon energy, and the Hardy-Weinberg equation.</p>
  <div class="animation-test element-to-hide">
      <div class="container">
          <div class="gallery">
            <div class="Container"><a class="gallery-item" style="margin: 0" href="science/Physics.aspx"><img src="Images/Physics2.jpg" title="Physics" alt="Physics" /><div class="centered" style="color: red">PHYSICS</div><span class="text-wrapper"><span class="name">Physics</span><span class="title">Learn science of motion</span></span></a></div>
            <div class="Container"><a class="gallery-item" style="margin: 0" href="science/Chemistry.aspx"><img src="Images/Chemistry2.jpg" title="Chemistry" alt="Chemistry" /><div class="centered" style="color: red">CHEMISTRY</div><span class="text-wrapper"><span class="name">Chemistry</span><span class="title">Learn science of matter</span></span></a></div>
            <div class="Container"><a class="gallery-item" style="margin: 0" href="science/Biology.aspx"><img src="Images/Biology.jpg" title="Biology" alt="Biology" /><div class="centered" style="color: red">BIOLOGY</div><span class="text-wrapper"><span class="name">Biology</span><span class="title">Learn science of life</span></span></a></div>
          </div>
      </div>
  </div>
</div>
  <div style="clear:both;"></div>
        <script>
        var a = 0;
            $(window).scroll(function () {
                var oTop = $('#counter').offset().top - window.innerHeight;
                if (a == 0 && $(window).scrollTop() > oTop) {
                    (function ($) {
                        $.fn.countTo = function (options) {
                            options = options || {};

                            return $(this).each(function () {
                                // set options for current element
                                var settings = $.extend({}, $.fn.countTo.defaults, {
                                    from: $(this).data('from'),
                                    to: $(this).data('to'),
                                    speed: $(this).data('speed'),
                                    refreshInterval: $(this).data('refresh-interval'),
                                    decimals: $(this).data('decimals')
                                }, options);

                                // how many times to update the value, and how much to increment the value on each update
                                var loops = Math.ceil(settings.speed / settings.refreshInterval),
                                    increment = (settings.to - settings.from) / loops;

                                // references & variables that will change with each update
                                var self = this,
                                    $self = $(this),
                                    loopCount = 0,
                                    value = settings.from,
                                    data = $self.data('countTo') || {};

                                $self.data('countTo', data);

                                // if an existing interval can be found, clear it first
                                if (data.interval) {
                                    clearInterval(data.interval);
                                }
                                data.interval = setInterval(updateTimer, settings.refreshInterval);

                                // initialize the element with the starting value
                                render(value);

                                function updateTimer() {
                                    value += increment;
                                    loopCount++;

                                    render(value);

                                    if (typeof (settings.onUpdate) == 'function') {
                                        settings.onUpdate.call(self, value);
                                    }

                                    if (loopCount >= loops) {
                                        // remove the interval
                                        $self.removeData('countTo');
                                        clearInterval(data.interval);
                                        value = settings.to;

                                        if (typeof (settings.onComplete) == 'function') {
                                            settings.onComplete.call(self, value);
                                        }
                                    }
                                }

                                function render(value) {
                                    var formattedValue = settings.formatter.call(self, value, settings);
                                    $self.html(formattedValue);
                                }
                            });
                        };

                        $.fn.countTo.defaults = {
                            from: 0,               // the number the element should start at
                            to: 0,                 // the number the element should end at
                            speed: 1000,           // how long it should take to count between the target numbers
                            refreshInterval: 100,  // how often the element should be updated
                            decimals: 0,           // the number of decimal places to show
                            formatter: formatter,  // handler for formatting the value before rendering
                            onUpdate: null,        // callback method for every time the element is updated
                            onComplete: null       // callback method for when the element finishes updating
                        };

                        function formatter(value, settings) {
                            return value.toFixed(settings.decimals);
                        }
                    }(jQuery));

                    jQuery(function ($) {
                        // custom formatting example
                        $('.count-number').data('countToOptions', {
                            formatter: function (value, options) {
                                return value.toFixed(options.decimals).replace(/\B(?=(?:\d{3})+(?!\d))/g, ',');
                            }
                        });

                        // start all the timers
                        $('.timer').each(count);

                        function count(options) {
                            var $this = $(this);
                            options = $.extend({}, options || {}, $this.data('countToOptions') || {});
                            $this.countTo(options);
                        }
                    });
                    a = 1;
                }
            });
        </script>
        <div id="counter">
            <div class="wrapper">
                <div class="counter col_fourth">
                  <img class="fa-2x2" src="Images/Calculator.png" style="height: 40px; width: 40px"/>
                  <h2 class="timer count-title count-number" data-to="150" data-speed="3000"></h2>
                   <p class="count-text ">Different Calculators</p>
                </div>

                <div class="counter col_fourth">
                  <img class="fa-2x2" src="Images/Image.png" style="height: 40px; width: 40px"/>
                  <h2 class="timer count-title count-number" data-to="300" data-speed="3000"></h2>
                  <p class="count-text ">Supportive Images</p>
                </div>

                <div class="counter col_fourth">
                  <img class="fa-2x2" src="Images/Caption.png" style="height: 40px; width: 40px"/>
                  <h2 class="timer count-title count-number" data-to="100" data-speed="3000"></h2>
                  <p class="count-text ">Informative Captions</p>
                </div>

                <div class="counter col_fourth end">
                  <img class="fa-2x2" src="Images/Sections.png" style="height: 40px; width: 40px"/>
                  <h2 class="timer count-title count-number" data-to="13" data-speed="3000"></h2>
                  <p class="count-text ">Sections of Education</p>
                </div>
            </div>
        </div>
        <h2>Brief Overview of this Website</h2>
	<dl>
		<dt>What is this website about?</dt>
		<dd>This website is about the different principles, functions, and procedures of STEM (Science Technology Engineering Math). First is science, which explores the concrete subjects of physics, chemistry, and biology - calculators are available for different formulas/equations and a more in-depth view of how certain chemicals and biological agents are extracted and processed into products. Technology/engineering is divided into the tiers of manufacturing, machines - both big and small, electronics, tools, and even physics - with more calculators to be used for various engineering formulas and functions, and a close look into the production process of a wide range of common products. Finally, math has the categories of geometry, algebra, trigonometry, statistics, and calculus, with yet more calculators to help ease and expedite the solving of expressions and problems and captions of information to go along with each calculator of whatever math concept is being taught. As a plus, this site even has a unique and interesting section called "Random", with a whole page dedicated to miscellaneous useful tools and modules that also help advance people in everyday life, like an events calendar, for example.</dd>
		<dt>What is the purpose of this site?</dt>
		<dd>The motive and objective of this site is to educate its users as much as possible for applications into the real world, particularly from a STEM point-of-view. It is also a goal to help aid any time-constrained students and employees, as this site can be considered an encyclopedia/guide with a plethora of chapters, resources, and tools that automate and expedite the processes of STEM-related calculations and learning. And remember, if you&#39;re ever stuck or confused about a certain STEM concept, you can easily access and search for its definition and application in this site like it is also a dictionary.</dd>
		<dt>What should I get out of this website?</dt>
		<dd>You will learn a range of topics from the information presented. From being a studious high school or college student to an active jobholder, the information and tools given to you in this site will help you excel in your studies or employment through the knowledge you inhale. For those pursuing scientific/engineering jobs, you are encouraged to fully navigate this site and actuate the objectives learned into the real world, making a solid difference.</dd>
	</dl>
    </main>
    <footer class="flex-rw">
        <ul class="footer-list-top">
        <li><h4 class="footer-list-header">Quick Links</h4></li>
        <li><a href='About.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink">ABOUT US</a></li>
        <li><a href='Contact.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink">CONTACT US</a></li>
        <li><a href='Blog.html' class="generic-anchor footer-list-anchor" itemprop="significantLink">BLOG</a></li>
        <li><a href='Help.html' itemprop="significantLink" class="generic-anchor footer-list-anchor">HELP</a></li>
        <li><a href='Sitemap.html' class="generic-anchor footer-list-anchor" itemprop="significantLink">SITE MAP</a></li>
        </ul>
        <ul class="footer-list-top">
        <li><h4 class="footer-list-header">Technology</h4></li>
        <li><a href='technology/Manufacturing.aspx' class="generic-anchor footer-list-anchor">MANUFACTURING</a></li>
        <li><a href='technology/machines/Big Machines.aspx' class="generic-anchor footer-list-anchor">BIG MACHINES</a></li>
        <li><a href='technology/machines/Small Machines.aspx' class="generic-anchor footer-list-anchor">SMALL MACHINES</a></li>
        <li><a href='technology/Electronics.aspx' class="generic-anchor footer-list-anchor">ELECTRONICS</a></li>
        <li><a href='technology/Tools.aspx' class="generic-anchor footer-list-anchor" target="_blank">TOOLS</a></li>
        </ul>
        <ul class="footer-list-top">
        <li id='help'><h4 class="footer-list-header">Math</h4></li>
        <li><a href='math/Geometry.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink" style="padding-bottom: 10px">GEOMETRY</a></li>
        <li><a href='math/Algebra.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink">ALGEBRA</a></li>
        <li id='find-a-store'><a href='math/Trigonometry.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink">TRIGONOMETRY</a></li>
        <li id='user-registration'><a href='math/Statistics.aspx' class="generic-anchor footer-list-anchor" itemprop="significantLink">STATISTICS</a></li>
        <li id='order-tracking'><a href='math/Calculus.aspx' itemprop="significantLink" class="generic-anchor footer-list-anchor">CALCULUS</a></li>
        </ul>
        <section class="footer-social-section flex-rw">
            <span class="footer-social-overlap footer-social-connect">
            CONNECT <span class="footer-social-small">with</span> US
            </span>
            <span class="footer-social-overlap footer-social-icons-wrapper">
            <a href="https://www.pinterest.com/paviliongift/" class="generic-anchor" target="_blank" title="Pinterest" itemprop="significantLink"><i class="fa fa-facebook"></i></a>
            <a href="https://www.facebook.com/paviliongift" class="generic-anchor" target="_blank" title="Facebook" itemprop="significantLink"><i class="fa fa-twitter"></i></a>
            <a href="https://twitter.com/PavilionGiftCo" class="generic-anchor" target="_blank" title="Twitter" itemprop="significantLink"><i class="fa fa-instagram"></i></a>
            <a href="http://instagram.com/paviliongiftcompany" class="generic-anchor" target="_blank" title="Instagram" itemprop="significantLink"><i class="fa fa-linkedin"></i></a>
            <a href="https://www.youtube.com/channel/UCYgUODvd0qXbu_LkUWpTVEg" class="generic-anchor" target="_blank" title="Youtube" itemprop="significantLink"><i class="fa fa-google"></i></a>
            <a href="https://plus.google.com/+Paviliongift/posts" class="generic-anchor" target="_blank" title="Google Plus" itemprop="significantLink"><i class="fa fa-youtube"></i></a>
            </span>
        </section>
        <section class="footer-bottom-section flex-rw">
    <div class="footer-bottom-wrapper">   
    &copy;&nbsp;<span id="year"><script type="text/javascript">document.getElementById('year').appendChild(document.createTextNode(new Date().getFullYear()));</script></span> Max Voisard in <address class="footer-address" role="company address">Versailles, OH </address><span class="footer-bottom-rights"> - All Rights Reserved</span><span style="float: right"><a href="TermsOfService.html" class="generic-anchor" rel="nofollow">Terms</a> | <a href="PrivacyPolicy.html" class="generic-anchor" rel="nofollow">Privacy</a></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        </section>
</footer>
</body>
</html>