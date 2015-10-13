<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>SB Admin 2 - Bootstrap Admin Theme</title>
    <link href="bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <!-- Bootstrap Core CSS -->
    <link href="bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" type="text/css" />
    <!-- MetisMenu CSS -->
    <link href="dist/css/sb-admin-2.css" rel="stylesheet" type="text/css" />
    <!-- Custom Fonts -->
    <link href="bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet"
        type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-red">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            Calculator</h3>
                    </div>
                    <div class="panel-body">
                        <div role="form">
                            <div>
                                <div class="form-group">
                                    <input class="form-control" name="ust" type="text" autofocus runat="server" id="ust" />
                                </div>
                                <div class="form-group">
                                    <input class="form-control" name="alt" type="text" value="0" runat="server" id="alt" />
                                </div>
                                <ul class="pager ">
                                    <li runat="server" id="previous">
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btn1_Click">0</asp:LinkButton>
                                    </li>
                                    <li runat="server" id="next">
                                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="btn1_Click">1</asp:LinkButton></li>
                                    <li runat="server" id="Li1">
                                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="btn1_Click">2</asp:LinkButton></li>
                                    <li runat="server" id="Li2">
                                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="btn1_Click">3</asp:LinkButton></li>
                                    <li runat="server" id="Li3">
                                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="btn1_Click">4</asp:LinkButton></li>
                                    <li runat="server" id="Li4">
                                        <asp:LinkButton ID="LinkButton11" runat="server" OnClick="bntHepsi_Click">+</asp:LinkButton></li>
                                    <li runat="server" id="Li10">
                                        <asp:LinkButton ID="LinkButton12" runat="server" OnClick="bntHepsi_Click">-</asp:LinkButton></li>
                                </ul>
                                <ul class="pager ">
                                    <li runat="server" id="Li5">
                                        <asp:LinkButton ID="LinkButton6" runat="server" OnClick="btn1_Click">5</asp:LinkButton>
                                    </li>
                                    <li runat="server" id="Li6">
                                        <asp:LinkButton ID="LinkButton7" runat="server" OnClick="btn1_Click">6</asp:LinkButton></li>
                                    <li runat="server" id="Li7">
                                        <asp:LinkButton ID="LinkButton8" runat="server" OnClick="btn1_Click">7</asp:LinkButton></li>
                                    <li runat="server" id="Li8">
                                        <asp:LinkButton ID="LinkButton9" runat="server" OnClick="btn1_Click">8</asp:LinkButton></li>
                                    <li runat="server" id="Li9">
                                        <asp:LinkButton ID="LinkButton10" runat="server" OnClick="btn1_Click">9</asp:LinkButton></li>
                                    <li runat="server" id="Li11">
                                        <asp:LinkButton ID="LinkButton13" runat="server" OnClick="bntHepsi_Click">*</asp:LinkButton></li>
                                    <li runat="server" id="Li12">
                                        <asp:LinkButton ID="LinkButton14" runat="server" OnClick="bntHepsi_Click">/</asp:LinkButton></li>
                                </ul>
                                <ul class="pager ">
                                    <li runat="server" id="Li13">
                                        <asp:LinkButton ID="LinkButton15" runat="server" OnClick="btnSil_Click">CE</asp:LinkButton>
                                    </li>
                                    <li runat="server" id="Li14">
                                        <asp:LinkButton ID="LinkButton16" runat="server" OnClick="btnVirgul_Click">,</asp:LinkButton></li>
                                    <li runat="server" id="Li15">
                                        <asp:LinkButton ID="LinkButton17" runat="server" OnClick="btnGeri_Click"><i class="fa fa-angle-double-left fa-fw"></i></asp:LinkButton></li>
                                    <li runat="server" id="Li16">
                                        <asp:LinkButton ID="LinkButton18" runat="server" OnClick="bntHepsi_Click"><</asp:LinkButton></li>
                                </ul>
                                <!-- Change this to a button or input when using this as a form -->
                                <ul class="pager pagination-lg ">
                                    <li runat="server" id="Li17">
                                        <asp:LinkButton ID="LinkButton19" runat="server" OnClick="btnEsittir_Click">=</asp:LinkButton>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- jQuery -->
    <script src="bower_components/jquery/dist/jquery.min.js" type="text/javascript"></script>
    <script src="bower_components/bootstrap/dist/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="bower_components/metisMenu/dist/metisMenu.min.js" type="text/javascript"></script>
    <script src="dist/js/sb-admin-2.js" type="text/javascript"></script>
    </form>
</body>
</html>
