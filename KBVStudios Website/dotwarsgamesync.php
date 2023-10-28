<?PHP

$Player = $_POST['Player'];
$ID = $_POST['ID'];
$Data = $_POST['Data'];
$Bot3Data = $_POST['Bot3Data'];
$Bot4Data = $_POST['Bot4Data'];

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
$time0 = time();
if($Player == 1){
    $upd0 = mysql_query("UPDATE DotWars SET Time = '$time0', ID1 = '$Data' WHERE `Game` = '$ID'");
    if($Bot3Data != ""){
        $upd1 = mysql_query("UPDATE DotWars SET ID3 = '$Bot3Data' WHERE Game = '$ID'");
    }
    if($Bot4Data != ""){
        $upd2 = mysql_query("UPDATE DotWars SET ID4 = '$Bot4Data' WHERE Game = '$ID'");
    }
}
elseif($Player == 2){
    $upd3 = mysql_query("UPDATE DotWars SET Time = '$time0', ID2 = '$Data' WHERE Game = '$ID'");
}
elseif($Player == 3){
    $upd4 = mysql_query("UPDATE DotWars SET Time = '$time0', ID3 = '$Data' WHERE Game = '$ID'");
}
elseif($Player == 4){
    $upd5 = mysql_query("UPDATE DotWars SET Time = '$time0', ID4 = '$Data' WHERE Game = '$ID'");
}
$sel = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$ID'");
$playerdata = mysql_fetch_row($sel);
if($Player == 1){
    if($Bot3Data != "" && $Bot4Data != ""){
        die("$playerdata[4]");
    }
    elseif($Bot3Data != "" && $Bot4Data == ""){
        die("$playerdata[4] $playerdata[6]");
    }
    elseif($Bot3Data == "" && $Bot4Data != ""){
        die("$playerdata[4] $playerdata[5]");
    }
    else{
        die("$playerdata[4] $playerdata[5] $playerdata[6]");
    }
}
elseif($Player == 2){
    die("$playerdata[3] $playerdata[5] $playerdata[6]");
}
elseif($Player == 3){
    die("$playerdata[3] $playerdata[4] $playerdata[6]");
}
elseif($Player == 4){
    die("$playerdata[3] $playerdata[4] $playerdata[5]");
}
?>