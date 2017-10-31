<%@ Page Title="" Language="C#" MasterPageFile="~/ReaderMaster.Master" AutoEventWireup="true" CodeBehind="ReaderFine.aspx.cs" Inherits="NYCLib.ReaderFine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <asp:Panel runat="server" ID="pnlgrid">
        <br /><br /><br /><br/>
        <asp:GridView runat="server" ID="FineGrid">

        </asp:GridView>
        <br />
        <asp:GridView runat="server" ID="TotalFineGrid">

        </asp:GridView>
    </asp:Panel>
    </center>
    
</asp:Content>
