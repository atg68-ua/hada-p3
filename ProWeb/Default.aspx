<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="formulario" runat="server">
    <asp:Label ID="CodeLabel" runat="server">Code</asp:Label>
    <asp:TextBox ID="CodeTextBox" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="NameLabel" runat="server">Name</asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="AmountLabel" runat="server">Amount</asp:Label>
    <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="CategoryLabel" runat="server">Category</asp:Label>
    <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>
    <br><br>
    <asp:Label ID="PriceLabel" runat="server">Price</asp:Label>
    <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="DateLabel" runat="server">Date Creation</asp:Label>
    <asp:TextBox  ID="DateTextBox" runat="server"></asp:TextBox>
    <br>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="botones" runat="server">
    <asp:Button ID="CreateButton" text="Create" runat="server" OnClick="CreateButton_Click"/>
    <asp:Button ID="UpdateButton" text="Update" runat="server" OnClick="UpdateButton_Click"/>
    <asp:Button ID="DeleteButton" text="Delete" runat="server" OnClick="DeleteButton_Click"/>
    <asp:Button ID="ReadButton" text="Read" runat="server" OnClick="ReadButton_Click"/>
    <asp:Button ID="ReadFirstButton" text="Read First" runat="server" OnClick="ReadFirstButton_Click"/>
    <asp:Button ID="ReadPrevButton" text="Read Prev" runat="server" OnClick="ReadPrevButton_Click"/>
    <asp:Button ID="ReadNextButton" text="Read Next" runat="server" OnClick="ReadNextButton_Click"/>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Output" runat="server">
    <asp:Label ID="OutputLabel" runat="server"></asp:Label>
    <br>
    <asp:Label ID="MsgLabel" runat="server"></asp:Label>
</asp:Content>
