<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="FeqBorrow.aspx.cs" Inherits="NYCLib.FeqBorrow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center> 
       <asp:Panel runat="server" ID="PnltopborrowGrid">
    <br /><br /><br /><br />
           Top borrower
                <asp:GridView runat="server" ID="BorrowGrid">

        </asp:GridView>
    </asp:Panel>
    

    


        <asp:Panel runat="server" ID="pnltopbooksGrid">
        <br /><br /><br /><br />
            Top Books
            <asp:GridView runat="server" ID="bookGrid">

            </asp:GridView>
    </asp:Panel>
        </center>
</asp:Content>
