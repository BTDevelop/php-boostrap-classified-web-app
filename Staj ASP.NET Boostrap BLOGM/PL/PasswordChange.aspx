<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="PasswordChange.aspx.cs" Inherits="PasswordChange" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-green">
        <div class="panel-heading">
            <div class="row">
                <div class="col-xs-3">
                    <i class="fa fa-asterisk fa-5x"></i>
                </div>
                <div class="col-xs-9 text-right">
                    <div class="huge">
                        Şifre Güncelle
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
                            <label class="col-md-3 control-label" for="password">
                                Eski Şifre</label>
                            <div class="col-md-8">
                                <input id="password" name="password" type="text" class="form-control" runat="server" />
                            </div>
                        </div>
                        <!-- Email input-->
                        <div class="form-group">
                            <label class="col-md-3 control-label" for="newpassword">
                                Yeni Şifre</label>
                            <div class="col-md-8">
                                <input id="newpassword" name="newpassword" type="text" class="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <ul class="pager">
                               
                                <li runat="server" id="search_table_button">
                                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OK_Click"><i class="fa fa-check fa-fw"></i>Onayla</asp:LinkButton>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-red">
                <div class="panel-heading">
                   Şifre güncelleme işleminde sonra E-Mailinize mesaj gönderilecektir.
                </div>
              
            </div>
            <div class="clearfix">
            </div>
        </div>
    </div>
</asp:Content>
