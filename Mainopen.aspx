<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Mainopen.aspx.cs" Inherits="TaskCreator.Mainopen" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:Label ID="Label1" runat="server" Font-Names="Modern" Font-Size="24pt" ForeColor="Red"
        
        Style="z-index: 102; left: 502px; position: absolute; top: 248px; width: 322px;" 
        Text="Task Manager..........."></asp:Label>
    <asp:Menu ID="Menu1" runat="server" Font-Names="Modern" Font-Size="12pt" ForeColor="Red"
        Style="z-index: 104; left: 92px; position: absolute; top: 329px" Height="174px">
        <Items>
             <asp:MenuItem Text="&gt;   Add Task" Value="&gt;   Add Task" NavigateUrl="~/NewTask.aspx"></asp:MenuItem>
            <asp:MenuItem Text="&gt;   View Task" Value="&gt;   View Task" NavigateUrl="~/ViewTask.aspx"></asp:MenuItem>
        
            
        </Items>
    </asp:Menu>
</asp:Content>
