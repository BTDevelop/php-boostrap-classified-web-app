<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="panel panel-green">
                <div class="panel-heading">
                  <i class="fa fa-leaf fa-fw"></i><b>
                        <%#Eval("Baslik") %></b>
                    <div class="pull-right"><i class="fa fa-clock-o fa-fw"></i><%#Eval("Tarih") %></div>
                </div>
                <div class="panel-body">
                    <img src="images/ogm%20logo%20tr.png" class="img-circle" alt="Cinque Terre" width="100" height="100" />
               
                    <%#Eval("MakaleOzet")%>
                </div>
                <div class="panel-footer">
                    <i class="fa fa-comments  fa-fw"></i><%--<%#Eval("YorumSayisi") %>--%>
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
    <h1 class="page-header"></h1>
    <ul class="pager">
        <li runat="server" id="previous">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btGeri_Click">Previous</asp:LinkButton>
        </li>
        <li runat="server" id="next">
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="btIleri_Click">Next</asp:LinkButton></li>
    </ul>
</asp:Content>

