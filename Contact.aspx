<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication6.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
    <link id="page_favicon" href="data:image/x-icon;base64,R0lGODlhEAAQAPIAAAAAAP8AAObm5v///wAAAAAAAAAAAAAAACH5BAkUAAQAIf8LTkVUU0NBUEUyLjADAQAAACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQRBAEwzAMwzAMwxAEQRAEwTAMg8FgMAgEAoFAYBAIDAaDwWAQCAwCgUBgMAgEBoPBIBAYDAKBQGAwGAQCg0EgMBgMAoFAYDAYDAIBAQEDAwMDAQEBAQMDAwMDAQEDAwMDAwEBAQEDAwMDAgMDAgMDAwMBAQEBAwMDAgMDAwMCAwMDAQEBAQMDAgMDAwMDAwIDAwEBAQEDAgMDAwMDAwMDAgMBAQEBAgMDAwMDAwMDAwMCAQEEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEEQTAMwzAMwzAMAUEEQRAMg8FgMBgMAgECIRAYBAKDwWAwGAQCAwIhEBgMAoHBYDAIBAYDAiEQGAwGgcBgEAgMBgMCIRAYDAYDAQEBAQMDAwMEBAEBAwMDAwMBAQMDAwMDBAQBAQMDAwMCAwMCAwMDAwQEAQEDAwMCAwMDAwIDAwMEBAEBAwMCAwMDAwMDAgMDBAQBAQMCAwMDAwMDAwMCAwQEAQECAwMDAwMDAwMDAwIEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEQRBAEwzAMwzAMA0EQRBAEgcFgMBgMBgMCgUAIBAaBwGAwGAwGAQKBQAgEBoNAYDAYDAIBAoFACAQGg0EgMBgEAgMCgUAIBAYDAwMBAQEBAwMEBAQEAQEDAwMDAwEBAwMDBAQEBAEBAwMDAwIDAwIDAwQEBAQBAQMDAwIDAwMDAgMEBAQEAQEDAwIDAwMDAwMCBAQEBAEBAwIDAwMDAwMDAwQEBAQBAQIDAwMDAwMDAwMEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEQBEEEQTAMwzAMA0EQBEEEgUBgMBgMBgMCgUAgEAKBQSAwGAwGAwKBQCAQAoHBIBAYDAYDAoFAIBACgcFgEAgMBgECgUAgEAIBAwMDAwEBAQEEBAQEBAQBAQMDAwMDAQEDBAQEBAQEAQEDAwMDAgMDAgQEBAQEBAEBAwMDAgMDAwMEBAQEBAQBAQMDAgMDAwMDBAQEBAQEAQEDAgMDAwMDAwQEBAQEBAEBAgMDAwMDAwMEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEQBEEQRBAEwzAMA0EQBEEQhEAgEBgMBgMCgUAgEAiEQGAQCAwGAwKBQCAQCIRAYDAIBAYDAoFAIBAIhEBgMBgEAgMCgUAgEAgEAQEDAwMDAQEEBAQEBAQEBAEBAwMDAwMBBAQEBAQEBAQBAQMDAwMCAwQEBAQEBAQEAQEDAwMCAwMEBAQEBAQEBAEBAwMCAwMDBAQEBAQEBAQBAQMCAwMDAwQEBAQEBAQEAQECAwMDAwMEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEQBEEQBEEEQTAMA0EQBEEQBAIhEAgEBgMCgUAgEAgEAiEQGAQCAwKBQCAQCAQCIRAYDAIBAoFAIBAIBAIhEBgMBgECgUAgEAgEBAQBAQMDAwMEBAQEBAQEBAQEAQEDAwMDBAQEBAQEBAQEBAEBAwMDAwQEBAQEBAQEBAQBAQMDAwIEBAQEBAQEBAQEAQEDAwIDBAQEBAQEBAQEBAEBAwIDAwQEBAQEBAQEBAQBAQIDAwMEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQBEEQBEEQBEEQRBAEA0EQBEEQBAKBQAgEAgECgUAgEAgEAoFACAQGAQKBQCAQCAQCgUAIBAYDAoFAIBAIBAKBQAgEBgMCgUAgEAgEBAQEBAEBAwMEBAQEBAQEBAQEBAQBAQMDBAQEBAQEBAQEBAQEAQEDAwQEBAQEBAQEBAQEBAEBAwMEBAQEBAQEBAQEBAQBAQMDBAQEBAQEBAQEBAQEAQEDAgQEBAQEBAQEBAQEBAEBAgMEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAACACwAAAAAEAAQAIEAAAD/AAAAAAAAAAAC55QkIiIiIoQQQgghhBBCCCEIgiAIgiAIgiAIgiAIQhAIgiAIgiAIgiAQCAIBgUAgEAgEAoFAIBAIAgGBQCAQCAQCgUAgEAgCAYFAIBAIBAKBQCAQCAIBgUAgEAgEAoFAICAgEBAgICAgICAgICAgICAgIBAQICAgICAgICAgICAgICAQECAgICAgICAgICAgICAgEBAgICAgICAgICAgICAgIBAQICAgICAgICAgICAgICAQECAgICAgICAgICAgICAgEBAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQIAAAQIKAAAh+QQJFAACACwAAAAAEAAQAIEAAAD/AAAAAAAAAAAC55QkIiIiIoQQQgghhBBCCCEIgiAEgSAIgiAIgiAIgiAEgSAIgiAIgiAQCASCQEAgEAgEAoFAIBAIBIJAQCAQCAQCgUAgEAgEgkBAIBAIBAKBQCAQCASCQEAgEAgEAoFAICAgICAQECAgICAgICAgICAgICAgEBAgICAgICAgICAgICAgIBAQICAgICAgICAgICAgICAQECAgICAgICAgICAgICAgEBAgICAgICAgICAgICAgIBAQICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgQIAAAQIKAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQxBAEAUEQBEEQBEEQRBAEAUEQBAKBQCAQCITAIBAgEAgEAoFAIBAIhMEgECAQCAQCgUAgEAiEwSAQIBAIBAKBQCAQCITBIBAgEAgEBAQEBAQEBAQDAwEBBAQEBAQEBAQEBAQEAwMBAQQEBAQEBAQEBAQEBAMDAQEEBAQEBAQEBAQEBAQDAwEBBAQEBAQEBAQEBAQEAgMBAQQEBAQEBAQEBAQEBAMCAQEEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQxDAMQRAQBEEQBEEQxDAEQRAQBAKBQCAQCIRBIDAIBAgEAoFAIBAIhEBgMAgECAQCgUAgEAiEwGAwCAQIBAKBQCAQCITBYDAIBAgEBAQEBAQEBAQDAwMDAQEEBAQEBAQEBAQEAwMDAwEBBAQEBAQEBAQEBAIDAwMBAQQEBAQEBAQEBAQDAgMDAQEEBAQEBAQEBAQEAwMCAwEBBAQEBAQEBAQEBAMDAwIBAQQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQxDAMwxAEAUEQBEEQxDAMQxAEAQKBQCAQCITBYBAIDAIBAoFAIBAIhMEgEBgMAgECgUAgEAiEQSAwGAwCAQKBQCAQCIRAYDAYDAIBBAQEBAQEBAQBAwMDAwMBAQQEBAQEBAQEAwIDAwMDAQEEBAQEBAQEBAMDAgMDAwEBBAQEBAQEBAQDAwMCAwMBAQQEBAQEBAQEAwMDAwIDAQEEBAQEBAQEBAMDAwMDAgEBBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQxDAMwzAMQRAQBEEQxDAMwzAEgUCAQCAQCITBYDAYBAKDQIBAIBAIhMFgMAgEBoNAgEAgEAiEwGAQCAwGg0CAQCAQCIRAIBAYDAYDAQEEBAQEBAQDAQEDAwMDAwEBBAQEBAQEAgMDAgMDAwMBAQQEBAQEBAMDAwMCAwMDAQEEBAQEBAQDAwMDAwIDAwEBBAQEBAQEAwMDAwMDAgMBAQQEBAQEBAMDAwMDAwMCAQEEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQxDAMwzAMwxAEAUEQxDAMwzAMg0AgECAQCITAYDAYDAaBwCAQIBAIhEBgMBgMAoHBIBAgEAiEQSAwGAQCg8EgECAQCITBIBAIBAYDAwMBAQQEBAQDAwMBAQMDAwMDAQEEBAQEAwMCAwMCAwMDAwEBBAQEBAMCAwMDAwIDAwMBAQQEBAQCAwMDAwMDAgMDAQEEBAQEAwMDAwMDAwMCAwEBBAQEBAMDAwMDAwMDAwIBAQQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQRDAMwzAMwzAMQRAQRBAMwzAMg8EgEAgECIRBIDAYDAaDQSAwCAQIhMEgEBgMBoNAYDAIBAiEwWAQCAwGgcBgMAgECITBYDAIBAIBAwMDAwEBBAQDAwMDAwEBAwMDAwMBAQQEAwMDAwIDAwIDAwMDAQEEBAMDAwIDAwMDAgMDAwEBBAQDAwIDAwMDAwMCAwMBAQQEAwIDAwMDAwMDAwIDAQEEBAIDAwMDAwMDAwMDAgEBBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAAh+QQJFAAEACwAAAAAEAAQAAAD6khERESEEEIIIYQQQgghBEEQBEEQRBAEwzAMwzAMwxAEQRAEwTAMg8FgMAgEAoFAYBAIDAaDwWAQCAwCgUBgMAgEBoPBIBAYDAKBQGAwGAQCg0EgMBgMAoFAYDAYDAIBAQEDAwMDAQEBAQMDAwMDAQEDAwMDAwEBAQEDAwMDAgMDAgMDAwMBAQEBAwMDAgMDAwMCAwMDAQEBAQMDAgMDAwMDAwIDAwEBAQEDAgMDAwMDAwMDAgMBAQEBAgMDAwMDAwMDAwMCAQEEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQIECBAgAABAgQSAAA7" rel="icon" type="image/x-icon" />
    <link rel="canonical" href="https://maxstechandmathsite.azurewebsites.net/Home"/>
    <div id="google_translate_element"></div>
        <script type="text/javascript" src="http://translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
    <h2>Contact Max</h2>
    <p>
        <asp:Image ID="Image7" runat="server" ImageUrl="~/Images/PictureOfMe.jpg" />
    </p>
    <p><a href="https://twitter.com/MaxVoisard?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="true">Follow @MaxVoisard</a><script async="async" src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
    <a href="https://twitter.com/intent/tweet?screen_name=MaxVoisard&ref_src=twsrc%5Etfw" class="twitter-mention-button" data-text="How&#39;s it going? https://maxstechandmathsite.azurewebsites.net/Contact #Science #Technology #Engineering #Math #STEM via @MaxsTechandMat1" data-related="TeachingSTEM,STEMEduc" data-show-count="false">Tweet to @MaxVoisard</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script> 
    <address>
        <asp:Image ID="Image6" runat="server" Height="18px" ImageUrl="~/Images/Website.png" />
        <strong>&nbsp;Website Creator: </strong>Max Voisard<br />
        <asp:Image ID="Image4" runat="server" Height="18px" ImageUrl="~/Images/Marker.png" />
        <strong>&nbsp;Address: </strong><a onclick="displayIframe()" style="cursor: pointer">11383 Marshall Road, Versailles, OH 45380</a>
        <div id="googleMap" style="visibility: hidden;"></div>
        <script>
            function displayIframe() {
                document.getElementById("googleMap").innerHTML = "<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3045.0451909086532!2d-84.44540568424674!3d40.25252697938451!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x883fbcabfeae0fed%3A0xf295e018b3d96169!2s11383+Marshall+Rd%2C+Versailles%2C+OH+45380!5e0!3m2!1sen!2sus!4v1551625629353 \" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0; visibility:visible\" allowfullscreen></iframe>";
            }
        </script>
        <asp:Image ID="Image5" runat="server" Height="18px" ImageUrl="~/Images/Email.png" />
        <strong>&nbsp;Email: </strong><a href="mailto:mvoisard@gmail.com?subject=Email+Max+your+Questions">max.voisard@gmail.com</a><br />
        <asp:Image ID="Image3" runat="server" Height="18px" ImageUrl="~/Images/Telephone.jpg" />
        <strong>&nbsp;Phone number: </strong><a href="tel:937-638-4972">937-638-4972</a>&nbsp;&nbsp;
    </address>
    <address>
        <strong>Your Name</strong>
        <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="330px"></asp:TextBox>
        <strong>&nbsp;</strong></address>
    <address>
        <strong>Your Email </strong>
        <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="330px"></asp:TextBox>
    </address>
    <address>
        <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head>
    <title>RDFaCE-Lite</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <!-- RDFaCE required libs-->
    <script type="text/javascript" src="https://ff.kis.v2.scr.kaspersky-labs.com/9F429392-D65E-C44E-9897-24E0F4769B9F/main.js" charset="UTF-8"></script>
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/plugins/rdface/js/util/config.js"></script>
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/plugins/rdface/js/util/jquery.min.js"></script>
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/plugins/rdface/js/util/jquery.cookie.js"></script>
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/plugins/rdface/js/util/functions.js"></script>
    <!-- END RDFaCE-->
    <!-- TinyMCE -->
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/tiny_mce.js"></script>
    <script type="text/javascript" src="https://ali1k.com/rdface/rdface-lite/tinymce/jscripts/tiny_mce/tiny_mce_gzip.js"></script>
    <script type="text/javascript">
        /*
        tinyMCE_GZ.init({
        <!-- user-defined plugins and themes should be identical to those in "tinyMCE.init" below.-->
                plugins : "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,contextmenu,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,advlist,rdface",
                themes : 'advanced',
                languages : 'en',
                disk_cache : true,
                debug : false
        });
        */
    </script>
    <script type="text/javascript">
        tinyMCE.init({
            // General options
            mode: "textareas",
            theme: "advanced",
            //skin : "o2k7",
            //Ali:added rdface plugin+contextmenu
            plugins: "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,wordcount,advlist,autosave,contextmenu,rdface",
            // Ali: add XHHTML elements for RDFa
            valid_elements: "*[*]",
            //Ali:added rdface buttons
            // Theme options
            theme_advanced_buttons1: "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,styleselect,formatselect,fontselect,fontsizeselect",
            theme_advanced_buttons2: "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
            theme_advanced_buttons3: "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
            theme_advanced_buttons4: "insertlayer,moveforward,movebackward,absolute,|,styleprops,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,pagebreak,restoredraft,|,rdfaceRun,rdfaceSetting",
            theme_advanced_toolbar_location: "top",
            theme_advanced_toolbar_align: "left",
            theme_advanced_statusbar_location: "bottom",
            theme_advanced_resizing: true,

            // Example content CSS (should be your site CSS)
            //Ali:added rdface style
            content_css: "css/content.css,../jscripts/tiny_mce/plugins/rdface/css/rdface.css",

            // Drop lists for link/image/media/template dialogs
            template_external_list_url: "lists/template_list.js",
            external_link_list_url: "lists/link_list.js",
            external_image_list_url: "lists/image_list.js",
            media_external_list_url: "lists/media_list.js",

            // Style formats
            style_formats: [
                { title: 'Bold text', inline: 'b' },
                { title: 'Red text', inline: 'span', styles: { color: '#ff0000' } },
                { title: 'Red header', block: 'h1', styles: { color: '#ff0000' } },
                { title: 'Example 1', inline: 'span', classes: 'example1' },
                { title: 'Example 2', inline: 'span', classes: 'example2' },
                { title: 'Table styles' },
                { title: 'Table row 1', selector: 'tr', classes: 'tablerow1' }
            ],

            // Replace values for the template plugin
            template_replace_values: {
                username: "Some User",
                staffid: "991234"
            }
        });
    </script>
    <!-- /TinyMCE -->
    <script type="text/javascript">

        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-29428344-1']);
        _gaq.push(['_trackPageview']);

        (function () {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();

    </script>
</head>
<body>
    <form method="post" action="../jscripts/tiny_mce/plugins/rdface/php/page.php">
        <div>
            <h3>Message Max</h3>

            <!-- Gets replaced with TinyMCE, remember HTML in a textarea should be encoded -->
            <div>
                <textarea id="elm1" name="elm1" rows="15" cols="80" style="width: 80%" spellcheck="true" autocomplete="on">
            <p></p>
			</textarea>
            </div>
            <br />
            <input type="submit" name="save" value="Send" />
            <input type="reset" name="reset" value="Reset" />
        </div>
    </form>

    <script type="text/javascript">
        if (document.location.protocol == 'file:') {
            alert("The examples might not work properly on the local file system due to security settings in your browser. Please use a real webserver.");
        }
    </script>
</body>
</html>
     &nbsp;</address>
</asp:Content>