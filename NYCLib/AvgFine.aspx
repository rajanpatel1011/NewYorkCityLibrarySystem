<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AvgFine.aspx.cs" Inherits="NYCLib.AvgFine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel runat="server" ID="Avggrid">
        <center><br /><br /><br /><br />
        <asp:GridView runat="server" ID="FineGrid">

        </asp:GridView>
            </center>
    </asp:Panel>
        
</asp:Content>
