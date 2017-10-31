<%@ Page Title="" Language="C#" MasterPageFile="~/ReaderMaster.Master" AutoEventWireup="true" CodeBehind="BookReturn.aspx.cs" Inherits="NYCLib.BookReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlgrid">

    <asp:GridView runat="server" ID="ReturnGrid" AutoGenerateColumns="false" OnRowCommand="gvBorrowId_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="BookID">
                <ItemTemplate>
                    <asp:Label runat="server" ID="BookID" text='<%# Eval("BookID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Book Title">
                <ItemTemplate>
                    <asp:Label runat="server" ID="BookTitle" text='<%# Eval("BookTitle") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Author">
                <ItemTemplate>
                    <asp:Label runat="server" ID="Author" text='<%# Eval("Author") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ISBN">
                <ItemTemplate>
                    <asp:Label runat="server" ID="ISBN" text='<%# Eval("ISBN") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Publisher Name">
                <ItemTemplate>
                    <asp:Label runat="server" ID="PublisherName" text='<%# Eval("PublisherName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Borrow Date">
                <ItemTemplate>
                    <asp:Label runat="server" ID="BorrowDate" text='<%# Eval("BDateTime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Return Date">
                <ItemTemplate>
                    <asp:Label runat="server" ID="ReturnDate" text='<%# Eval("RDateTime") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnReturnBook" text="Return" CommandName="returnBook" CommandArgument='<%# String.Format("{0} - {1}", Eval("BorrowID"), Eval("RDateTime")) %>'></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlform">
        <asp:Button runat="server" ID="btnReturnBook" OnClick="btnReturnBook_click" text =" return book"/>

    </asp:Panel>
</asp:Content>
