<%@ Page Title="" Language="C#" MasterPageFile="~/Management/MainMaster.master" AutoEventWireup="true"
    CodeFile="Details.aspx.cs" Inherits="Management_Kullanici_Details" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </div>
                </div>
            </div>
        </div>
        <a href="#">
            <div class="panel-footer">
                <span class="pull-left"><b>Password:</b> 
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span> <span class="pull-right"><i class="fa fa-asterisk">
                </i></span>
                <hr />
                <span class="pull-left"><b>Active Date:</b>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></span> <span class="pull-right"><i class="fa fa-clock-o">
                </i></span><hr />
                <span class="pull-left"><b>Active IP:</b> 
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></span> <span class="pull-right"><i class="fa fa-tag">
                </i></span><hr />
                <span class="pull-left"><b>Active Explorer:</b> 
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></span> <span class="pull-right"><i class="fa fa-globe">
                </i></span>
                <div class="clearfix">
                </div>
            </div>
        </a>
    </div>
</asp:Content>
