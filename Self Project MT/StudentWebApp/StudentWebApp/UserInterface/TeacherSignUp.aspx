<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherSignUp.aspx.cs" Inherits="StudentWebApp.UserInterface.TeacherSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 113px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>TEACHER SIGN UP</h1>
        <div>
                 <table>
            <tr>
                <td>
                    Teacher ID
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherIDSignUp" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    NAME
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherNameSignUp" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherEmailSignUp" TextMode="Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherPswSignUp" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                </tr>
               <tr>
                <td>Retype Password</td>
                <td>
                        <asp:TextBox ID="txtTeacherRetypePswSignUp" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        </div>
        <asp:Button ID="btnTeacherSaveSignUp" runat="server" Text="Save" OnClick="btnSaveSignUp_Click" />
        <asp:Button ID="btnTeacherUpdateSignUp" runat="server" Text="Update" OnClick="btnTeacherUpdateSignUp_Click" />
        <asp:Button ID="btnTeacherEditSignUp" runat="server" Text="Edit" OnClick="btnTeacherEditSignUp_Click" />
        <div>
            <a href="Teacher.aspx">Log In</a>
        </div>
        <asp:Label ID="TeacherlblResult" runat="server" Text="Result"></asp:Label>
    </form>
</body>
</html>
