<?PHP

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS2" , $con) or die ("could not load the database" . mysql_error());
$insid = mysql_query("INSERT INTO `Musix Xenon` (UserId) VALUES ('')");
$id = mysql_insert_id();
die("$id");
?>