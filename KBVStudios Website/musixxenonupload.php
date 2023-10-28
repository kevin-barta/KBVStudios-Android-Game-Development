<?PHP

$UserID = $_POST['UserID'];
$SongTitle = $_POST['SongTitle'];
$SongData = $_POST['SongData'];
$Score = $_POST['Score'];

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS2" , $con) or die ("could not load the database" . mysql_error());
if($UserID != ""){
    $sel = mysql_query("SELECT * FROM `Musix Xenon Song` WHERE `SongTitle` = '$SongTitle'");
    $row = mysql_num_rows($sel);
    if($row == 0){
        $inssongdata = mysql_query("INSERT INTO `Musix Xenon Song` (SongTitle, SongData) VALUES ('$SongTitle', '$SongData')");
        $createtable = mysql_query("ALTER TABLE `Musix Xenon` ADD `$SongTitle` INT");
        $updscore = mysql_query("UPDATE `Musix Xenon` SET `$SongTitle` = '$Score' WHERE `UserId` = '$UserID'");
        $upd1st = mysql_query("UPDATE `Musix Xenon Song` SET `Place1` = '$Score' WHERE `SongTitle` = '$SongTitle'");
    }
    else{
        $selscore1 = mysql_query("SELECT `$SongTitle` FROM `Musix Xenon` WHERE `UserId` = '$UserID'");
        $rowscore = mysql_fetch_array($selscore1);
        if(intval($rowscore[0]) < intval($Score)){
            $updscore1 = mysql_query("UPDATE `Musix Xenon` SET `$SongTitle` = '$Score' WHERE `UserId` = '$UserID'");
        }
        $sel1 = mysql_query("SELECT * FROM `Musix Xenon Song` WHERE `SongTitle` = '$SongTitle'");
        $row1 = mysql_fetch_array($sel1);
        $Place1 = intval($row1["Place1"]);
        $Place2 = intval($row1["Place2"]);
        $Place3 = intval($row1["Place3"]);
        $Place4 = intval($row1["Place4"]);
        $Place5 = intval($row1["Place5"]);
        $Place6 = intval($row1["Place6"]);
        $Place7 = intval($row1["Place7"]);
        $Place8 = intval($row1["Place8"]);
        $Place9 = intval($row1["Place9"]);
        $Place10 = intval($row1["Place10"]);
        $PlaceExtra = 0;
        if($Score > $Place10){
            if($Score > $Place1){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Place5;
                $Place5 = $Place4;
                $Place4 = $Place3;
                $Place3 = $Place2;
                $Place2 = $Place1;
                $Place1 = $Score;
            }
            else if($Score > $Place2){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Place5;
                $Place5 = $Place4;
                $Place4 = $Place3;
                $Place3 = $Place2;
                $Place2 = $Score;
            }
            else if($Score > $Place3){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Place5;
                $Place5 = $Place4;
                $Place4 = $Place3;
                $Place3 = $Score;
            }
            else if($Score > $Place4){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Place5;
                $Place5 = $Place4;
                $Place4 = $Score;
            }
            else if($Score > $Place5){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Place5;
                $Place5 = $Score;
            }
            else if($Score > $Place6){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Place6;
                $Place6 = $Score;
            }
            else if($Score > $Place7){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Place7;
                $Place7 = $Score;
            }
            else if($Score > $Place8){
                $Place10 = $Place9;
                $Place9 = $Place8;
                $Place8 = $Score;
            }
            else if($Score > $Place9){
                $Place10 = $Place9;
                $Place9 = $Score;
            }
            else if($Score > $Place10){
                $Place10 = $Score;
            }
            $updp1 = mysql_query("UPDATE `Musix Xenon Song` SET `Place1` = '$Place1' WHERE `SongTitle` = '$SongTitle'");
            $updp2 = mysql_query("UPDATE `Musix Xenon Song` SET `Place2` = '$Place2' WHERE `SongTitle` = '$SongTitle'");
            $updp3 = mysql_query("UPDATE `Musix Xenon Song` SET `Place3` = '$Place3' WHERE `SongTitle` = '$SongTitle'");
            $updp4 = mysql_query("UPDATE `Musix Xenon Song` SET `Place4` = '$Place4' WHERE `SongTitle` = '$SongTitle'");
            $updp5 = mysql_query("UPDATE `Musix Xenon Song` SET `Place5` = '$Place5' WHERE `SongTitle` = '$SongTitle'");
            $updp6 = mysql_query("UPDATE `Musix Xenon Song` SET `Place6` = '$Place6' WHERE `SongTitle` = '$SongTitle'");
            $updp7 = mysql_query("UPDATE `Musix Xenon Song` SET `Place7` = '$Place7' WHERE `SongTitle` = '$SongTitle'");
            $updp8 = mysql_query("UPDATE `Musix Xenon Song` SET `Place8` = '$Place8' WHERE `SongTitle` = '$SongTitle'");
            $updp9 = mysql_query("UPDATE `Musix Xenon Song` SET `Place9` = '$Place9' WHERE `SongTitle` = '$SongTitle'");
            $updp10 = mysql_query("UPDATE `Musix Xenon Song` SET `Place10` = '$Place10' WHERE `SongTitle` = '$SongTitle'");
        }
    }
    die();
}
?>