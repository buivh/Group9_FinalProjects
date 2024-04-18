<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Group9_FinalProjects.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="LeetCodeEasy" runat="server" Text="Leet Code Problem Easy" OnClick="cmdLeetCodeEasy_Click" />
            <asp:Button ID="LeetCodeMedium" runat="server" Text="Leet Code Problem Medium" OnClick="cmdLeetCodeMedium_Click" />
            <asp:Button ID="LeetCodeHard" runat="server" Text="Leet Code Problem Hard" OnClick="cmdLeetCodeHard_Click" />
        </div>
    </form>
</body>
</html>
