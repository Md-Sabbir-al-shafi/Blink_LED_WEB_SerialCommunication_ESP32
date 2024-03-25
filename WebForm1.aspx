<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RoboButton2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
     <asp:Button ID="OFFButton" runat="server" Text="OFF" BackColor="Lime" Font-Bold="True" Width="51px" OnClick="OFFButton_Click" />
     <asp:Button ID="ONButton" runat="server" Text="ON" BackColor="#FF3300" Font-Bold="True" Width="51px" OnClick="ONButton_Click" />
 </div>
    </form>
</body>
</html>
