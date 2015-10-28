<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">


    <title>İlan Ver</title>

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
   <!-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">-->
   <!-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css">-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <style type="text/css">
        .bs-example{
            margin: 20px;
        }
    </style>
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
                <a href="#" class="list-group-item list-group-item-danger disabled">Kategoriler</a>
                <a href="#" class="list-group-item">Otomobil<span class="badge">54145</span></a>
                <a href="#" class="list-group-item">Arazi, SUV & Pick-up<span class="badge">144</span></a>
                <a href="#" class="list-group-item">Motosiklet<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Minivan, Van & Panelvan<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Kiralık Araçlar<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Ticari Araçlar<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Deniz Araçları<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Hasarlı Araçlar<span class="badge">154</span></a>
                <a href="#" class="list-group-item">Klasik Araçlar<span class="badge">154</span></a>

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
                            <form  action="" method="post" enctype="multipart/form-data">
                                <table class="table table text-muted">
                                    <thead>
                                    <tr>
                                        <th>Seçim Türü</th>
                                        <th>Seçim</th>

                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr>
                                        <td>
                                            <span class="label label-warning">İlan Başlığı</span></td>
                                        <td>
                                            <textarea name="baslik" class="form-control" rows="3"></textarea>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="label label-warning">Vasıta Türü</span></td>
                                        <td>
                                            <select class="form-control" name="sel1">
                                                <?php
                                                mysql_connect("localhost","root","");
                                                mysql_select_db("vasitalar");
                                                mysql_query("SET NAMES utf8"); /*Türkçe karakterler için*/
                                                mysql_query("SET CHARACTER SET utf8");
                                                mysql_query("SET COLLATION_CONNECTION='utf8_general_ci'");
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
                                        <td>
                                            <select class="form-control" name="sel2">
                                                <?php

                                              databaseBağlanti();
echo "$_POST[sel1]";
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
                                        <td><span class="label label-warning">Model</span></td>
                                        <td>
                                            <select class="form-control" name="sel3">
                                                <?php

                                              databaseBağlanti();
                                                $sonuc=mysql_query("SELECT Model FROM vasitamodel");
                                                $i=1;
                                                while ($test=mysql_fetch_array($sonuc)) {
                                                    $Model=$test["Model"];

                                                    echo "<option value='$i'>$Model</option>";

                                                    $i++;                           }
                                                ?>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Seri</span></td>
                                        <td>
                                            <select class="form-control" name="sel4">
                                                <?php

                                                databaseBağlanti();
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
                                        <td><span class="label label-warning">Yıl</span></td>
                                        <td>
                                            <select class="form-control" name="sel5">
                                               <?php
                                               $i=1990;
                                               while($i<=2015){
                                                  echo "<option value='$i'>$i</option>";
                                                   $i++;
                                               }
                                               ?>

                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Yakıt</span></td>
                                        <td>
                                            <select class="form-control" name="sel6">
                                                <option value="Benzin">Benzin</option>
                                                <option value="Dizel">Dizel</option>
                                                <option value="Benzin/LPG">Benzin/LPG</option>
                                                <option value="Hybrid">Hybrid</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Vites</span></td>
                                        <td>
                                            <select class="form-control" name="sel7">
                                                <option value="Manuel">Manuel</option>
                                                <option value="Yarı Otomatik">Yarı Otomatik</option>
                                                <option value="Otomatik">Otomatik</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Kilometre</span></td>
                                        <td><div class="input-group">
                                                <input type="text" name="kilometre" class="form-control" placeholder="16000" aria-describedby="basic-addon2">
                                                <span class="input-group-addon" id="basic-addon2">KM</span>
                                            </div></td>
                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Kasa Tipi</span></td>
                                        <td>
                                            <select class="form-control" name="sel8">
                                                <option value="Cabrio">Cabrio</option>
                                                <option value="Coupe">Coupe</option>
                                                <option value="Hatchback 3 Kapı">Hatchback 3 Kapı</option>
                                                <option value="Hatchback 5 Kapı">Hatchback 5 Kapı</option>
                                                <option value="Sedan">Sedan</option>
                                                <option value="Station Wagon">Station Wagon</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Motor Hacmi</span></td>
                                        <td>
                                            <select class="form-control" name="sel9">
                                                <option value="1">1200 cm'e kadar</option>
                                                <option value="2">1201-1400</option>
                                                <option value="3">1401-1600</option>
                                                <option value="4">1601-1800</option>
                                                <option value="5">1801-2000</option>
                                                <option value="6">2001-2500</option>
                                                <option value="7">2501-3000</option>
                                                <option value="8">3001-3500</option>
                                                <option value="9">3501-4000</option>
                                                <option value="10">4001-4500</option>
                                                <option value="11">4501-5000</option>
                                                <option value="12">5001-5500</option>
                                                <option value="13">5501-6000</option>
                                                <option value="14">6001 cm'e üzeri</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Motor Gücü</span></td>
                                        <td>
                                            <select class="form-control" name="sel10">
                                              <option value="1" >50 Hp'e kadar</option>
                                              <?php
                                              $i=51;$j=75;$k=2;
                                              while($i<=576&&$j<=600)
                                              {
                                                  echo "<option value='$k'>$i-$j HP</option>";
                                                  $i+=25;
                                                  $j+=25;$k+=1;

                                              }

                                              ?>
                                                <option value="24">601 HP ve üzeri</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Çekiş</span></td>
                                        <td>
                                            <select class="form-control" name="sel11">
                                                <option value="Önden Çekiş">Önden Çekiş</option>
                                                <option value="Arkadan İtiş">Arkadan İtiş</option>
                                                <option value="4WD(Sürekli)">4WD(Sürekli)</option>
                                                <option value="AWD(Elektronik)">AWD(Elektronik)</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Renk</span></td>
                                        <td>
                                            <select class="form-control" name="sel12">
                                                <option value="Bej">Bej</option>
                                                <option value="Beyaz">Beyaz</option>
                                                <option value="Bordo">Bordo</option>
                                                <option value="Füme">Füme</option>
                                                <option value="Gri">Gri</option>
                                                <option value="Gümüş Gri">Gümüş Gri</option>
                                                <option value="Kahverengi">Kahverengi</option>
                                                <option value="Kırmızı">Kırmızı</option>
                                                <option value="Lacivert">Lacivert</option>
                                                <option value="Mavi">Mavi</option>
                                                <option value="Mor">Mor</option>
                                                <option value="Pembe">Pembe</option>
                                                <option value="Sarı">Sarı</option>
                                                <option value="Siyah">Siyah</option>
                                                <option value="Şampanya">Şampanya</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Garanti</span></td>
                                        <td>
                                            <select class="form-control" name="sel13">
                                                <option value="0">Evet</option>
                                                <option value="1">Hayır</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Plaka/Uyruk</span></td>
                                        <td>
                                            <select class="form-control" name="sel14">
                                                <option value="Türkiye (TR) Plakalı">Türkiye (TR) Plakalı</option>
                                                <option value="Yabancı Plakalı">Yabancı Plakalı</option>
                                                <option value="Mavi(MA) Plakalı">Mavi(MA) Plakalı</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Takas</span></td>
                                        <td>
                                            <select class="form-control" name="sel15">
                                                <option value="0">Evet</option>
                                                <option value="1">Hayır</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Durumu</span></td>
                                        <td>
                                            <select class="form-control" name="sel16">
                                                <option value="0">Sıfır</option>
                                                <option value="1">İkinci El</option>
                                            </select>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Fiyat</span></td>
                                        <td>
                                            <div class="input-group">
                                                <input type="text" name="fiyat" class="form-control" placeholder="16000" aria-describedby="basic-addon2">
                                                <span class="input-group-addon" id="basic-addon2">YTL</span>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td><span class="label label-warning">Kimden</span></td>
                                        <td>
                                            <select class="form-control" name="sel17">
                                                <option value="0">Sahibinden</option>
                                                <option value="1">Galeriden</option>
                                            </select>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="label label-warning">Ana Vasıta Resmi</span></td>
                                        <td> <span class="btn btn-default btn-file">Dosyadan Seç <input type="file"  name="files[]" multiple></span> </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <h5>Özellikler</h5>
                                        </td>
                                    </tr>

                                    </tbody>
                                </table>
                                <div class="bs-example">
                                    <div class="panel-group" id="accordion">
                                        <div class="panel panel-danger">
                                            <div class="panel-heading">
                                                <h4 class="panel-title">
                                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Güvenlik</a>
                                                </h4>
                                            </div>
                                            <div id="collapseOne" class="panel-collapse collapse in">
                                                <div class="panel-body">
                                                    <?php
                                                   databaseBağlanti();
                                                    $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='1'");
                                                    $i=1;
                                                    while ($test=mysql_fetch_array($sonuc)) {
                                                        $ozellik=$test["Ozellik"];

                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]' value='$i' >$ozellik</label>";
                                                    $i+=1;
                                                    }
                                                    ?>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="panel panel-danger">
                                            <div class="panel-heading">
                                                <h4 class="panel-title">
                                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">İç Donanım</a>
                                                </h4>
                                            </div>
                                            <div id="collapseTwo" class="panel-collapse collapse">
                                                <div class="panel-body">
                                                    <?php
                                                    databaseBağlanti();
                                                    $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='2'");
                                                    $j=41;
                                                    while ($test=mysql_fetch_array($sonuc)) {
                                                        $ozellik=$test["Ozellik"];

                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]' value='$j' >$ozellik</label>";
                                                   $j+=1;
                                                    }
                                                    ?>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="panel panel-danger">
                                            <div class="panel-heading">
                                                <h4 class="panel-title">
                                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseThree">Dış Donanım</a>
                                                </h4>
                                            </div>
                                            <div id="collapseThree" class="panel-collapse collapse">
                                                <div class="panel-body">
                                                    <?php
                                                    databaseBağlanti();
                                                    $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='3'");
                                                   $k=80;
                                                    while ($test=mysql_fetch_array($sonuc)) {
                                                        $ozellik=$test["Ozellik"];

                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]' value='$k'>$ozellik</label>";
                                                    $k+=1;
                                                    }
                                                    ?>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <input type="submit" name="kaydet" value="Kaydet" class="btn btn-group-justified btn-danger btn-group-lg">
                           <br>
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
databaseBağlanti();

extract($_POST);
$sql="SELECT * FROM vasitailanozellik";
$sec=mysql_query($sql);
$toplamGirdi=mysql_num_rows($sec);

if(isset($_POST["kaydet"])||isset($_FILES["kaydet"])) {


    $errors= array();
    foreach($_FILES['files']['tmp_name'] as $key => $tmp_name ) {
        $dosya_adi = $key . $_FILES['files']['name'][$key];
        $dosya_temp = $_FILES['files']['tmp_name'][$key];


        if ($file_size > 2097152) {
            $errors[] = 'File size must be less than 2 MB';
        }
        $desired_dir="ilan_resimleri";
        if(empty($errors)==true) {
            if (is_dir($desired_dir) == false) {
                mkdir("$desired_dir", 0700);        // Create directory if it does not exist
            }
            if (is_dir("$desired_dir/" . $dosya_adi) == false) {
                move_uploaded_file($dosya_temp, "$desired_dir/" . $dosya_adi);
            } else {                                    // rename the file if another one exist
                $new_dir = "$desired_dir/" . $dosya_adi . time();
                rename($dosya_temp, $new_dir);
            }

            $tarih = date("Y-m-d");
            mysql_query("INSERT INTO vasitatopilan(ilanNo,resimYolu,ilanBasligi,ilanTarihi,vasitaTuru,marka,model,seri,fiyat,yil) VALUES ('','$dosya_adi','$_POST[baslik]','$tarih','$_POST[sel1]','$_POST[sel2]','$_POST[sel3]','$_POST[sel4]','$_POST[fiyat]','$_POST[sel5]')");

        }
        else
        {
            print_r($errors);
        }


    }


    mysql_query("INSERT INTO vasitailan(ilanNo,yakit,vites,kilometre,kasaTipi,motorHacmi,motorGucu,cekis,renk,garanti,plaka,takas,durum,kimden) VALUES ('','$_POST[sel6]','$_POST[sel7]','$_POST[kilometre]','$_POST[sel8]','$_POST[sel9]','$_POST[sel10]','$_POST[sel11]','$_POST[sel12]','$_POST[sel13]','$_POST[sel14]','$_POST[sel15]','$_POST[sel16]','$_POST[sel17]')");

    $tumOzellikDeger = implode(",", $_POST['vasitailanozellik']);


    $ekleme = "INSERT INTO vasitailanozellik(ozellikAdi) VALUES('" . $tumOzellikDeger . "')";
    mysql_query($ekleme);
}

?>