<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="NYCLib.SearchBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel runat="server" ID="pnlform" >
         <br />
         <br />
         <br />

    <table>
        <tr>
            <td>
                Serach Book : by Name
            </td>
            <td>
                by author
            </td>
        
        </tr>
        <tr>
            <td>
               <asp:TextBox runat="server" ID="txtSerachByName">

               </asp:TextBox>
            </td>
            <td>
               <asp:TextBox runat="server" ID="txtSerachByAuthor">

               </asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>
               
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnSerachbook" Text="Search" OnClick="btnserachbook_click"/>

            </td>
        </tr>
    </table>
        </asp:Panel>
    <asp:Panel runat="server" ID="pnlgrid" Visible="false">
        <br /><br /><br /><br />

        <asp:GridView runat="server" ID="SearchGrid">

        </asp:GridView>
    </asp:Panel>
</asp:Content>
