<%@ Page Title="İletişim" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-green ">
    <div class="panel-heading">İletişim Formu
    </div>
        <div class="form-horizontal" action="" method="post">
            <div>
                <legend class="text-center"></legend>
                <!-- Name input-->
                <div class="form-group">
                    <label class="col-md-3 control-label" for="name">
                        İsim</label>
                    <div class="col-md-8">
                        <input name="name" type="text" class="form-control" runat="server" id="isimCon" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label" for="surname">
                        Soyad</label>
                    <div class="col-md-8">
                        <input name="surname" type="text" class="form-control" runat="server" id="soyCon" />
                    </div>
                </div>
                <!-- Email input-->
                <div class="form-group">
                    <label class="col-md-3 control-label" for="email">
                        E-mail</label>
                    <div class="col-md-8">
                        <input type="text" class="form-control" runat="server" id="emailCon" />
                    </div>
                </div>
                <!-- Message body -->
                <div class="form-group">
                    <label class="col-md-3 control-label" for="message">
                        Mesajınız</label>
                    <div class="col-md-8">
                        <textarea class="form-control" id="message" name="message" runat="server" placeholder="Buraya mesajınızı yazınız..."
                            rows="5"></textarea>
                    </div>
                </div>
                <!-- Form actions -->
                <div class="form-group">
                    <ul class="pager">
                        <li runat="server" id="Li1">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="geri_Click"><i class="fa fa-times fa-fw"></i>Cancel</asp:LinkButton>
                        </li>
                        <li runat="server" id="search_table_button">
                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="gonder_Click"><i class="fa fa-check fa-fw"></i>Send</asp:LinkButton>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="panel panel-green">
        <div class="panel-heading">
            Adres: Beştepe Mahallesi Söğütözü Caddesi No:8/1 06560 Yenimahalle ANKARA 
        </div>
    </div>
     <div class="panel panel-red">
        <div class="panel-heading">
              Telefon: 0312 296 40 00 
        </div>
    </div>
  
</asp:Content>
