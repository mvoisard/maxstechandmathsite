<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

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
    </script>
    <!-- End Google Tag Manager -->
    <script async="async" defer="defer" src="//survey.g.doubleclick.net/async_survey?site=xp6xgahi7ejimgm2yd57tnr7du"></script>
    <script async="async" src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
    <script>
      (adsbygoogle = window.adsbygoogle || []).push({
        google_ad_client: "ca-pub-8887116012216502",
        enable_page_level_ads: true
      });
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <!--[if lt IE 9]>
    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js">
    </script>
    <![endif]-->
    <title>Login</title>
    <link rel="stylesheet" href="Style/StyleSheet2.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" />
    <link href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="data:image/x-icon;base64,AAABAAEAEBAAAAAAAABoBAAAFgAAACgAAAAQAAAAIAAAAAEAIAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAD///8AERERAAAAADMMLVThImip/TyX0v89oNr/Op3Y/zSU1f82kND/LHzC/xhUmP0KKE3fAAAAMhEREQD///8A////ABEREQAAAAANFlmu/yt+xv9Kptz/SK7j/0Wx5P9BqeH/RqTb/zeMz/8dZ7n/ElKm/wAAAA0REREA////AP///wAREREAHUxsABdfuP8vi9L/WLvn/1rE7f9LiqX/T1pi/1K35f8/oNr/IHTG/xRWr/8UOlcAERERAP///wD///8ASJ3WADqW0wAYZLz/NJfY/2HE6/920/H/ysrK/6qqqv90rMH/Rq7g/ySCzv8VXLX/LYLGADuKygD///8A////AFKh2ABGmtUAGmrA/zqj3P9vz+7/jN30/6Kiov9UVFT/edbv/1S/5v8qj9T/FmK5/z6QywBLl88A////AP///wD///8A////ABxwxP9Dr+D/gNjw/5Tj9f+k6Pb/mub1/4rg8v9mzev/NJ7b/xlqv/////8A////AP///wD///8A////AP///wAheMj/V73l/6Li9P/S8vr/0PP6/7/w+f+s6vb/kd3x/0mw4f8fdMP/////AP///wD///8A////AP///wD///8AQrns/2Kdvv9hkKv/eNLy/0/D7v9Txe//itjz/2iSqv+Dtsz/Rrzt/////wD///8A////AP///wD///8A////ADOY1gCYq7n/KzM7/3S55f8uidb/IXzS/0Sa2/8uOED/m6u3/zeSzwL///8A////AP///wD///8A////AP///wCmpqYAtra2/zIyMv90ttMAWrfjAE+v4QBfqcwANTU1/7e3t/+rq6sA////AP///wD///8A////AP///wD///8Ao6OjALu7u/80NDT/oKCgAG2w0ABkqcwAmJiYADc3N/+6urr/ra2tAP///wD///8A////AP///wD///8A////AP///wDx8fH/XFxc/5+fnwD5+/sAuMPLAJSUlQBjY2P/8/Pz/////wD///8A////AP///wD///8A////AP///wD///8Aj4+P/GdnZ/9ES1Dl+fv7ALjDywBCTlfmXFxc/5KSkvz///8A////AP///wD///8A////AP///wD///8A////AP///wbR0dH/w8PE/y0wMf8gIyT/3t7e/7+/v/+WlpYA////AP///wD///8A////AP///wD///8A////AP///wD///8A////AEtLS+mnp6f/lZWV/19fX+r///8B////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A4AcAAOAHAADgBwAA4AcAAOAHAADgBwAA4AcAAOAHAADwDwAA888AAPPPAADzzwAA8Y8AAPgfAAD8PwAA//8AAA==" rel="icon" type="image/x-icon" />
    <meta name="keywords" content="STEM Education Math Science Technology Machines Industrial Manufacturing Electronics"/>
    <meta name="description" content="This website offers insights into math, industrial processes & machines, science - from physics to chemistry to biology, and overall, a STEM education."/>
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
    <meta property="og:url" content="https://maxstechandmathsite.azurewebsites.net/Default" />
    <meta property="og:type" content="website" />
    <meta property="og:title" content="Max’s Technology and Math Site" />
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
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta http-equiv="Set-Cookie" content="SessionID=38afes7a8; Expires=Tue, 31 Dec 2019 11:59:59 GMT; Secure; HttpOnly; Path=/" />
    <meta http-equiv="content-disposition" content="inline; filename=Complete Business Guide.docx" />
    <meta http-equiv="Cache-control" content="public" />
    <meta http-equiv="Cache-control" content="max-age=3600" />
    <meta http-equiv="page-enter" content="revealtrans(duration=3.0,transition=1)" />
    <meta http-equiv="page-exit" content="revealtrans(duration=3.0,transition=1)" />
    <meta name="google-signin-scope" content="profile email" />
    <meta name="google-signin-client_id" content="639859509357-eommn88ku4hkk42li4eas0a8r4usf0s8.apps.googleusercontent.com" />
    <script src="https://apis.google.com/js/platform.js" async="async" defer="defer"></script>
    <style>
        #FloatLoginBox {
            overflow: auto;
            border: 5px solid #4CAF50;
            padding: 5px;
            width: 325px;
            margin: 0 auto;
            text-align: center;
            background: -webkit-linear-gradient(-90deg, rgba(230,240,163,1) 0, rgba(210,230,56,1) 50%, rgba(195,216,37,1) 51%, rgba(219,240,67,1) 100%), #0199d9;
            background: -moz-linear-gradient(180deg, rgba(230,240,163,1) 0, rgba(210,230,56,1) 50%, rgba(195,216,37,1) 51%, rgba(219,240,67,1) 100%), #0199d9;
            background: linear-gradient(180deg, rgba(230,240,163,1) 0, rgba(210,230,56,1) 50%, rgba(195,216,37,1) 51%, rgba(219,240,67,1) 100%), #0199d9;
            background-position: 50% 50%;
            -webkit-background-origin: padding-box;
            background-origin: padding-box;
            -webkit-background-clip: border-box;
            background-clip: border-box;
            -webkit-background-size: auto auto;
            background-size: auto auto;
            -webkit-box-shadow: 3px 3px 3px 1px rgba(0,0,0,0.3);
            box-shadow: 3px 3px 3px 1px rgba(0,0,0,0.3);
            text-shadow: 0 1px 1px rgba(0,0,0,0.2);
        }
        @media only all and (max-width: 768px) {
            .g-signin2 {
                margin-left: 0%;
            }
        }
    </style>
</head>
<body style="background-image: url(Images/STEMBackground.jpg)">
    <form id="form1" runat="server">
    <!-- Google Tag Manager (noscript) -->
    <noscript>
        <iframe src="https://www.googletagmanager.com/ns.html?id=GTM-N5KXG2Z" height="0" width="0" style="display:none;visibility:hidden"></iframe>
    </noscript>
    <!-- End Google Tag Manager (noscript) -->
    <div id="wrapper">
	<header style="background-image: url(Images/lilyheader.jpg)">
        <h1 style="text-align: left"><asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Images/Lock.png"/>Login</h1>
        <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
        <script src="https://cdn.rawgit.com/oauth-io/oauth-js/c5af4519/dist/oauth.js"></script>
	</header>
        <a class="myButton3" href="Registration.aspx">New and don't have an account? Register here <img src="Images/RightArrow.png" style="height: 11px; width: 15px"/></a>&nbsp;<br />
        <br />
        <img src="Images/key.png" height="450" style="float: left; margin-left: 50px" />
        <img src="Images/padlock.png" height="450" style="float: right; margin-right: 50px" />
        <div id="FloatLoginBox">
        <h3>Sign in via Social Connections</h3>
        <i class="fa fa-google fa-3x" style="color: blue"></i>&nbsp;<i class="fa fa-facebook fa-3x" style="color: blue"></i>&nbsp;<i class="fa fa-twitter fa-3x" style="color: blue"></i>&nbsp;<img height="40" src="Images/microsoft.png" />&nbsp;<i class="fa fa-linkedin fa-3x" style="color: blue"></i>
        <br />
        <!--<div class="g-signin2" data-width="240" data-height="40" data-scope="profile email" data-longtitle="true" data-onsuccess="onSignIn" data-onfailure="onFailure" data-theme="dark" style="margin-left: 12%"></div><input type="button" onclick="signOut();" class="myButton" style="height: 40px; width: 240px; margin-top: 2px; margin-bottom: 2px" value="Sign out of Google" />
        <script>
            function onSignIn(googleUser) {
                document.getElementById("GoogleTable").style = "width: 100%; height: 105px; visibility: visible";
                var profile = googleUser.getBasicProfile();
                document.getElementById("ID").innerHTML = profile.getId();
                document.getElementById("fullName").innerHTML = profile.getName();
                document.getElementById("imageURL").href = profile.getImageUrl();
                document.getElementById("imageURL").innerHTML = profile.getImageUrl();
                document.getElementById("email").innerHTML = profile.getEmail();
                document.getElementById("<%= ((TextBox)logUsers.FindControl("UserName")).ClientID %>").value = profile.getName();
                var password = profile.getId().substring(0, 14).replace(/^.{6}/g, 'hPclM#');
                document.getElementById("<%= ((TextBox)logUsers.FindControl("Password")).ClientID %>").value = password;
                document.getElementById("Text1").value = profile.password;
            }
            var auth2;
            var initClient = function() {
                gapi.load('auth2', function(){
                    auth2 = gapi.auth2.init({
                        client_id: '639859509357-eommn88ku4hkk42li4eas0a8r4usf0s8.apps.googleusercontent.com',
                        cookiepolicy: 'single_host_origin',
                        scope: 'profile'
                    });
                    auth2.attachClickHandler('g-signin2', {}, onSuccess, onFailure);
                });
            };
            var onSuccess = function(user) {
                document.getElementById("ErrorLabel").value = "Signed in as " + user.getBasicProfile().getName();
             };
            var onFailure = function(error) {
                document.getElementById("ErrorLabel").value = "Error processing Google login: " + error;
            };
            function signOut() {
            var auth2 = gapi.auth2.getAuthInstance();
            auth2.signOut().then(function () {
                console.log('User signed out.');
            });
            }
        </script>
        <script async="async" defer="defer" src="https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.2&appId=108355726669362&autoLogAppEvents=1"></script>
        <script>
          var called = false;
          window.fbAsyncInit = function() {
            if (called) return;
            called = true;
            FB.init({
              appId      : '108355726669362',
              cookie     : true,
              xfbml      : true,
              scope      : 'public_profile,name,id,password,email,gender,user_birthday',
              status     : true,
              version    : 'v3.2'
            });
              FB.AppEvents.logPageView();
              $("#FBLogOut").click(function () { FB.logout(function () { window.location.reload(); }); });
          };
          if (!called) window.fbAsyncInit();
          (function(d, s, id){
             var js, fjs = d.getElementsByTagName(s)[0];
             if (d.getElementById(id)) {return;}
             js = d.createElement(s); js.id = id;
             js.src = "https://connect.facebook.net/en_US/sdk.js";
             fjs.parentNode.insertBefore(js, fjs);
            }(document, 'script', 'facebook-jssdk'));
          function checkLoginState() {
              FB.getLoginStatus(function (response) {
                  if (response.status === 'connected') {
                      FB.api('/me', function (response) {
                          document.getElementById("Label8").value = "Welcome, " + response.name;
                          document.getElementById("Label8").style.color = "green";
                      });
                      console.log("Access token: " + response.authResponse.accessToken);
                  }
                  else {
                      document.getElementById("Label8").value = "Please log into this app.";
                      document.getElementById("Label8").style.color = "red";
                  }
              });
            }
        </script>
        <div id="fb-root"></div>
        <div id="auth-status">
        <div id="auth-loggedout">
        <fb:login-button onlogin="checkLoginState();" onclick="FacebookUsername()" class="fb-login-button" data-width="50px" data-size="large" data-button-type="login_with" data-auto-logout-link="false" data-use-continue-as="true"></fb:login-button>
        </div>
        </div>
        &nbsp;&nbsp;
        <input type="button" id="FBLogOut" class="myButton" style="height: 40px; width: 240px; margin-top: 2px; margin-bottom: 2px" value="Sign out of Facebook" />&nbsp;
        &nbsp;--><br />
        <input type="button" id="LoginBtn" class="myButton" style="height: 40px; width: 240px; margin-top: 2px; margin-bottom: 2px" value="Sign in via External Login" />
        <br />
        <input type="button" id="LogoutBtn" class="myButton3" style="height: 40px; width: 240px; margin-top: 2px; margin-bottom: 2px" value="Sign out of External Login" />
        <br />
        </div>
        <br />
        <asp:Login ID="logUsers" runat="server" style="margin: 0 auto" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" FailureText="" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="logUsers_Authenticate" UserNameRequiredErrorMessage="Username is required.">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        </asp:Login>
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <br />
        <input type="checkbox" onchange="document.getElementById('<%= ((TextBox)logUsers.FindControl("Password")).ClientID %>').type = this.checked ? 'text' : 'password'" /> Show password&nbsp;<span toggle="#password-field" class="fa fa-fw fa-eye field_icon toggle-password"></span><br />
        &nbsp;<br />
        This website is still under development, so you can click<br />
        the link below to navigate to the site without logging in:<br />
        <br />
        <a class="myButton2" href="Home.aspx">Continue to Site <img src="Images/RightArrow.png" style="height: 11px; width: 15px"/></a>&nbsp;<br />
        <br />
        <img src="Images/Science.png" height="300" style="float: left; margin-left: 75px" />
        <img src="Images/MathIcon.png" height="300" style="float: right; margin-right: 75px" /><br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Change Password" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Username:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <asp:ChangePassword ID="ChangePassword1" runat="server" style="margin: 0 auto" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" NewPasswordRegularExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$" NewPasswordRegularExpressionErrorMessage="Password must be 8-15 characters long, have a number, special character, and uppercase letter." OnChangedPassword="ChangePassword1_ChangedPassword">
            <MailDefinition BodyFileName="html/ChangePassword.html" IsBodyHtml="True" Subject="Changed Password Confirmation">
            </MailDefinition>
            <SuccessTextStyle ForeColor="Green" />
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:ChangePassword>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <img src="https://img.icons8.com/color/48/000000/forgot-password.png" height="35" />&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Black" Text="Forgot Password?" Font-Bold="True"></asp:Label>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" style="margin: 0 auto" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" OnSendingMail="PasswordRecovery1_SendingMail">
            <MailDefinition BodyFileName="~/Software.txt" From="max.voisard@gmail.com" Subject="Password Recovery">
            </MailDefinition>
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:PasswordRecovery>
        <div class="content">
    <nav class="navbar navbar-default">
      <div class="container-fluid">
        <div class="navbar-header">
          <a class="navbar-brand" href="#">Auth0 - JavaScript</a>

          <button id="btn-home-view" class="btn btn-primary btn-margin">
              Home
          </button>

          <button id="btn-profile-view" class="btn btn-primary btn-margin">
              Profile
          </button>

          <button id="qsLoginBtn" class="btn btn-primary btn-margin">
              Log In
          </button>

          <button id="qsLogoutBtn" class="btn btn-primary btn-margin">
              Log Out
          </button>

        </div>
      </div>
    </nav>

    <main class="container">
      <!-- home view -->
      <div id="home-view">
        <h4></h4>
      </div>

      <!-- profile view -->
      <div id="profile-view" class="panel panel-default profile-area"> 
        <div class="panel-heading"><h3>Profile</h3></div>
          <div class="panel-body">
            <div>
              <label><i class="glyphicon glyphicon-user"></i> Nickname</label>
              <h3 class="nickname"></h3>
            </div>
            <pre class="full-profile"></pre>
          </div>
      </div>
    </main>
  </div>
        <asp:Label ID="lblPassword" runat="server" Visible="False" style="clear: both">An email has been sent to your account with your password.</asp:Label>
        <br />
        <table id="GoogleTable" style="width: 100%; height: 105px; visibility: hidden; display: none">
            <tr>
                <th>Google Account attributes</th>
                <th>Values</th>
            </tr>
            <tr>
                <td class="auto-style1">ID</td>
                <td><span id="ID"></span></td>
            </tr>
            <tr>
                <td class="auto-style1">Full Name</td>
                <td><span id="fullName"></span></td>
            </tr>
            <tr>
                <td class="auto-style1">Image URL</td>
                <td><a id="imageURL" href="#"></a></td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td><span id="email"></span></td>
            </tr>
        </table>
        <asp:Button ID="btnSQL" runat="server" PostBackUrl="~/Manager.aspx" Text="Show Members of Site in SQL database" Visible="False" />
        <footer>Copyright ©&nbsp;<span id="year"><script type="text/javascript">document.getElementById('year').appendChild(document.createTextNode(new Date().getFullYear()))</script></span> Max Voisard<br/><a href="mailto:max.voisard@gmail.com">max.voisard@gmail.com</a></footer>
        </div>
    </form>
    <script src="node_modules/auth0-js/build/auth0.js"></script>
    <script src="Scripts/auth0-variables.js"></script>
    <script src="Scripts/app.js"></script>
    <script src="Scripts/UserProfile.js"></script>
</body>
</html>