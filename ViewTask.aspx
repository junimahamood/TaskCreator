<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="ViewTask.aspx.cs" Inherits="TaskCreator.ViewTask" %>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


                
     <asp:GridView ID="GridView1" runat="server"  style="text-align: center" 
         Width="691px" onrowdeleting="GridView1_RowDeleting" 
         onrowediting="GridView1_RowEditing" onselectedindexchanged="GridView1_SelectedIndexChanged" 
         >
         <Columns>
             <asp:CommandField ShowEditButton="True" />
             <asp:CommandField ShowDeleteButton="True" />
         </Columns>
     </asp:GridView>
    

 
</asp:Content>
