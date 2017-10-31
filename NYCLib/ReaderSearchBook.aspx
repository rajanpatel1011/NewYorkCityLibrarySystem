<%@ Page Title="" Language="C#" MasterPageFile="~/ReaderMaster.Master" AutoEventWireup="true" CodeBehind="ReaderSearchBook.aspx.cs" Inherits="NYCLib.ReaderSearchBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlform">
        <table>
            <tr>
                <td>Serach Book : by ID
                </td>
                <td>by Title
                </td>
                <td>by Publisher
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="txtSeachBookById">
                    </asp:TextBox>
                     </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSearchBookByTitle">
                        
                    </asp:TextBox>
                     </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSearchBookByPulisher">
                         
                    </asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnSerachbook" Text="Search" OnClick="btnserachbook_click" ValidationGroup="login"/>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlgrid" Visible="false" >
        <asp:GridView runat="server" ID="gvBooks" AutoGenerateColumns="false" OnRowCommand="gvBooks_RowCommand"> 
            <Columns>
                <asp:TemplateField HeaderText="BookID">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="bookID" Text='<%# Eval("BookID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Title">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="bookTitle" Text='<%# Eval("BookTitle") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Author" Text='<%# Eval("Author") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Publisher Name">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="pub" Text='<%# Eval("PublisherName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnCheckout" Text="Checkout" CommandName="checkout" CommandArgument='<%# Eval("BookID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </asp:Panel>
</asp:Content>
