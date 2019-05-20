<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Random.aspx.cs" Inherits="WebApplication6.Random2" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Register src="WebUserControl.ascx" tagname="WebUserControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//WAPFORUM//DTD XHTML Mobile 1.0//EN">

<html lang="en-us" xmlns="http://www.w3.org/1999/xhtml" xmlns:fb="http://ogp.me/ns/fb#">
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
    <script async="" defer="" src="https://survey.g.doubleclick.net/async_survey?site=xp6xgahi7ejimgm2yd57tnr7du"></script>
    <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
    <script type="text/javascript" src="Scripts/jquery.min.js"></script>
    <script type="text/javascript" src="Scripts/my_script.js"></script>
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
    <title>Random</title>
    <link id="page_favicon" href="data:image/x-icon;base64,R0lGODlhEAAQAPZgAAAMCwAFEgAGEQAAGAASBQASBgAXAAAYAAAeBgAAJgAFLgAANAAANQAcPQAkAAArBgAqFAAxAAA9AAAlKAAvKAAkMwAAQwAAUQAAUgAAXAASRwAAZgAAcAAAegAAewBJAABKAABUAABeAAByAABzAAB1AABGSQBGWgBSSQBeWgBeYgB3dAAAjQAAjgAAkwAAlAAAnAAApAAArAAAtAAAtQAAvQAvhwA2oQAAxQAAxgAAyAAAzQAAzgAA1QAA1gAA1wAA3AAA4gAA6AAA6gAA7wAA8AAA8QCFAACLAACMAACYAACCLAClAAC8AAC9AACnNACtOwCzPAC5OwDNAADXAADdAADeAADfAADkAADqAADrAADsAADwAAD3AAD4AP///wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH5BAkKAGAAIf8LTkVUU0NBUEUyLjADAQAAACwAAAAAEAAQAAAH/oBfYGBgYAQKDRscIWBgYGBgYGBgBwsUIyYuKExKJWBgYGBgBxAiHS8xNDY4Tk5IYGBgBwgTHS8yNDtUVlY3OkhgYAcWHC0wNDs9VitFW1ZOYAQCFxwvMjg9QVpdUl1RTycACRcdLzQ4PVhdXV1dXVg1AwkaHS40OEBaXV1dXV1aOAZEqNABBg0cPbB06dKlSxctOAY4COHhBQ0cPYQUKeKlSxcoNAYcADEiiYwaO4AIKVKEi5YbMsAMkCDiCAwaOHoACSLEihUVYMAMMABiRAsYNGrg6HFjSooXYMCAEfDgQocWMGTQqFFjyQswYMCAAUNgwQUOHV64cPGiAxgwFWDAgAEDBsyABRc2ZLgABgwYMGACAQAh+QQJCgBfACwAAAAAEAAQAIYADAwAABcABhIAABgAEQYAGAAAHgUAGBoAACYAADQAADUAEiAAEi8AHD0AHT0AJAAAKgYAMAAAMQAAPQAAOBMAJCkAJSgALikALygAAFEAAFIAAFMAAFwAAGYAAGcAAHAAAHoAAHsAI28ASQAAVAAAXgAAcgAAcwAAdQAAeQAAfwAARUoAUUoAXmIAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0AIoAALogAPrIAAMUAAMYAAM0AANUAANYAANwAAOIAAOgAAO8AhQAAiwAAjAAAmAAAjiwApAAApQAAsAAAsQAAvAAAvQAAvgAAvwAApzUAqDQAxQAAxgAA1QAA3QAA3gAA5AAA6gAA6wAA9wAA+QD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBeX19fXwIbDh4eF19fX19fX19fBBEOIEcxNEpIKF9fX19fBRAXKjI0Nzg8SU8rX19fAA8VJiI1Nz4/U1hYLUdfXwUTHjA0Nz4/QlpEO0JPXwMBFCAyNTw/QkRdXFxaUiwDBhUgMjc8P0NEXFxcXFlPAwccIDE3PEFERFxcXFxaVQYoKKFixg0eQYYQ4cKFCxctVQYgIJHiyA0eP4YQIUKECBcsOgYMGIHiSJMnPoIMIUKEiBYrOb4MYFCiiJImPH78ECJECJYnX74MCDDCxBElN3D4+PHDx5MYX758GbCAhAkYM2rcwGHjRowvX758+TIgwoYPLmTEiBEDxJcvFV++fPny5UuABBs8cNjw5cuXL18CAQAh+QQJCgBXACwAAAAAEAAQAIYACwwADAsADAwAABcAABgACxoAACYAADQAADUAEj0AJAAAKgYAPQAALygAAFEAAFIAAFwAHFwAAGYAAGcAAHAAAHEAAHoAAHwAAH0AI1wAImkAI3YASgAAQhQAVAAAVQAAXgAAaAAAcwAAdQAAaSUAdCUARVwAUkkAXVoAX1kAbnIAb3cAenoAAIEAAJMAAJQAAJwAAKQAAKwAAK0AALQAALUAAL0APbMAAMUAAM0AANUAANYAANwAAN4AAOIAAOgAAOsAAO8AAPAAhQAAjAAAjQAAmAAAmgAApAAApQAAsAAAvAAAvQAAvgAAxQAAzQAA3gAA4AAA5AAA6gAA6wAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBWV1dXVwEODRMVHldXV1dXV1dXBAsgFxpGMDFGI1dXV1dXBAwgF0QyNTY4OEwkV1dXBAoeEUQbNTk7OztRTEZXVwIcIUQxNTg7PkFBQDwoVwQACREvMjg7PkFBQVVTUCYEBQ4XLjU4O0BBQjdVVVJMBAgdFi81ODw/QUJCVVVSTggggJChBAocPH4ECRKkCospTggYcBDBiBImO3wECRIkSJAVTAgQcCCCCBImT1T8CBIkCJAdSK4QQCBhCBImTJ7w8PHDxw4mV64QGOCgAhEkTJjk2LEjh40SV65cIWDAgQgiJ2TUsFGjhosrV65cuUIAgYcKLVy4gOHCwpUrFVeuXLly5cqAAw4kQHBw5cqVK1cCAQAh+QQJCgBgACwAAAAAEAAQAIYAABcABhEAABgAACYAADQAADUAPQAAJCkAOjIAOT0APz0AAFEAAFIAAFwAEkcAHFIAHVwAAGYAAHAAAHoAAHsAIm4AInAAVAAAXgAAXwAAVh4AcgAAcwAAdQAAeQAAfwAAaCQAUlIAUVsAXVsAXmIAXmMAZ2IAaGEAbnIAdXcAAIEAAI0AAI4AAJMAAJQAAJUAAJwAAJ0AAKUAAKYAAK4AALQAALUAAL0AAL4AL4cAAMUAAMYAAM0AAM8AANUAANYAANcAAOIAAOgAAO4AAO8AiwAAjAAAjQAAlwAAmAAAmgAAgS0AjS0AjiwApAAApQAAsAAAsQAAvAAAvQAApzQAxQAAzQAA1QAA3QAA3gAA5AAA6gAA8gAA9gAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBfYGBgYAELCwgQDmBgYGBgYGBgAgYYGkZJITJJHWBgYGBgAgYYHi4iNjc6OkwgYGBgAgMXGxZOIyc+Pj4+PRVgYAIGG0ZITDo+QUJEQihTYAIABxtFSzo+QURERERbV04CAwsJLjk6PkREREREXVhTAgUNCi42Jj5CRERERF1bVQQUaDAhho0SQIIQIUKECJEUJQQMWEDBBY0pV7QQIUKECJEgNwQIWCCBBZQpVrBo4UKEiBAfTsAIKBBBRYwpU6xgwSIkiI8bYMAIALBAAgsZU6ZYoeKjx40WYMCAETBgwQQWTqDYuGHDRgswYMCAASOgwIIHH1y0aOFiAhgwFWDAgAEDBgyAAgsiNFgABgwYMGACAQAh+QQJCgBTACwAAAAAEAAQAIYAABcABhEAABgAACYAADQAADUAPgAAOjwAAEMAAFEAAFIAAFwAEkcAHEcAHUcAHVwAAHAAAHoAAHsAL3YAQRQAXgAAUh0AVh4AaAAAcgAAeQAARkoAXVsAb2oAAIEAAI0AAI4AAJMAAJQAAJUAAJwAAKQAAKwAALQAALUAAL0AAL4ALpkANqEAAMUAAMcAAM0AAM4AANUAANYAANcAANwAAOIAAOgAAO4AAO8AAPEAhQAAiwAAjAAAmAAAgSwAjDYAjjQApAAAsAAAsQAAvAAAvQAApjsArTsArjsArzoAxQAAzQAAzgAA1QAA3gAA5AAA8AAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBSU1NTUwEKCg0PDFNTU1NTU1NTAgYUFxsjQRMhFlNTU1NTAggVGjslHCktLSc7U1NTAgMKGTxBRT8dMzMzQB9TUwIIGDpBRUozNTY3NjRFUwIACgc7QkUsNTc5Nzc3TkECAwoRPSctMzY3Nzk3OUZFAgULESNCMDRJNzc5Nzc3SgQUWBBhxIkVM5LkyHEjR44bLQQMUBBhxIkWM55AiXLjxo0aJwQAUADhg4kUS5w8gRIFio0ZJqYIKLDAQ4gTLZY4efIkyYwUU6YIGKAAwgcSJ1IsadIERooQU6ZMEVBAQYQPJHwUKZLiRIgpU6ZMmSJggAIIEXiMCBEiwpQpFVOmTJkyZQqAAgoaLFAwZcqUKVMCAQAh+QQJCgBOACwAAAAAEAAQAIYADAsAABcAABgAACYAADQAADUAMQAAAEMAAFEAAFIAAFwAEkcAEV0AHFIAAGYAAGcAAHAAAHoAAHsAI2gAI2kAIngAVAAAdAAAeQAAaSUARUoAUlMAb2oAb2sAAIEAAI0AAJMAAJQAAJYAAJwAAKUAAKwAAK0AALQAALUAALYAAL0APbMAAMUAAM0AAM4AANUAANYAANcAANwAAOIAAOgAAO4AAO8AAPAAAPEAiwAAjAAAljUApAAAsQAAvAAAvQAAvgAAxQAAzQAAzgAA1QAA3QAA3gAA5AAA6gAA6wAA8AAA9wAA+QD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBNTk5OTgAJCQ8NC05OTk5OTk5OAgYWFxMhJBshDE5OTk5OAgcKGDk8KD8sLCgVTk5OAgMJETo9P0NEMS8vLBpOTgIHEBM8P0FGRjY2NDIsTgIBCRAhPD9ERjY2NjY2LzwCAwkRIShBLzQ2NjY2NjQ/AgUKESAoOxw2Nis2NjY2LAQUUBBhBIoWL3DYWMLEhg0bLAQMSBAhRAkWL2jYWLJkCY4ZKAQESBDhQwkVL2QkUbJESZIXJZwIKPDAwwgUKl7IOHLEiBEVTpwIGJAAwocRKFS04EBkCAoQTpw4EVAgQYQPI0qg+PEDBQgnTpw4cSKgQAIIHkKEyBAighMnFU6cOHHixEkAAgkePEjgxIkTJ04CAQAh+QQJCgBKACwAAAAAEAAQAIYADAsAABcAABgAACYAADQAADUAEjwAOTMAAEMAAFEAAFIAAFwAAGYAAHAAAHoAAHsAIncAI34AXgAAVhQAcwAAaSQAaSUAUkkAX1oAb2sAe3cAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0ALpEAL5AAPbMAPrIAP7IAAMUAAM4AANUAANYAANwAAOIAAOgAAOkAAO8AAPAAjAAAnjUApAAAsAAAsQAAvAAAvQAApzQApT0AxQAAzQAA1QAA3QAA3gAA5AAA6gAA6wAA8AAA9gAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBJSkpKSgAKCgcTC0pKSkpKSkpKAAQSFBYWFxAeDUpKSkpKAgQLDjU3OCU7JiQeSkpKAgMKDh84Oz42QjwtKx1KSgIIDB0hOD5AQkQzMS8rSgIBCg4fIiZAQkRIMzMzLRECAwoOHyQrGUMzMykzMzElAgQLDh4kKy1EGjM0MzMxKwQQWOAABAkWLWLMoJECCZIZKwQMUODgg4gVLWLMmJECCZIeGAQIUNCgQ4gSLV7EmIHECBEgIpQIQLBggwcSJVrAgBFDiJAdSpQIGKCgQQcQJEqsaNHihw8PSpQoEUBAgYMOIESQKEECxwclSpQoUSKAgIIGDj54AFHDgRIlFUqUKFGiRIkAAgoYMDCgRIkSJUoCAQAh+QQJCgBOACwAAAAAEAAQAIYAABcABhEAABgAGAAAACYAADQAADUAMQAALygAAEMAAFEAAFIAAFwAHFwAAGYAAGcAAHAAAHoAAHsAAHwALnAAcgAAcwAAaSQARkMARUoARkgAUEsAUkkAX1kAX1oAZmwAb2IAb2sAfXUAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAALYAAL0ALpgAPbMAPbQAAMUAAMcAAM0AANUAANYAANwAAOIAAOgAAO4AAO8AAPAAAPEAgSUApAAAvAAAvQAAuTsAujsAxQAA1QAA3QAA3gAA3wAA5AAA6gAA9gAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBNTk5OTgMLCw4VC05OTk5OTk5OAQcIFRgZGxsZEE5OTk5OAgkMDSc/QUEyQSwmTk5OAgQLEScpHURFR0cfMiVOTgIJDiUoLC9FR0pKMTcyTgIACxEnKjI1R0pLSzw7NSkCBAsRJywyNTlCSzsiOzkuAgYMESYsMjU7O0JLMDs7MgQYYBABBQsZN3Ls2LGDxxIlIAQQWBDhBAsZNXDs2LFjx5IkQQQAWADhhAoXNG7k2LFjh5IiPpwIMMBghAkWMmrcwIEDR4ggTpwIILAAQgkULFzQqFGDhgcKTpw4CWBgQYQSKFSwcMGCxQUnTpw4cSLAwAIII06YMHFighMnFU6cOHHixIkAAwscMFjgxIkTJ04CAQAh+QQJCgBIACwAAAAAEAAQAIYACwwADAsAABcABhEABhIAABgAGAAAACYAADQAADUAPgAALikAOT0AAEMAAFEAAFIAAFwAAGYAAHAAAHoAAHsAIm8AXgAAdAAAaiQAdSwARUoAUUoAbWwAbnEAfHcAAIEAAI0AAI4AAJMAAJQAAJUAAJwAAKQAAKUAAKwAALQAALUAAL0APbMAAMUAAMYAAM0AANUAANYAANcAANwAAOIAAOgAAOoAAO8AAPEAjQAAmAAApAAAsAAAvQAApzQAuTsAxQAA1QAA3QAA3gAA6gAA9wAA+AD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBHSEhISAYPDxEXC0hISEhISEhIBgoWDDkaGxkjEkhISEhIAAgQExgmPD09PT0iSEhIAQcPEyMoKi1BQ0McLSFISAUNESEmKi8wQ0RERD4tSAUCDxMjKC0wNDdGRT84MCYFBw8TIyotMDY3Nz8eLDYrBQgQEyIqLTA2Nzc3OEY3QAoggDChhIoWMGrcuHHjxo0bQAoceDBhhIoWMGjcuHHjxo0OPQYIeCBhBIoVL2bUuHHjhg0YO5AUQADhgwgVLWDMoFGDBowVSJAMOPBAQogSKla0gAHjxQodSJAgKXDgwYQQJVCoWJFCRQUkSJAgQVIAwQMJE0aUECFiAhIkFUiQIEGCBIkABA8iQHiABAkSJEgCAQAh+QQJCgBIACwAAAAAEAAQAIYADAwAABcABhEABhIAABgAEQYAGAAAACYAADQAADUAEiAAEi8APQAALygAAEMAAFEAAFIAAFwAAGYAAHAAAHEAAHoAAHsAI24AVAAAXgAAVx4AcwAARUoARloAXmsAbnEAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAALYAAL0ALpgAAMUAAMYAAM0AANUAANYAANwAAOIAAOgAAOkAAO4AAO8AjQAAjS0ApAAApQAAsgAAvAAAvQAAvgAAvwAApTYA1QAA3gAA6gAA8gAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBHSEhISAYQEBIaGEhISEhISEhIBgwZGzgcOzsXFEhISEhIBgsNFSQ8KT09PT0cSEhIAwcQFSQmKS8wQUNCOSJISAQJEiIlKS8wMzVEREMtSAQBEBUkJy0wMzc3N0ZFMCYEBxAVJCktMDU3Nzc3Rh8rBAkRFSMpLTI1Nzc3Nzc3HggkiFChRIoWMGrcuHHjxo0bLAAcgFBhRIoWMGbcuHHjxo0ZQgwEgEBhxIkVL2TQuHHjBg0YHZAQcBABxIgULWDImEFjBowVSJAUCACBgogSKVa0gAHjxYoRSJAgGZAAQgURJU6kWIEixQgkSJAgQUJAAQQKFUiUGDGiAhIkFUiQIEGCBEmABBAkRICABAkSJEgCAQAh+QQJCgBCACwAAAAAEAAQAIYADAsAABcABRIABhEABhIAABgAGAAAHgUAACYABSAAADQAADUAEj0AJAAAPQAAJSkAOj0AAEMAAFEAAFIAAFwAHVsAAGYAAHAAAHoAAHsAImkAXgAAcwAAdQAAaSQAdCUAfXYAAIEAAIcAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0AAMUAAM0AANUAANYAANwAAN4AAOIAAOMAAOgAAO8AgAAAjAAAmQAAjS0ApAAAvAAAvgAA1QAA3gAA6wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBBQkJCQgYREhYQDEJCQkJCQkJCBg4bHCQ5HzseHUJCQkJCBg4UNyYoOiw9PT04QkJCBgcMGCYpKy0vLzE+PBpCQgIPFyInKy4vNDY2QD88QgIBEhcmKS0vNDY2NjYgPygACBIYJistLzU2NjY2NjQ9AAsUGCUrLTE1NjY2NjY1LQQsoIDhxIoWL2rYsGHDhg0bLQokkIDBxIoWL2jYsGHDhg0aKwoUkHDBRAoWLmLUsGHDRo0XKYQYWEAhRIkVLV7EoFGDRgwWQoQYaCChAokTK1i0ePHCBYsSQoQIKYBAAgYSJ1KsYKFiRQkhQoQIEVJggYQLGEycKFECgxAhFUKECBEiREiABRIsUJAgRIgQIUICAQAh+QQJCgBHACwAAAAAEAAQAIYACwwAABcABRIABhEAABgAEQYAEgUAFwAAGAAAACYABiAAADQAADUAEj0AJAAAMAAAMQAAPQAALygAAEMAAFEAAFIAAFwAHEgAHVwAAGYAAHAAAHEAAHoAAHsAAHwASQAAVAAAXgAAVh4AWB4AZB4AcgAAaCUAaSQAaSUAUVIAXmIAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0AAL8AAMUAAM0AANUAANYAANwAAN0AAOIAAOgAAO8AjAAAmAAApAAApQAAvAAAvQD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBGR0dHRwUNFBkYEkdHR0dHR0dHCA8hJSgvQ0MnIkdHR0dHCBEhHigxNDc3KkRAR0dHCA4gHi8xNDg6Ojo6REFHRwgTGy0wNDc6PT4/PjxERwAHFBwvMjc6PT8/Pz8/OikICRQcLzQ3Oj4/Pz8/Pz41BAwWHC80Nzo+Pz8/Pz8+NwowsMABBo0bO3z8+PHjx48fNwYooMDBBY0bOnz8+PHjx48eNAgQoCCihYwaOnj4+PHjhw8dMo4MiHBhhQsaNXTw6OGjB48aR44QOPBhQwsYM2rg0KEDRw0XR44cIfAABIcWMGTQqEGDhosjR44cOUIgAYUNJF64gPGCw5EjFUeOHDly5EgABhQyWKBw5MiRI0cCAQAh+QQJCgBCACwAAAAAEAAQAIYACwwABhEAABgACxoAFwAAGAAAGBoAADQAADUAEj4AHD0AJAAAKwUAOAUAPQAAOSkAOjIAAFEAAFIAAFwAAGYAAHAAAHEAAHoAAHsAI3YAIXgASQAASgAAQhQAVAAAXgAAcgAAcwAAdQAAeQAARUkAUlIAAIEAAIcAAJMAAJQAAJwAAKQAAKwAALQAALUAALYAAL0AMI4AAMUAAM0AAM4AANUAANYAANwAAOIAAOgAAO8AiwAAjAAAjQAAmAAApAAApwD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBBQkJCQgERERQWHUJCQkJCQkJCBQ4fIDwkGkA+IkJCQkJCBQ0fIyglLzAxMi87QkJCBQseIDwsLzQ2NjY2MjtCQgUbECdALzI2ODo6OTcyQgUEGxcpLDI2ODo6Ojo6NhkCBhEXKS8yNjk6Ojo6OjkwAgMKFykvNDc5Ojo6Ojo5MgQciHBBxQsZN3Lo0KFDhw4dMgQASHABxQsZNnDo0KFDhw4cLwQIiFCBx4oXNm7k0KFDRw4bLIQIOPDAhIoXMWzcwJEDxw0YQoQIILABxA4VL2DIsGGDBgwUQoQIEcDAAwgeKli0gAHjBQohQoQIESLgQIQKJlCgUIHighAhFUKECBEiRIiAAxEoTIggRIgQIUICAQAh+QQJCgBKACwAAAAAEAAQAIYADAsADAwAABcABhEAABgAEQYAFwAAGAAAACYABiAAADQAADUAEj0AJAAAMAAAPQAAAEMAAFEAAFIAAFwAAGYAAHAAAHoAIlwAIm8AI24ASQAASgAAQhQAUwAAVAAAXgAAaAAAcgAAcwAAdQAAeQAAayMAaSUAaiQAdiQARUkARlIAAIEAAJMAAJQAAJ0AAKQAAKwAAK0AAK4AALQAALUAAL0AL4cALogAAMUAAMYAAM0AANUAANYAANwAAN0AAOIAAOgAAO8AiwAAjAAAmAAAji0ApAAApQAAvQD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBJSkpKSgAQERQVHEpKSkpKSkpKBw4fIUMmKEdEI0pKSkpKBQ8fJEIxNjU4ODQpSkpKBw0eIUNHNzo7Ozs7OCZKSgcaIENHNDg7P0FBQD04SgQGGiFDMTU7P0FBQUFBOy8BCB4kJTQ4O0FBQUFBQUA1AAkdFhg0ODtAQUFBQUFBOAgMmGBBBQ0dO4AECRIkSBAgOAggiECiBQ0cO34ECRIkSJAfNAgQYFChxQskOnoACRIkCJAdMZQQUEBhhQsaOHb0+AHkx44aSpQQEBAhxJAjRWro2LFDRw0WSpQoIYDAQ4ghRGLQoEGDBgslSpQoUUJAQYQKF1qwwMDCghIlFUqUKFGiRAkBBREoUIigRIkSJUoCAQAh+QQJCgBSACwAAAAAEAAQAIYACwwAABcAABgAFwAAGAAAACYAADUAET4AJAAAMQAAPQAAJTIALz0AAEMAAEQAAFEAAFIAAFwAAGYAAHAAAHoAAHwAIncASQAASgAAVAAAXgAAVR8AVh4AQD0AaAAAcgAAeQAAdi0AR0gAXVwAXWwAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKUAAKwAALQAALUAAL0AAL4ALogAL5AALpkAN6AAOKAAPrIAAMUAAMYAAM0AAM4AANAAANUAANYAANwAAOIAAOgAAOoAAO8AgAAAiwAAjAAAmAAAgCUAlTUApAAApQAAsAAAsQAAvAAAvQAA3gD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBRUlJSUgIQEBITC1JSUlJSUlJSBAoaH0ZHSiFHDFJSUlJSAAoaG0VKMjE5OS8oUlJSBAgZH0ZITyQ+Pj4+OSZSUgQXHkZKIzQ1QENDQT85UgQDFx9GTTE2QENDQ0NDPisCCAcgR005PkFDQ0NDQ0ExAgkRRBYvOT9BQ0NDQ0NBOAQUiNBBxQseP4IMGTJkyJAhOQQUgLAhRZMcPoAMGTJkyBAgLgQIgDDBBIsYOqAEuTFkSBAfLaQIaCChhIoXM3wAARIEyI8YUqQICABhggklT54k8eFDRwwUUqRIEVAgQgUjSpo8ieHiBQopUqRIkSLAAIQJJVKkQCGCghQpFVKkSJEiRYoABxAkSIAgRYoUKVICAQAh+QQJCgBQACwAAAAAEAAQAIYACwwAABcABRIABhIAABgAEQYAGAAAACYAADQAADUAEjwAMAAAPQAALykAAFEAAFIAAFwAAGYAAHAAAHoAAHsAI24ASQAASgAAQRQAVAAAXgAAcgAAcwAAeQAAAIEAAI0AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0ALoAALogAL5cALpgAMI8ALqEAPbMAP7EAPbQAAMUAAMYAAM0AANUAANYAANwAAN0AAOIAAOgAAOkAAO8AAPIAhQAAiwAAjAAAmAAAjywApAAAsAAAsQAAvAAAvQAAvgAAxQAAzQAA1QAA1gAA1wAA3wAA6gD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBPUFBQUAQPDxESClBQUFBQUFBQBgsYHD5AQkIhElBQUFBQBQwaHT5CRikyMiUgUFBQBAAZHD5ERkhKNDQ0Mh9QUAYWHD1CRkhNODs7OTYyUAUCFhw+REZKOC47Ozs7NCMABxgdQERISjk7Ozs7OzknBgkNEyJGKjQ5Ozs7Ozs7MggkgDABRIkVNHjs2LFjx44cMggceDAhRBAZSnDs2MFjxw4cJQQEeCDhA4oSLWzkcALDRQ4aJKAQSADBg4gSMmjYwJEDBw0WUKAQOPBAwgcRJYwkUaJkxgkQUKBAIZDgwYQPQIgYMWKkBAgoUKBAgUIgwQMJE0KAqABiAhQoFVCgQIECBQqBBA8iQHgABQoUKFACAQAh+QQJCgBWACwAAAAAEAAQAIYACwwADAsAABcABhEAABgAEgUAFwAAGAAAACYABSAAADUAGSgAJAAAPQAANxQAAEMAAFEAAFIAAFwAEkcAAGYAAHAAAHoAAHsASgAAVQAAXgAAXwAAVh4AaAAAcgAAeQAAaSQARkoAdXcAe3cAAIEAAI0AAJMAAJQAAJwAAKQAAKwAALQAALUAAL0AL48AN5kAOJ8AOKUAPqwAN7QAPbMAPLQAAMUAAMYAAMcAANUAANYAANwAAOIAAOMAAOgAAOoAAO8AAPEAiwAAjAAAmAAApAAAsAAAsQAAvQAArjsAsT0AxQAAzQAA1QAA1wAA3QAA3gAA3wAA5AAA8QAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBVVlZWVgQLEBQVE1ZWVlZWVlZWAQ4bHENERUUhFVZWVlZWBw0bH0JFSEg4LismVlZWAwkZHkNFSEtNUDo6OCVWVgANHUNFSEtNUDQjPjs4VgcGGB5DR0hNUEpAQEBAOSkHDBsWREhLUFJUQEBAQD4tBwoSFkQrOFAyQEBAQEBANg4okGABxAocOpIAoQEECBAfOA4ggGDBxAocTXhMAQIECBAeKw4QgFDBRIoWL2LMCAJkig8YKqwUeCCBhIkVLXTw4CGCh44WVqwMEAChQgkUK1rgaNKESQsTVqxYIaAAgoUSKFQgQYLkyAkrVqxYsUJAAYQKFk6cMHHCghUrFVasWLFixQoBBRAoSIBgxYoVK1YCAQAh+QQJCgBaACwAAAAAEAAQAIYACwwADAsAABcABRIABhEAABgAEgYAFwAAGAAAACYAADUAEi8AEj0AJAAAJRoAMQAAPQAALygAJTIAOT0AOD4AAEMAAFEAAFIAAFwAAGYAAHAAAHoAAHsASQAAVAAAXgAAXwAAVR8AeQAAaSQAUksAcGkAfHgAAIEAAI0AAJMAAJQAAJwAAKQAAKwAALQAALUAALYAAL0ALpEAMIcAN6cANrQAPbMAP7EAPLQAAMUAAM0AANUAANYAANwAAOIAAOgAAOkAAOoAAO8AAPAAAPIAiwAAjAAAmAAAnjUAowAApAAAsQAAvAAAvQAAuTsAxQAAxgAAzQAA1QAA3QAA3gAA3wAA5AAA6gAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBZWlpaWgEMFhkaElpaWlpaWlpaBA4gFEZHSkokGlpaWlpaCBAgIkVKTU1NMjMqWlpaAQ0RFEVKTU9SVFQlOShaWgQVIUZKTU9UVFdEQD05WggHHRRFS01SVFdYTkJCPCwIDR4iKklPVFZYWDhCQkAxCA8gHCsvTzw1WEJCQkJCORA88MBhxYsnPIAIsSHEhhAhORA0sMBBxYscPHyYEILFhhAfLwAcsKABRYsYOnoAESJECBAeLLQgWJDhRIoXOXj08AGEhpUYWrQYEGBBA4oVL2Lo4IEkShMVWrRoKZDAAgcUK1q8iNHkxQgtWrRo0VIggQUNJ1SkWKGCgxYtFVq0aNGiRYsABRYyYLCgRYsWLVoCAQAh+QQJCgBdACwAAAAAEAAQAIYABhEAABgAEQYAEgUAFwAAGAAAGBoAADUAJAAAMAAAMQAANhQANxQAOD4APz0AAEMAAEQAAFEAAFIAAFwAEkcAHFIAAGYAAHAAAHEAAHoAAHsAAHwASQAATB4AVAAAXgAAaQAAcwAAeQAAfwAARUQAXloAXmIAb3EAe3gAAIIAAI0AAJMAAJQAAJwAAKQAAKUAAKwAALQAALUAAL0ALogAOKUAO7YAPbMAPrMAAMUAAMYAAM0AAM8AANUAANYAANwAAOIAAOgAAOkAAO4AAO8AAPEAhgAAiwAAmAAAmQAAjiwApAAAsAAAswAAvAAAvQAAvgAAszsAxQAA1QAA1gAA3QAA3gAA5AAA5QAA6gAA9wAA+AD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBcXV1dXQIQEhYXFF1dXV1dXV1dAQYfFSRIS0tIF11dXV1dAQkfIkdLTE9PT08rXV1dAQAeDUdLT1JTU1ZTOSpdXQUPHUYvT1JWVllZUSc5XQIEHCFHTE9TVllaWlpBPS8FCR8bSDQmVldaWlpbREAzBQgfDkglOT9ZRChaRDhEOQIk+DACSYwdPa4QIUKECBEiOQIgWCBiBYwcPYAQIWIDR5EaSgIQWHBBxYsZO34EIUKkSJAeMLoUSAAixYoYOXr8AAIESI8nXboEICAhhIoWMWbk6NGjxxMkXbp0CXBgwgYVLWDEmBGDyYouXbp06RLggIQLGVi0WMEiQ5cuFV26dOnSpUuAAxIsTJDQpUuXLl0CAQAh+QQJCgBiACwAAAAAEAAQAIYADAwAABcAABgAEQYAFwAAGAAAGBoAACYABSAAADQAADUAEi8AHD0AJAAAMQAAPQAANxQAJSkAAFEAAFIAAFwAEkgAHVEAAGYAAHAAAHoAAHsAI24ASQAASgAAQRQATBQAVAAAXgAAcgAAcwAAeQAAfwAAaCUAaSUAdSQARkMARkoAXmIAaGIAdXgAfHgAAIEAAI0AAI4AAJMAAJQAAJUAAJwAAKQAAKwAALQAALUAALYAAL0AAL8AMI4ANqEAPrMAAMUAAMYAAM0AANUAANYAANwAAOIAAOgAAOkAAO4AAO8AhQAAiwAAjAAAmAAAgC4AjS0ApAAAsAAAsQAAvAAAvQAApzUAxQAA1QAA3QAA3gAA3wAA5gAA6gAA8AAA9wAA+AD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBhYmJiYgMREhcYFWJiYmJiYmJiAgkMIzEmUVFOFmJiYmJiAgsfJSZRVVVVUFUbYmJiAg0eI01PVVdYWFpYVTFiYgIPFilRVVdaWl1dXVo9YgIEHCMqU1VYWl1fX19dQzYADiEkTlNXPlxeX19fLkg7BQ0hJU46V1ZISl9KP19IQAQYCFHCyZQVRY4oAaNEiZIWLAQcAEGCyRQgQ44oUaJEiQstOwQE4DCCiQ0dQoocUaJECZIhKMQIeBBiCQ0dQIYUMXLEyJAdYsQICMBhRAwUOnYIGTJEyI4mYsSIEYAAQoYYNW7o2KFDBw0xYsSIESMggQQML2jIqEEjgxgxFWLEiBEjRkyABBIoUJAgRowYMWICAQAh+QQJCgBhACwAAAAAEAAQAIYAABcABRIABhEAABgAACYABSAAADQAADUAJAAAMQAALykAAEMAAFEAAFIAAFwAHFwAAGYAAHAAAHIAAHoAAHwAIlIAIm8AInEALXoASQAASwAAVAAAXgAAXwAAcgAAcwAAeQAAfwAARkMARUoARkkAXVwAXmMAZmsAb2oAb2sAdXcAe3gAAIEAAIgAAJMAAJQAAJwAAKQAAKwAALQAALUAAL0AAL4AI4cAPLQAPbQAAMUAAMYAAM0AAM4AANUAANYAANwAAOIAAOMAAOgAAOoAAO8AAPAAAPMAhQAAiwAAjAAAmAAAgiwAlDYApAAApQAAsAAAsQAAvAAAvQAAvgAAujsAxQAAxwAA1QAA3QAA3gAA5AAA5QAA6gAA8AAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBgYWFhYQIZDRASG2FhYWFhYWFhAgYNDyIjGE5LFWFhYWFhAwsKFCNPU1NTU1NJYWFhAwQNH0pPU1ZYWlpaVhdhYQMLEi1PUycoWl1dXVpTYQMAGR9KTDtYWl1eX19dWjEDCBsgS1BWWlw5OV9fVVw1AwkcIUtTVildOUVHK0VHOwYU4BBiCZQmWlQUKVJkRZEcVgYQaAAiCZQpWIgUKVKkSJEgMwYAaCBBCZQpPIAQKVKkyJAfN8IMMAAByZMSNX4ECTIkyI8aYcIMINDgg5IlM0zw+PGDR40RYcKEGWCgwQcLMGTMqFFjhoswYcKECTPAQIMILFy4cOFiQpgwFWHChAkTJgwAAw0gOGgQJkyYMGECAQAh+QQJCgBdACwAAAAAEAAQAIYADAsAABcABhEAABgAEgUAGAAAACYABiAAADQAADUAEj0AOjwAAEMAAFEAAFIAAFwAHVEAHF0AAGYAAHAAAHoAAHsASgAAQhMAQRQAXwAAdQAAeQAAfwAAdSUARUMARkoAUkQAXWMAfHgAAIEAAI0AAJMAAJQAAJUAAKQAAKwAAK0AALQAALUAAL0AIYEAL5cANqEAN6AAOKUAAMUAAM0AANUAANYAAOIAAOQAAOgAAOoAAO4AAO8AAPAAAPEAhQAAiwAAjAAAmAAAgiQAgC4AjysAjzMApAAAsAAAsQAAvAAAvQAAvgAArTQAuTsAxQAAzQAA1QAA1gAA1wAA3QAA3gAA5AAA6gAA7QAA8AAA9wAA+QD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBcXV1dXQAWDhIQGF1dXV1dXV1dBAcXFR4nHUdCGl1dXV1dAgwPCx8uREtLS0tAXV1dAwYOFUFJS09RVVVRSyBdXQMMEj8oRSFRVVhXV1VLXQMBDhFASTM1OFdaWlpXVSgDBgobQklPVU1aTj4+WjlLAwkZHEJLT1VXIlo8PE48LwYkeMBBCJInVaxo2cKDBw8eRgoYcFDhRJIlUaxk8cGDB48bLQoEcFCBxJAlUKrk8MGDR44aKboMSPBgRIklS6LEkHHjRo0WXboMMOBgAokjS5bQiFGDRosSXbp0GZDAQYUgR1KwaLGCRYkuXbp06TIggYMJI06UKHGiQpcuFV26dOnSpcuABA4kPHDQpUuXLl0CAQAh+QQJCgBVACwAAAAAEAAQAIYACwwAABcABhIAABgAEgUAFwAAGAAAACYABiAAADQAADUAHD0AJCkAOjwAAEMAAFEAAFIAAFwAAGYAAHAAAHoAAHsAUwAAdQAAdCUARkoAUlIAX1EAb2wAbngAcHAAAIEAAI0AAI4AAJMAAJQAAJwAAKQAAKYAAKwAALUAALYAAL0ALogAL5cANqEAPbQAAMUAAM0AANUAAOIAAOMAAOgAAOoAAO4AAO8AiwAAmAAAmQAAgi0AliwApAAAsAAAvAAAvQAApjUAqz0AuTsAxAAAxQAAzQAA1QAA3QAA3gAA3wAA5AAA5gAA6gAA6wAA8AAA9gAA9wAA+AAA+QD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBUVVVVVQQMEBINFlVVVVVVVVVVAAkLFCE5Jj05F1VVVVVVBgkRFBkbKUBAQEA4VVVVAgcQFCM7QEVHSUlHQDhVVQMOEiEaKywcSU0dTUlAVQMBEBQjPUBBMzdRUVFNSRgDBxAUOT5FSUxRLlFSN0wqAwkRFDlARklNUVEuUjc3LwwkiEAhh48iSZZEiRJlyI0aLwwMgEBBxIkXSZg4iRLlxo0ZKgwYgDAhhAkVPJI0eXLjBo0YJ6oYSBDhA4kUKowkEVLDQwwVVaoYCABhQggSKYAUCdIChgoRVapUGXAAAoUQJHwAUaEihYgqVapUqTIgAYQJFEaIECGCQpUqFVWqVKlSpcqABBAkRIBQpUqVKlUCAQAh+QQJCgBZACwAAAAAEAAQAIYACwwADAwAABcABhIAABgAEgYAFwAAGAAAHhQAACYAADUAJAAAJRoAMAAANxQALygAOT0AAEMAAFEAAFIAAFwAHFIAAGYAAHAAAHoAAHsASgAAUwAAXwAAdQAAUUoAbmsAb2oAbmwAdXcAfHYAAIEAAI0AAI4AAJMAAJQAAJwAAKwAAK0AALQAALUAAL0AL4cALogAN60APbQAPbUAPLYAAMUAAMYAAM0AAM4AANUAANYAANcAANwAAOIAAOgAAOoAAO8AAPIAiwAAmAAAjC4ApAAApQAAvAAAvQAAvwAAqDQArjsArDwAuzoAxQAAzQAA1QAA3QAA3gAA5AAA6gAA8AAA8QAA9wD///8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH/oBYWVlZWQAODxYXG1lZWVlZWVlZBwwcECYnRkZDHVlZWVlZAA0UGCgqLy5HREdCWVlZBwkTGCgqLU5QUiFKR0JZWQQRFiYpLU85MTNUVFJHWQMCExgoKjVQUiJNI1czHx4ECRMYKC1OUFNWV1dBVz9HBwoUGCctTlJUV1dXV1dANQ4goIAhRQsnUqhcuXLlyhUgNQ4smJABRYsaOXpYuXLlyowfLQIY0FABhQoXN3gssXLFio8cKrIcaECBBIoWNXLkmDJlCQgXWbIUMDDhgokULVzcgALlRo0TWbJkKaBgAgYTKVS0OAKjxYksWbJkyUJAwYQLGFCcSIECQ5YsFVmyZMmSJYsABRMsWJiQJUuWLFkCAQA7" rel="icon" type="image/x-icon" />
    <link rel="canonical" href="Home.aspx"/>
    <link href="Style/StyleSheet4.css" rel="stylesheet" />
    <link href="Style/StyleSheet3.css" rel="stylesheet" />
    <link href="Style/ml-navigation-bar.css" rel="stylesheet" />
    <link rel="stylesheet" href="Style/SMS.css" type="text/css"/>
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,300italic,400" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://intl-tel-input.com/node_modules/bootstrap/dist/css/bootstrap.min.css?7" />
    <link rel="stylesheet" href="https://intl-tel-input.com/node_modules/intl-tel-input/build/css/intlTelInput.css?39" />
    <link rel="stylesheet" href="https://intl-tel-input.com/css/demo.css?14" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Droid+Sans" rel="stylesheet" />
    <link rel="stylesheet" href="Style/Dashboard.css" />
    <link rel="apple-touch-icon" sizes="57x57" href="Images/apple-icon-57x57.png" />
    <link rel="apple-touch-icon" sizes="60x60" href="Images/apple-icon-60x60.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="Images/apple-icon-72x72.png" />
    <link rel="apple-touch-icon" sizes="76x76" href="Images/apple-icon-76x76.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="Images/apple-icon-114x114.png" />
    <link rel="apple-touch-icon" sizes="120x120" href="Images/apple-icon-120x120.png" />
    <link rel="apple-touch-icon" sizes="144x144" href="Images/apple-icon-144x144.png" />
    <link rel="apple-touch-icon" sizes="152x152" href="Images/apple-icon-152x152.png" />
    <link rel="apple-touch-icon" sizes="180x180" href="Images/apple-icon-180x180.png" />
    <link rel="mask-icon" href="Images/MaskIcon.svg" />
    <link rel="manifest" href="manifest.json" />
    <script type="application/javascript" src="Scripts/browser-polyfill.js"></script>
    <script src="Scripts/Background.js"></script>
    <script src="Scripts/content-script.js"></script>
    <script src="Scripts/EventCalendar.js"></script>
    <script src="Scripts/intlTelInput.min.js"></script>
	<script src="Scripts/intlTelInput-jquery.min.js"></script>
    <script src="Scripts/tablesort.js"></script>
    <script src="Scripts/tablesort.filesize.js"></script>
    <script src="Scripts/utils.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.2.3.js"></script>
    <script src="https://ff.kis.v2.scr.kaspersky-labs.com/9F429392-D65E-C44E-9897-24E0F4769B9F/main.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/10.0.2/js/intlTelInput.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/10.0.2/js/utils.js"></script>
    <script language="C#" runat="server"> void btnSubmit_Click(object sender, EventArgs e){ System.Web.HttpCookie myCookie = new System.Web.HttpCookie("test", "value"); Response.Cookies.Add(myCookie); } </script>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=0.28, minimum-scale=0.28, maximum-scale=10.0, user-scalable=yes"/>
    <meta name="keywords" content="Random Speech Recognition Download File Conversion Random Number Generator Rock Paper Scissors Bowling Score Calculator Financial Calculators"/>
    <meta name="description" content="This self-explanatory random page introduces many different effective features and modules available that can be used under the ASP.NET framework."/>
    <meta name="author" content="Max Voisard"/>
    <meta name="copyright" content="Max Voisard"/>
    <meta name="application-name" content="Max's Tech and Math Site"/>
    <meta name="contact" content="max.voisard@gmail.com"/>
    <meta name="reply-to" content="max.voisard@gmail.com"/>
    <meta name="language" content="English"/>
    <meta name="content-language" content="English"/>
    <meta name="google-site-verification" content="iO6FPNQGOnq5iAEyBpnsxVJ6Bh1oxZQ4s71s6-vcneE"/>
    <meta name="googlebot" content="noodp"/>
    <meta name="robots" content="index, follow"/>
    <meta name="generator" content="Visual Studio 2017"/>
    <meta name="MobileOptimized" content="width"/>
    <meta name="HandheldFriendly" content="true"/>
    <meta name="mobile-web-app-capable" content="yes"/>
    <meta name="msapplication-TileColor" content="#ffffff"/>
    <meta name="msapplication-TileImage" content="favicon.ico"/>
    <meta name="theme-color" content="#7CFC00"/>
    <meta name="thumbnail" content="favicon.ico"/>
    <meta name="distribution" content="Global"/>
    <meta name="revisit-after" content="3 Day"/>
    <meta property="fb:app_id" content="108355726669362"/>
    <meta property="og:locale" content="en_US"/>
    <meta property="og:title" content="Random"/>
    <meta property="og:description" content="This self-explanatory random page introduces many different effective features and modules available that can be used under the ASP.NET framework."/>
    <meta property="og:url" content="http://maxstechandmathsite.azurewebsites.net/Random"/>
    <meta property="og:type" content="website"/>
    <meta property="og:image" content="Images/Wrench.png"/>
    <meta property="og:site_name" content="Max's Tech And Math Site"/>
    <meta property="og:email" content="max.voisard@gmail.com"/>
    <meta property="og:phone_number" content="937-638-4972"/>
    <meta property="og:street-address" content="11383 Marshall Rd"/>
    <meta property="og:locality" content="Versailles"//>
    <meta property="og:region" content="OH"/>
    <meta property="og:postal-code" content="45380"/>
    <meta name="twitter:card" content="summary_large_image"/>
    <meta name="twitter:description" content="This self-explanatory random page introduces many different effective features and modules available that can be used under the ASP.NET framework."/>
    <meta name="twitter:title" content="Random"/>
    <meta name="twitter:image" content="Images/Random.jpg"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta http-equiv="Set-Cookie" content="SessionID=38afes7a8; Expires=Tue, 31 Dec 2019 11:59:59 GMT; Secure; HttpOnly; Path=/"/>
    <meta http-equiv="content-disposition" content="inline; filename=Complete Business Guide.docx"/>
    <meta http-equiv="Cache-control" content="public"/>
    <meta http-equiv="Cache-control" content="max-age=3600"/>
    <meta http-equiv="page-enter" content="revealtrans(duration=3.0,transition=1)"/>
    <meta http-equiv="page-exit" content="revealtrans(duration=3.0,transition=1)"/>
    <style>
    .cont {
        width: 93%;
        max-width: 350px;
        text-align: center;
        margin: 0 auto;
        padding: 30px 0;
        background: #111;
        color: #EEE;
        border-radius: 5px;
        border: thin solid #444;
        overflow: hidden;
    }

    hr {
        margin: 20px;
        border: none;
        border-bottom: thin solid rgba(255,255,255,.1);
    }

    div.stars {
        width: 350px;
        padding-right: 38px;
        display: inline-block;
    }

    input.star {
        display: none;
    }

    label.star {
        float: right;
        padding: 10px;
        font-size: 36px;
        color: #444;
        transition: all .2s;
    }

    input.star:checked ~ label.star:before {
        content: '\f005';
        color: #FD4;
        transition: all .25s;
    }

    input.star-5:checked ~ label.star:before {
        color: #FE7;
        text-shadow: 0 0 20px #952;
    }

    input.star-1:checked ~ label.star:before {
        color: #F62;
    }

    label.star:hover {
        transform: rotate(-15deg) scale(1.3);
    }

    label.star:before {
        content: '\f006';
        font-family: FontAwesome;
    }

    .rev-box {
        overflow: hidden;
        height: 0;
        padding-left: 34px;
        width: 100%;
        transition: all .25s;
    }

    textarea.review {
        background: #222;
        border: none;
        width: 100%;
        max-width: 100%;
        height: 100px;
        padding: 10px;
        box-sizing: border-box;
        color: #EEE;
    }

    label.review {
        display: block;
        transition: opacity .25s;
    }

    input.star:checked ~ .rev-box {
        height: 125px;
        overflow: visible;
    }

    .rating-form .ir {
		  position: absolute;
		  left: -9999px;
    }

    .rating-form .form-output {
		display: none;
		position: absolute;
		right: 15px; bottom: -45px;
		font-size: 30px; font-size: 3rem;
		opacity: 0;
		.transition();
	}

	.no-js .rating-form .form-output {
		right: 5px;
		opacity: 1;
	}

	.rating-form input[type='radio']:checked ~ .form-output {
		right: 5px;
		opacity: 1;
	}
    .width {
        width: 90px;
        height: 30px;
    }
    .width2 {
        width: 90px;
        height: 15px;
    }
    .width3 {
        width: 110px;
        height: 30px;
    }
        </style>
</head>
<body style="background-image: url('Images/Clouds.jpg'); background-size: 100vw 100vh; left: -8px; top: -22px;" contextmenu="myMenu" onafterprint="PostPrint()">
    <!-- Google Tag Manager (noscript) -->
    <noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-N5KXG2Z"
    height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
    <!-- End Google Tag Manager (noscript) -->
    <?php
        function wp_set_all_cookies() {
        if ($_COOKIE["viewed1"] != get_the_title()) {
        setcookie("viewed3", $_COOKIE["viewed2"], time()+3600, "/", ".cookie.com");
        setcookie("viewed2", $_COOKIE["viewed1"], time()+3600, "/", ".cookie.com");
        setcookie("viewed1", get_the_title(), time()+3600, "/", ".cookie.com");
        }}
        if(isset($_COOKIE['yourcookiename’])) {$cookievariable = $_COOKIE['pageview1'];}
    ?>
 <div id="fb-root"></div>
  <menu type="context" id="myMenu">
    <menuitem label="Refresh" onclick="window.location.reload();" icon="Images/refresh.png"></menuitem>
    <menu label="Share on...">
    <menuitem label="Twitter" icon="Images/Twitter.png" onclick="window.open('//twitter.com/intent/tweet?text=' + window.location.href);"></menuitem>
    <menuitem label="Facebook" icon="Images/Facebook.jpg" onclick="window.open('//facebook.com/sharer/sharer.php?u=' + window.location.href);"></menuitem>
    </menu>
    <menuitem label="Email This Page" onclick="window.location='mailto:?body='+window.location.href;"></menuitem>
  </menu>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.2&appId=108355726669362&autoLogAppEvents=1';
  fjs.parentNode.insertBefore(js, fjs);
  }(document, 'script', 'facebook-jssdk'));
</script>
    <script type="text/javascript">
        function goto() {
            var id = '#004@$%^&?';
            var url = 'Search.aspx?item=' + encodeURIComponent(id);
            window.location.href = url;
        }
        function PostPrint() {
            alert("Printing successful.");
        }
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-19268069-1']);
        _gaq.push(['_trackPageview']);

        document.cookie = "myContents=SessionCookie; expires=0; path=/";
        var cookiename = getCookie("SessionCookie");
        if (cookiename == "value") {
        }
        
        function getCookie(cname) {
            var name = cname + "=";
            var ca = document.cookie.split(';');
            for (var i = 0; i < ca.length; i++) {
                var c = ca[i];
                while (c.charAt(0) == ' ') c = c.substring(1);
                if (c.indexOf(name) != -1) return c.substring(name.length, c.length);
            }
            return "";
        }

        window.addEventListener("load", function(){
        window.cookieconsent.initialize({
          "palette": {
            "popup": {
              "background": "#f0f0d0",
              "text": "#333333"
            },
            "button": {
              "background": "#b0b080",
              "text": "#333"
            }
          },
          "content": {
            "message": "This website uses cookies. By using this website you accept the use of cookies.",
            "href": "http://maxstechandmathsite.azurewebsites.net/PrivacyPolicy.html"
          }
            })
        });

        if ('serviceWorker' in navigator) {
          // sw.js can literally be empty, but must exist
          navigator.serviceWorker.register('Scripts/sw.js');
        }

        // window.onbeforeunload = function() {
        // return "Bowling Score data will be lost if you leave this page!";
        // }
    </script>
    <script>
      (function() {
        var cx = '011638576377907098648:gz_9enmjnc8';
        var gcse = document.createElement('script');
        gcse.type = 'text/javascript';
        gcse.async = true;
        gcse.src = 'https://cse.google.com/cse.js?cx=' + cx;
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(gcse, s);
      })();
    </script>
    <header>
        <section id="contents" class="navbar navbar-default" style="width: 89%">
            <div class="container-fluid">
              <div class="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                  <li style="width: 500px; padding: 5px 0px"><gcse:search></gcse:search></li>
                    <li class="dropdown" style="margin-top: 12px">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">My profile <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="#"><i class="fa fa-user-o fw"></i> My account</a></li>
                        <li><a href="#"><i class="fa fa-envelope-o fw"></i> My inbox</a></li>
                        <li><a href="#"><i class="fa fa-question-circle-o fw"></i> Help</a></li>
                        <li role="separator" class="divider"></li>
                        <li><a href="#"><i class="fa fa-sign-out"></i> Log out</a></li>
                    </ul>
                    </li>
                    <li style="margin-top: 12px"><a href="#"><i class="fa fa-comments"></i><span>23</span></a></li>
                    <li style="margin-top: 12px"><a href="#"><i class="fa fa-bell-o"></i><span>98</span></a></li>
                    <li style="margin-top: 12px"><a href="#"><i data-show="show-side-navigation1" class="fa fa-bars show-side-btn"></i></a></li>
                </ul>
              </div>
            </div>
        </section>
        <aside class="side-nav" id="show-side-navigation1">
          <i class="fa fa-bars close-aside hidden-sm hidden-md hidden-lg" data-close="show-side-navigation1"></i>
          <div class="heading">
            <img id="ProfilePicture" runat="server" src="Images/PictureOfMe.jpg" height="95" alt="Profile Picture" />
            <div class="info">
              <h3><a href="#"><asp:Label ID="Label114" runat="server"></asp:Label></a></h3>
              <asp:Label ID="Label115" runat="server"></asp:Label>
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
            <li><i class="fa fa-laptop fa-fw"></i><a href="#"> About Random Page <span class="num succ">43</span></a></li>
            <li><i class="fa fa-comments-o fa-fw"></i><a href="#"> Support</a></li>
          </ul>
        </aside>
        <span id="lowZ"><img src="Images/Logo.PNG"; style="width: 76%; margin-right: 4%" height="355"/></span>
        <div id="Header" style="width: 88.5%"><img src="Images/Random.jpg" height="70" style="margin-bottom: 43px" />&nbsp;Random</div>
    </header>
    <nav style="width: 88.5%">
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
		    <li><a onclick="createCookie('Geometry', 'yes', 0)" href="math/Geometry.aspx">Geometry</a></li>
            <li><a onclick="createCookie('Algebra', 'yes', 0)" href="math/Algebra.aspx">Algebra</a></li>
            <li><a onclick="createCookie('Trigonometry', 'yes', 0)" href="math/Trigonometry.aspx">Trigonometry</a></li>
            <li><a onclick="createCookie('Statistics', 'yes', 0)" href="math/Statistics.aspx">Statistics</a></li>
            <li><a onclick="createCookie('Calculus', 'yes', 0)" href="math/Calculus.aspx">Calculus</a></li>
	    </ul>
	    </li>
        <li id="active"><a onclick="createCookie('Random', 'yes', 0)" href="/Random.aspx">Random</a></li>
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
    <map name="skillset_Map">
        <area shape="poly" alt="W3C Guidelines" coords="90,70,113,112,67,112,90,70" href="math/Geometry.aspx" />
        <area shape="poly" alt="Browser Bugs" coords="61,120,115,120,137,157,40,157,62,120" href="math/Calculus.aspx" />
        <area shape="poly" alt="User Impact" coords="35,166,142,166,171,216,6,216,35,166" href="math/Statistics.aspx" />
    </map>
    <div id="sidebar">
        <asp:Image ID="Image1" runat="server" Height="20px" ImageUrl="Images/RSS.png" /> RSS feeds
        <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="http://rss.cnn.com/rss/cnn_topstories.rss" XPath="rss/channel/item [position() &lt;=10]"></asp:XmlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource2">
        <ItemTemplate>
            <%#XPath ("title") %>
            <%#XPath ("description") %>
        </ItemTemplate>
        </asp:DataList>
    </div>
        <br />
    <form runat="server" autocomplete="on" id="fileUploadForm" enctype="multipart/form-data">
    <main>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml"></asp:XmlDataSource>
        <asp:WebPartManager ID="WebPartManager1" runat="server"><Personalization Enabled="False" /></asp:WebPartManager>
        <asp:ScriptManager ID="ScriptManager2" runat="server" />
        <div id="google_translate_element"></div>
        <script type="text/javascript">
            function googleTranslateElementInit() {
              new google.translate.TranslateElement({pageLanguage: 'en'}, 'google_translate_element');
            }
        </script>
        <script type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
        Advertisement
        <asp:HyperLink ID="HyperLink10" runat="server" ImageUrl="Images/AdChoices.PNG" NavigateUrl="http://youradchoices.com">HyperLink</asp:HyperLink>
        <br />
        <asp:AdRotator ID="adrComputers" runat="server" DataSourceID="XmlDataSource1" Target="_blank" />
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Miscellaneous Features"></asp:Label>
        <br />
        <strong>Location Tracking</strong><script async="async" defer="defer" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA7zD20EAeR-v1_YfFb_h2yUZIhGrWTi4o&callback=initMap"></script><br />
        <div id="locationData"></div>
        <div id="address"></div>
        <div id="city"></div>
        <div id="country"></div>
        <div id="latitude"></div>
        <div id="longitude"></div>
        <div id="ip"></div>
        <script type="text/javascript">
                $.get("https://api.ipdata.co?api-key=test", function (response) {
                    $("#ip").html("IP Address: " + response.ip);
                    $("#city").html("Your Location: " + response.city + ", " + response.region);
                    $("#latitude").html("Latitude: " + response.latitude);
                    $("#longitude").html("Longitude: " + response.longitude);
                }, "jsonp");
        </script>
        <br />
        <strong>User Input-triggered Events</strong>
        &nbsp;<script type="text/javascript">
            function allowDrop(ev) {
              ev.preventDefault();
            }

            function drag(ev) {
                ev.dataTransfer.setData("Text", ev.target.id);
                document.getElementById("drag1").style = "cursor: -webkit-grabbing; cursor: grabbing";
            }

            function drop(ev) {
              var data = ev.dataTransfer.getData("Text");
              ev.target.appendChild(document.getElementById(data));
              ev.preventDefault();
            }
        </script><div id="div1" class="center" ondrop="drop(event)" ondragover="allowDrop(event)"></div>
        <br />
        <p id="drag1" draggable="true" style="cursor: -webkit-grab; cursor: grab" ondragstart="drag(event)">This is a draggable sentence. Drag this sentence into the above rectangle.</p>
        <strong>Random Number Generator</strong><br />
        <asp:Label ID="Label47" runat="server" Text="Enter range: "></asp:Label>
        <asp:TextBox ID="TextBox104" runat="server" class="text-box2" Width="100px" AccessKey="r" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
        To
        <asp:TextBox ID="TextBox105" runat="server" class="text-box2" Width="100px" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
        <asp:Label ID="Label48" runat="server" Text="Enter # of random numbers to get:"></asp:Label>
        <asp:TextBox ID="TextBox106" runat="server" class="text-box2" Width="60px" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>   
        <asp:Button ID="btnRandom" class="myButton" runat="server" OnClick="btnRandom_Click" Text="Get Random Numbers" BorderStyle="Dotted" Height="38px" />
        <br />
        <asp:Label ID="lblRandom" runat="server" Text="Random Numbers: "></asp:Label>
        <br />
        <br />
        <strong>Choose display mode (must login in upper-right corner of
        <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Contact.aspx">Contact</asp:HyperLink>
        <i class="material-icons">open_in_new</i> or  
        <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/About.aspx">About</asp:HyperLink>
        <i class="material-icons">open_in_new</i> page):</strong><br />
        <asp:Button ID="btnBrowse" class="myButton" runat="server" OnClick="btnBrowse_Click" Text="Browse" Height="38px" />
&nbsp;<asp:Button ID="btnDesign" class="myButton" runat="server" OnClick="btnDesign_Click" Text="Design" Height="38px" />
&nbsp;<asp:Button ID="btnCatalog" class="myButton" runat="server" OnClick="btnCatalog_Click" Text="Catalog" Height="38px" />
&nbsp;<asp:Button ID="btnEdit" class="myButton" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="38px" />
        <br />
        <asp:Label ID="lblError2" runat="server" ForeColor="Red"></asp:Label>
        <br />
<asp:WebPartZone ID="WebPartZone1" runat="server" Height="193px" Width="400px" BorderColor="#CCCCCC" Font-Names="Verdana" Padding="6">
            <ZoneTemplate>
                <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" Width="390px">
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />
            </FinishNavigationTemplate>
            <StartNavigationTemplate>
                <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" />
            </StartNavigationTemplate>
            <WizardSteps>
                <asp:TemplatedWizardStep runat="server" Title="Start">
                    <ContentTemplate>
                        Welcome to the Voisard Information Wizard. Press Next to continue.
                    </ContentTemplate>
                </asp:TemplatedWizardStep>
                <asp:TemplatedWizardStep runat="server" Title="Step 1 - Personal Info">
                    <ContentTemplate>
                        <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <br />
                    </ContentTemplate>
                </asp:TemplatedWizardStep>
                <asp:TemplatedWizardStep runat="server" Title="Step 2 - Contact Info">
                    <ContentTemplate>
                        <asp:Label ID="lblMail" runat="server" Text="Email:"></asp:Label>
                        <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblPhone" runat="server" Text="Phone Number:"></asp:Label>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        <br />
                    </ContentTemplate>
                </asp:TemplatedWizardStep>
                <asp:TemplatedWizardStep runat="server" Title="Finish">
                    <ContentTemplate>
                        Thank you for completing the Voisard Information Wizard.
                    </ContentTemplate>
                </asp:TemplatedWizardStep>
            </WizardSteps>
        </asp:Wizard>
                </ZoneTemplate>
            <MenuLabelHoverStyle ForeColor="#E2DED6" />
            <MenuLabelStyle ForeColor="White" />
            <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em" />
            <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
            <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
            <EmptyZoneTextStyle Font-Size="0.8em" />
            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
            <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
            <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
        </asp:WebPartZone>
                <br />
                <asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana" Height="330px" Padding="6" Width="330px">
                    <ZoneTemplate>
                        <asp:ImageMap ID="ImageMap1" runat="server" Height="300px" HotSpotMode="Navigate" ImageUrl="/Images/nature.jpg" Width="300px">
                        <asp:RectangleHotSpot AlternateText="Google" Bottom="150" HotSpotMode="Navigate" NavigateUrl="http://www.google.com" Right="151" Target="_blank" />
                        <asp:RectangleHotSpot AlternateText="Yahoo" Bottom="300" HotSpotMode="Navigate" NavigateUrl="http://www.yahoo.com" Right="150" Top="151" Target="_blank" />
                        <asp:RectangleHotSpot AlternateText="Facebook" Bottom="150" HotSpotMode="Navigate" Left="151" NavigateUrl="http://www.facebook.com" Right="300" Target="_blank" />
                        <asp:RectangleHotSpot AlternateText="Twitter" Bottom="300" HotSpotMode="Navigate" Left="151" NavigateUrl="http://www.twitter.com" Right="300" Top="151" Target="_blank" />
                        </asp:ImageMap>
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#E2DED6" />
                    <MenuLabelStyle ForeColor="White" />
                    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em" />
                    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
                    <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                    <EmptyZoneTextStyle Font-Size="0.8em" />
                    <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                    <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                </asp:WebPartZone>
        <br />
        <asp:EditorZone ID="EditorZone4" runat="server">
            <ZoneTemplate>
                <asp:AppearanceEditorPart ID="AppearanceEditorPart2" runat="server" />
            </ZoneTemplate>
        </asp:EditorZone>
        <asp:CatalogZone ID="CatalogZone1" runat="server">
                <ZoneTemplate>
                        <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                            <WebPartsTemplate>
                               <uc1:WebUserControl title = "Addition" ID = "WebUserControl1" runat="server" />
                                    <asp:EditorZone ID="EditorZone1" runat="server">
                                       <ZoneTemplate>
                                           <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                                       </ZoneTemplate>
                                    </asp:EditorZone>
                             </WebPartsTemplate>
                        </asp:DeclarativeCatalogPart>
                </ZoneTemplate>
         </asp:CatalogZone>
        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Computer Modules"></asp:Label>
        <br />
        <strong>Download Common Programs</strong>
        <br />
        *All of the following programs will be downloaded for the Windows operating system only, and are only free and open-source community editions rather than priced commercial professional or enterprise editions. The .exe and .msi files will give setup/installation wizards in which you will need to follow the steps given, like choosing your language and accepting the terms and conditions. For the .zip files, you will need to find the .exe file within the folder, right-click it and select "Extract".
        <script>
            function myFunction() {
              var input, filter, table, tr, td, i, txtValue;
              input = document.getElementById("myInput");
              filter = input.value.toUpperCase();
              table = document.getElementById("Downloads");
              tr = table.getElementsByTagName("tr");
              for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[0];
                if (td) {
                  txtValue = td.textContent || td.innerText;
                  if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                  } else {
                    tr[i].style.display = "none";
                  }
                }       
              }
            }
        </script>
        <br />
        <br />
        <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for Applications..." title="Type in an Application" />
        <table id="Downloads" class="sort">
            <thead>
                <tr>
                    <th class="Column1" style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Application<br /><button type="button" class="button" style="padding: 6px" onclick="return sort(true, 'Column1', 'Downloads');" title="Application ASC Sort"><i class="fa fa-chevron-down"></i></button>&nbsp;<button type="button" class="button" style="padding: 6px" onclick="return sort(false, 'Column1', 'Downloads');" title="Application DESC Sort"><i class="fa fa-chevron-up"></i></button></th>
                    <th class="Column2" style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Release Version<br /><button type="button" class="button" style="padding: 6px" onclick="return sort(true, 'Column2', 'Downloads');" title="Version ASC Sort"><i class="fa fa-chevron-down"></i></button>&nbsp;<button type="button" class="button" style="padding: 6px" onclick="return sort(false, 'Column2', 'Downloads');" title="Version DESC Sort"><i class="fa fa-chevron-up"></i></button></th>
                    <th class="Column3" style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Application Type<br /><button type="button" class="button" style="padding: 6px" onclick="return sort(true, 'Column3', 'Downloads');" title="Application Type ASC Sort"><i class="fa fa-chevron-down"></i></button>&nbsp;<button type="button" class="button" style="padding: 6px" onclick="return sort(false, 'Column3', 'Downloads');" title="Application Type DESC Sort"><i class="fa fa-chevron-up"></i></button></th>
                    <th class="Column4" style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Download File Type<br /><button type="button" class="button" style="padding: 6px" onclick="return sort(true, 'Column4', 'Downloads');" title="File Type ASC Sort"><i class="fa fa-chevron-down"></i></button>&nbsp;<button type="button" class="button" style="padding: 6px" onclick="return sort(false, 'Column4', 'Downloads');" title="File Type DESC Sort"><i class="fa fa-chevron-up"></i></button></th>
                    <th id="Column5" style="font-weight: 600; text-align: center; border: 3px solid #3F2860; cursor: pointer">Download File Size<br /><img id="Down5" src="Images/down-arrow.png" height="20"/><img id="Up5" src="Images/up-arrow.png" height="20"/></th>
                    <th style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Download Button</th>
                    <th style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Download Progress</th>
                    <th style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Download Message</th>
                    <th style="font-weight: 600; text-align: center; border: 3px solid #3F2860">Save File</th>
                </tr>
            </thead>
            <tbody>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/4KIcon.jpg" height="20" /> 4K Video Downloader</td>
                    <td data-label="Column2" class="Column2">4.5.0.2482</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Video Hosting Site Video Downloader</td>
                    <td data-label="Column4" class="Column4">.MSI (Windows Installer Package)</td>
                    <td>24.5 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton11" runat="server" OnClientClick="return Download('Executables/4Kvideodownloader_4.5.0_x64.msi', 'ImageButton11', 'Loading7', '#save-file7', '#progressBar7', 'result8', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileMSI" CommandArgument="Executables/4kvideodownloader_4.5.0_x64.msi" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading7"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar7" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result8">Message: </p></td>
                    <td><a id="save-file7" href="Executables/4Kvideodownloader_4.5.0_x64.msi">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/4kvideodownloader_4.5.0_x64.msi" data-filename="4K Video Downloader" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/7ZipIcon.png" height="25" /> 7-Zip</td>
                    <td data-label="Column2" class="Column2">19.00</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">File Archiver</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.41 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton12" runat="server" OnClientClick="return Download('Executables/7z1900-x64.exe', 'ImageButton12', 'Loading8', '#save-file8', '#progressBar8', 'result9', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/7z1900-x64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading8"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar8" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result9">Message: </p></td>
                    <td><a id="save-file8" href="Executables/7z1900-x64.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/7z1900-x64.exe" data-filename="7-Zip" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/AdobeIcon.png" height="20" /> Adobe Acrobat Reader DC</td>
                    <td data-label="Column2" class="Column2">2019.010.20098</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">PDF Viewer</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.18 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton7" runat="server" OnClientClick="return Download('Executables/readerdc_en_ka_cra_install.exe', 'ImageButton7', 'Loading3', '#save-file3', '#progressBar3', 'result4', 'blob');" UseSubmitBehavior="false" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" OnCommand="GetFileEXE" CommandArgument="Executables/readerdc_en_ka_cra_install.exe" /><button class="buttonload" id="Loading3"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar3" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result4">Message: </p></td>
                    <td><a id="save-file3" href="Executables/readerdc_en_ka_cra_install.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/readerdc_en_ka_cra_install.exe" data-filename="Adobe Acrobat Reader DC" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/AdobeFlashIcon.png" height="20" /> Adobe Flash Player</td>
                    <td data-label="Column2" class="Column2">31.0.0.148</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Media Player</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.18 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton13" runat="server" OnClientClick="return Download('Executables/flashplayer31pp_ka_install.exe', 'ImageButton13', 'Loading9', '#save-file9', '#progressBar9', 'result10', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/flashplayer31pp_ka_install.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading9"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar9" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result10">Message: </p></td>
                    <td><a id="save-file9" href="Executables/flashplayer31pp_ka_install.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/flashplayer31pp_ka_install.exe" data-filename="Adobe Flash Player" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/AtomIcon.png" height="25" /> Atom</td>
                    <td data-label="Column2" class="Column2">1.35.1</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Text & Code Editor</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>144 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton27" runat="server" OnClientClick="return Download('Executables/AtomSetup-x64.exe', 'ImageButton27', 'Loading24', '#save-file24', '#progressBar24', 'result25', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/AtomSetup-x64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading24"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar24" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result25">Message: </p></td>
                    <td><a id="save-file24" href="Executables/AtomSetup-x64.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/AtomSetup-x64.exe" data-filename="Atom" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/AutoCADIcon.png" height="20" /> Autodesk AutoCAD</td>
                    <td data-label="Column2" class="Column2">Regular 2020</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Computer-Aided Design (CAD) Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>474 KB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton8" runat="server" OnClientClick="return Download('Executables/AutoCAD_2020_Windows_64bit.exe', 'ImageButton8', 'Loading4', '#save-file4', '#progressBar4', 'result5', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/AutoCAD_2020_Windows_64bit.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading4"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar4" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result5">Message: </p></td>
                    <td><a id="save-file4" href="Executables/AutoCAD_2020_Windows_64bit.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/AutoCAD_2020_Windows_64bit.exe" data-filename="AutoCAD" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/AVGIcon.png" height="20" /> AVG AntiVirus</td>
                    <td data-label="Column2" class="Column2">FREE</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Antivirus Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>263 KB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="return Download('Executables/avg_antivirus_free_setup.exe', 'ImageButton1', 'Loading', '#save-file', '#progressBar', 'result2', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/avg_antivirus_free_setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result2">Message: </p></td>
                    <td><a id="save-file" href="Executables/avg_antivirus_free_setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/avg_antivirus_free_setup.exe" data-filename="AVG Antivirus" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/JabberIcon.jpg" height="20" /> Cisco Jabber</td>
                    <td data-label="Column2" class="Column2">12.5.1</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Instant Messaging (IM) Service</td>
                    <td data-label="Column4" class="Column4">.MSI (Windows Installer Package)</td>
                    <td>140 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton24" runat="server" OnClientClick="return Download('Executables/CiscoJabberSetup12.5.1.msi', 'ImageButton24', 'Loading21', '#save-file21', '#progressBar21', 'result21', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileMSI" CommandArgument="Executables/CiscoJabberSetup12.5.1.msi" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading21"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar21" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result22">Message: </p></td>
                    <td><a id="save-file21" href="Executables/CiscoJabberSetup12.5.1.msi">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/CiscoJabberSetup12.5.1.msi" data-filename="Cisco Jabber" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/Dev-Cpp.png" height="20" /> Dev-C++</td>
                    <td data-label="Column2" class="Column2">5.11</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">C/C++ Integrated Development Environment (IDE)</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>49.3 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton14" runat="server" OnClientClick="return Download('Executables/Dev-Cpp 5.11 TDM-GCC 4.9.2 Setup.exe', 'ImageButton14', 'Loading10', '#save-file10', '#progressBar10', 'result11', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/Dev-Cpp 5.11 TDM-GCC 4.9.2 Setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading10"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar10" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result11">Message: </p></td>
                    <td><a id="save-file10" href="Executables/Dev-Cpp 5.11 TDM-GCC 4.9.2 Setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/Dev-Cpp 5.11 TDM-GCC 4.9.2 Setup.exe" data-filename="Dev-C++" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/DockerIcon.png" height="25" /> Docker</td>
                    <td data-label="Column2" class="Column2">Community Edition (CE) 2.0.3.0</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Virtualization Environment</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>554 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton15" runat="server" OnClientClick="return Download('Executables/Docker for Windows Installer.exe', 'ImageButton15', 'Loading11', '#save-file11', '#progressBar11', 'result12', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Docker for Windows Installer.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading11"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar11" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result12">Message: </p></td>
                    <td><a id="save-file11" href="Executables/Docker for Windows Installer.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/Docker for Windows Installer.exe" data-filename="Docker" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/DropboxIcon.png" height="25" /> Dropbox</td>
                    <td>69.4.102.0</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">File Hosting Service</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>678 KB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton16" runat="server" OnClientClick="return Download('Executables/DropboxInstaller.exe', 'ImageButton16', 'Loading12', '#save-file12', '#progressBar12', result13, 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/DropboxInstaller.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading12"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar12" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result13">Message: </p></td>
                    <td><a id="save-file12" href="Executables/DropboxInstaller.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/DropboxInstaller.exe" data-filename="Dropbox" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/EclipseIcon.png" height="20" /> Eclipse</td>
                    <td data-label="Column2" class="Column2">Java Photon</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Java IDE</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>47.8 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton17" runat="server" OnClientClick="return Download('Executables/eclipse-inst-win64.exe', 'ImageButton17', 'Loading13', '#save-file13', '#progressBar13', 'result14', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/eclipse-inst-win64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading13"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar13" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result14">Message: </p></td>
                    <td><a id="save-file13" href="Executables/eclipse-inst-win64.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/eclipse-inst-win64.exe" data-filename="Eclipse" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/FileZillaIcon.png" height="25" /> FileZilla</td>
                    <td data-label="Column2" class="Column2">3.41.2</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">FTP Client</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>7.73 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton18" runat="server" OnClientClick="return Download('Executables/FileZilla_3.41.2_win32-setup.exe', 'ImageButton18', 'Loading14', '#save-file14', '#progressBar14', 'result15', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/FileZilla_3.41.2_win32-setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading14"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar14" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result15">Message: </p></td>
                    <td><a id="save-file14" href="Executables/FileZilla_3.41.2_win32-setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/eclipse-inst-win64.exe" data-filename="Eclipse" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/GIMPIcon.png" height="25" /> GIMP</td>
                    <td data-label="Column2" class="Column2">2.10.8</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Image Editing Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>199 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton40" runat="server" OnClientClick="return Download('Executables/gimp-2.10.8-setup.exe', 'ImageButton40', 'Loading37', '#save-file37', '#progressBar37', 'result38', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/gimp-2.10.8-setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading37"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar37" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result38">Message: </p></td>
                    <td><a id="save-file37" href="Executables/gimp-2.10.8-setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/gimp-2.10.8-setup.exe" data-filename="GIMP" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/GoodSyncIcon.png" height="20" /> GoodSync</td>
                    <td data-label="Column2" class="Column2">v10</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Backup and File Synchronization Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>43.3 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton41" runat="server" OnClientClick="return Download('Executables/GoodSync-v10-Setup.exe', 'ImageButton41', 'Loading38', '#save-file38', '#progressBar38', 'result39', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/GoodSync-v10-Setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading38"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar38" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result39">Message: </p></td>
                    <td><a id="save-file38" href="Executables/GoodSync-v10-Setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/GoodSync-v10-Setup.exe" data-filename="GoodSync" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/ChromeIcon.png" height="20" /> Google Chrome</td>
                    <td data-label="Column2" class="Column2">Chrome 73</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Browser</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.19 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton6" runat="server" OnClientClick="return Download('Executables/ChromeSetup.exe', 'ImageButton6', 'Loading2', '#save-file2', '#progressBar2', 'result3', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/ChromeSetup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading2"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar2" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result3">Message: </p></td>
                    <td><a id="save-file2" href="Executables/ChromeSetup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/ChromeSetup.exe" data-filename="Google Chrome" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/GoogleDriveIcon.png" height="20" /> Google Drive</td>
                    <td data-label="Column2" class="Column2">Backup and Sync 3.41.2</td>
                    <td style="padding-left: 5px; padding-right: 5px">File Storage and Synchronization Service</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.19 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton19" runat="server" OnClientClick="return Download('Executables/installbackupandsync.exe', 'ImageButton19', 'Loading15', '#save-file15', '#progressBar15', 'result16', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/installbackupandsync.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading15"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar15" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result16">Message: </p></td>
                    <td><a id="save-file15" href="Executables/installbackupandsync.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/installbackupandsync.exe" data-filename="Google Drive" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/JavaIcon.png" height="20" /> JRE</td>
                    <td data-label="Column2" class="Column2">JRE 8 Update 111</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Java Runtime Environment (JRE)</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>61.8 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton20" runat="server" OnClientClick="return Download('Executables/jre-8u111-windows-x64.exe', 'ImageButton20', 'Loading16', '#save-file16', '#progressBar16', 'result17', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/jre-8u111-windows-x64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading16"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar16" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result17">Message: </p></td>
                    <td><a id="save-file16" href="Executables/jre-8u111-windows-x64.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/jre-8u111-windows-x64.exe" data-filename="JRE 8 Update 111" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/K-LiteIcon.jpg" height="20" /> K-Lite Codec Pack</td>
                    <td data-label="Column2" class="Column2">13.4.5</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">MP3 Player</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>47 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton28" runat="server" OnClientClick="return Download('Executables/mp3player_setup.exe', 'ImageButton27', 'Loading24', '#save-file24', '#progressBar24', 'result25', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/AtomSetup-x64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading24"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar25" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result26">Message: </p></td>
                    <td><a id="save-file25" href="#">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/mp3player_setup.exe" data-filename="K-Lite Codec Pack" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/LightworksIcon.jpg" height="20" /> Lightworks</td>
                    <td data-label="Column2" class="Column2">v14.0.0</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Video Editing Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>88.7 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton42" runat="server" OnClientClick="return Download('Executables/lightworks_v14.0.0_full_64bit_setup.exe', 'ImageButton42', 'Loading39', '#save-file39', '#progressBar39', 'result40', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/Executables/lightworks_v14.0.0_full_64bit_setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading39"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar39" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result40">Message: </p></td>
                    <td><a id="save-file39" href="Executables/lightworks_v14.0.0_full_64bit_setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/lightworks_v14.0.0_full_64bit_setup.exe" data-filename="Lightworks" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/LogitechIcon.png" height="20" /> Logitech Unifying Software</td>
                    <td data-label="Column2" class="Column2">250</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Logitech Mouse Driver</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>4.05 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton33" runat="server" OnClientClick="return Download('Executables/unifying250.exe', 'ImageButton33', 'Loading30', '#save-file30', '#progressBar30', 'result31', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/unifying250.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading30"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar30" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result31">Message: </p></td>
                    <td><a id="save-file30" href="Executables/unifying250.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/unifying250.exe" data-filename="Logitech Unifying Software" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/OneDriveIcon.png" height="25" /> Microsoft OneDrive</td>
                    <td data-label="Column2" class="Column2">19.012.0121.0011</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">File Hosting and Synchronization Service</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>28.2 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton21" runat="server" OnClientClick="return Download('Executables/OneDriveSetup.exe', 'ImageButton21', 'Loading17', '#save-file17', '#progressBar17', 'result18', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/OneDriveSetup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading17"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar17" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result18">Message: </p></td>
                    <td><a id="save-file17" href="Executables/OneDriveSetup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/OneDriveSetup.exe" data-filename="Microsoft OneDrive" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/MSSIcon.png" height="20" /> Microsoft SQL Server</td>
                    <td data-label="Column2" class="Column2">Evaluation Edition 2017</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Relational Database Management System (RDBMS)</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>4.82 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton32" runat="server" OnClientClick="return Download('Executables/SQLServer2017-SSEI-Eval.exe', 'ImageButton32', 'Loading29', '#save-file29', '#progressBar29', 'result30', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/SQLServer2017-SSEI-Eval.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading29"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar29" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result30">Message: </p></td>
                    <td><a id="save-file29" href="Executables/SQLServer2017-SSEI-Eval.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/SQLServer2017-SSEI-Eval.exe" data-filename="Microsoft SQL Server" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/FirefoxIcon.png" height="20" /> Mozilla Firefox</td>
                    <td data-label="Column2" class="Column2">Firefox 66 Quantum</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Browser</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>315 KB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton10" runat="server" OnClientClick="return Download('Executables/Firefox Installer.exe', 'ImageButton10', 'Loading6', '#save-file6', '#progressBar6', 'result7', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/Firefox Installer.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading6"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar6" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result7">Message: </p></td>
                    <td><a id="save-file6" href="Executables/Firefox Installer.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/Firefox Installer.exe" data-filename="Mozilla Firefox" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/NotepadPPIcon.jpg" height="25" /> Notepad++</td>
                    <td data-label="Column2" class="Column2">7.5.4</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Text & Code Editor</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>4.07 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton22" runat="server" OnClientClick="return Download('Executables/OneDriveSetup.exe', 'ImageButton22', 'Loading18', '#save-file18', '#progressBar18', 'result19', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/npp.7.5.4.Installer.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading18"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar19" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result20">Message: </p></td>
                    <td><a id="save-file19" href="Executables/OneDriveSetup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/npp.7.5.4.Installer.exe" data-filename="Notepad++" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/OracleNetBeansIcon.jpg" height="20" /> Oracle NetBeans</td>
                    <td data-label="Column2" class="Column2">10.0</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Java IDE</td>
                    <td data-label="Column4" class="Column4">.ZIP (Compressed Folder)</td>
                    <td>111 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton26" runat="server" OnClientClick="return Download('Executables/incubating-netbeans-10.0-source.zip', 'ImageButton26', 'Loading23', '#save-file23', '#progressBar23', 'result24', 'arraybuffer');" UseSubmitBehavior="false" OnCommand="GetFileZIP" CommandArgument="Executables/incubating-netbeans-10.0-source.zip" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading23"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar23" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result24">Message: </p></td>
                    <td><a id="save-file23" href="Executables/incubating-netbeans-10.0-source.zip">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/incubating-netbeans-10.0-source.zip" data-filename="Oracle NetBeans" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/OracleSQLIcon.png" height="20" /> Oracle SQL Developer</td>
                    <td data-label="Column2" class="Column2">18.3.0.277.2354</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">RDBMS</td>
                    <td data-label="Column4" class="Column4">.ZIP (Compressed Folder)</td>
                    <td>435 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton25" runat="server" OnClientClick="return Download('Executables/sqldeveloper-18.3.0.277.2354-x64.zip', 'ImageButton25', 'Loading22', '#save-file22', '#progressBar22', 'result23', 'arraybuffer');" UseSubmitBehavior="false" OnCommand="GetFileZIP" CommandArgument="Executables/sqldeveloper-18.3.0.277.2354-x64.zip" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading22"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar22" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result23">Message: </p></td>
                    <td><a id="save-file22" href="Executables/sqldeveloper-18.3.0.277.2354-x64.zip">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/sqldeveloper-18.3.0.277.2354-x64.zip" data-filename="Oracle SQL Developer" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/PythonIcon.jpg" height="20" /> Python IDLE</td>
                    <td data-label="Column2" class="Column2">3.7.3</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Python IDE</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>24.8 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton23" runat="server" OnClientClick="return Download('Executables/python-3.7.3.exe', 'ImageButton23', 'Loading20', '#save-file20', '#progressBar20', 'result21', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/python-3.7.3.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading20"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar20" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result21">Message: </p></td>
                    <td><a id="save-file20" href="Executables/python-3.7.3.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/python-3.7.3.exe" data-filename="Python IDE" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/QtIcon.svg" height="20" /> Qt</td>
                    <td data-label="Column2" class="Column2">Open-Source 3.0.6</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Widget Toolkit for Graphical User Interfaces (GUIs) and Apps</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>19.8 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton29" runat="server" OnClientClick="return Download('Executables/qt-unified-windows-x86-3.0.6-online.exe', 'ImageButton29', 'Loading26', '#save-file26', '#progressBar26', 'result27', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/qt-unified-windows-x86-3.0.6-online.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading26"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar26" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result27">Message: </p></td>
                    <td><a id="save-file26" href="Executables/qt-unified-windows-x86-3.0.6-online.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/qt-unified-windows-x86-3.0.6-online.exe" data-filename="Qt" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/SkypeIcon.png" height="20" /> Skype</td>
                    <td data-label="Column2" class="Column2">8.41.0.54</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Telecommunications Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>62.3 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton30" runat="server" OnClientClick="return Download('Executables/Skype-8.41.0.54.exe', 'ImageButton30', 'Loading27', '#save-file27', '#progressBar27', 'result28', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/Skype-8.41.0.54.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading27"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar27" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result28">Message: </p></td>
                    <td><a id="save-file27" href="Executables/Skype-8.41.0.54.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/Skype-8.41.0.54.exe" data-filename="Skype" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/SQLiteIcon.png" height="20" /> SQLite</td>
                    <td data-label="Column2" class="Column2">3.27.2</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Embedded RDBMS</td>
                    <td data-label="Column4" class="Column4">.ZIP (Compressed Folder)</td>
                    <td>2.25 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton31" runat="server" OnClientClick="return Download('Executables/sqlite-amalgamation-3270200.zip', 'ImageButton31', 'Loading28', '#save-file28', '#progressBar28', 'result29', 'arraybuffer');" UseSubmitBehavior="false" OnCommand="GetFileZIP" CommandArgument="Executables/sqlite-amalgamation-3270200.zip" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading28"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar28" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result29">Message: </p></td>
                    <td><a id="save-file28" href="Executables/sqlite-amalgamation-3270200.zip">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/sqlite-amalgamation-3270200.zip" data-filename="SQLite" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/TeamViewerIcon.png" height="20" /> TeamViewer</td>
                    <td data-label="Column2" class="Column2">TeamViewer 13</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Remote Desktop Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>22.3 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton34" runat="server" OnClientClick="return Download('Executables/TeamViewer_Setup.exe', 'ImageButton34', 'Loading31', '#save-file31', '#progressBar31', 'result32', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/TeamViewer_Setup.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading31"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar31" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result32">Message: </p></td>
                    <td><a id="save-file31" href="Executables/TeamViewer_Setup.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/TeamViewer_Setup.exe" data-filename="TeamViewer" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/VisualStudioIcon.png" height="20" /> Visual Studio</td>
                    <td data-label="Column2" class="Column2">Community Edition 2017</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">IDE</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>1.18 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton35" runat="server" OnClientClick="return Download('Executables/vs_community.exe', 'ImageButton35', 'Loading32', '#save-file32', '#progressBar32', 'result33', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/vs_community.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading32"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar32" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result33">Message: </p></td>
                    <td><a id="save-file32" href="Executables/vs_community.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/vs_community.exe" data-filename="Visual Studio" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/VisualStudioCodeIcon.svg" height="20" /> Visual Studio Code</td>
                    <td data-label="Column2" class="Column2">1.30.2</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Source Code Editor</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>44.9 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton36" runat="server" OnClientClick="return Download('Executables/VSCodeUserSetup-x64-1.30.2.exe', 'ImageButton36', 'Loading33', '#save-file33', '#progressBar33', 'result34', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/VSCodeUserSetup-x64-1.30.2.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading33"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar33" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result34">Message: </p></td>
                    <td><a id="save-file33" href="Executables/VSCodeUserSetup-x64-1.30.2.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/VSCodeUserSetup-x64-1.30.2.exe" data-filename="Visual Studio Code" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/VLCIcon.svg" height="20" /> VLC Media Player</td>
                    <td data-label="Column2" class="Column2">3.0.6</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Media Player</td>
                    <td>.EXE (Application)</td>
                    <td>40.9 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton37" runat="server" OnClientClick="return Download('Executables/vlc-3.0.6-win64.exe', 'ImageButton37', 'Loading34', '#save-file34', '#progressBar34', 'result35', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/vlc-3.0.6-win64.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading34"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar34" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result35">Message: </p></td>
                    <td><a id="save-file34" href="Executables/vlc-3.0.6-win64.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/vlc-3.0.6-win64.exe" data-filename="VLC Media Player" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/VMWareIcon.png" height="20" /> VMWare Workstation</td>
                    <td data-label="Column2" class="Column2">15.0.2</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Virtualization Environment</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>524 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton38" runat="server" OnClientClick="return Download('Executables/VMWare-workstation-full-15.0.2-10952284.exe', 'ImageButton38,' 'Loading35', '#save-file35', '#progressBar35', 'result36', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/VMWare-workstation-full-15.0.2-10952284.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading35"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar35" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result36">Message: </p></td>
                    <td><a id="save-file35" href="Executables/VMWare-workstation-full-15.0.2-10952284.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/VMWare-workstation-full-15.0.2-10952284.exe" data-filename="VMWare Workstation" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/ConvertIcon.png" height="20" /> Windows Convert</td>
                    <td data-label="Column2" class="Column2">v4.10</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Unit Converter</td>
                    <td data-label="Column4" class="Column4">.ZIP (Compressed Folder)</td>
                    <td>153 KB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton9" runat="server" OnClientClick="return Download('Executables/convert.zip', 'ImageButton9', 'Loading5', '#save-file5', '#progressBar5', 'result6', 'arraybuffer');" UseSubmitBehavior="false" OnCommand="GetFileZIP" CommandArgument="Executables/convert.zip" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading5"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar5" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result6">Message: </p></td>
                    <td><a id="save-file5" href="Executables/convert.zip">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/convert.zip" data-filename="Windows Convert" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
                <tr class="item">
                    <td data-label="Column1" class="Column1"><img src="Images/WMMIcon.png" height="20" /> Windows Movie Maker</td>
                    <td data-label="Column2" class="Column2">2018</td>
                    <td data-label="Column3" class="Column3" style="padding-left: 5px; padding-right: 5px">Video Editing Software</td>
                    <td data-label="Column4" class="Column4">.EXE (Application)</td>
                    <td>183 MB</td>
                    <td style="padding-left: 5px; padding-right: 5px"><asp:ImageButton ID="ImageButton39" runat="server" OnClientClick="return Download('Executables/win-movie-maker-2018.exe', 'ImageButton39', 'Loading36', '#save-file36', '#progressBar36', 'result37', 'blob');" UseSubmitBehavior="false" OnCommand="GetFileEXE" CommandArgument="Executables/win-movie-maker-2018.exe" ImageUrl="~/Images/DownloadButton.PNG" Height="38px" /><button class="buttonload" id="Loading36"><i class="fa fa-circle-o-notch fa-spin"></i> Loading</button></td>
                    <td style="padding-left: 5px; padding-right: 5px"><div id="progressBar36" class="progressBar"><div></div></div></td>
                    <td style="padding-left: 5px; padding-right: 5px"><p id="result37">Message: </p></td>
                    <td><a id="save-file36" href="Executables/win-movie-maker-2018.exe">Save to PC</a>&nbsp;<div class="g-savetodrive" data-src="Executables/win-movie-maker-2018.exe" data-filename="Windows Movie Maker" data-sitename="Max's Tech and Math Site"></div></td>
                </tr>
            </tbody>
        </table>
        <script>
            new Tablesort(document.getElementById('Downloads'));
        </script>
        <script>
            	function sort(ascending, columnClassName, tableId) {
                    SetSortingColumn('hello', SetOtherColumns);
                    function SetSortingColumn(message, callback) {
			            for (var index = 0; index < 40; index++) {
                            document.getElementsByClassName(columnClassName)[index].style.background = "#f4ce42";
                        }
                        document.querySelectorAll("table td:nth-of-type(odd)").style.background = "yellow";
                        document.querySelectorAll("table td:nth-of-type(even)").style.background = "orange";
                        callback();
                    }
                    function SetOtherColumns() {
                        alert('Well, ${message} world');
                    }
		            var tbody = document.getElementById(tableId).getElementsByTagName(
				            "tbody")[0];
		            var rows = tbody.getElementsByTagName("tr");
		            var unsorted = true;
		            while (unsorted) {
                        unsorted = false;
			            for (var r = 0; r < rows.length - 1; r++) {
				            var row = rows[r];
				            var nextRow = rows[r + 1];
				            var value = row.getElementsByClassName(columnClassName)[0].innerHTML;
				            var nextValue = nextRow.getElementsByClassName(columnClassName)[0].innerHTML;
				            value = value.replace(',', ''); // in case a comma is used in float number
				            nextValue = nextValue.replace(',', '');
				            if (!isNaN(value)) {
					            value = parseFloat(value);
					            nextValue = parseFloat(nextValue);
				            }
				            if (ascending ? value > nextValue : value < nextValue) {
					            tbody.insertBefore(nextRow, row);
					            unsorted = true;
				            }
			            }
                    }
                    return true;
	            };
        </script>
        <script>
            function progress(percent, $element) {
            var progressBarWidth = percent * $element.width() / 100;
            //$element.find('div').animate({ width: progressBarWidth }, 500).html(percent + "%&nbsp;");
            $element.find('div').animate({ width: progressBarWidth }, 100).html(percent + "%&nbsp;");
        }

        function Download(file_name, download_button, load_button, save_link, progress_bar, result, response_type) {
            var request = new XMLHttpRequest();
            request.addEventListener('readystatechange', function (e) {
                if (request.readyState === 2 && request.status === 200) {
                    // Download is being started
                    document.getElementById(download_button).style = "display: none; visibility: hidden";
                    document.getElementById(load_button).style = "display: block; visibility: visible";
                }
                else if (request.readyState === 3) {
                    // Download is under progress
                }
                else if (request.readyState === 4) {
                    // Downloading has finished
                    document.getElementById(download_button).style = "display: block; height: 38px; visibility: visible";
                    document.getElementById(load_button).style = "display: none; visibility: hidden";
                    document.querySelector(save_link).setAttribute('href', _OBJECT_URL);
                    document.querySelector(save_link).setAttribute('download', file_name);
                    _OBJECT_URL = URL.createObjectURL(request.response);
                    // Recommended : Revoke the object URL after some time to free up resources
                    // There is no way to find out whether user finished downloading
                    setTimeout(function () {
                        window.URL.revokeObjectURL(_OBJECT_URL);
                    }, 60 * 1000);
                }
            });
            request.addEventListener("progress", function (e) {
                if (e.lengthComputable) {
                    var percent_complete = (e.loaded / e.total) * 100;
                    progress(percent_complete, $(progress_bar));
                }
                else {
                    document.getElementById(result).innerHTML = "Message: Length of file is not computable.";
                }
            });
            request.addEventListener("load", transferComplete);
            request.addEventListener("error", transferFailed);
            request.addEventListener("abort", transferCanceled);
            request.open('get', file_name);
            request.responseType = response_type;
            request.send();
            function transferComplete(evt) {
                document.getElementById(result).innerHTML = "Message: The transfer is complete.";
            }

            function transferFailed(evt) {
                document.getElementById(result).innerHTML = "Message: An error occurred while transferring the file.";
            }

            function transferCanceled(evt) {
                document.getElementById(result).innerHTML = "Message: The transfer has been canceled by the user.";
            }
            return true;
        }
        </script>
        <script src="https://apis.google.com/js/plusone.js"></script>
        <br />
        <strong>Get Codes</strong><br />
        <asp:Label ID="Label10" runat="server" Text="Enter website URL:"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox102" runat="server" class="text-box2" Width="668px" AccessKey="w" Height="38px" TextMode="Url"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
        &nbsp;<asp:Button ID="Button15" class="myButton" runat="server" OnClick="Button15_Click" Text="Get Source Code and Other Info" Height="38px" />
        <br />
        <asp:Label ID="Label16" runat="server" Text="*The HTML code will be posted in a text file that will appear on your Desktop"></asp:Label>
        <br />
        <asp:Label ID="lblIPAddress" runat="server" Text="IP Address(es): "></asp:Label>
        <br />
        <asp:Label ID="lblCookies" runat="server" Text="Information on website's cookies (if any): "></asp:Label>
        <br />
        <asp:Label ID="lblCache" runat="server" Text="Cache credentials: "></asp:Label>
        <br />
        <asp:Label ID="lblError4" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="Label116" runat="server" Text="Enter FTP Server Host Name (like &quot;ftp.example.com&quot; if &quot;ftp://ftp.example.com/directory/to/download&quot;): "></asp:Label><asp:TextBox ID="TextBox13" runat="server" class="text-box2" Width="668px" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
        <br />
        Enter Directory of FTP Host Name (like "directory/to/download" if "ftp://ftp.example.com/directory/to/download"):&nbsp;<asp:TextBox ID="TextBox58" runat="server" class="text-box2" Width="400px" Height="38px"></asp:TextBox><br />
        <asp:Label ID="Label117" runat="server" Text="Select Protocol of Address: "></asp:Label><asp:DropDownList ID="DropDownList9" runat="server">
            <asp:ListItem>HTTP</asp:ListItem>
            <asp:ListItem>FTP</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button26" runat="server" class="myButton" OnClick="Button26_Click" Text="Download Entire Repository of Files" />
        &nbsp;<asp:Button ID="Button27" runat="server" class="myButton" OnClick="Button27_Click" Text="Button #2" /><br />
        *The directory of files will be downloaded as a .zip file to your Desktop
        <br />
        <asp:Label ID="Label118" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Enter string: "></asp:Label>
        <asp:TextBox ID="TextBox107" runat="server" class="text-box2" AccessKey="h" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button20" class="myButton" runat="server" OnClick="Button20_Click" Text="Get Hash Codes" Height="38px" />
&nbsp;<asp:Label ID="lblHash" runat="server"></asp:Label>
        <br />
        Enter integer:
        &nbsp;<asp:TextBox ID="TextBox14" runat="server" class="text-box2" AccessKey="h" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button16" class="myButton" runat="server" OnClick="Button16_Click" Text="Get Stored Memory Address of Integer" Height="38px" />
&nbsp;<asp:Label ID="lblMemory" runat="server"></asp:Label>
        <br />
        Enter hexadecimal code:
        <asp:TextBox ID="TextBox112" runat="server" class="text-box2" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button29" class="myButton" runat="server" OnClick="Button29_Click" Text="Get Binary Code" Height="38px" />
&nbsp;<asp:Label ID="lblBinary" runat="server"></asp:Label>
        <br />
        Enter IP Address:
        <asp:TextBox ID="TextBox113" runat="server" class="text-box2" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button30" class="myButton" runat="server" OnClick="Button30_Click" Text="Get Binary Code" Height="38px" />
&nbsp;<asp:Label ID="lblBinary2" runat="server"></asp:Label>
        <br />
        Enter single character:
        <asp:TextBox ID="TextBox114" runat="server" class="text-box2" Width="40px" Height="38px"></asp:TextBox>
&nbsp;<asp:Button ID="Button31" class="myButton" runat="server" OnClick="Button31_Click" Text="Get ASCII Encoding" Height="38px" />
&nbsp;<asp:Label ID="lblASCII" runat="server"></asp:Label>
        <br />
        Enter binary string:
        <asp:TextBox ID="TextBox115" runat="server" class="text-box2" Height="38px"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button13" class="myButton" runat="server" OnClick="Button13_Click" Text="Get Binary Info" Height="38px" />&nbsp;<asp:Label ID="lblDecimal" runat="server"></asp:Label>
        <br />
        <br />
        <strong>Connections</strong><br />
        <asp:HiddenField ID="lblNumber" runat="server" />
        <div style="width: 400px; text-align: center; margin: 0 auto" class="w3-container w3-red">
        <h4>Send Text or Email</h4>
    </div>
    <script>
        function selectValue() {
            if (document.getElementById("RadioButtonList2_0").checked == true) {
                document.getElementById("phone").style = "visibility: visible; display: block";
                document.getElementById("toLabel").style = "visibility: visible; display: inline";
                document.getElementById("PhoneIcon").style = "visibility: visible; display: inline-block";
                document.getElementById("yourEmail").style = "visibility: hidden; display: none";
                document.getElementById("yourEmailLabel").style = "visibility: hidden; display: none";
                document.getElementById("password2").style = "visibility: hidden; display: none";
                document.getElementById("password2Label").style = "visibility: hidden; display: none";
                document.getElementById("recipientEmail").style = "visibility: hidden; display: none";
                document.getElementById("recipientEmailLabel").style = "visibility: hidden; display: none";
                document.getElementById("subject").style = "visibility: hidden; display: none";
                document.getElementById("subjectLabel").style = "visibility: hidden; display: none";
                document.getElementById("attachmentsLabel").style = "visibility: hidden; display: none";
                document.getElementById("FileUpload2").style = "visibility: hidden; display: none";
                document.getElementById("priorityLabel").style = "visibility: hidden; display: none";
                document.getElementById("DropDownList1").style = "visibility: hidden; display: none";
                document.getElementById("eye").style = "visibility: hidden; display: none";
                document.getElementById("EmailIcon").style = "visibility: hidden; display: none";
                document.getElementById("PasswordIcon").style = "visibility: hidden; display: none";
                document.getElementById("EmailIcon2").style = "visibility: hidden; display: none";
                document.getElementById("SubjectIcon").style = "visibility: hidden; display: none";
                document.getElementById("AttachmentIcon").style = "visibility: hidden; display: none";
                document.getElementById("PriorityIcon").style = "visibility: hidden; display: none";
            }

            if (document.getElementById("RadioButtonList2_1").checked == true) {
                document.getElementById("phone").style = "visibility: hidden; display: none";
                document.getElementById("toLabel").style = "visibility: hidden; display: none";
                document.getElementById("PhoneIcon").style = "visibility: hidden; display: none";
                document.getElementById("yourEmail").style = "visibility: visible; display: block";
                document.getElementById("yourEmailLabel").style = "visibility: visible; display: inline";
                document.getElementById("password2").style = "visibility: visible; display: block";
                document.getElementById("password2Label").style = "visibility: visible; display: inline";
                document.getElementById("recipientEmail").style = "visibility: visible; display: block";
                document.getElementById("recipientEmailLabel").style = "visibility: visible; display: inline";
                document.getElementById("subject").style = "visibility: visible; display: block";
                document.getElementById("subjectLabel").style = "visibility: visible; display: inline";
                document.getElementById("attachmentsLabel").style = "visibility: visible; display: inline";
                document.getElementById("FileUpload2").style = "visibility: visible; display: block";
                document.getElementById("priorityLabel").style = "visibility: visible; display: inline";
                document.getElementById("DropDownList1").style = "visibility: visible; display: block; margin: 0 auto";
                document.getElementById("eye").style = "visibility: visible; display: block";
                document.getElementById("EmailIcon").style = "visibility: visible; display: inline-block";
                document.getElementById("PasswordIcon").style = "visibility: visible; display: inline-block";
                document.getElementById("EmailIcon2").style = "visibility: visible; display: inline-block";
                document.getElementById("SubjectIcon").style = "visibility: visible; display: inline-block";
                document.getElementById("AttachmentIcon").style = "visibility: visible; display: inline-block";
                document.getElementById("PriorityIcon").style = "visibility: visible; display: inline-block";
            } 
        }
    </script>
    <div style="width: 400px; text-align: center; margin: 0 auto" class="w3-container w3-pale-blue w3-leftbar w3-border-blue">
        <div class="content">
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" onchange="return selectValue();" RepeatDirection="Horizontal" RepeatLayout="Flow" AutoPostBack="true">
                <asp:ListItem Selected="True">Text Message (SMS)&nbsp;</asp:ListItem>
                <asp:ListItem>Email</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <img id="EmailIcon" src="https://img.icons8.com/office/16/000000/secured-letter.png" height="20" style="display: none; visibility: hidden" />&nbsp;<label id="yourEmailLabel" runat="server" style="display: none; visibility: hidden">Your Email Address:</label>
            <input type="text" runat="server" id="yourEmail" name="yourEmail" class="w3-input" style="display: none; visibility: hidden" />
            <img id="PasswordIcon" src="https://img.icons8.com/ultraviolet/40/000000/lock-2.png" height="20" style="display: none; visibility: hidden" />&nbsp;<label id="password2Label" runat="server" style="display: none; visibility: hidden">Password:</label>
            <input type="password" runat="server" id="password2" name="password2" class="w3-input" style="display: none; visibility: hidden" />
            <span id="eye" toggle="#password2" class="fa fa-fw fa-eye field-icon toggle-password" style="display: none; visibility: hidden"></span>
            <script>
                $(".toggle-password").click(function() {
                    $(this).toggleClass("fa-eye fa-eye-slash");
                    var input = $($(this).attr("toggle"));
                    if (input.attr("type") == "password") {
                    input.attr("type", "text");
                    } else {
                    input.attr("type", "password");
                    }
                });
            </script>
            <img id="PhoneIcon" src="https://img.icons8.com/dusk/64/000000/phonelink-ring.png" height="20" />&nbsp;<label id="toLabel" runat="server">Recipient Phone Number:</label>
            <span class="demo"><input type="tel" runat="server" id="phone" name="phone" class="w3-input form-control" style="width: 180px" /><span id="valid-msg" class="hide" style="color: green; font-size: 1em"> ✓ Valid</span><span id="error-msg" style="color: red; font-size: 1em" class="hide"></span></span>
            <script src="Scripts/intlTelInput.min.js"></script>
	        <script src="Scripts/intlTelInput-jquery.min.js"></script>
            <script type="text/javascript">
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
                    validMsg.classList.add("hide");
                };

                // on blur: validate
                input.addEventListener('blur', function() {
                    reset();
                    if (input.value.trim()) {
                    if (iti.isValidNumber()) {
                        validMsg.classList.remove("hide");
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

                function GetNumber() {
                    document.getElementById("lblNumber").value = iti.getNumber(intlTelInputUtils.numberFormat.E164);
                    return true;
                }
            </script>
            <img id="EmailIcon2" src="https://img.icons8.com/office/16/000000/secured-letter.png" height="20" style="display: none; visibility: hidden" />&nbsp;<label id="recipientEmailLabel" runat="server" style="display: none; visibility: hidden">Recipient Email Address:</label>
            <input type="text" runat="server" id="recipientEmail" name="recipientEmail" class="w3-input" style="display: none; visibility: hidden" />
            <img id="SubjectIcon" src="https://img.icons8.com/cotton/64/000000/physics-book.png" height="20" style="display: none; visibility: hidden" />&nbsp;<label id="subjectLabel" runat="server" style="display: none; visibility: hidden">Subject:</label>
            <input type="text" runat="server" id="subject" name="subject" class="w3-input" style="display: none; visibility: hidden" />
            <img id="AttachmentIcon" src="https://img.icons8.com/ios/50/000000/attach-filled.png" height="20" style="display: none; visibility: hidden" />&nbsp;<label id="attachmentsLabel" runat="server" style="display: none; visibility: hidden">Attachments:</label>
            <asp:FileUpload ID="FileUpload2" AllowMultiple="true" runat="server" style="visibility: hidden; display: none" />
            <img id="PriorityIcon" src="https://img.icons8.com/color/48/000000/urgent-message.png" height="25" style="display: none; visibility: hidden" />&nbsp;<label id="priorityLabel" runat="server" style="display: none; visibility: hidden">Priority:</label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="display: none; visibility: hidden; margin: 0 auto">
                <asp:ListItem>Normal</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
                <asp:ListItem>Low</asp:ListItem>
            </asp:DropDownList>
            <span style="display: block"><img src="https://img.icons8.com/color/48/000000/sms.png" height="20" />&nbsp;<label>Message:</label></span>
            <textarea runat="server" cols="50" rows="5" class="w3-input" id="message" name="message"></textarea>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                     <asp:Button ID="Send" runat="server" class="w3-btn w3-white w3-border w3-round" Text="Send" OnClientClick="return GetNumber();" OnClick="SubmitFunction"></asp:Button>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="Send" />
                </Triggers>
            </asp:UpdatePanel>
         </div>
        <p><span class="w3-tag w3-blue" id="ack">Message Status</span></p>
    </div>
    <footer style="width: 400px; text-align: center; margin: 0 auto" class="w3-container w3-red">
      <h3>Powered By: <a href="http://www.howi.in">HOWI.IN</a></h3>
    </footer>
        <br />
        <asp:Label ID="Label3" runat="server" Text="*Note: You cannot specify your own phone number as the sending number due to the possibility of hacking and sending an unsolicited amount of text messages from other peoples' private numbers. Also, be careful with the text you send, i.e. no graphic, violent, sexual, inappropriate, or excessive content, as this website is not responsible for the messages sent by its users." ForeColor="Red"></asp:Label>
        <br />
        <strong>File Converters</strong><br />
        <asp:FileUpload ID="FileUpload1" runat="server" Width="1850px" AccessKey="f" Height="39px" encType="multipart/form-data" />
    <script src="Scripts/DragAndDropFiles.js"></script>
        <script type="text/javascript">
            var developerKey = 'AIzaSyBAZ7XcBDaYHu7daxGUyWATlWH1jZmvwdQ';
            // The Client ID obtained from the Google API Console. Replace with your own Client ID.
            var clientId = "639859509357-l0vg5h7g14evm30ugic6bunv1kb75sm0.apps.googleusercontent.com"
            // Replace with your own project number from console.developers.google.com.
            // See "Project number" under "IAM & Admin" > "Settings"
            var appId = "639859509357";
            // Scope to use to access user's Drive items.
            var scope = ['https://www.googleapis.com/auth/drive'];
            var pickerApiLoaded = false;
            var oauthToken;

            // Use the API Loader script to load google.picker and gapi.auth.
            function onApiLoad() {
            gapi.load('auth2', onAuthApiLoad);
            gapi.load('picker', onPickerApiLoad);
            }

            function onAuthApiLoad() {
            var authBtn = document.getElementById('auth');
            authBtn.disabled = false;
            authBtn.addEventListener('click', function() {
                gapi.auth2.authorize({
                client_id: clientId,
                scope: scope
                }, handleAuthResult);
            });
            }

            function onPickerApiLoad() {
            pickerApiLoaded = true;
            createPicker();
            }

            function handleAuthResult(authResult) {
            if (authResult && !authResult.error) {
                oauthToken = authResult.access_token;
                createPicker();
            }
            }

            // Create and render a Picker object for picking user Photos.
            function createPicker() {
            if (pickerApiLoaded && oauthToken) {
                var picker = new google.picker.PickerBuilder().
                    addView(google.picker.ViewId.PHOTOS).
                    setOAuthToken(oauthToken).
                    setDeveloperKey(developerKey).
                    setCallback(pickerCallback).
                    build();
                picker.setVisible(true);
            }
            }

            // A simple callback implementation.
            function pickerCallback(data) {
            var url = 'nothing';
            if (data[google.picker.Response.ACTION] == google.picker.Action.PICKED) {
                var doc = data[google.picker.Response.DOCUMENTS][0];
                url = doc[google.picker.Document.URL];
            }
            var message = 'You picked: ' + url;
            document.getElementById('result').innerHTML = message;
            }
    </script>
        <br />
    <input type="image" id="auth" src="Images/GoogleDrive.png" height="50" width="145" />
    <div id="result"></div>
    <script type="text/javascript" src="https://apis.google.com/js/api.js?onload=onApiLoad"></script>
    <script type="text/javascript" src="https://www.dropbox.com/static/api/2/dropins.js" id="dropboxjs" data-app-key="viozfkotk74lobo"></script>
    <script>
        document.getElementById("OpenDropboxFilePicker").addEventListener("click", e => {
        var options = {
            success: function (files) {
                 for (const file of files) {
                        const name = file.name;
                        const url = file.link;
                        console.log({ name: name, url: url });
                    }
            },
            cancel: function () {
            },
            linkType: "direct",
            multiselect: true,
            extensions: ['.pdf', '.doc', '.docx', '.html'],
        };
        Dropbox.choose(options);
        fetch(url)
        .then(response => response.blob())
        .then(blob => {
            const url = URL.createObjectURL(blob);
            (document.getElementById("preview")).src = url;
        });
    });
    </script>
        <input type="image" id="OpenDropboxFilePicker" src="Images/DropboxButton.png" />
        <script type="text/javascript" src="https://js.live.net/v5.0/OneDrive.js" id="onedrive-js" client-id="5940fe3a-ca9e-4975-86a3-6e9a8e8d17bc"></script>
        <script type="text/javascript" src="https://js.live.net/v7.2/OneDrive.js" client-id="5940fe3a-ca9e-4975-86a3-6e9a8e8d17bc"></script>
        <script type="text/javascript" src="https://js.live.net/v7.2/OneDrive.js"></script>
        <script type="text/javascript">
          window.onload = function() {
            var pickerOptions = { success: function(files) {
                // Handle returned file object(s)
                alert("You picked " + files.values[0].fileName);
              },

              cancel: function() {
                  // handle when the user cancels picking a file
              },

              linkType: "webViewLink", // or "downloadLink",
              multiSelect: true };
            var pickerButton = OneDrive.createOpenButton(pickerOptions);
            document.getElementById("picker").appendChild(pickerButton);
          }
        </script>
        <!-- CHANGE THE ACTION TO THE PHP SCRIPT THAT WILL PROCESS THE FILE VIA AJAX -->
        
	        <input id="file-upload" type="file" name="fileUpload" />
	        <label for="file-upload" id="file-drag">
		        Select a file to upload
		        <br />OR
		        <br />Drag a file into this box
		        <br /><br /><span id="file-upload-btn" class="button">Add a file</span>
	        </label>
	
	        <progress id="file-progress" value="0">
		        <span>0</span>%
	        </progress>
	
	        <output for="file-upload" id="messages"></output>
        <?php
        $fn = (isset($_SERVER['HTTP_X_FILE_NAME']) ? $_SERVER['HTTP_X_FILE_NAME'] : false);
        $targetDir = 'tmp/';

        if ($fn) {
          	        if (isFileValid($fn)) {
          		        // AJAX call
          		        file_put_contents(
          			        $targetDir . $fn,
          			        file_get_contents('php://input')
          		        );
          		        removeFile($fn);
          	        }
        }

        function removeFile($file) {
	        unlink($targetDir . $file);
        }
        ?>
        <br />
        <asp:Label ID="Label17" runat="server" Text="*Each of the converted files will be saved to the same folder/path you chose for the original file"></asp:Label>
        <br />
        <br />
        &nbsp;<asp:Button ID="Button18" class="myButton" runat="server" Text="Convert .mp3 to .wav" OnClick="Button18_Click" Height="38px" />
        &nbsp;<asp:Button ID="Button23" class="myButton" runat="server" Text="Convert to .mp4" Height="38px" />
        &nbsp;<asp:Button ID="Button24" class="myButton" runat="server" OnClick="Button24_Click" Text="Convert PDF to Text File" Height="38px" />
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Convert To: "></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>JPG</asp:ListItem>
            <asp:ListItem>PNG</asp:ListItem>
            <asp:ListItem>GIF</asp:ListItem>
            <asp:ListItem>BMP</asp:ListItem>
            <asp:ListItem>TIFF</asp:ListItem>
        </asp:ListBox>
&nbsp;<asp:Button ID="Button22" class="myButton" runat="server" OnClick="Button22_Click" Text="Convert image file" Height="38px" />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Media" ForeColor="Red"></asp:Label>
        <br />
        <audio controls="controls" loop="loop">
            <source src="BrassMonkey.mp3" type="audio/mpeg"/>
	        <source src="BrassMonkey.ogg" type="audio/ogg"/> 
	        <a href="BrassMonkey.mp3">Download the Audio File</a> (MP3)
	    </audio>
        <br />
        <input type="color" />
        <br />
        <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Rock/Paper/Scissors Game"></asp:Label>
        <br />
        <asp:Image ID="Image3" runat="server" Height="120px" ImageUrl="~/Images/RPS.jpg" />
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" ForeColor="Black" Text="Select the object you wish to play:"></asp:Label>
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="180px" ImageUrl="Images/Rock.PNG" OnClick="ImageButton2_Click" />
&nbsp;
        <asp:ImageButton ID="ImageButton3" runat="server" Height="180px" ImageUrl="Images/Paper.PNG" OnClick="ImageButton3_Click" />
&nbsp;
        <asp:ImageButton ID="ImageButton4" runat="server" Height="180px" ImageUrl="Images/Scissors.PNG" OnClick="ImageButton4_Click" />
        <br />
        <asp:Label ID="Label25" runat="server" Font-Bold="True" Text="You: "></asp:Label>
        <asp:Image ID="Image4" runat="server" Height="180px" Visible="False" />
&nbsp;<asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Computer: "></asp:Label>
&nbsp;<asp:Image ID="Image5" runat="server" Height="180px" Visible="False" />
        <br />
        <asp:Label ID="Label27" runat="server" Font-Size="X-Large" ForeColor="#00CC00"></asp:Label>
        <br />
        <asp:Image ID="Image6" runat="server" ImageUrl="Images/Scoreboard.PNG" />
        <br />
        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Large" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Large" Text="0"></asp:Label>
        <br />
        Rounds:
        <asp:Label ID="Label28" runat="server" Text="0"></asp:Label>
&nbsp; Ties:
        <asp:Label ID="Label29" runat="server" Text="0"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Bowling Score Calculator"></asp:Label>
        <br />
        <asp:Image ID="Image9" runat="server" Height="170px" ImageUrl="~/Images/BowlingStrike.jpg" Width="300px" />
        <br />
        <br />
        <asp:Label ID="Label46" runat="server" Font-Bold="True" Text="Bowler Name: "></asp:Label>
        <strong>&nbsp;</strong><asp:TextBox ID="TextBox111" runat="server" Height="38px" class="text-box2" Width="140px" AccessKey="b"></asp:TextBox>
        <button class="close-icon" type="reset"></button>
&nbsp;<asp:Button ID="Button12" class="myButton" runat="server" Text="New Game" OnClientClick="return confirm('Are you sure you want to start a new game?');" OnClick="Button12_Click" data-toggle="modal" data-target="#newGame" Height="38px" />
        &nbsp;<strong> &nbsp;Edit Frame #:</strong>
        <div class="modal fade" id="newGame" tabindex="-1" role="dialog" aria-labelledby="newGameLabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title" id="newGameLabel">How to use this calculator</h4>
              </div>
              <div class="modal-body">
                    Are you sure you want to start a new game?
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Yes</button>
                <button type="button" class="btn btn-default" data-dismiss="modal">No</button>
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
              </div>
            </div>
          </div>
        </div>
        <asp:ListBox ID="ListBox2" runat="server">
            <asp:ListItem>Previous</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:ListBox>
&nbsp;<asp:Button ID="Button14" class="myButton" runat="server" OnClick="Button14_Click" Text="Edit Frame" Height="38px" />
        <br />
        <strong>Enter number of pins knocked down:<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button28" class="myButton" runat="server" OnClick="Button28_Click" Text="Strike (X)" Height="38px" />
&nbsp;</strong><asp:Label ID="Label45" runat="server" Text="First shot: "></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server" class="text-box2" Width="60px" Height="38px"></asp:TextBox>
        &nbsp;<asp:Label ID="Label44" runat="server" Text="Second shot: "></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server" class="text-box2" Width="60px" Height="38px"></asp:TextBox>
        <asp:Label ID="Label43" runat="server" Text="Third shot in 10th frame: " Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox110" runat="server" class="text-box2" Height="38px" Visible="False" Width="36px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" class="myButton" runat="server" Text="Submit" OnClick="Button1_Click" Height="38px" />
        <asp:Button ID="Button2" class="myButton" runat="server" OnClick="Button2_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button3" class="myButton" runat="server" OnClick="Button3_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button4" class="myButton" runat="server" OnClick="Button4_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button5" class="myButton" runat="server" OnClick="Button5_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button6" class="myButton" runat="server" OnClick="Button6_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button7" class="myButton" runat="server" OnClick="Button7_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button8" class="myButton" runat="server" OnClick="Button8_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button9" class="myButton" runat="server" OnClick="Button9_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button10" class="myButton" runat="server" OnClick="Button10_Click" Text="Submit" Visible="False" Height="38px" />
        <asp:Button ID="Button11" class="myButton" runat="server" OnClick="Button11_Click" Text="Submit" Visible="False" Height="38px" />
        <br />
        <br />
        <strong>Frame: </strong>
        <asp:Label ID="Label42" runat="server" Font-Bold="True" Text="1"></asp:Label>
        <br />
        <table id="Bowling">
            <tr>
                <th class="width2" style="text-align: center">
                    &nbsp;<asp:Label ID="Label41" runat="server" style="margin: 0 auto" Text="1" Font-Bold="True"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label40" runat="server" Text="2"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    &nbsp;<asp:Label ID="Label39" runat="server" Text="3"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label38" runat="server" Text="4"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label37" runat="server" Text="5"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label36" runat="server" Text="6"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label35" runat="server" Text="7"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label34" runat="server" Text="8"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label33" runat="server" Text="9"></asp:Label>
                </th>
                <th class="width2" style="text-align: center">
                    <asp:Label ID="Label32" runat="server" Text="10"></asp:Label>
                </th>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox10" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox20" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox30" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox40" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox50" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="auto-style6"></asp:TextBox>
                    <asp:TextBox ID="TextBox60" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="auto-style6"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox70" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox80" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox90" runat="server" Width="49px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxTen" runat="server" Width="29px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox100" runat="server" Width="29px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                    <asp:TextBox ID="TextBox101" runat="server" Width="29px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox21" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox22" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox23" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox24" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox25" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox26" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox27" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox28" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox29" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxThirty" runat="server" Width="106px" Height="35px" ReadOnly="True" CssClass="text-xs-center"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblError3" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <img src="Images/change.png" height="40" />&nbsp;<asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Financial Calculators"></asp:Label>
        <br />
        <br />
        <img src="Images/gasoline.png" height="30" /> <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Fuel Expense Calculator"></asp:Label>
        <br />
        <button id="FuelPrices" class="myButton" onclick="FuelAPI();">Get Prices</button>
        <script>
            function FuelAPI() {
                function readTextFile(file, callback) {
                    var rawFile = new XMLHttpRequest();
                    rawFile.overrideMimeType("application/json");
                    rawFile.open("GET", file, true);
                    rawFile.onreadystatechange = function() {
                        if (rawFile.readyState === 4 && rawFile.status == "200") {
                            callback(rawFile.responseText);
                        }
                    }
                    rawFile.send(null);
                }

                readTextFile("http://api.mygasfeed.com/stations/radius/40.2225481/-84.484396/5/reg/distance/paooyk3ldl.json", function(text){
                    var data = JSON.parse(text);
                    console.log(data);
                    alert("Function did execute.");
                });
            }
        </script>
        <br />
        Enter number of miles driven (reference the odometer):
        <asp:TextBox ID="TextBox116" runat="server" class="text-box2" Width="100px" Height="38px"></asp:TextBox>
&nbsp;miles<br />
        Enter average price of fuel during time span of travel: $<asp:TextBox ID="TextBox117" runat="server" class="text-box2" Width="80px" Height="38px"></asp:TextBox>
        /gallon
        <br />
        Enter miles per gallon (MPG) of your vehicle:
        <asp:TextBox ID="TextBox118" runat="server" class="text-box2" Width="60px" Height="38px"></asp:TextBox>
&nbsp;miles/gallon
        <asp:Button ID="Button32" runat="server" Text="Submit" class="myButton" OnClick="Button32_Click" />
        <br />
        <asp:Label ID="Label50" runat="server" Text="Total Fuel Expense: "></asp:Label>
        <br />
        <br />
        <img src="Images/InterestRate.png" height="30" />&nbsp;<asp:Label ID="Label31" runat="server" Font-Bold="True" Text="Simple Interest Calculator"></asp:Label>
        <br />
&nbsp;<asp:Image ID="Image8" runat="server" Height="180px" ImageUrl="~/Images/Interest.jpg" />
        <br />
        <asp:Label ID="Label80" runat="server" Text="Enter Principal: $"></asp:Label><asp:TextBox ID="TextBox49" runat="server" class="text-box2" Height="38px" Width="160px"></asp:TextBox>
        <br />
        <asp:Label ID="Label81" runat="server" Text="Enter Annual Interest Rate: "></asp:Label><asp:TextBox ID="TextBox51" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>%
        <br />
        <asp:Label ID="Label82" runat="server" Text="Enter Time of Loan/Note: "></asp:Label><asp:TextBox ID="TextBox52" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>years
        <asp:Button ID="Button36" runat="server" class="myButton" Text="Submit" OnClick="Button36_Click" />
        <br />
        <asp:Label ID="Label83" runat="server" Text="Interest Expense: "></asp:Label>
        <br />
        <br />
        <img src="Images/Depreciation.png" height="30" />&nbsp;<asp:Label ID="Label84" runat="server" Font-Bold="True" Text="Depreciation Calculator"></asp:Label>
        <br />
        Depreciation Method:
        <asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>Straight-Line</asp:ListItem>
            <asp:ListItem Value="Declining-Balance">Declining-Balance</asp:ListItem>
        </asp:DropDownList>
        <br />
        Asset Cost: $<asp:TextBox ID="TextBox125" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
        <br />
        Salvage Value: $<asp:TextBox ID="TextBox126" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
        <br />
        Depreciation Years:
        <asp:TextBox ID="TextBox127" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
        <br />
        <asp:Label ID="Label85" runat="server" Text="Depreciation Factor: " Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox128" runat="server" class="text-box2" Height="38px" Width="40px" Visible="False"></asp:TextBox>
&nbsp;<asp:Button ID="Button37" runat="server" class="myButton" Text="Submit" OnClick="Button37_Click" />
        <br />
        <asp:Table ID="myTable" runat="server" CssClass="depreciation" Width="100%" Visible="False">
            <asp:TableHeaderRow style="font-weight: 700">
                <asp:TableCell>Year</asp:TableCell>
                <asp:TableCell>Beginning Book Value</asp:TableCell>
                <asp:TableCell>Depreciation Percent</asp:TableCell>
                <asp:TableCell>Depreciation Amount</asp:TableCell>
                <asp:TableCell>Accumulated Depreciation Amount</asp:TableCell>
                <asp:TableCell>Ending Book Value</asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>  
        <br />
        <img src="Images/loan.png" height="30" />&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Amortized Loan Calculator"></asp:Label>
        <br />
        *This is a calculator for the normal loans you pay in fixed increments (cannot be variable/flexible) throughout, like mortgages, auto loans, and installment plans. For a calculator on deferred loan payments, visit the <a href="math/Algebra.aspx">Algebra page</a><i class="material-icons">open_in_new</i><br />
        <asp:Image ID="Image7" runat="server" Height="220px" ImageUrl="Images/AmortizedLoan.png" />
        <br />
        Enter initial principal (loan amount): $<asp:TextBox ID="TextBox15" runat="server" class="text-box2" Height="38px"></asp:TextBox>
        <br />
        Enter total additional fees/charges, if any (could be financing or non-financing fees, like closing costs): $<asp:TextBox ID="TextBox16" class="text-box2" Width="100px" runat="server"></asp:TextBox>
        <br />
        Enter interest rate:
        <asp:TextBox ID="TextBox119" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>%<br />
        Enter total number of payments per period (so monthly payments out of a one-year period would be 12): 
        <asp:TextBox ID="TextBox120" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
        <br />
        Enter total number of periods (so 30 for a 30-year mortgage):
        <asp:TextBox ID="TextBox121" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
&nbsp;<asp:Button ID="Button33" runat="server" Text="Submit" class="myButton" OnClick="Button33_Click" />
        <br />
        <asp:Label ID="Label51" runat="server" Text="Payment per Period: "></asp:Label>
        <br />
        <asp:Label ID="Label52" runat="server" Text="Total Cost when Done Paying (Future Value): "></asp:Label>
        <br />
        <asp:Label ID="Label13" runat="server" Text="APR (Annual Percentage Rate): "></asp:Label>
        <br />
        <asp:Label ID="Label53" runat="server" Text="Calculations: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Payroll Taxes Calculator"></asp:Label>
        <br />
        <asp:Label ID="Label87" runat="server" Text="Enter Paycheck Rate: "></asp:Label>
        <asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem>Weekly</asp:ListItem>
            <asp:ListItem>Biweekly</asp:ListItem>
            <asp:ListItem>Semimonthly</asp:ListItem>
            <asp:ListItem>Monthly</asp:ListItem>
            <asp:ListItem>Semiannually</asp:ListItem>
            <asp:ListItem>Annually</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label86" runat="server" Text="Enter Weekly Pay: $"></asp:Label>
        <asp:TextBox ID="TextBox129" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
        &nbsp;<asp:Label ID="Label96" runat="server" Text="or...Calculate Pay Based on Hours"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>No</asp:ListItem>
            <asp:ListItem>Yes</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label91" runat="server" Text="Enter # of Regular Hours Worked: " Visible="False" style="display: none" ></asp:Label><asp:TextBox ID="TextBox53" class="text-box2" Value="40" Height="38px" Width="60px" runat="server" Visible="False" style="display: none"></asp:TextBox>
        <br />
        <asp:Label ID="Label92" runat="server" Text="Enter Base Hourly Pay: $" Visible="False" style="display: none"></asp:Label>
        <asp:TextBox ID="TextBox131" runat="server" class="text-box2" onchange="javascript:return GetOvertimeRate();" Height="38px" Width="80px" Visible="False" style="display: none"></asp:TextBox>
        <script type="text/javascript">
            function GetOvertimeRate()
            {
                var basePay = document.getElementById("TextBox131").value;
                var overtimePay = basePay * 1.5;
                document.getElementById("TextBox55").value = overtimePay;
                return false;
            }
        </script>
        <br />
        <asp:Label ID="Label93" runat="server" Text="Enter # of Overtime Hours Worked: " Visible="False" style="display: none"></asp:Label><asp:TextBox ID="TextBox54" runat="server" class="text-box2" Height="38px" Width="60px" Visible="False" style="display: none"></asp:TextBox>
        <br />
        <asp:Label ID="Label94" runat="server" Text="Enter Overtime Hourly Pay: $" Visible="False" style="display: none"></asp:Label><asp:TextBox ID="TextBox55" runat="server" class="text-box2" Height="38px" Width="80px" Visible="False" style="display: none"></asp:TextBox>
        <br />
        <asp:Label ID="Label97" runat="server" Text="Enter YTD (year-to-date) gross pay, not including this paycheck: $"></asp:Label>
        <asp:TextBox ID="TextBox132" runat="server" class="text-box2" Height="38px" Width="160px"></asp:TextBox>
        <br />
        <asp:Label ID="Label98" runat="server" Text="Select State: "></asp:Label>
        <asp:DropDownList ID="DropDownList8" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged">
            <asp:ListItem>Alabama</asp:ListItem>
            <asp:ListItem>Alaska</asp:ListItem>
            <asp:ListItem>Arizona</asp:ListItem>
            <asp:ListItem>Arkansas</asp:ListItem>
            <asp:ListItem>California</asp:ListItem>
            <asp:ListItem>Colorado</asp:ListItem>
            <asp:ListItem>Connecticut</asp:ListItem>
            <asp:ListItem>Delaware</asp:ListItem>
            <asp:ListItem>Florida</asp:ListItem>
            <asp:ListItem>Georgia</asp:ListItem>
            <asp:ListItem>Hawaii</asp:ListItem>
            <asp:ListItem>Idaho</asp:ListItem>
            <asp:ListItem>Illinois</asp:ListItem>
            <asp:ListItem>Indiana</asp:ListItem>
            <asp:ListItem>Iowa</asp:ListItem>
            <asp:ListItem>Kansas</asp:ListItem>
            <asp:ListItem>Kentucky</asp:ListItem>
            <asp:ListItem>Louisiana</asp:ListItem>
            <asp:ListItem>Maine</asp:ListItem>
            <asp:ListItem>Maryland</asp:ListItem>
            <asp:ListItem>Massachusetts</asp:ListItem>
            <asp:ListItem>Michigan</asp:ListItem>
            <asp:ListItem>Minnesota</asp:ListItem>
            <asp:ListItem>Mississippi</asp:ListItem>
            <asp:ListItem>Missouri</asp:ListItem>
            <asp:ListItem>Montana</asp:ListItem>
            <asp:ListItem>Nebraska</asp:ListItem>
            <asp:ListItem>Nevada</asp:ListItem>
            <asp:ListItem>New Hampshire</asp:ListItem>
            <asp:ListItem>New Jersey</asp:ListItem>
            <asp:ListItem>New Mexico</asp:ListItem>
            <asp:ListItem>New York</asp:ListItem>
            <asp:ListItem>North Carolina</asp:ListItem>
            <asp:ListItem>North Dakota</asp:ListItem>
            <asp:ListItem>Ohio</asp:ListItem>
            <asp:ListItem>Oklahoma</asp:ListItem>
            <asp:ListItem>Oregon</asp:ListItem>
            <asp:ListItem>Pennsylvania</asp:ListItem>
            <asp:ListItem>Rhode Island</asp:ListItem>
            <asp:ListItem>South Carolina</asp:ListItem>
            <asp:ListItem>South Dakota</asp:ListItem>
            <asp:ListItem>Tennessee</asp:ListItem>
            <asp:ListItem>Texas</asp:ListItem>
            <asp:ListItem>Utah</asp:ListItem>
            <asp:ListItem>Vermont</asp:ListItem>
            <asp:ListItem>Virginia</asp:ListItem>
            <asp:ListItem>Washington</asp:ListItem>
            <asp:ListItem>West Virginia</asp:ListItem>
            <asp:ListItem>Wisconsin</asp:ListItem>
            <asp:ListItem>Wyoming</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label111" runat="server" Text="Enter Year # of your Employment: " Visible="false"></asp:Label>
        <asp:TextBox ID="TextBox136" runat="server" class="text-box2" Height="38px" Width="60px" Visible="false"></asp:TextBox>
        <br />
        <asp:Label ID="Label112" runat="server" Text="Enter Industry Tax Rate Average for " Visible="false"></asp:Label>
        <asp:TextBox ID="TextBox137" runat="server" class="text-box2" Height="38px" Width="100px" Visible="false"></asp:TextBox><asp:Label ID="Label113" runat="server" Text="%" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="Label90" runat="server" Text="Are you Single or Married? "></asp:Label>
        <asp:DropDownList ID="DropDownList6" runat="server">
            <asp:ListItem>Married</asp:ListItem>
            <asp:ListItem>Single</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label89" runat="server" Text="Enter Number of Dependents/Withholding Allowances: "></asp:Label>
        <asp:TextBox ID="TextBox130" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
        <br />
        <asp:Label ID="Label108" runat="server" Text="City Tax Rate: "></asp:Label>
        <asp:TextBox ID="TextBox133" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>
        %<br />
        <asp:Label ID="Label110" runat="server" Text="Local School Tax Rate: "></asp:Label>
        <asp:TextBox ID="TextBox134" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>
        %<br />
        Additional Withholdings (like for retirement, insurance, or charity): $<asp:TextBox ID="TextBox135" runat="server" class="text-box2" Height="38px" Width="120px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button38" runat="server" class="myButton" Text="Submit" OnClientClick="return GetStateTax();" OnClick="Button38_Click" />
        <script>
            function GetStateTax() {
                function readTextFile(file, callback) {
                    var rawFile = new XMLHttpRequest();
                    // rawFile.overrideMimeType("application/json");
                    rawFile.open("GET", file, true);
                    rawFile.onreadystatechange = function() {
                        if (rawFile.readyState === 4 && rawFile.status == "200") {
                            callback(rawFile.responseText);
                        }
                    }
                    rawFile.send(null);
                }

                readTextFile("https://taxee.io/api/v2/state/2019/OH", function(text){
                    var data = JSON.parse(text);
                    console.log(data);
                    alert("Function did execute.");
                });

                return true;
            }
        </script>
        &nbsp;<asp:Label ID="lblError5" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="Label95" runat="server" Text="Gross Pay: "></asp:Label>
        <br />
        <asp:Label ID="Label88" runat="server" Text="Federal Income Tax Owed: "></asp:Label>
        <br />
        <asp:Label ID="Label100" runat="server" Text="State Income Tax Owed: "></asp:Label>
        <br />
        <asp:Label ID="Label101" runat="server" Text="Social Security Tax Owed: "></asp:Label>
        <br />
        <asp:Label ID="Label99" runat="server" Text="Medicare Tax Owed: "></asp:Label>
        <br />
        <asp:Label ID="Label103" runat="server" Text="State Unemployment Tax Owed (for employer only): "></asp:Label>
        <br />
        <asp:Label ID="Label102" runat="server" Text="Federal Unemployment Tax Owed (employer only): "></asp:Label>
        <br />
        <asp:Label ID="Label104" runat="server" Text="Local (City &amp; School) Taxes Owed: "></asp:Label>
        <br />
        <asp:Label ID="Label105" runat="server" Text="Total Taxes Owed for Employee: "></asp:Label>
        <br />
        <asp:Label ID="Label109" runat="server" Text="Total Taxes Owed for Employer: "></asp:Label>
        <br />
        <asp:Label ID="Label106" runat="server" Text="Net Pay: "></asp:Label>
        <br />
        <asp:Label ID="Label107" runat="server" Text="Year-To-Date Pay and Taxes: "></asp:Label>
        <br />
        <asp:Label ID="Label49" runat="server" Font-Bold="True" Text="Annuity Calculators"></asp:Label>
        <br />
        <ul class="flex-container">
          <li class="flex-item-red">
              <h3>Payment per Period</h3>
              <asp:Image ID="Image10" runat="server" Height="210px" ImageUrl="~/Images/AnnuityPayment.PNG" />
              <br />
              Present Value (PV): $<asp:TextBox ID="TextBox122" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              Interest Rate (r):
              <asp:TextBox ID="TextBox123" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>
              %<br />
              Number of Periods/Payments (n):
              <asp:TextBox ID="TextBox124" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
              &nbsp;<asp:Button ID="Button34" runat="server" class="myButton" Text="Submit" OnClick="Button34_Click" />
              <br />
              <asp:Label ID="Label54" runat="server" Text="Payment per Period: "></asp:Label>
          </li>
          <li class="flex-item-red">
              <h3>Present Value</h3>
              <asp:Image ID="Image11" runat="server" ImageUrl="~/Images/PresentValue.png" />
              <br />
              Payment per Period (P): $<asp:TextBox ID="TextBox17" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              Interest Rate (r):
              <asp:TextBox ID="TextBox18" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>
              %<br />
              Number of Periods/Payments (n):
              <asp:TextBox ID="TextBox19" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
              &nbsp;<asp:Button ID="Button17" runat="server" class="myButton" Text="Submit" OnClick="Button17_Click" />
              <br />
              <asp:Label ID="Label18" runat="server" Text="Present Value (PV): "></asp:Label>
          </li>
          <li class="flex-item-red">
              <h3>Future Value</h3>
              <asp:Image ID="Image12" runat="server" Height="210px" ImageUrl="~/Images/AnnuityValues.png" />
              <br />
              Payment per Period (P): $<asp:TextBox ID="TextBox31" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              Interest Rate (r):
              <asp:TextBox ID="TextBox32" runat="server" class="text-box2" Height="38px" Width="80px"></asp:TextBox>
              %<br />
              Number of Periods/Payments (n):
              <asp:TextBox ID="TextBox33" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
              &nbsp;<asp:Button ID="Button19" runat="server" class="myButton" Text="Submit" OnClick="Button19_Click" />
              <br />
              <asp:Label ID="Label19" runat="server" Text="Future Value (FV): "></asp:Label>
          </li>
        </ul>
        <br />
        <img src="Images/stock.png" height="30" />&nbsp;<asp:Label ID="Label79" runat="server" Font-Bold="True" Text="Stock Calculators"></asp:Label>
        <br />
        <img src="https://img.icons8.com/dusk/64/000000/bonds.png" height="30" />&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Bond Calculators"></asp:Label>
        <br />
        <asp:Image ID="Image2" runat="server" Height="250px" ImageUrl="~/Images/BondPrice.png" />
        &nbsp;<asp:Image ID="Image13" runat="server" Height="250px" ImageUrl="~/Images/ZeroCouponValue.PNG" Width="350px" />
&nbsp;<asp:Image ID="Image15" runat="server" Height="250px" ImageUrl="~/Images/CurrentYield.png" Width="350px" />
&nbsp;<asp:Image ID="Image14" runat="server" Height="250px" ImageUrl="~/Images/ZeroCouponYield.PNG" Width="350px" />
        <br />
        <asp:Image ID="Image16" runat="server" Height="250px" ImageUrl="~/Images/YTM.PNG" Width="350px" style="margin-top: 7px" />
        &nbsp;<asp:Image ID="Image17" runat="server" Height="250px" ImageUrl="~/Images/BondReturn.PNG" Width="500px" style="margin-top: 7px" />
        <br />
        <ul class="flex-container">
          <li class="flex-item-green">
            <h3 style="color: red; font-weight: 700">Bond Price</h3>
            Zero-Coupon Bond? 
            <asp:RadioButtonList ID="RadioButtonList4" runat="server" style="display: inline" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList4_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem Selected="True">No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label60" runat="server" Text="Enter face/par value: $"></asp:Label><asp:TextBox ID="TextBox34" runat="server" class="text-box2" Width="140px" Height="38px"></asp:TextBox>
            <br />
            <asp:Label ID="Label20" runat="server" Text="Enter coupon rate: "></asp:Label><asp:TextBox ID="TextBox35" runat="server" class="text-box2" Width="80px" Height="38px"></asp:TextBox>%
            <br />
            <asp:Label ID="Label59" runat="server" Text="Enter YTM/YTC/YTP (Yield to Maturity/Call/Put): "></asp:Label><asp:TextBox ID="TextBox36" runat="server" class="text-box2" Width="80px" Height="38px"></asp:TextBox><asp:Label ID="Label61" runat="server" Text="%"></asp:Label>
            <br />
            Enter time until maturity/call/put: <asp:TextBox ID="TextBox37" runat="server" class="text-box2" Width="60px" Height="38px"></asp:TextBox>years<br />
            <asp:Label ID="Label62" runat="server" Text="Rate of coupon payments received: "></asp:Label><asp:RadioButtonList ID="RadioButtonList3" runat="server">
                <asp:ListItem>Quarterly</asp:ListItem>
                <asp:ListItem Selected="True">Semi-Annually</asp:ListItem>
                <asp:ListItem>Annually</asp:ListItem>
            </asp:RadioButtonList>
    &nbsp;<asp:Button ID="Button35" runat="server" Text="Submit" class="myButton" OnClick="Button35_Click" />
            <br />
            <asp:Label ID="Label55" runat="server" Text="Bond Price: "></asp:Label>
            <br />
            <asp:Label ID="Label56" runat="server" Text="Type of Bond: "></asp:Label>
            <br />
            <asp:Label ID="Label57" runat="server" Text="Current Yield: "></asp:Label>
            <br />
            <asp:Label ID="Label58" runat="server" Text="Adjusted Current Yield: "></asp:Label>
          </li>
          <li class="flex-item-green">
              <h3 style="color: red; font-weight: 700">Yield to Maturity/Call/Put</h3>
              Select yield to calculate: 
              <asp:RadioButtonList ID="RadioButtonList6" runat="server" OnSelectedIndexChanged="RadioButtonList6_SelectedIndexChanged" AutoPostBack="true">
                  <asp:ListItem Selected="True">Yield to Maturity (YTM)</asp:ListItem>
                  <asp:ListItem>Yield to Call (YTC)</asp:ListItem>
                  <asp:ListItem>Yield to Put (YTP)</asp:ListItem>
              </asp:RadioButtonList>
              <asp:Label ID="Label67" runat="server" Text="Enter Face/Par Value: $"></asp:Label><asp:TextBox ID="TextBox38" class="text-box2" Height="38px" Width="140px" runat="server"></asp:TextBox>
              <br />
              <asp:Label ID="Label63" runat="server" Text="Enter Bond Price: $"></asp:Label><asp:TextBox ID="TextBox39" class="text-box2" Height="38px" Width="140px" runat="server"></asp:TextBox>
              <br />
              <asp:Label ID="Label64" runat="server" Text="Enter Coupon Rate: "></asp:Label><asp:TextBox ID="TextBox41" class="text-box2" Height="38px" Width="80px" runat="server"></asp:TextBox>
              %<br />
              <asp:Label ID="Label65" runat="server" Text="Enter Time until Maturity: "></asp:Label><asp:TextBox ID="TextBox42" class="text-box2" Height="38px" Width="60px" runat="server"></asp:TextBox>years
              <br />
              <asp:Label ID="Label68" runat="server" Text="Rate of coupon payments received: "></asp:Label><asp:RadioButtonList ID="RadioButtonList5" runat="server">
                <asp:ListItem>Quarterly</asp:ListItem>
                <asp:ListItem Selected="True">Semi-Annually</asp:ListItem>
                <asp:ListItem>Annually</asp:ListItem>
              </asp:RadioButtonList>
              <asp:Button ID="Button21" runat="server" class="myButton" Text="Submit" OnClick="Button21_Click" />
              <br />
              <asp:Label ID="Label66" runat="server" Text="Approximate Yield to Maturity: "></asp:Label>
              <br />
              <asp:Label ID="Label69" runat="server" Text="Exact Yield to Maturity: "></asp:Label>
          </li>
          <li class="flex-item-green">
              <h3 style="color: red; font-weight: 700">Bond Return</h3>
              <asp:Label ID="Label78" runat="server" Text="Enter Face Value: $"></asp:Label><asp:TextBox ID="TextBox48" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              <asp:Label ID="Label70" runat="server" Text="Enter Buying Price (Starting Principal): $"></asp:Label><asp:TextBox ID="TextBox43" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              <asp:Label ID="Label71" runat="server" Text="Enter Selling Price (End Principal): $"></asp:Label><asp:TextBox ID="TextBox44" runat="server" class="text-box2" Height="38px" Width="140px"></asp:TextBox>
              <br />
              <asp:Label ID="Label72" runat="server" Text="Enter Coupon Interest: "></asp:Label><asp:TextBox ID="TextBox45" runat="server" class="text-box2" Height="38px" Width="100px"></asp:TextBox>
              <asp:DropDownList ID="DropDownList2" runat="server">
                  <asp:ListItem Selected="True">%</asp:ListItem>
                  <asp:ListItem>$</asp:ListItem>
              </asp:DropDownList>
              <br />
              <asp:Label ID="Label73" runat="server" Text="Enter Taxes, Fees, & Commissions: "></asp:Label><asp:TextBox ID="TextBox46" runat="server" class="text-box2" Height="38px" Width="100px"></asp:TextBox>
              <asp:DropDownList ID="DropDownList3" runat="server">
                  <asp:ListItem Selected="True">%</asp:ListItem>
                  <asp:ListItem>$</asp:ListItem>
              </asp:DropDownList>
              <br />
              <asp:Label ID="Label74" runat="server" Text="Enter Time until Maturity: "></asp:Label><asp:TextBox ID="TextBox47" runat="server" class="text-box2" Height="38px" Width="60px"></asp:TextBox>
              <asp:Label ID="Label77" runat="server" Text="years"></asp:Label>
              <br />
              <asp:Button ID="Button25" runat="server" class="myButton" Text="Submit" OnClick="Button25_Click" />
              <br />
              <asp:Label ID="Label75" runat="server" Text="Bond Return Amount: "></asp:Label>
              <br />
              <asp:Label ID="Label76" runat="server" Text="Bond Return Percent: "></asp:Label>
          </li>
        </ul>
        <br />
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Retirement Calculator"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="FIFO/LIFO Inventory Calculator"></asp:Label>
        <br />
        <div id="BottomSection">
        <br />
        <h3 style="font-weight: 700">Interact with this Page</h3>
&nbsp;<script type="text/javascript" src="//s7.addthis.com/js/300/addthis_widget.js#pubid=ra-5ab46f659b031ec0"></script>
        <button class="myButton" onclick="window.print()"><i class="fa fa-print"></i> Print This Page</button>
        <br />
        <br />
        <div class="fb-save" data-uri="http://maxstechandmathsite.azurewebsites.net" data-size="large"></div>
        <div class="fb-comments" data-href="http://maxstechandmathsite.azurewebsites.net" data-numposts="5"></div>
        <div class="fb-like" data-href="http://maxstechandmathsite.azurewebsites.net" data-layout="standard" data-action="like" data-size="small" data-show-faces="true" data-share="true"></div>
        <br />
        <br />
        <a class="twitter-share-button" href="https://twitter.com/intent/tweet?text=Check%20out%20this%20website%20on%20technology,%20science,%20and%20math!%20#STEM%20via%20@MaxVoisard">Tweet</a>
        <a href="https://twitter.com/MaxVoisard?ref_src=twsrc%5Etfw" class="twitter-follow-button" data-show-count="true">Follow @MaxVoisard</a><script async="async" src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
        <br />
        <div class="cont">
            <div class="stars">
              <input class="star star-5" id="star-5" type="radio" name="star" value="5"/>
              <label class="star star-5" for="star-5"></label>
              <input class="star star-4" id="star-4" type="radio" name="star" value="4"/>
              <label class="star star-4" for="star-4"></label>
              <input class="star star-3" id="star-3" type="radio" name="star" value="3"/>
              <label class="star star-3" for="star-3"></label>
              <input class="star star-2" id="star-2" type="radio" name="star" value="2"/>
              <label class="star star-2" for="star-2"></label>
              <input class="star star-1" id="star-1" type="radio" name="star" value="1"/>
              <label class="star star-1" for="star-1"></label>
              <div class="rev-box">
                <textarea class="review" cols="30" name="review" rows="1"></textarea>
                <label class="review" for="review">Brief Review</label>
              </div>
            </div>
            <p>Rate This Site</p>
        </div>
        <br />
        </div>
    </main>
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
    <div class="icon-column    "><i><img src="Images/Media.jpg" alt="Social Media" height="20" width="20"/></i></div>
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
        <div class="icon-column    "><i><img src="Images/Contact.jpg" alt="Contact Us" height="20" width="20"/></i></div>
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
    <div class="icon-column    "><i><img src="Images/Telephone.jpg" alt="Call" height="20" width="20"/></i></div>
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
</div>
        &nbsp;&nbsp;&nbsp;
        <span style="color: black"><gcse:search></gcse:search></span>
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
        <i><img src="Images/Facebook.jpg" alt="Facebook" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://twitter.com/crownequipment" target="_blank" tabindex="-1"><i><img src="Images/Twitter.png" alt="Twitter" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.flickr.com/photos/crownequipment" target="_blank" tabindex="-1"><i><img src="Images/Instagram.png" alt="Instagram" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.linkedin.com/company/crown-equipment-corporation" target="_blank" tabindex="-1"><i><img src="Images/LinkedIn.png" alt="LinkedIn" width="30" height="30"/></i>
    </a>
&nbsp;</li>
        <li>
    <a href="https://plus.google.com/103248524698165801838/posts" target="_blank" tabindex="-1">
        <i><img src="Images/Google.png" alt="Google" width="30" height="30"/></i>
    </a>
</li>
        <li>
    &nbsp;<a href="https://www.youtube.com/user/CrownEquipment" target="_blank" tabindex="-1"><i><img src="Images/YouTube.png" alt="YouTube" width="30" height="30"/></i>
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
</footer>
</form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jasny-bootstrap/3.1.3/js/jasny-bootstrap.min.js"></script>
    <script src="https://intl-tel-input.com/node_modules/intl-tel-input/build/js/intlTelInput.js?67"></script>
    <script src="https://intl-tel-input.com/js/demo.js?3"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.bundle.js"></script>
    <script src="Scripts/Dashboard.js"></script>
</body>
</html>