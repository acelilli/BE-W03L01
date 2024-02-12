<%@ Page Title="Esercizio 1" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Esercizio1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Button ID="btnShowMe" runat="server" Text="Mostra Candidato" OnClick="Button1_Click"/>
        <p id="test" runat="server"></p>
    </main>

</asp:Content>
