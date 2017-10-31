<%@ Page Title="" Language="C#" MasterPageFile="~/ReaderMaster.Master" AutoEventWireup="true" CodeBehind="BookReserve.aspx.cs" Inherits="NYCLib.BookReserve" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlgrid">
        <br /><br /><br /><br />
        <asp:GridView runat="server" ID="ReserveGrid">

        </asp:GridView>
    </asp:Panel>
</asp:Content>
