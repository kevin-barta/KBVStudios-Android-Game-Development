<?PHP

$Player = $_POST['Player'];
$ID = $_POST['ID'];

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
if($Player == 1){
    $sel = mysql_query("SELECT * FROM DotWarsGameCreator WHERE `ID`='".$ID."'");
    $dataarray = mysql_fetch_row($sel);
    $time10 = $dataarray[1] + 1;
    $time0 = time();
    if($time0 > $time10){
        $ins1 = mysql_query("INSERT INTO DotWars (Game, Time) VALUES ($ID, $time10)");
        $del = mysql_query("DELETE FROM DotWarsGameCreator WHERE `ID`='".$ID."'");
        if($dataarray[2] == 1){
            die ("1Ready");
        }
        if($dataarray[2] == 2){
            die ("2Ready");
        }
        if($dataarray[2] == 3){
            die ("3Ready");
        }
        if($dataarray[2] == 4){
            die ("Ready");
        }
    }
    else{
        die("Not Ready");
    }
}
else{
    $ins = mysql_query("SELECT `Game` FROM DotWars WHERE `Game`='".$ID."'");
    $row = mysql_fetch_row($ins);
    if ($row != 0){
        die ("Ready");
    }
    else{
        die ("Not Ready");
    }
}
?>