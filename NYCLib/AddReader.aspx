<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddReader.aspx.cs" Inherits="NYCLib.AddReader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Panel runat="server" ID="pnlform" Visible="false">
        <br />
        <br />
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>Name : 
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReaderName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address : 
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReaderAdd"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Phone :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReaderPhone"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Date of Birth :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtReaderDOB"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;
                </td>
                >
                <td>
                    <asp:Button runat="server" ID="btnAddReader" OnClick="btnAddReader_click" Text="Add" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlgrid">
        <br />
        <br />
        <br />
        <br />
        <asp:GridView runat="server" ID="ReaderGrid">
        </asp:GridView>
        <asp:Button runat="server" ID="btnAdd" Text="Add Reader" OnClick="btnAddReaderPanel_click" />
    </asp:Panel>


</asp:Content>
