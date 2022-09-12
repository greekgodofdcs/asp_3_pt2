<%@ Page Title="" Language="C#" MasterPageFile="~/mainpage.Master" AutoEventWireup="true" CodeBehind="find-with-year.aspx.cs" Inherits="WebApplication1.find_with_year" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Find With Birth year</h1>
    <table>
        <tr>
            <td>
                <asp:label runat="server" text="Year"></asp:label>
            </td>
            <td>
                <asp:TextBox ID="txtyear" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Year" Text="*" ControlToValidate="txtyear"></asp:RequiredFieldValidator></td>
            <td>
                <asp:Button ID="btnfind" runat="server" Text="Find" CausesValidation="False" OnClick="btnfind_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
