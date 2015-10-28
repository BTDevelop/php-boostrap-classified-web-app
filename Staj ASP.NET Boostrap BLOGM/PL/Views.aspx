<%@ Page Title="Views" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Views.aspx.cs" Inherits="Views" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="dist/css/comment_area.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-red">
        <div class="panel-heading">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <div class="pull-right">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </div>
        </div>
        <div class="panel-body" id="textArticle" runat="server">
            <img src="images/logo-small.jpg" class="img-circle" alt="Cinque Terre" width="250" height="250" />
        </div>
        <div class="panel-footer">
            <%-- <i class="fa fa-comments  fa-fw"></i>
            <%#Eval("YorumSayisi") %> Comments --%><i class="fa fa-upload fa-fw"></i>Yayınlayan
            <asp:HyperLink ID="HyperLink2" runat="server">Burak Tahtacıoğlu</asp:HyperLink>
        </div>
    </div>
    <div class="container">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="container" id="comments-logout">
                    <ul class="media-list">
                        <li class="media">
                            <a class="pull-left" href="#">
                                <img src="images/logo-small.jpg" class="media-object img-circle" />
                            </a>
                            <div class="media-body">
                                <div class="well well-lg">
                                    <h4 class="media-heading text-uppercase reviews" runat="server" id="userName"><%#Eval("YorumYapan") %> </h4>
                              
                                    <p class="media-comment">
                                        <%#Eval("YorumText") %>
                                    </p>
                                    <ul class="pager">
                                        <li runat="server" id="Li1">
                                            <asp:LinkButton ID="LinkButton1" runat="server"><i class="fa fa-thumbs-o-up fa-fw"></i>Like</asp:LinkButton>
                                        </li>
                                        <li runat="server" id="Li2">
                                            <asp:LinkButton ID="LinkButton4" runat="server"><i class="fa fa-times fa-fw"></i>Reload</asp:LinkButton>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <div class="col-lg-">
            <ul class="pager">
                <li runat="server" id="previous">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btGeri_Click">Geri</asp:LinkButton>
                </li>
                <li runat="server" id="next">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="btIleri_Click">İleri</asp:LinkButton></li>
            </ul>
        </div>
        <div class="container col-lg-7">
            <div class="alert alert-warning" runat="server" id="alertSign">
                Yorum mu yapmak mı istiyorsunuz? <a href="User_Login/User_Login.aspx" class="alert-link">Giriş Yap</a> veya <a href="Register.aspx" class="alert-link">Kayıt Ol Me</a>
            </div>
            <div action="#" method="post" class="form-horizontal" id="commentForm" role="form" runat="server">
                <div class="form-group">
                    <label for="email" class="col-sm-2 control-label">Yorumun</label>
                    <div class="col-sm-10">
                        <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <ul class="pager">
                            <li runat="server" id="commentadd" class="pull-left">
                                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="AddComment_Click"><i class="fa fa-check fa-fw"></i> Ekle</asp:LinkButton>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

