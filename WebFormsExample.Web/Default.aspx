<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsExample.Web._Default" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
	<asp:Label ID="welcomeMessage" runat="server" />
	<asp:Panel ID="inputs" runat="server">
		<form>
			<label>Please enter your name:</label>
			<asp:TextBox ID="yourName" runat="server" />
			<asp:Button runat="server" ID="submit" OnClick="submit_Click" Text="Click" />
		</form>
	</asp:Panel>
</asp:Content>
