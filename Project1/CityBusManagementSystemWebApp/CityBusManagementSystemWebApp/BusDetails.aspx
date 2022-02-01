<%@ Page Title="" Language="C#" MasterPageFile="~/CityBus.Master" AutoEventWireup="true" CodeBehind="BusDetails.aspx.cs" Inherits="CityBusManagementSystemWebApp.BusDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Bus Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBusName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Bus No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBusNo" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="RouteNo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRouteNo" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="DestinationArrivalTime"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDestinationArrivalTime" runat="server"></asp:TextBox>
            </td>
              <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="DestinationDepartureTime"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDestinationDepartureTime" runat="server"></asp:TextBox>
            </td>
        </tr>  
    </table>
  
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 29px" Text="Delete" />
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
    <asp:Button ID="btnExit" runat="server" OnClick="btnExit_Click" Text="Exit" style="height: 29px" />
        </div>
    <div>
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
        <asp:GridView ID="gvResult" runat="server"></asp:GridView>
    </div>
</asp:Content>
