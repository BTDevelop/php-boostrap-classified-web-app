<%@ Page Title="Arama Sonuçları" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="panel panel-green">
    <div class="panel-heading">Arama Sonuçları
   </div></div>
  <asp:Repeater ID="rptAramaSonuclari" runat="server">
        <ItemTemplate>
            <div class="panel panel-green">
                <div class="panel-heading">
                  <i class="fa fa-clock-o fa-fw"></i><b>
                        <%#Eval("Baslik") %></b>
                    <div class="pull-right"><i class="fa fa-clock-o fa-fw"></i><%#Eval("Tarih") %></div>
                </div>
                <div class="panel-body">
                    <img src="images/ogm%20logo%20tr.png" class="img-circle" alt="Cinque Terre" width="100" height="100" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    
                    <%#Eval("MakaleOzet")%>
                </div>
                <div class="panel-footer">
                    <i class="fa fa-comments  fa-fw"></i><%#Eval("YorumSayisi") %>
                    Yorum <i class="fa fa-upload fa-fw"></i>Yayınlayan
                    <asp:HyperLink ID="HyperLink2" runat="server">Burak Tahtacıoğlu</asp:HyperLink>
                   <i class="fa fa-share-alt fa-fw"></i> 
                    <div class="pull-right"> 
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("urlSeoCreater","~/Views.aspx?MakaleId={0}")%>'><i class="fa fa-ellipsis-h  fa-2x"></i></asp:HyperLink>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

