<?PHP

$UserID = $_POST['UserID'];
$SongTitle = $_POST['SongTitle'];

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS2" , $con) or die ("could not load the database" . mysql_error());
if($UserID != ""){
    $sel1 = mysql_query("SELECT * FROM `Musix Xenon Song` WHERE `SongTitle` = '$SongTitle'");
    $row1 = mysql_fetch_array($sel1);
    echo $row1["Place1"];
    echo ",";
    echo $row1["Place2"];
    echo ",";
    echo $row1["Place3"];
    echo ",";
    echo $row1["Place4"];
    echo ",";
    echo $row1["Place5"];
    echo ",";
    echo $row1["Place6"];
    echo ",";
    echo $row1["Place7"];
    echo ",";
    echo $row1["Place8"];
    echo ",";
    echo $row1["Place9"];
    echo ",";
    echo $row1["Place10"];
    echo ",";
    $selown = mysql_query("SELECT `$SongTitle` FROM `Musix Xenon` WHERE `UserId` = '$UserID'");
    $rowown = mysql_fetch_array($selown);
    echo $rowown[0];
    die();
}
else if($SongTitle == ""){
    $sel2 = mysql_query("SELECT `SongTitle` FROM `Musix Xenon Song`");
    $s1 = "Akiam Dance (Snabisch)";
    $s2 = "Slow Pipes (RawGameStudios)";
    $s3 = "The Tunnel (Snabisch)";
    $s4 = "At The Other End On The Party (Snabisch)";
    $s5 = "Irelands Coast Travelog Edition (Matthew Pablo)";
    $s6 = "The Old Song (Snabisch)";
    $s7 = "Hello (OMFG)";
    $s8 = "Sea Star (Snabisch)";
    $s9 = "Laser Millenium (Neocrey)";
    $s10 = "Disco Century (Neocrey)";
    $s11 = "Zombies Also Love To Play The Fool (Alexandr Zhelanov)";
    $s12 = "No Joke Is All That Counts (Snabisch)";
    $s13 = "Night Adventure (Alexandr Zhelanov)";
    $s14 = "Runner (Alexandr Zhelanov)";
    $s15 = "Chocolate Addiction (Snabisch)";
    while ($row2 = mysql_fetch_array($sel2)) {
        $st = $row2["SongTitle"];
        if($s1 != $st && $s2 != $st && $s3 != $st && $s4 != $st && $s5 != $st && $s6 != $st && $s7 != $st && $s8 != $st && $s9 != $st && $s10 != $st && $s11 != $st && $s12 != $st && $s13 != $st && $s14 != $st && $s15 != $st){
            echo ",";
            echo $st;
        }
    }
    die();
}
else{
    $sel3 = mysql_query("SELECT `SongData` FROM `Musix Xenon Song` WHERE `SongTitle` = '$SongTitle'");
    while ($row3 = mysql_fetch_array($sel3)) {
        echo $row3["SongData"];
    }
    die();
}
?>