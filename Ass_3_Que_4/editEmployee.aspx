<%@ Page Title="" Language="C#" MasterPageFile="~/mainpage.Master" AutoEventWireup="true" CodeBehind="editEmployee.aspx.cs" Inherits="WebApplication1.editEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Edit Employee</h1>
    <table>
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Emp No"></asp:label>
            </td>
            <td>
                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnfind" runat="server" Text="Find" OnClick="btnfind_Click" /></td>
        </tr> 
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Select Designation"></asp:label>
            </td>
            <td>
                <asp:DropDownList ID="dldesig" runat="server">

                </asp:DropDownList>&nbsp;<asp:Label ID="lbldesig" runat="server" Text=""></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Select Department"></asp:label>
            </td>
            <td>
                <asp:DropDownList ID="dldept" runat="server"></asp:DropDownList> &nbsp;<asp:Label ID="lbldept" runat="server" Text=""></asp:Label></td>
            <td></td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Salary"></asp:label>
            </td>
            <td>
                <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox></td>
            <td>
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td>
               
                <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
            
            </td>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></td>
        </tr>
        
    </table>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
       
    </asp:GridView>
</asp:Content>
