<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewTask.aspx.cs" Inherits="TaskCreator.NewTask" %>

 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  

 

    
    <style type="text/css">
        .style1
        {
            width: 60%;
            margin-left: 122px;
        }
        .style2
        {
            width: 168px;
        }
    </style>


    
       
        <table align="center" class="style1" cellpadding="2" cellspacing="2">
            <tr>
                <td colspan="1" style="text-align: left" class="style2">
                    Task</td>
                <td>
                    <asp:TextBox ID="txttaskname" runat="server" Width="375px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="style2">
                    Task Description</td>
                <td>
                    <asp:TextBox ID="txtTTaskDesc" runat="server" Height="79px" Width="368px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td style="text-align: left" class="style2">
                    Date</td>
                <td>
                    &nbsp;<asp:Calendar ID="dtDate" runat="server" BackColor="White" 
                        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                        Width="200px">
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    </asp:Calendar>
                </td>
                
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Back To Home" />
                    <asp:TextBox ID="txttaskdate" runat="server" Width="154px" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="txttaskid" runat="server" Width="208px" Visible="False"></asp:TextBox>
                </td>
                
            </tr>
        </table>
    
  
 
</asp:Content>
