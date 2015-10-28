<%@ Page Title="Article" Language="C#" MasterPageFile="~/Management/MainMaster.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Management_Makale_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../../bower_components/jquery/dist/jquery.min.js" type="text/javascript"></script>
    <script src="../../bower_components/bootstrap/dist/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="../../bower_components/metisMenu/dist/metisMenu.min.js" type="text/javascript"></script>
    <script src="../../dist/js/sb-admin-2.js" type="text/javascript"></script>
    <link href="../../bower_components/datatables-plugins/integration/bootstrap/3/dataTables.bootstrap.css"
        rel="stylesheet" type="text/css" />
    <link href="../../bower_components/datatables-responsive/css/dataTables.responsive.css"
        rel="stylesheet" type="text/css" />
    <script src="../../bower_components/datatables-responsive/js/dataTables.responsive.js"
        type="text/javascript"></script>
    <script src="../../bower_components/datatables-plugins/integration/bootstrap/3/dataTables.bootstrap.js"
        type="text/javascript"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/jquery-footable/0.1.0/css/footable.min.css"
        rel="stylesheet" type="text/css" />
    <script src="../../js/Chart.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>

