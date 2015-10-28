<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="UserSetting.aspx.cs" Inherits="UserSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-green">
        <div class="panel-heading">
            <div class="row">
                <div class="col-xs-3">
                    <i class="fa fa-user fa-5x"></i>
                </div>
                <div class="col-xs-9 text-right">
                    <div class="huge">
                        Senin Bilgilerin
                    </div>
                    <div>
                    </div>
                </div>
            </div>
        </div>
        <div class="panel-footer">
            <div class="panel panel-red">
                <div class="panel-heading">
                    Aşağıdaki Bilgilerini Düzenle</div>
                <div class="form-horizontal" action="" method="post">
                    <div>
                        <br />
                        <!-- Name input-->
                        <div class="form-group">
                            <label class="col-md-3 control-label" for="name">
                                İsim</label>
                            <div class="col-md-8">
                                <input id="name" name="name" type="text" class="form-control" runat="server" />
                            </div>
                        </div>
                        <!-- Email input-->
                        <div class="form-group">
                            <label class="col-md-3 control-label" for="surname">
                                Soyisim</label>
                            <div class="col-md-8">
                                <input id="surname" name="surname" type="text" class="form-control" runat="server" />
                            </div>
                        </div>
                        <!-- Message body -->
                        <!-- Form actions -->
                        <div class="form-group">
                            <ul class="pager">
                                <li runat="server" id="Li1">
                                    <asp:LinkButton ID="LinkButton1" runat="server"><i class="fa fa-times fa-fw"></i>Geri</asp:LinkButton>
                                </li>
                                <li runat="server" id="search_table_button">
                                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OK_Click"><i class="fa fa-check fa-fw">
                                    </i>Onayla</asp:LinkButton>
                                </li>
                            </ul>
                        </div>
                        <div class="form-group">
                            <ul class="pager">
                                <li>
                                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="Aktif_Click"><i class="fa fa-check fa-fw">
                                    </i>Hesabımı Aktifleştir</asp:LinkButton>
                                </li>
                                <li>
                                    <asp:LinkButton ID="LinkButton8" runat="server" OnClick="Dondur_Click"><i class="fa fa-check fa-fw">
                                    </i>Hesabımı Dondur</asp:LinkButton>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-red">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-asterisk fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">
                                Şifreni Güncelle</div>
                            <div>
                            </div>
                        </div>
                    </div>
                </div>
                <a href="PasswordChange.aspx">
                    <div class="panel-footer">
                        <span class="pull-left">Git</span> <span class="pull-right"><i class="fa fa-arrow-circle-right">
                        </i></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
            <div class="clearfix">
            </div>
        </div>
    </div>
</asp:Content>
