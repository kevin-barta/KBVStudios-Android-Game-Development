<?PHP

$Game = $_POST['Game'];
$Ping1 = $_POST['Ping1'];
$Ping2 = $_POST['Ping2'];
$Ping3 = $_POST['Ping3'];
$Ping4 = $_POST['Ping4'];
$Bot3 = $_POST['Bot3'];
$Bot4 = $_POST['Bot4'];

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
if($Ping1 != ""){
    $upd1 = mysql_query("UPDATE DotWars SET Ping1 = '$Ping1' WHERE Game = '$Game'");
    if($Bot3 != ""){
        $upd2 = mysql_query("UPDATE DotWars SET Ping3 = '$Ping1' WHERE Game = '$Game'");
    }
    if($Bot4 != ""){
        $upd3 = mysql_query("UPDATE DotWars SET Ping4 = '$Ping1' WHERE Game = '$Game'");
    }
    $sel = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
    $playerdata = mysql_fetch_row($sel);
    while($playerdata[12] == "" && $playerdata[13] == "" && $playerdata[14] == ""){
        $sel1 = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
        $playerdata = mysql_fetch_row($sel1);
    }
    if($playerdata[12] >= $playerdata[13] && $playerdata[12] >= $playerdata[14] && $playerdata[12] >= $Ping1){
        die("$playerdata[12]");
    }
    elseif($playerdata[13] >= $playerdata[12] && $playerdata[13] >= $playerdata[14] && $playerdata[13] >= $Ping1){
        die("$playerdata[13]");
    }
    elseif($playerdata[14] >= $playerdata[12] && $playerdata[14] >= $playerdata[13] && $playerdata[14] >= $Ping1){
        die("$playerdata[14]");
    }
    elseif($Ping1 >= $playerdata[12] && $Ping1 >= $playerdata[13] && $Ping1 >= $playerdata[14]){
        die("$Ping1");
    }
}
elseif($Ping2 != ""){
    $upd1 = mysql_query("UPDATE DotWars SET Ping2 = '$Ping2' WHERE Game = '$Game'");
    if($Bot3 != ""){
        $upd2 = mysql_query("UPDATE DotWars SET Ping3 = '$Ping2' WHERE Game = '$Game'");
    }
    if($Bot4 != ""){
        $upd3 = mysql_query("UPDATE DotWars SET Ping4 = '$Ping2' WHERE Game = '$Game'");
    }
    $sel = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
    $playerdata = mysql_fetch_row($sel);
    while($playerdata[11] == "" && $playerdata[13] == "" && $playerdata[14] == ""){
        $sel1 = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
        $playerdata = mysql_fetch_row($sel1);
    }
    if($playerdata[11] >= $playerdata[13] && $playerdata[11] >= $playerdata[14] && $playerdata[11] >= $Ping2){
        die("$playerdata[11]");
    }
    elseif($playerdata[13] >= $playerdata[11] && $playerdata[13] >= $playerdata[14] && $playerdata[13] >= $Ping2){
        die("$playerdata[13]");
    }
    elseif($playerdata[14] >= $playerdata[11] && $playerdata[14] >= $playerdata[13] && $playerdata[14] >= $Ping2){
        die("$playerdata[14]");
    }
    elseif($Ping2 >= $playerdata[11] && $Ping2 >= $playerdata[13] && $Ping2 >= $playerdata[14]){
        die("$Ping2");
    }
}
elseif($Ping3 != ""){
    $upd1 = mysql_query("UPDATE DotWars SET Ping3 = '$Ping3' WHERE Game = '$Game'");
    if($Bot3 != ""){
        $upd2 = mysql_query("UPDATE DotWars SET Ping3 = '$Ping3' WHERE Game = '$Game'");
    }
    if($Bot4 != ""){
        $upd3 = mysql_query("UPDATE DotWars SET Ping4 = '$Ping3' WHERE Game = '$Game'");
    }
    $sel = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
    $playerdata = mysql_fetch_row($sel);
    while($playerdata[11] == "" && $playerdata[12] == "" && $playerdata[14] == ""){
        $sel1 = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
        $playerdata = mysql_fetch_row($sel1);
    }
    if($playerdata[11] >= $playerdata[12] && $playerdata[11] >= $playerdata[14] && $playerdata[11] >= $Ping3){
        die("$playerdata[11]");
    }
    elseif($playerdata[12] >= $playerdata[11] && $playerdata[12] >= $playerdata[14] && $playerdata[12] >= $Ping3){
        die("$playerdata[12]");
    }
    elseif($playerdata[14] >= $playerdata[11] && $playerdata[14] >= $playerdata[12] && $playerdata[14] >= $Ping3){
        die("$playerdata[14]");
    }
    elseif($Ping3 >= $playerdata[11] && $Ping3 >= $playerdata[12] && $Ping3 >= $playerdata[14]){
        die("$Ping3");
    }
}
elseif($Ping4 != ""){
    $upd1 = mysql_query("UPDATE DotWars SET Ping4 = '$Ping4' WHERE Game = '$Game'");
    if($Bot3 != ""){
        $upd2 = mysql_query("UPDATE DotWars SET Ping3 = '$Ping4' WHERE Game = '$Game'");
    }
    if($Bot4 != ""){
        $upd3 = mysql_query("UPDATE DotWars SET Ping4 = '$Ping4' WHERE Game = '$Game'");
    }
    $sel = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
    $playerdata = mysql_fetch_row($sel);
    while($playerdata[11] == "" && $playerdata[12] == "" && $playerdata[13] == ""){
        $sel1 = mysql_query("SELECT * FROM `DotWars` WHERE Game = '$Game'");
        $playerdata = mysql_fetch_row($sel1);
    }
    if($playerdata[11] >= $playerdata[12] && $playerdata[11] >= $playerdata[13] && $playerdata[11] >= $Ping4){
        die("$playerdata[11]");
    }
    elseif($playerdata[12] >= $playerdata[11] && $playerdata[12] >= $playerdata[13] && $playerdata[12] >= $Ping4){
        die("$playerdata[12]");
    }
    elseif($playerdata[13] >= $playerdata[11] && $playerdata[13] >= $playerdata[12] && $playerdata[13] >= $Ping4){
        die("$playerdata[13]");
    }
    elseif($Ping4 >= $playerdata[11] && $Ping4 >= $playerdata[12] && $Ping4 >= $playerdata[13]){
        die("$Ping4");
    }
}
?>