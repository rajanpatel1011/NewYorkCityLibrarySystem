<%@ Page Title="" Language="C#" MasterPageFile="~/ReaderMaster.Master" AutoEventWireup="true" CodeBehind="BookCheckout.aspx.cs" Inherits="NYCLib.BookCheckout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Book Details 
    <asp:Panel runat="server" ID="pnlgrid">
        <asp:GridView runat="server" ID="bookcheckoutgrid" >

        </asp:GridView>  

    </asp:Panel>
    <asp:Panel runat="server" ID="pnlform">
        <asp:Button runat="server" ID="btnCheckOut" OnClick="btnCheckOut_click" Text="check" />
    </asp:Panel>
</asp:Content>
