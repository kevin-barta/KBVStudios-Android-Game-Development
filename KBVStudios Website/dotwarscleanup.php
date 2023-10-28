<?PHP

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
$time0 = time();
$time0 = $time0 - 60;
$ins = mysql_query("SELECT ID FROM `DotWarsGameCreator` WHERE `Time` < $time0");
while($row = mysql_fetch_array($ins, MYSQL_ASSOC)){
    $row1 = $row['ID'];
    $del = mysql_query("DELETE FROM `DotWarsGameCreator` WHERE `ID` = $row1");
}
$time1 = time();
$time1 = $time1 - 300;
$ins1 = mysql_query("SELECT Game FROM `DotWars` WHERE `Time` < $time1");
while($row2 = mysql_fetch_array($ins1, MYSQL_ASSOC)){
    $row3 = $row2['Game'];
    $del1 = mysql_query("DELETE FROM `DotWars` WHERE `Game` = $row3");
}
die("Finished");
?>