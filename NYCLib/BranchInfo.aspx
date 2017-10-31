<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BranchInfo.aspx.cs" Inherits="NYCLib.BranchInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlgrid">
        <br /><br /><br /><br />
        <table>
            <th>
                Branches 
            </th>
            <tr>

            </tr>
        </table>
        <asp:GridView runat="server" ID="BranchInfoGrid">

        </asp:GridView>
    </asp:Panel>


</asp:Content>
