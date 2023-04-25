<%@ Page Title="User Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="TestApp2.UserPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <main aria-labelledby="title">
        
        <h2 id="title"><%: Title %>.</h2>
        
        <h3>Clicking the button will generate a report and start downloading the file.</h3>

        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>

        <div><asp:Button ID="ButtonExcelDownload" runat="server" Text="Create report" OnClick="ButtonExcelDownload_Click" /></div>
        
        <div><asp:Label ID="LabelClick" runat="server" ></asp:Label></div>
        
    </main>

</asp:Content>