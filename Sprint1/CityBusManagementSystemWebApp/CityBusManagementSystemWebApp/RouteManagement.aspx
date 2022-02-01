<%@ Page Title="" Language="C#" MasterPageFile="~/CityBus.Master" AutoEventWireup="true" CodeBehind="RouteManagement.aspx.cs" Inherits="CityBusManagementSystemWebApp.RouteManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
    <img src="RouteBus.jpg" alt="LA" style="width:70%">
            </div>
    <div style="background-color:antiquewhite">
   <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Route No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRouteNo" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="No of Stops"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNoOfStops" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Fare Stages"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFareStages" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Begining Stoppage"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBegStop" runat="server"></asp:TextBox>
            </td>
              <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Ending Stoppage"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEndStop" runat="server"></asp:TextBox>
            </td>
        </tr>
              <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Start Time"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtStartTime" runat="server"></asp:TextBox>
            </td>
        </tr>
              <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="End Time"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEndTime" runat="server"></asp:TextBox>
            </td>
        </tr>  
    </table>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /> 
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /> 
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" /> 
        <asp:Button ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" /> 
    </div>
    <div>
        <asp:Label ID="lblResult" runat="server" Text="Result:"></asp:Label>
        <asp:GridView ID="gvResult" runat="server"></asp:GridView>
    </div>
  </asp:Content>
