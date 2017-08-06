

<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="TaskCreator.MainPage" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  

  <table style="z-index: 101; left: 234px; position: absolute; top: 275px; color: #ffffff; font-family: 'Lucida Console';">
  
    <tr>
    <td style="height: 26px; font-family: 'Times New Roman', Times, serif;">&nbsp;</td>
    <td style="height: 26px">
    <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
    </td>
    <td style="height: 26px; width: 157px;">
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name"
            Style="position: relative" ControlToValidate="nametxt">*
            </asp:RequiredFieldValidator>
            </td></tr>
   
   
    <tr>
    <td>Password</td><td><asp:TextBox ID="pwdtxt" runat="server"></asp:TextBox></td><td style="width: 157px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="pwdtxt"
            ErrorMessage="Enter Password" Style="position: relative">*</asp:RequiredFieldValidator></td></tr>
    <tr><td>Confirm Password</td>
    <td><asp:TextBox ID="conpwdtxt" runat="server"></asp:TextBox></td><td style="width: 157px">
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwdtxt"
            ControlToValidate="conpwdtxt" ErrorMessage="Not Matching" Style="position: relative">*</asp:CompareValidator></td></tr>
    
    </table>
    <table style="z-index: 101; left: 299px; position: absolute; top: 400px; font-weight: bold; color: #ffffff; font-family: 'Lucida Console';">
    <tr><td style="width: 88px">
        <asp:Button ID="subbtn" runat="server" Text="Submit" Width="94px"  /></td>
        <td style="width: 93px">
        <asp:Button ID="Resbtn" runat="server" Text="Reset" Width="94px"  /></td>
     <td style="width: 93px">
        <asp:Button ID="canbtn" runat="server" Text="Cancel" Width="94px" /></td></tr>
    </table>

</asp:Content>
