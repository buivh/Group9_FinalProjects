<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Group9_FinalProjects.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>N-Queens Solver</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter the size of the board (n): <asp:TextBox ID="txtN" runat="server" Width="50"></asp:TextBox>
            <asp:Button ID="btnSolve" runat="server" Text="Solve N-Queens" OnClick="SolveButton_Click" />
            <hr />
            Number of solutions: <asp:Label ID="lblSolutions" runat="server" />
        </div>
    </form>
</body>
</html>
