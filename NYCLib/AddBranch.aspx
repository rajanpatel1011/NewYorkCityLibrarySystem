<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddBranch.aspx.cs" Inherits="NYCLib.AddBranch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlform">
        <br /><br /><br /><br />

        <table><tr>
            
            <td>
                Branch Name :
            </td>
        <td>
            <asp:TextBox runat="server" ID="txtBranchName"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="r1" ControlToValidate="txtBranchName" ErrorMessage="Enter Branch Name" ValidationGroup="Branch"></asp:RequiredFieldValidator>

            
        </td>    
        </tr>
            <tr>
                <td>
                    Location :
                </td>
                <td>
                <asp:TextBox runat="server" ID="txtBranchLocation" AutoCompleteType="BusinessCity"> </asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtBranchLocation" ErrorMessage="Enter Branch Location" ValidationGroup="Branch"></asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnAddBranch" OnClick="btnAddBranch_click" text="Add Branch" ValidationGroup="Branch"/>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlgrid">
        <br /><br /><br /><br /><br />
        <asp:GridView runat="server" ID="BranchGrid" >

        </asp:GridView>
        <asp:Button runat="server" ID="btnBranchPanel" OnClick="btnAddBranchPanel_click" Text="Add More Branch" />
    </asp:Panel>
</asp:Content>
