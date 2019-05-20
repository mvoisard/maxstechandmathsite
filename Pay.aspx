<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="WebApplication6.Pay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Subscribe</title>
    <link href="data:image/x-icon;base64,AAABAAEAEBAQAAEABAAoAQAAFgAAACgAAAAQAAAAIAAAAAEABAAAAAAAgAAAAAAAAAAAAAAAEAAAAAAAAAAAAAAAAJA1AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEAABAAAAAAEQEQEAAAAAAAEREBAAAAAAAAAAEAAAAAEREREQAAAAEREREREAAAAQAAAAAQAAABAAAAABAAAAEAAAAAEAAAEQAAAAARAAAQAAAAAAEAABEREREREQAAAAAAAAABAAAAAAAAAAERAAAAAAAAABH73wAA8Y8AAPAPAADwDwAA/+8AAPAPAADgBwAA7/cAAO/3AADv9wAAz/MAAN/7AADAAwAA//sAAP/4AAD//AAA" rel="icon" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
                Your account has been created!<br />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#990099" Text="Start your one-year subscription with a "></asp:Label>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#00CC00" Text="1-week free trial period"></asp:Label>
                &nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#990099" Text="and then pay for the low price of just "></asp:Label>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#00CC00" Text="$1.99 / month!"></asp:Label>
        </div>
    </form>
        <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
            <input type="hidden" name="cmd" value="_s-xclick"/>
            <input type="hidden" name="hosted_button_id" value="674R2RS24WSB4"/>
            <input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_subscribeCC_LG.gif" name="submit" alt="PayPal - The safer, easier way to pay online!"/>
            <img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1"/>
        </form>
</body>
</html>