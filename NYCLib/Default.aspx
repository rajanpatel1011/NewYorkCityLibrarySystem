<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NYCLib._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br />
    <center>
        <table>
            <tr>
                <td>
                    User Name:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="r1" ControlToValidate="txtUserName" ErrorMessage="Enter UserName" ValidationGroup="login"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtPassword" ErrorMessage="Enter Password" ValidationGroup="login"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" ValidationGroup="login" />
                </td>
            </tr>
        </table>
    </center>
</asp:Content>
