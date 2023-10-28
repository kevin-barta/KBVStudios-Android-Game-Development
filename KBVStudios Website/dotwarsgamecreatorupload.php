<?PHP

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
$timecreate = time();
$sel = mysql_query("SELECT * FROM `DotWarsGameCreator` WHERE Player != '4' AND Time > $timecreate LIMIT 1");
$numrow = mysql_num_rows($sel);
if($numrow == "0"){
    $time0 = time();
    $time0 = $time0 + 9;
    $ins = mysql_query("INSERT INTO DotWarsGameCreator (ID, Time, Player) VALUES ('', $time0, '1')");
    $id = mysql_insert_id();
    die ("1$id");
}
elseif($numrow == "1"){
    $playerdata = mysql_fetch_row($sel);
    $time1 = time();
    $time2 = $playerdata[1];
    if($time1 < $time2){    
        $player = $playerdata[2];
        $id = $playerdata[0];
        if($player == 1){
            $ins1 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '2' WHERE `ID` = $id");
            die("2$id");
        }
        elseif($player == 2){
            $ins1 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '3' WHERE `ID` = $id");
            die("3$id");
        }
        elseif($player == 3){
            $ins1 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '4' WHERE `ID` = $id");
            die("4$id");
        }
    }
}
die("No Connection");
?>