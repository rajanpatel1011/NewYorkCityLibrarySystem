<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddPublisher.aspx.cs" Inherits="NYCLib.AddPublisher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  

    <asp:Panel runat="server" ID="pnlform"  Visible="false">
        <br />
        <br />
        <br />
        <br />

        <table>
            <tr>
                <td>
                    Publisher Name :
                     
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPublisherName">

                    </asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="r1" ControlToValidate="txtPublisherName" ErrorMessage="Enter Publisher Name" ValidationGroup="Publisher"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Publisher Location :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPublisherLocation">
                    
                    </asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtPublisherLocation" ErrorMessage="Enter Publisher Location" ValidationGroup="Publisher"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Publish Date :
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPublisherDate">
                        

                    </asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="txtPublisherDate" ErrorMessage="Enter Publish Date" ValidationGroup="Publisher"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnAddPublisher" OnClick="btnAddPublisher_click" text="Add" ValidationGroup="Publisher"/>
                </td>
            </tr>
        </table>
    </asp:Panel>
      <asp:panel runat="server" ID="pnlgrid">
          <br />
          <br />
          <br />
          <br />

        <asp:GridView runat="server" ID="PublisherGrid" >
            
        </asp:GridView> 
          <asp:Button runat="server" ID="btnAddPublisherpanel" OnClick="btnAddPublisherPanel_click" text="Add New Publisher"/>
    </asp:panel>
</asp:Content>
