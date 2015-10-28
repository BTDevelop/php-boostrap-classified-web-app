<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <script src='https://www.google.com/recaptcha/api.js'></script>

    <title>OGM | Kayıt Ol</title>

    <!-- Bootstrap Core CSS -->
    <link href="bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"
        type="text/css" />
    <!-- MetisMenu CSS -->
    <link href="bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom CSS -->
    <link href="dist/css/sb-admin-2.css" rel="stylesheet" type="text/css" />
    <!-- Custom Fonts -->
    <link href="bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet"
        type="text/css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <body>

            <div class="container">
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <div class="login-panel panel panel-red">
                            <div class="panel-heading">
                                <h3 class="panel-title">Lütfen Kayıt Ol</h3>
                            </div>
                            <div class="panel-body">
                                <div role="form">
                                    <div>
                                        <div class="form-group">
                                            <input class="form-control" placeholder="İsim" name="name" type="text" autofocus runat="server" id="name"/>
                                        </div>
                                        <div class="form-group">
                                            <input class="form-control" placeholder="Soyisim" name="surname" type="text" autofocus runat="server" id="surname"/>
                                        </div>
                                        <div class="form-group">
                                            <input class="form-control" placeholder="E-mail" type="text" autofocus runat="server" id="mail" required/>
                                        </div>

                                        <div class="form-group">
                                            <input type="password" placeholder="Şifre" class="form-control" name="password" id="password" runat="server" required />
                                        </div>
                                        <div class="form-group">
                                            <input type="password" placeholder="Şifre Tekrarı" class="form-control" name="confirmPassword" id="confirmpassword" runat="server" required />
                                        </div>

                                        <div class="form-group">
                                            <div class="g-recaptcha" data-sitekey="6LdT2gsTAAAAAF8aNdUMIDKQFDa-DoEpJLvSalw9" runat="server" id="recaptcha"></div>
                                        </div>


                                        <!-- Change this to a button or input when using this as a form -->
                                        <button class="btn btn-lg btn-success btn-block" runat="server" onserverclick="Register_Click">Kayıt Ol</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- jQuery -->
       
            <script src="bower_components/jquery/dist/jquery.min.js" type="text/javascript"></script>

            <!-- Bootstrap Core JavaScript -->
            <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

            <!-- Metis Menu Plugin JavaScript -->
            <script src="../bower_components/metisMenu/dist/metisMenu.min.js"></script>

            <!-- Custom Theme JavaScript -->
            <script src="../dist/js/sb-admin-2.js"></script>
            <script>
                $('form').on('submit', function () {

                    if ($('#password').val() != $('#confirmpassword').val()) {
                        alert('Password not matches');
                        return false;
                    }
                    return true;

                });

            </script>
        </body>
    </form>
</body>
</html>
