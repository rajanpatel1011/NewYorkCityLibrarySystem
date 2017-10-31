<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="NYCLib.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    &nbsp;
    <br />
    <br />
    <br />

    <asp:Panel runat="server" ID="pnlForm" Visible="false">
        <br />
        <br />
        <br />
        <table>
         
            <tr> 
                <td>
                    Book Title
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtBookTitle"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="r1" ControlToValidate="txtBookTitle" ErrorMessage="Enter BookName" ValidationGroup="addBook"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>
                    Author
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtAuthor"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtAuthor" ErrorMessage="Enter Author" ValidationGroup="addBook"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    ISBN
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtISBN"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="txtISBN" ErrorMessage="Enter ISBN" ValidationGroup="addBook"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Publisher
                </td>
                <td>
                    <asp:DropDownList ID="drpPublisher" runat="server">

                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Publication Date
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPublicationDate"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtPublicationDate" ErrorMessage="Enter UserName" ValidationGroup="addBook"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td> <br />
                    <asp:Button runat="server" Text="Add Book" ID="btnAddBook" OnClick="btnAddBook_Click" ValidationGroup="addBook" />
                </td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlGrid">
        <br />
            <asp:Button runat="server" ID="btnAddBookPanel" OnClick="btnAddBookPanel_Click" Text="Add New Book"/>
     
          <asp:GridView runat="server" ID="BookGrid">

        </asp:GridView>

    </asp:Panel>
</asp:Content>
