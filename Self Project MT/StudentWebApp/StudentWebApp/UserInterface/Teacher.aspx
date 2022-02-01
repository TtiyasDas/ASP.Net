<%@ Page Title="" Language="C#" MasterPageFile="~/UserInterface/MasterPage.Master" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="StudentWebApp.UserInterface.Teacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        TEACHER LOG IN
    </h1>
    <div>
        <table>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherEmailLogIn" TextMode="Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtTeacherPswLogIn" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="btnTeacherLogIn" runat="server" Text="Log In" OnClick="btnTeacherLogIn_Click"/>
    <asp:Button ID="btnTeacherReset" runat="server" Text="Reset" />
    <div>
        <asp:Label ID="lblTeacherResult" runat="server" Text="Result"></asp:Label>
        <a href="TeacherSignUp.aspx">Create a new account</a>
    </div>
</asp:Content>
