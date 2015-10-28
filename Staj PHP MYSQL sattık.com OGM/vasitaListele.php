
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">


    <title>Jumbotron Template for Bootstrap</title>

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
                    <button type="submit" class="btn btn-default"><b>sattık.com</b></button>
                </form></div>
        </div>
        <div id="navbar" class="navbar-collapse collapse">

            <form class="navbar-form navbar-right">
                <button type="submit" class="btn btn-success"><span class="glyphicon glyphicon-user" aria-hidden="true"></span> Giriş Yap</button>
                <div class="form-group">
                    <input type="text" placeholder="Kelime, ilan no ile ara" class="form-control">
                </div>
                <button type="submit" class="btn btn-primary"><span class="glyphicon glyphicon-search" aria-hidden="true"></span></button>
                <button type="submit" class="btn btn-warning"><span class="glyphicon glyphicon-plus" aria-hidden="true"></span> İlan Ver</button>
            </form>
        </div><!--/.navbar-collapse -->
    </div>
</nav>

<!-- Main jumbotron for a primary marketing message or call to action -->
<div class="well">
    <div class="container">
        <div class="row">

            <div class="list-group col-lg-3">
                <a href="#" class="list-group-item" name="tüm">Tümü<span class="badge">54145</span></a>
                <a href="#" class="list-group-item" name="otomobil">Otomobil<span class="badge">54145</span></a>
                <a href="#" class="list-group-item" name="arazisuv">Arazi/SUV&Pick-up<span class="badge">144</span></a>
                <a href="#" class="list-group-item" name="kiralik">Kiralık Araçlar<span class="badge">154</span></a>
                <a href="#" class="list-group-item" name="ticari">Ticari Araçlar<span class="badge">154</span></a>


            </div>

                <div class="panel panel-danger panel col-lg-9">
<hr/>
                    <ol class="breadcrumb breadcrumb col-lg-12 list-group-item-success">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Library</a></li>
                    <li class="active">Data</li>
                    </ol>
                    <div class="panel panel-danger panel col-lg-12">
                    <div class="row">
                        <div class="col-lg-12">
                            <form action="goruntule.php" method="post">
                            <table class="table table-hover table text-muted">
                                <thead>
                                <tr>
                                    <th>Seç</th>
                                    <th>Resim</th>
                                    <th>İlan No</th>
                                    <th>İlan Tarihi</th>
                                    <th>Marka</th>
                                    <th>Seri</th>
                                    <th>Model</th>
                                    <th>İlan Başlığı</th>
                                    <th>Yıl</th>
                                    <th>Fiyat</th>
                                </tr>
                                </thead>
                               <tbody>
                               <?php
                               databaseBağlanti();
                               $test=mysql_query("SELECT * FROM vasitatopilan");

                               while($dizi=mysql_fetch_array($test)) {
                                   $no = $dizi["ilanNo"];
                                   $resimYol = $dizi["resimYolu"];
                                   $tarih = $dizi["ilanTarihi"];
                                   $marka = $dizi["marka"];
                                   $seri = $dizi["seri"];
                                   $model = $dizi["model"];
                                   $baslik = $dizi["ilanBasligi"];
                                   $yil = $dizi["yil"];
                                   $fiyat = $dizi["fiyat"];

                                   $sec = mysql_query("SELECT * FROM vasitamarka WHERE Id='$marka'");
                                   $marka = mysql_fetch_array($sec)["Marka"];

                                   $sec_1 = mysql_query("SELECT * FROM vasitaseri WHERE Id='$seri'");
                                   $seri = mysql_fetch_array($sec_1)["Seri"];

                                   $sec_2 = mysql_query("SELECT * FROM vasitamodel WHERE Id='$model'");
                                   $model = mysql_fetch_array($sec_2)["Model"];
                                   echo "<tr>
                                    <td> <div class='checkbox'>
                                        <label>
                                            <input  type='radio' name='veri' value='$no'>
                                        </label>
                                    </div></td>

                                     <td>
                                            <a href='' class='thumbnail' >
                                                <img src='ilan_resimleri/$resimYol' alt='...'>
                                            </a>
                                     </td>
                                    <td>$no</td>
                                    <td>$tarih</td>
                                    <td>$marka</td>
                                    <td>$seri</td>
                                    <td>$model</td>
                                    <td>$baslik</td>
                                    <td>$yil</td>
                                    <td>$fiyat</td>

                                </tr>";

                               }?>
                               </tbody>
                            </table>
                                <div class="container col-lg-12">
                                    <div class="alert alert-danger" role="alert">
                                        <a href="#" class="alert-link">Detayları görüntülemek için butona tıklayınız...</a>
                                    </div>
                                    <input type="submit" name="detayGor" value="Detay Gör" class="btn btn-group-justified btn-danger btn-group-lg">
                                  <hr/>  </div>

                         </form>
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
?>