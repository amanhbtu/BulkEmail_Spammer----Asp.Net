<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BulkEmail_Spammer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="txtemailid" runat="server" placeholder="Email ID" type="email"/><br/>
            <input id="txtnofemails" runat="server" placeholder="Number of Emails" type="number"/><br/>
            <input id="txtsub" runat="server" placeholder="Subject"/><br/>
            <input id="txtmsg" runat="server" placeholder="Message" type="text"/><br/>
            <asp:Button ID="btnAction" runat="server" Text="Go" OnClick="btnAction_Click" />
        </div>
    </form>
</body>
</html>
