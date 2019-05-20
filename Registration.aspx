<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication6.Registration" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--[if lt IE 9]>
    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js">
    </script>
    <![endif]-->
    <title>Create Account</title>
    <meta charset="utf-8" />
    <meta http-equiv="Content-Type" content="text/html" />
    <link rel="stylesheet" type="text/css" media="all" href="Style/HorizontalForm.css" />
    <link rel="stylesheet" type="text/css" media="all" href="Style/switchery.min.css" />
    <link rel="stylesheet" href="Style/intlTelInput.css" />
    <link type="text/css" rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500" />
    <link href="data:image/x-icon;base64,AAABAAEAEBAAAAAAAABoBAAAFgAAACgAAAAQAAAAIAAAAAEAIAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAJAAAAFgAAABoAAAAaAAAAGgAAABoAAAAaAAAAGgAAABoAAAAaAAAAGgAAABoAAAAaAAAAGgAAABYAAAAJAAAAEgEOADMCSgCDAl0AvAJdAMwCXQDMAl0AzAJdAMwCXQDMAl0AzAJdAMwCXQDMAl0AvAJKAIMBDgAzAAAAEgIdAAAGbQBzEpII3SDMEPki2RH/ItkR/yLZEf8i2RH/ItkR/yLZEf8i2RH/ItkR/x/MD/kQkgfdBm0AcwIdAAAKfQAACn0AuiXKFfki0RH/ItER/yLREf8i0RH/IrYR/yK2Ef8i0RH/ItER/yLREf8i0RH/IMgP+Qp9ALoKfQAADIQAAAyEAMwrzBr/IsgR/yLIEf8iyBH/IrwR/+jo6P/s7Oz/IrwR/yLIEf8iyBH/IsgR/yLIEf8MhADMDIQAAA2JAAANiQDMMcYg/yK+Ef8ivhH/Ir4R/yK1Ef/k5OT/6Ojo/yK1Ef8ivhH/Ir4R/yK+Ef8jvhL/DYkAzA2JAAAOjQAADo0AzEHDMP8jtBL/IqgR/yKoEf8ipBH/4ODg/+Tk5P8ipBH/IqgR/yKoEf8itBH/JbUU/w6NAMwOjQAAD5IAAA+SAMxSyUH/M68i/9TU1P/T09P/19fX/9zc3P/g4OD/5OTk/+jo6P/s7Oz/IqYR/yivF/8PkgDMD5IAABCWAAAQlgDMVcxE/zyzK//4+Pj/4eHh/9XV1f/X19f/3Nzc/+Dg4P/k5OT/6Ojo/yKgEf8sqhv/EJYAzBCWAAARmgAAEZoAzFrRSf9Hvjb/PrUt/z61Lf83rib/6+vr/+Li4v8lnRT/I5sS/yObEv8nnxb/ObEo/xGaAMwRmgAAEp4AABKeAMxg10//TsU9/07FPf9OxT3/RLsz////////////RLsz/07FPf9OxT3/TsU9/1jPR/8SngDMEp4AABOiAAATogDMZ95W/1fORv9Xzkb/V85G/0rBOf///////////0rBOf9Xzkb/V85G/1fORv9g10//E6IAzBOiAAAUpQAAFKUAumTeU/lf1k7/X9ZO/1/WTv9f1k7/UMc//1DHP/9f1k7/X9ZO/1/WTv9f1k7/YNpP+RSlALoUpQAAFKgAABSoAHM3wSTdZuBU+W7lXf9u5V3/buVd/27lXf9t5Fz/beRc/23kXP9t5Fz/ZN9T+Ta/I90UqABzFKgAABSoAAAVqQAMFaoAcxWqALoVqgDMFaoAzBWqAMwVqgDMFaoAzBWqAMwVqgDMFaoAzBWqALoVqgBzFakADBSoAAD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A////AP///wD///8A//8AAMADAADAAwAAgAEAAIABAACAAQAAgAEAAIABAACAAQAAgAEAAIABAACAAQAAgAEAAMADAADgBwAA//8AAA==" rel="icon" type="image/x-icon" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css" />
    <link href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://intl-tel-input.com/node_modules/intl-tel-input/build/css/intlTelInput.css?39" />
    
    <script type="text/javascript" src="Scripts/switchery.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jasny-bootstrap/3.1.3/js/jasny-bootstrap.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA7zD20EAeR-v1_YfFb_h2yUZIhGrWTi4o&libraries=places&callback=initAutocomplete" async="async" defer="defer"></script>
    <script src="https://www.google.com/recaptcha/api.js" async="async" defer="defer"></script>
	<script src="Scripts/intlTelInput.min.js"></script>
	<script src="Scripts/intlTelInput-jquery.min.js"></script>
    <script src="Scripts/utils.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/10.0.2/js/intlTelInput.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/10.0.2/js/utils.js"></script>
    <script>
  window.fbAsyncInit = function() {
    FB.init({
        appId: '108355726669362',
      cookie     : true,
      xfbml      : true,
      version    : 'v2.12'
    });
      
    FB.AppEvents.logPageView();   
      
  };

  (function(d, s, id){
     var js, fjs = d.getElementsByTagName(s)[0];
     if (d.getElementById(id)) {return;}
     js = d.createElement(s); js.id = id;
     js.src = "https://connect.facebook.net/en_US/sdk.js";
     fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));

        FB.getLoginStatus(function (response) {
            statusChangeCallback(response);
        });
        {
            status: 'connected',
                authResponse: {
                accessToken: '...',
                    expiresIn:'...',
                        signedRequest:'...',
                            userID:'...'
            }
        }

        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return;
            js = d.createElement(s); js.id = id;
            js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.12&appId=108355726669362&autoLogAppEvents=1';
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));
    </script>
</head>
<body onload="initialize()">
  <a href="Default.aspx" class="myButton3" style="position: absolute; top: 0; left: 0; width: 200px">◄ Back to Login Page</a>
  <div id="wrapper">
  <img src="Images/Logo.PNG" style="height: 120px" /><a href="https://fontmeme.com/cursive-fonts/" style="margin-left: 20px"><img src="https://fontmeme.com/permalink/190408/9bc081fdc53152ed0dbf8ce6efa64189.png" alt="cursive-fonts" border="0" /></a>
  <br />
  <label id="lblSuccessMessage" class="isa_success" runat="server" Visible="false" style="font-size: 2em; margin-bottom: 3px"><i class="fa fa-check"></i></label>
  <label id="lblErrorMessage" class="isa_error" runat="server" Visible="false" style="font-size: 2em; margin-bottom: 3px"><i class="fa fa-exclamation-triangle"></i></label>
  <br />
  <form runat="server">
  <a href="https://cooltext.com"><img src="https://images.cooltext.com/5278229.png" style="width: 100%; background-color: #ebf442" height="100" alt="Personal Information" /></a>
  <asp:HiddenField ID="hdnLabelState" runat="server" />
  <div class="col-3" style="border-top: 1px solid #7eaf4a">
    <label>
      First Name <span class="red">*</span>
      <input placeholder="What is your first name?" runat="server" required="required" id="first" name="first" tabindex="1" />
    </label>
  </div>
  <div class="col-3" style="border-top: 1px solid #7eaf4a">
    <label>
      Middle
      <input placeholder="What is your middle name?" runat="server" id="middle" name="middle" tabindex="2" />
    </label>
  </div>
  <div class="col-3" style="border-top: 1px solid #7eaf4a">
    <label>
      Last Name <span class="red">*</span>
      <input placeholder="What is your last name?" runat="server" required="required" id="last" name="last" tabindex="3" />
    </label>
  </div>
  <div class="col-3">
    <label>
      Company
      <input placeholder="Where do you currently work?" runat="server" id="company" name="company" tabindex="4" />
    </label>
  </div>
  <div class="col-3">
    <label>
      Phone Number <span class="red">*</span>
      <br style="height: 10px" />
      <span class="demo"><input type="tel" style="position: relative; width: 400px; height: 37px; line-height: 27px; color: #555; font-family: 'Helvetica Neue', Arial, sans-serif; font-weight: bold; font-size: 14px; opacity: .6; transition: all linear .3s" placeholder="What is the best # to reach you?" runat="server" class="form-control" required="required" id="phone" name="phone" tabindex="5" /><span id="valid-msg" class="hide" style="color: green; font-size: 1em; visibility: hidden; display: none"> ✓ Valid</span><span id="error-msg" style="color: red; font-size: 1em" class="hide"></span></span>
    </label>
  </div>
   <script>
        function phoneFormatter() {
            $('#phone').on('input', function() {
            var number = $(this).val().replace(/[^\d]/g, '')
            if (number.length == 7) {
                number = number.replace(/(\d{3})(\d{4})/, "$1-$2");
                //US & Canada Formatting
            } else if (number.length == 10) {
                number = number.replace(/(\d{3})(\d{3})(\d{4})/, "($1) $2-$3");
            }
                //France Formatting
                else if (number.length == 11) {
                number = number.replace(/(\d{2})(\d{1})(\d{2})(\d{2})(\d{2})(\d{2})/, "+$1 $2 $3 $4 $5 $6");
            }
                //German Formattiing 
                else if (number.length == 13) {
                number = number.replace(/(\d{2})(\d{3})(\d{8})/, "+$1 $2 $3");
            }
            $(this).val(number)
            });
        };

       $(phoneFormatter);

        var input = document.querySelector("#phone"),
        errorMsg = document.querySelector("#error-msg"),
        validMsg = document.querySelector("#valid-msg");

        // here, the index maps to the error code returned from getValidationError - see readme
        var errorMap = [ "Invalid number", "Invalid country code", "Too short", "Too long", "Invalid number"];

        // initialise plugin
        var iti = window.intlTelInput(input, {
            utilsScript: "Scripts/utils.js"
        });

        var reset = function() {
            input.classList.remove("error");
            errorMsg.innerHTML = "";
            errorMsg.classList.add("hide");
            validMsg.style.visibility = "hidden";
            validMsg.style.display = "none";
        };

        // on blur: validate
        input.addEventListener('blur', function() {
            reset();
            if (input.value.trim()) {
            if (iti.isValidNumber()) {
                validMsg.style.visibility = "visible";
                validMsg.style.display = "inline";
            } else {
                input.classList.add("error");
                var errorCode = iti.getValidationError();
                errorMsg.innerHTML = " " + errorMap[errorCode];
                errorMsg.classList.remove("hide");
            }
            }
        });

        // on keyup / change flag: reset
        input.addEventListener('change', reset);
        input.addEventListener('keyup', reset);

        window.intlTelInput(input, {
            initialCountry: "auto",
            placeholderNumberType: "MOBILE",
            geoIpLookup: function(callback) {
            $.get('https://ipinfo.io', function() {}, "jsonp").always(function(resp) {
                var countryCode = (resp && resp.country) ? resp.country : "";
                callback(countryCode);
            });
            },
            utilsScript: "Scripts/utils.js" // just for formatting/placeholders etc
        });
    </script>
  <div class="col-3">
      <label>
      Address Line 1 <span class="red">*</span>
      <input placeholder="What is your main address?" runat="server" required="required" id="address" name="address" tabindex="6" />
    </label>
  </div>
  <div class="col-3">
    <label>
      Address Line 2
      <input placeholder="If applicable, do you have a secondary address?" runat="server" id="address2" tabindex="7" />
    </label>
    <span class="focus-border">
        <i></i>
    </span>
  </div>
  <script>
      var autocomplete;
      function initialize() {
          autocomplete = new google.maps.places.Autocomplete(
              /** @type {HTMLInputElement} */(document.getElementById('autocomplete')),
              { types: ['geocode'] });
          google.maps.event.addListener(autocomplete, 'place_changed', function() {
          });
      }
  </script>
  <div class="col-3" id="locationField">
    <label>
    Location <span class="red">*</span>
    <input type="text" id="autocomplete" onfocus="geolocate()" placeholder="Where is your place of residence?" runat="server" name="location" required="required" tabindex="8" />
    </label>
  </div>
  <div class="col-3">
    <label>
      Zip Code <span class="red">*</span>
      <input placeholder="What is your ZIP Code?" runat="server" required="required" id="zip" name="zip" tabindex="9" />
    </label>
  </div>
  <div class="col-4">
    <label>
      Date of Birth (DOB) <span class="red">*</span>
      <input type="date" required="required" runat="server" placeholder="When is your date of birth?" id="dob" name="dob" tabindex="10" />
    </label>
  </div>
  <div class="col-4">
    <label>
      Gender <span class="red">*</span>
      <select id="gender" required="required" runat="server" name="gender" tabindex="11">
          <option>Male</option>
          <option>Female</option>
          <option>I do not wish to identify</option>
      </select>
    </label>
  </div>
  <div class="col-4 switch">
    <label>Send Text Notifications?</label>
    <center style="position:relative; padding-bottom: 8px"><input type="checkbox" runat="server" id="texts" class="js-switch" /></center>
  </div>
  <div class="col-4 switch">
    <label>Email Updates?</label>
    <center style="position:relative; padding-bottom: 8px"><input type="checkbox" runat="server" id="emailUpdates" class="js-switch" /></center>
  </div>
  <div id="LoginSection">
  <script>
      function Loader() {
          document.getElementsByClassName("loader")[0].style = "display: inline; visibility: visible; -moz-animation: cssAnimation 0s ease-in 5s forwards; -webkit-animation: cssAnimation 0s ease-in 5s forwards; -o-animation: cssAnimation 0s ease-in 5s forwards; animation: cssAnimation 0s ease-in 5s forwards; -webkit-animation-fill-mode: forwards; animation-fill-mode: forwards";
      }
  </script>
  <asp:scriptmanager id="ScriptManager1" runat="server"></asp:scriptmanager>
      <asp:Label ID="Label1" runat="server" style="font-size: 1.5em" Text="Upload Profile Picture: "></asp:Label><asp:Image ID="Image2" runat="server" /><asp:FileUpload ID="FileUpload1" runat="server" accept=".png,.jpg,.jpeg,.gif" />
  <asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>
  <cc1:ModalPopupExtender ID="mpePopUp" runat="server" TargetControlID="lblHidden" PopupControlID="divPopUp" BackgroundCssClass="modalBackground"></cc1:ModalPopupExtender>
  <div id="divPopUp" class="pnlBackGround">
      <div style="background-color: blue; padding: 20px 0px"><asp:ImageButton ID="ImageButton1" runat="server" Height="25" style="float: right; margin-right: 5px" ImageUrl="~/Images/close.png" OnClick="ImageButton1_Click" /><asp:Label ID="Label5" runat="server" Text="Activate Account : Verification Code" ForeColor="White" Font-Size="XX-Large"></asp:Label></div>
      <asp:Label ID="Label4" runat="server" Text="We have sent a 6-digit verification code text to your phone to validate you are human." Font-Size="Large" ForeColor="#009900" Font-Bold="True"></asp:Label>
      <br />
      <asp:Image ID="Image1" runat="server" Height="38px" style="margin-right: 5px" ImageUrl="~/Images/smartphone.png" />
      <span><asp:Label ID="Label3" Font-Size="X-Large" Text="Enter Verification Code: " runat="server"></asp:Label><asp:TextBox ID="TextBox1" Width="50px" runat="server" Height="30px" style="margin-right: 5px"></asp:TextBox>&nbsp;<asp:Button ID="Button1" class="myButton" runat="server" Text="Activate Account" OnClientClick="Loader()" OnClick="Button1_Click" UseSubmitBehavior="false" style="margin-right: 5px" />
      <svg class="loader" viewBox="0 0 38 38" xmlns="http://www.w3.org/2000/svg">
          <circle class="internal-circle" cx="19" cy="19" r="10"></circle>
          <circle class="external-circle" cx="19" cy="19" r="16"></circle>
      </svg>
      &nbsp;<span style="margin-top: 5px"><asp:LinkButton runat="server" ID="Button3" class="myButton3" Text="<i class='fa fa-refresh'></i> Resend Different Code" OnClick="Button2_Click" Height="30px"></asp:LinkButton></span>
      <br />
      <asp:UpdatePanel ID="up1" runat="server" UpdateMode="always">
        <ContentTemplate>
           <asp:Label ID="lblTimer" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="#6600CC"></asp:Label>
           <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="timer1_tick"></asp:Timer>
           <br />
           <asp:Label ID="lblStatus" runat="server" Font-Size="Large"></asp:Label>
        </ContentTemplate>
        <Triggers>
           <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="tick" />
        </Triggers>
    </asp:UpdatePanel>
      <br />
      </span>
     <div id="buttons">
          <span id="DivbtnOK" class="buttonOK"><asp:Button id="btnOk" runat="server" text="OK" OnClick="btnOk_Click" UseSubmitBehavior="false" /></span>
          <span id="Divbtncancel" class="buttonOK">&nbsp;<asp:Button id="btnCancel" runat="server" text="Cancel" OnClick="btnCancel_Click" UseSubmitBehavior="false" /></span>
     </div>
  </div>
  <a href="https://cooltext.com"><img src="https://images.cooltext.com/5278232.png" style="width: 100%" height="140" alt="Login Information" /></a>
      <br />
      <img src="Images/key.png" height="450" style="float: left; margin-left: 130px" />
      <img src="Images/padlock.png" height="450" style="float: right; margin-right: 140px" />
      <asp:createuserwizard id="RegisterUser" style="margin: 0 auto; margin-bottom: 10px" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" ContinueDestinationPageUrl="~/Pay.aspx" FinishDestinationPageUrl="~/Pay.aspx" ToolTip="Create User Wizard" CreateUserButtonText="">
          <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
          <CreateUserButtonStyle Height="0px" Width="0px" />
          <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        <wizardsteps>
          <asp:createuserwizardstep runat="server" title="Sign Up for Your New Account">
            <contenttemplate>
              <table border="0">
                <tr>
                  <td>
                    <table border="0" style="height: 100%; width: 100%;">
                      <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="Label2" runat="server" Text="&nbsp;Sign Up for Your New Account&nbsp;" BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"></asp:Label></td>
                      </tr>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="UserName" id="UserNameLabel">
                            User Name:</asp:label></td>
                        <td>
                            <asp:textbox runat="server" id="UserName"></asp:textbox>
                            <asp:requiredfieldvalidator runat="server" controltovalidate="UserName" tooltip="User Name is required."
                            id="UserNameRequired" validationgroup="Createuserwizard1" errormessage="User Name is required.">
                            *</asp:requiredfieldvalidator>
                        </td>
                      </tr>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="Password" id="PasswordLabel">
                            Password:</asp:label></td>
                        <td>
                          <div class="popup">
                            <asp:textbox runat="server" textmode="Password" id="Password" onkeypress="return capLock(event,'Password','myPopup')" OnChange="ValidatePage();"></asp:textbox>
                            <asp:requiredfieldvalidator runat="server" controltovalidate="Password" tooltip="Password is required."
                            id="PasswordRequired" validationgroup="Createuserwizard1" errormessage="Password is required.">
                            *</asp:requiredfieldvalidator>
                            <span class="popuptext" id="myPopup">Warning: CAPS LOCK is ON.</span>
                          </div>
                        </td>
                      </tr>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="ConfirmPassword" id="ConfirmPasswordLabel">
                            Confirm Password:</asp:label></td>
                        <td>
                          <div class="popup">
                            <asp:textbox runat="server" textmode="Password" id="ConfirmPassword" onkeypress="return capLock(event,'ConfirmPassword','myPopup2')"></asp:textbox>
                            <asp:requiredfieldvalidator runat="server" controltovalidate="ConfirmPassword" tooltip="Confirm Password is required."
                            id="ConfirmPasswordRequired" validationgroup="Createuserwizard1" errormessage="Confirm Password is required.">
                            *</asp:requiredfieldvalidator>
                            <span class="popuptext" id="myPopup2">Warning: CAPS LOCK is ON.</span>
                          </div>
                        </td>
                      </tr>
                      <script>
                          function capLock(e, inputID, popupID) {
                            var bt = document.getElementById(inputID);
                            var popup = document.getElementById(popupID);
                            kc = e.keyCode ? e.keyCode : e.which;
                            sk = e.shiftKey ? e.shiftKey : ((kc == 16) ? true : false);
                            if (((kc >= 65 && kc <= 90) && !sk) || ((kc >= 97 && kc <= 122) && sk)) {
                               popup.classList.toggle("show");
                                $("#" + popupID).delay(4000).fadeOut(1000);
                            }
                          }
                      </script>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="Email" id="EmailLabel">
                            Email:</asp:label></td>
                        <td>
                          <asp:textbox runat="server" id="Email" OnChange="ValidatePage();"></asp:textbox>
                          <asp:requiredfieldvalidator runat="server" controltovalidate="Email" tooltip="Email is required."
                            id="EmailRequired" validationgroup="Createuserwizard1" errormessage="Email is required.">
                            *</asp:requiredfieldvalidator>
                        </td>
                      </tr>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="Question" id="QuestionLabel">
                            Security Question:</asp:label></td>
                        <td>
                          <asp:textbox runat="server" id="Question"></asp:textbox>
                          <asp:requiredfieldvalidator runat="server" controltovalidate="Question" tooltip="Security question is required."
                            id="QuestionRequired" validationgroup="Createuserwizard1" errormessage="Security question is required.">
                            *</asp:requiredfieldvalidator>
                        </td>
                      </tr>
                      <tr>
                        <td align="right">
                          <asp:label runat="server" associatedcontrolid="Answer" id="AnswerLabel">
                            Security Answer:</asp:label></td>
                        <td>
                          <asp:textbox runat="server" id="Answer"></asp:textbox>
                          <asp:requiredfieldvalidator runat="server" controltovalidate="Answer" tooltip="Security answer is required."
                            id="AnswerRequired" validationgroup="Createuserwizard1" errormessage="Security answer is required.">
                            *</asp:requiredfieldvalidator>
                        </td>
                      </tr>
                      <tr>
                        <td align="center" colspan="2">
                          <asp:comparevalidator runat="server" display="Dynamic" errormessage="The Password and Confirmation Password must match."
                            controltocompare="ConfirmPassword" controltovalidate="Password" id="PasswordCompare"
                            validationgroup="Createuserwizard1" ForeColor="Red"></asp:comparevalidator>
                        </td>
                      </tr>
                      <tr>
                        <td align="center" colspan="2" style="color: Red;">
                          <asp:button ID="CreateUser" validationgroup="Createuserwizard1" runat="server" Text="Create User" OnClientClick="return ValidatePage();" OnClick="CreateUser_Click" BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775">
                          </asp:button>
                        </td>
                      </tr>
                      <script>
                          function ValidatePage() {
                              if (Page_ClientValidate("Createuserwizard1") == false)
                                  document.getElementById("CreateUser").disabled = true;
                              if (Page_ClientValidate("") == false)
                                  document.getElementById("CreateUser").disabled = true;

                              var input = document.querySelector("#phone");
                              var iti = window.intlTelInput(input, {
                                  utilsScript: "Scripts/utils.js"
                              });
                     
                              document.getElementById("hdnLabelState").value = iti.getNumber(intlTelInputUtils.numberFormat.E164);
                          }
                      </script>
                      <tr>
                          <td align="center" colspan="2">
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="Password" validationgroup="Createuserwizard1" ErrorMessage="Password must be 8-15 characters long, have an<br />uppercase letter, number, and special character." ForeColor="Red" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"></asp:RegularExpressionValidator>
                          </td>
                      </tr>
                      <tr>
                          <td align="center" colspan="2">
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" validationgroup="Createuserwizard1" ErrorMessage="The email you entered has invalid syntax." ForeColor="Red" ValidationExpression="(?:[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+)*|&quot;(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*&quot;)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])"></asp:RegularExpressionValidator>
                          </td>
                      </tr>
                    </table>
                  </td>
                </tr>
              </table>
            </contenttemplate>
          </asp:createuserwizardstep>
          <asp:completewizardstep runat="server" title="Complete">
            <contenttemplate>
              <table border="0">
                <tr>
                  <td>
                    <table border="0" style="height: 100%; width: 100%;">
                      <tr>
                        <td align="center" colspan="2">
                          <asp:Label ID="Label2" runat="server" Text="&nbsp;Complete&nbsp;" BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"></asp:Label></td>
                      </tr>
                      <tr>
                        <td>
                          Your account has been successfully created.</td>
                      </tr>
                      <tr>
                        <td align="right" colspan="2">
                          <asp:button runat="server" validationgroup="Createuserwizard1" commandname="Continue"
                            id="ContinueButton" causesvalidation="False" text="Continue" />
                        </td>
                      </tr>
                    </table>
                  </td>
                </tr>
              </table>
            </contenttemplate>
          </asp:completewizardstep>
        </wizardsteps>
          <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" HorizontalAlign="Center" />
          <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
          <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="#FFFFFF" />
          <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
          <StepStyle BorderWidth="0px" />
      </asp:createuserwizard>
    <input type="checkbox" onchange="document.getElementById('<%= ((TextBox)RegisterUser.CreateUserStep.ContentTemplateContainer.FindControl("Password")).ClientID %>').type = this.checked ? 'text' : 'password'" /> 
    <br />
    <a href="https://fontmeme.com/inanimate-insanity-font/"><img src="https://fontmeme.net/permalink/190417/884f884e690298af2ec92d6b92a05ec9.png" height="30" alt="inanimate-insanity-font" border="0" /></a><br />
    <br />
    <img src="Images/PasswordHint.gif" height="40" style="margin-top: 10px" /><br />
      <asp:TextBox ID="PasswordHint" runat="server" Width="200px" Height="20px"></asp:TextBox>
    <div class="g-recaptcha" style="margin-top: 10px; margin-bottom: 10px" data-type="image" data-sitekey="6Le-Sk0UAAAAAEy6zP3KeCwKOlg4T860E5C0Anyp"></div>
    <br />
    <asp:CheckBox ID="CheckBox1" tabindex="12" runat="server" />
    <br />
    <a href="https://cooltext.com"><img src="https://images.cooltext.com/5279281.png" width="247" height="40" alt="I have read and agree to the " /></a><a href="Privacy Policy"><img src="https://images.cooltext.com/5279284.png" width="226" height="40" alt="Privacy Policy " /></a><a href="https://cooltext.com"><img src="https://images.cooltext.com/5279285.png" width="61" height="40" alt="and" /></a><a href="TermsOfService.html"><img src="https://images.cooltext.com/5279286.png" width="202" height="40" alt="Terms of Service" /></a>
      <br />
&nbsp;</div>
<script type="text/javascript">
var elems = Array.prototype.slice.call(document.querySelectorAll('.js-switch'));
elems.forEach(function(html) {
  var switchery = new Switchery(html);
});
</script>
</form>
<footer>Copyright &copy; 2019 Max Voisard<br /><a href="mailto:max.voisard@gmail.com">max.voisard@gmail.com</a></footer>
</div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jasny-bootstrap/3.1.3/js/jasny-bootstrap.min.js"></script>
    <script src="https://intl-tel-input.com/node_modules/intl-tel-input/build/js/intlTelInput.js?67"></script>
    <script src="https://intl-tel-input.com/js/demo.js?3"></script>
</body>
</html>