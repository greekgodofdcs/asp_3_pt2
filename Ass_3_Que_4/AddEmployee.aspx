<%@ Page Title="" Language="C#" MasterPageFile="~/mainpage.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="WebApplication1.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 178px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Employee</h1>
    <table>
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Name"></asp:label>
            </td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Date Of Birth"></asp:label>
            </td>
            <td>
                
                <br />
                <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
            </td>
             <td></td>
        </tr>
        
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Select Designation"></asp:label>
            </td>
            <td>
                <asp:DropDownList ID="dldesig" runat="server">

                </asp:DropDownList></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:label runat="server" text="Select Department"></asp:label>
            </td>
            <td>
                <asp:DropDownList ID="dldept" runat="server"></asp:DropDownList></td>
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
                <td class="auto-style1"><asp:Label ID="lbluploadcv" runat="server" Text="Upload Resume:"></asp:Label></td>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
            <td><asp:RegularExpressionValidator   
id="FileUpLoadValidator" runat="server"   
ErrorMessage="Upload pdf only."   
ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))(.pdf)$"   
ControlToValidate="FileUpload1">  
</asp:RegularExpressionValidator>
                <br /><asp:Label ID="lblfile" runat="server" Visible="False"></asp:Label></td>
            </tr>
            
        <tr>
            <td class="auto-style1"></td>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />

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
