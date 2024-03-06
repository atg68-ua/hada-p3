<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProWeb.WebForm1" %>
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
    <asp:TextBox ID="CategoryTextBox" runat="server">Computing</asp:TextBox>
    <br><br>
    <asp:Label ID="PriceLabel" runat="server">Price</asp:Label>
    <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
    <br><br>
    <asp:Label ID="DateLabel" runat="server">Date Creation</asp:Label>
    <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
    <br>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="botones" runat="server">
    <asp:Button ID="CreateButton" text="Create" runat="server"/>
    <asp:Button ID="UpdateButton" text="Update" runat="server"/>
    <asp:Button ID="DeleteButton" text="Delete" runat="server"/>
    <asp:Button ID="ReadButton" text="Read" runat="server"/>
    <asp:Button ID="ReadFirstButton" text="Read First" runat="server"/>
    <asp:Button ID="ReadPrevButton" text="Read Prev" runat="server"/>
    <asp:Button ID="ReadNextButton" text="Read Next" runat="server"/>
</asp:Content>