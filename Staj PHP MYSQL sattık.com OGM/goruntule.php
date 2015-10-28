<?php?>
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
                    <a href="#" class="list-group-item list-group-item-info disabled">Kategoriler</a>
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



                <div class="list-group col-lg-9">
                    <div class="panel panel-danger panel col-lg-12">
                        <?php
              $test=$_POST["veri"];
              databaseBağlanti();
              $sec=mysql_query("SELECT * FROM vasitatopilan WHERE ilanNo='$test'");

                        while($dizim=mysql_fetch_array($sec)) {

                            echo "<h6><b>$dizim[ilanBasligi]</b></h6>";
                        }
                        ?>
                        <hr/>

                        <div class="col-md-6">
                            <!-- Slides-->
                            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">

                                <!-- Indicators -->

                                <ol class="carousel-indicators">

                                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>

                                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>

                                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>

                                </ol>


                                <!-- Wrapper for slides -->

                                <div class="carousel-inner">

                                    <!-- 1nci slide için başlangıç -->

                                    <div class="item active">
                                        <?php
                                 $test=$_POST["veri"];
                                 databaseBağlanti();
                                 $sec=mysql_query("SELECT * FROM vasitatopilan WHERE ilanNo='$test'");

                                     while($dizim=mysql_fetch_array($sec)) {
                                         $resimYol = $dizim["resimYolu"];
                                         echo "<img src='ilan_resimleri/$resimYol' alt='...'>";
                                     }?>
                                    </div>

                                    <!-- // 1nci slide için bitiş -->
                                </div>

                                <!-- Controls -->

                                <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">

                                    <span class="glyphicon glyphicon-chevron-left"></span>

                                </a>

                                <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">

                                    <span class="glyphicon glyphicon-chevron-right"></span>

                                </a>

                            </div>

                        </div>

                        <br>
                        <div class="col-md-6">
                            <?php
                            $test=$_POST["veri"];
                            databaseBağlanti();
                            $sec=mysql_query("SELECT * FROM vasitatopilan WHERE ilanNo='$test'");

                            while($dizim=mysql_fetch_array($sec)) {

                                $sec_1=mysql_query("SELECT * FROM vasitaseri WHERE Id='$dizim[seri]'");
                                $seri=mysql_fetch_array($sec_1)["Seri"];

                                $sec_2=mysql_query("SELECT * FROM vasitamodel WHERE Id='$dizim[model]'");
                                $model=mysql_fetch_array($sec_2)["Model"];

                                $sec_3=mysql_query("SELECT * FROM vasitamarka WHERE Id='$dizim[marka]'");
                                $marka=mysql_fetch_array($sec_3)["Marka"];

                                echo "<a href='' class='btn btn-primary btn-md disabled' role='button'>İlan Tarihi</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$dizim[ilanTarihi]</a>
                                    <a href='' class='btn btn-primary btn-md disabled' role='button'>Marka</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$marka</a>
                                    <br>
                                    <br>
                                    <a href='' class='btn btn-primary btn-md disabled' role='button'>Seri</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$seri</a>
                                    <a href='' class='btn btn-primary btn-md disabled' role='button'>Model</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$model</a>
                                    <br>
                                    <br>
                                    <a href='' class='btn btn-primary btn-md disabled' role='button'>Yıl</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$dizim[yil]</a>
                                    <a href='' class='btn btn-danger btn-md disabled' role='button'>Fiyat</a>
                                    <a href='' class='btn btn-default btn-md disabled' role='button'>$dizim[fiyat]</a>
                                          ";
                            }
                            ?>

                        </div>
<br>
                        <hr/>
                    </div>
                    <div class="col-lg">
                        <div class="panel panel-danger panel col-lg-12">
                            <h6><b>Özellikler</b></h6>
                            <hr/>
                            <table class="table table-hover table text-muted">
                                <tbody>
                             <?php

                                $temp=$_POST["veri"];
                               databaseBağlanti();
                               $test=mysql_query("SELECT * FROM vasitailan WHERE ilanNo='$temp'");

                               while($dizi=mysql_fetch_array($test)){

                                   $yakit=$dizi["yakit"];
                                   $vites=$dizi["vites"];
                                   $kilometre=$dizi["kilometre"];
                                   $kasaTipi=$dizi["kasaTipi"];
                                   $motorHacmi=$dizi["motorHacmi"];
                                   $motorGucu=$dizi["motorGucu"];
                                   $renk=$dizi["renk"];
                                   $plaka=$dizi["plaka"];
                                   $motorHcm=motorHacmiSabit($motorHacmi);
                                   $motorGc=motorGucuSabit($motorGucu);
                                   if($dizi["takas"]==0||$dizi["garanti"]==0)
                                   {$takas="Evet";$garanti="Evet";}
                                   else{$takas="Hayır;";$garanti="Hayır";}
                                   $cekis=$dizi["cekis"];
                                   if($dizi["durum"]==0){$durum="Sıfır";}else{$durum="İkinci El";}
                                   if($dizi["kimden"]==0){$kimden="Sahibinden";}else{$kimden="Galeriden";}
                                   echo "
                                    <tr>
                                    <td><b>Yakıt</b></td><td>$yakit</td>
                                    </tr>
                                    <tr> <td><b>Vites</b></td><td>$vites</td>
                                    </tr>
                                    </tr>
                                    <tr> <td><b>Kilometre</b></td><td>$kilometre</td>
                                    </tr>
                                    </tr>
                                    <tr> <td><b>KasaTipi</b></td><td>$kasaTipi</td>
                                    </tr>
                                    </tr>
                                    <tr> <td><b>Motor Hacmi</b></td><td>$motorHcm</td>
                                    </tr>
                                     <tr> <td><b>Motor Gücü</b></td><td>$motorGc</td>
                                    </tr>
                                     <tr> <td><b>Renk</b></td><td>$renk</td>
                                    </tr>
                                     <tr> <td><b>Garanti</b></td><td>$garanti</td>
                                    </tr>
                                     <tr> <td><b>Plaka/Uyruk</b></td><td>$plaka</td>
                                    </tr>
                                     <tr> <td><b>Takas</b></td><td>$takas</td>
                                    </tr>
                                     <tr> <td><b>Çekiş</b></td><td>$cekis</td>
                                    </tr>
                                     <tr> <td><b>Durumu</b></td><td>$durum</td>
                                    </tr>
                                     <tr> <td><b>Kimden</b></td><td>$kimden</td>
                                    </tr>
                                </tr>";
                               }
                             ?>
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
                                                $temp=$_POST["veri"];
                                                $sql="SELECT * FROM vasitailanozellik WHERE ilanNo='$temp'";
                                                $sec=mysql_query($sql);

                                                $myValue=mysql_fetch_assoc($sec);
                                                $myOzellikAlan=explode(',',$myValue['ozellikAdi']);
                                                $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='1'");
                                                $i=1;
                                                while ($test=mysql_fetch_array($sonuc)) {
                                                    $ozellik=$test["Ozellik"];

                                                    if (in_array($i, $myOzellikAlan)) {echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='i' checked disabled>$ozellik</label>";
                                                        $i+=1;}
                                                    else{
                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='$i' disabled>$ozellik</label>";
                                                        $i+=1;}
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
                                                $temp=$_POST["veri"];
                                                $sql="SELECT * FROM vasitailanozellik WHERE ilanNo='$temp'";
                                                $sec=mysql_query($sql);

                                                $myValue=mysql_fetch_assoc($sec);
                                                $myOzellikAlan=explode(',',$myValue['ozellikAdi']);
                                                $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='2'");
                                                $j=41;
                                                while ($test=mysql_fetch_array($sonuc)) {
                                                    $ozellik=$test["Ozellik"];
                                                    if (in_array($j, $myOzellikAlan)) {echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='$j' checked disabled>$ozellik</label>";
                                                        $j+=1;}
                                                    else{
                                                    echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='$j' disabled>$ozellik</label>";
                                                    $j+=1;}
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
                                                $temp=$_POST["veri"];
                                                $sql="SELECT * FROM vasitailanozellik WHERE ilanNo='$temp'";
                                                $sec=mysql_query($sql);

                                                $myValue=mysql_fetch_assoc($sec);
                                                $myOzellikAlan=explode(',',$myValue['ozellikAdi']);
                                                $sonuc=mysql_query("SELECT Ozellik FROM vasitaozellik WHERE ozellikTipi='3'");
                                                $k=80;
                                                while ($test=mysql_fetch_array($sonuc)) {
                                                    $ozellik = $test["Ozellik"];

                                                    if (in_array($k, $myOzellikAlan)) {
                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='$k' checked disabled>$ozellik</label>";
                                                        $k += 1;
                                                    } else {
                                                        echo " <label class='checkbox-inline'>
                                                <input type='checkbox' name='vasitailanozellik[]'  value='$k' disabled>$ozellik</label>";
                                                        $k += 1;
                                                    }}
                                                    ?>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

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
    mysql_connect("localhost", "root", "");
    mysql_select_db("vasitalar");
    mysql_query("SET NAMES utf8"); /*Türkçe karakterler için*/
    mysql_query("SET CHARACTER SET utf8");
    mysql_query("SET COLLATION_CONNECTION='utf8_general_ci'");
}
function motorHacmiSabit($motorHac)
{
    switch($motorHac){
        case 1:
            return "1200 cm'e kadar";break;
        case 2:
            return "1201-1400";break;
        case 3:
            return "1401-1600";break;
        case 4:
            return "1601-1800";break;
        case 5:
            return "1801-2000";break;
        case 6:
            return "2001-2500";break;
        case 7:
            return "2501-3000";break;
        case 8:
            return "3001-3500";break;
        case 9:
            return "3501-4000";break;
        case 10:
            return "4001-4500";break;
        case 11:
            return "4501-5000";break;
        case 12:
            return "5001-5500";break;
        case 13:
            return "5501-6000";break;
        case 14:
            return "6001 cm'e üzeri";break;

    }

}
function motorGucuSabit($motorGuc)
{
    switch($motorGuc){
        case 1:
            return "50 Hp'e kadar";break;
        case 2:
            return "51-75 Hp";break;
        case 3:
            return "76-100 Hp";break;
        case 4:
            return "101-125 Hp";break;
        case 5:
            return "126-150 Hp";break;
        case 6:
            return "151-175 Hp";break;
        case 7:
            return "176-200 Hp";break;
        case 8:
            return "201-225 Hp";break;
        case 9:
            return "226-250 Hp";break;
        case 10:
            return "251-275 Hp";break;
        case 11:
            return "276-300 Hp";break;
        case 12:
            return "301-325 Hp";break;
        case 13:
            return "326-350 Hp";break;
        case 14:
            return "351-375 Hp";break;
        case 15:
            return "376-400 Hp";break;
        case 16:
            return "401-425 Hp";break;
        case 17:
            return "426-450 Hp";break;
        case 18:
            return "451-475 Hp";break;
        case 19:
            return "476-500 Hp";break;
        case 20:
            return "501-525 Hp";break;
        case 21:
            return "526-550 Hp";break;
        case 22:
            return "551-575 Hp";break;
        case 23:
            return "576-600 Hp";break;
        case 24:
            return "601 Hp ve üzeri";break;
    }

}


?>