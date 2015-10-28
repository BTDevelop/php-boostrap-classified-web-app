<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">


    <title>Site Yönetim</title>

    <!-- Bootstrap core CSS -->
    <link href="./css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="./css/jumbotron.css" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="./js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <![endif]-->
</head>

<body>

<nav class="navbar navbar-inverse navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <div id="navbar" class="navbar-collapse collapse">
                <form class="navbar-form navbar-left">
                    <button type="submit" class="btn btn-default"><b>sattık.com</b> YÖNETİM PANELİ</button>
                </form>
            </div>
        </div>
        <div id="navbar" class="navbar-collapse collapse">

            <form class="navbar-form navbar-right">
                <div class="form-group">
                    <input type="text" placeholder="Kelime, ilan no ile ara" class="form-control">
                </div>
                <button type="submit" class="btn btn-primary"><span class="glyphicon glyphicon-search" aria-hidden="true"></span></button>
            </form>
        </div><!--/.navbar-collapse -->
    </div>
</nav>

<!-- Main jumbotron for a primary marketing message or call to action -->
<div class="well">
    <div class="container">
        <div class="row">
            <div class="col-lg-1"></div>
            <div class="list-group col-lg-3">

                <a href="#" class="list-group-item">Kategori ve Özellik İşlemleri</a>
                <a href="#" class="list-group-item">Admin İşlemleri</a>


            </div>

            <div class="container container-fluid col-lg-7">

                <ol class="breadcrumb breadcrumb col-lg-12 list-group-item-danger">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Library</a></li>
                    <li class="active">Data</li>
                </ol>

                <div class="panel panel-default panel col-lg-12">
                    <div class="row">
                        <div class="col-lg-12">
                            <form  action="" method="post">
                            <table class="table table text-muted">
                                <thead>
                                <tr>
                                    <th>Seçim Türü</th>
                                    <th>Seçim</th>
                                    <th>Uygula</th>

                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <td><span class="label label-danger" > Vasıta Türü </span ></td >
                                    <td ><input type = "text" class="form-control" name = "vasitaTuru" placeholder = "Otomobil" aria - describedby = "basic-addon1" ></td >
                                    <td ><input type = "submit" name = "ekleVasitaTuru" value = "Ekle" class="btn btn-primary btn-group-lg" ></td >

                                </tr>
                                </tbody>
                            </table>
                            </form>
                        </div>
                        <div class="col-lg-12">
                            <div class="bs-example">
                                <div class="panel-group" id="accordion">
                                    <div class="panel panel-danger">
                                        <div class="panel-heading">
                                            <h4 class="panel-title">
                                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Marka Ekleme</a>
                                            </h4>
                                        </div>
                                        <div id="collapseOne" class="panel-collapse collapse in">
                                            <div class="panel-body">
                                                <div class="col-lg-12">
                                                    <form  action="" method="post">
                                                        <table class="table table text-muted">
                                                            <thead>
                                                            <tr>
                                                                <th>Seçim Türü</th>
                                                                <th>Seçim</th>
                                                                <th>Uygula</th>

                                                            </tr>
                                                            </thead>
                                                            <tbody>
                                                            <tr>
                                                                <td><span class="label label-danger">Vasıta Türü</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel1">
                                                                        <?php
                                                                        databaseBağlanti(vasitalar);
                                                                        $sonuc=mysql_query("SELECT Tur FROM vasitaturleri");
                                                                        $i=1;
                                                                        while ($test=mysql_fetch_array($sonuc))
                                                                        {
                                                                            $Tur=$test["Tur"];
                                                                            echo "<option value='$i'>$Tur</option>";
                                                                            $i++;

                                                                        }
                                                                        ?>
                                                                    </select>
                                                                </td>


                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-warning">Marka</span></td>
                                                                <td><input type="text" class="form-control" name="marka" placeholder="Audi" aria-describedby="basic-addon1"></td>
                                                                <td><input type="submit" name="ekleMarka" value="Ekle" class="btn btn-primary btn-group-lg"></td>
                                                            </tr>

                                                            </tbody>
                                                        </table>
                                                    </form>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel panel-danger">
                                        <div class="panel-heading">
                                            <h4 class="panel-title">
                                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">Seri Ekleme</a>
                                            </h4>
                                        </div>
                                        <div id="collapseTwo" class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <div class="col-lg-12">
                                                    <form  action="" method="post">
                                                        <table class="table table text-muted">
                                                            <thead>
                                                            <tr>
                                                                <th>Seçim Türü</th>
                                                                <th>Seçim</th>
                                                                <th>Uygula</th>

                                                            </tr>
                                                            </thead>
                                                            <tbody>
                                                            <tr>
                                                                <td><span class="label label-danger">Vasıta Türü</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel2"">
                                                                    <?php
                                                                    databaseBağlanti(vasitalar);
                                                                    $sonuc=mysql_query("SELECT Tur FROM vasitaturleri");
                                                                    $i=1;
                                                                    while ($test=mysql_fetch_array($sonuc)) {
                                                                        $Tur=$test["Tur"];
                                                                        echo "<option value='$i'>$Tur</option>";
                                                                        $i++;
                                                                    }
                                                                    ?>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-warning">Marka</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel3">
                                                                        <?php
                                                                        databaseBağlanti(vasitalar);
                                                                        $sonuc=mysql_query("SELECT Marka FROM vasitamarka");
                                                                        $i=1;
                                                                        while ($test=mysql_fetch_array($sonuc)) {
                                                                            $Marka=$test["Marka"];

                                                                            echo "<option value='$i'>$Marka</option>";

                                                                            $i++;                           }
                                                                        ?>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-success">Seri</span></td>
                                                                <td><input type="text" class="form-control" name="seri" placeholder="A1" aria-describedby="basic-addon1"></td>
                                                                <td><input type="submit" name="ekleSeri" value="Ekle" class="btn btn-primary btn-group-lg"></td>
                                                            </tr>

                                                            </tbody>
                                                        </table>
                                                    </form>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel panel-danger">
                                        <div class="panel-heading">
                                            <h4 class="panel-title">
                                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseThree">Model&Özellik Ekleme</a>
                                            </h4>
                                        </div>
                                        <div id="collapseThree" class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <div class="col-lg-12">
                                                    <form  action="" method="post">
                                                        <table class="table table text-muted">
                                                            <thead>
                                                            <tr>
                                                                <th>Seçim Türü</th>
                                                                <th>Seçim</th>
                                                                <th>Uygula</th>

                                                            </tr>
                                                            </thead>
                                                            <tbody>
                                                            <tr>
                                                                <td><span class="label label-danger">Vasıta Türü</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel5"">
                                                                    <?php
                                                                    databaseBağlanti(vasitalar);
                                                                    $sonuc=mysql_query("SELECT Tur FROM vasitaturleri");
                                                                    $i=1;
                                                                    while ($test=mysql_fetch_array($sonuc)) {
                                                                        $Tur=$test["Tur"];
                                                                        echo "<option value='$i'>$Tur</option>";
                                                                        $i++;
                                                                    }
                                                                    ?>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-warning">Marka</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel6">
                                                                        <?php

                                                                        databaseBağlanti(vasitalar);
                                                                        $sonuc=mysql_query("SELECT Marka FROM vasitamarka");
                                                                        $i=1;
                                                                        while ($test=mysql_fetch_array($sonuc)) {
                                                                            $Marka=$test["Marka"];

                                                                            echo "<option value='$i'>$Marka</option>";

                                                                            $i++;                           }
                                                                        ?>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-warning">Seri</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel7">
                                                                        <?php
                                                                        databaseBağlanti(vasitalar);
                                                                        $sonuc=mysql_query("SELECT Seri FROM vasitaseri");
                                                                        $i=1;
                                                                        while ($test=mysql_fetch_array($sonuc)) {
                                                                            $Seri=$test["Seri"];

                                                                            echo "<option value='$i'>$Seri</option>";

                                                                            $i++;                           }
                                                                        ?>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-success">Model</span></td>
                                                                <td><input type="text" class="form-control" name="model" placeholder="1.4 TFSI Ambition" aria-describedby="basic-addon1"></td>
                                                                <td><input type="submit" name="ekleModel" value="Ekle" class="btn btn-primary btn-group-lg"></td>
                                                            </tr>

                                                            </tbody>
                                                        </table>
                                                    </form>
                                                </div>
                                                <div class="col-lg-12">
                                                    <form  action="" method="post">
                                                        <table class="table table text-muted">
                                                            <thead>
                                                            <tr>
                                                                <th>Seçim Türü</th>
                                                                <th>Seçim</th>
                                                                <th>Uygula</th>

                                                            </tr>
                                                            </thead>
                                                            <tbody>
                                                            <tr>
                                                                <td><span class="label label-warning">Özellik Tipi</span></td>
                                                                <td>
                                                                    <select class="form-control" name="sel4">
                                                                        <option value="1">Güvenlik</option>
                                                                        <option value="2">İç Donanım</option>
                                                                        <option value="3">Dış Donanım</option>
                                                                        <option value="4">Multimedya</option>
                                                                        <option value="5">Boyalı Parça</option>
                                                                        <option value="6">Değişen Parça</option>
                                                                    </select>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td><span class="label label-default">Özellik</span></td>
                                                                <td><input type="text" class="form-control" name="vasitaOzellik" placeholder="Hava Yastığı" aria-describedby="basic-addon1"></td>
                                                                <td><input type="submit" name="ekleOzellik" value="Ekle" class="btn btn-primary btn-group-lg"></td>
                                                            </tr>
                                                            </tbody>
                                                        </table>
                                                    </form>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>




                    </div>
                </div>

                </ul>
            </div>
        </div>
    </div>
</div>
</div>
</div>

<div class="container">
    <!-- Example row of columns -->
    <div class="row">


        <hr>

        <footer>
            <p>&copy; Company 2014</p>
        </footer>
    </div> <!-- /container -->

</div>
<!-- Bootstrap core JavaScript
================================================== -->
<!-- Placed at the end of the document so the pages load faster -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script src="./js/bootstrap.min.js"></script>
<!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
<script src="./js/ie10-viewport-bug-workaround.js"></script>

</body>
</html>

<?php
function databaseBağlanti()
{
    mysql_connect("localhost","root","");
    mysql_select_db("vasitalar");
    mysql_query("SET NAMES utf8"); /*Türkçe karakterler için*/
    mysql_query("SET CHARACTER SET utf8");
    mysql_query("SET COLLATION_CONNECTION='utf8_general_ci'");
}

if(isset($_POST["ekleVasitaTuru"]))
{
    databaseBağlanti();
    $vasitaTur=$_POST["vasitaTuru"];
    mysql_query("INSERT INTO vasitaturleri(Id,Tur) VALUES ('','$_POST[vasitaTuru]')");

}
if(isset($_POST["ekleMarka"]))
{
    databaseBağlanti(vasitalar);
    $select1=$_POST["sel1"];
    $marka=$_POST["marka"];
    mysql_query("INSERT INTO vasitamarka(Id,Marka,vasitaTuruId) VALUES ('','$marka','$select1')");

}
if(isset($_POST["ekleSeri"]))
{
    databaseBağlanti();
    $select2=$_POST["sel2"];
    $select3=$_POST["sel3"];
    $seri=$_POST["seri"];
    mysql_query("INSERT INTO vasitaseri(Id,Seri,vasitaTuruId,markaId) VALUES ('','$seri','$select2','$select3')");

}
if(isset($_POST["ekleModel"]))
{
    databaseBağlanti();
    $select5=$_POST["sel5"];
    $select6=$_POST["sel6"];
    $select7=$_POST["sel7"];
    $model=$_POST["model"];
    mysql_query("INSERT INTO vasitamodel(Id,Model,MarkaId,VasitaId,seriId) VALUES ('','$model','$select6','$select5','$select7')");

}
if(isset($_POST["ekleOzellik"]))
{
    databaseBağlanti();
    $select4=$_POST["sel4"];
    $ozellik=$_POST["vasitaOzellik"];
    mysql_query("INSERT INTO vasitaozellik(Id,Ozellik,ozellikTipi) VALUES ('','$ozellik','$select4')");

}
?>