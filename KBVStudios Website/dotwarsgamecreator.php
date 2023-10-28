<?PHP

$localhost = "";
$username = "";
$password = "";
$con = mysql_connect($localhost, $username, $password) or ("No Connection");
if (!$con)
	die("No Connection");
	
mysql_select_db("KBVSTUDIOS1" , $con) or die ("could not load the database" . mysql_error());
$check = mysql_query("SELECT * FROM DotWarsGameCreator WHERE `ID`='1'");
$gamedata = mysql_fetch_row($check);
$gameid = $gamedata[1];
while($gameid != 1){
    --$gameid;
    $upd = mysql_query("UPDATE DotWarsGameCreator SET `GameID` = $gameid WHERE `ID` = '1'");
    $ins = mysql_query("SELECT ID FROM `DotWarsGameCreator` WHERE GameID ='0' LIMIT 4");
    $numrow = mysql_num_rows($ins);
    if($numrow != 0){
        $row1 = 0;
        $ins0 = mysql_query("INSERT INTO DotWars (Game) VALUES ('');");
        $id = mysql_insert_id();
        while($row = mysql_fetch_array($ins, MYSQL_ASSOC)){
            $row2 = $row['ID'];
            ++$row1;
            $upd0 = mysql_query("UPDATE DotWarsGameCreator SET `GameID` = '$id' WHERE `ID` = '$row2'");
            if($row1 == 1){
                if($numrow == 1){
                    $ins1 = mysql_query("UPDATE DotWarsGameCreator SET `Bot2` = '1' WHERE `ID` = '$row2'");
                    $ins2 = mysql_query("UPDATE DotWarsGameCreator SET `Bot3` = '1' WHERE `ID` = '$row2'");
                    $ins3 = mysql_query("UPDATE DotWarsGameCreator SET `Bot4` = '1' WHERE `ID` = '$row2'");
                }
                else if($numrow == 2){
                    $ins4 = mysql_query("UPDATE DotWarsGameCreator SET `Bot3` = '1' WHERE `ID` = '$row2'");
                }
                else if($numrow == 3){
                    $ins5 = mysql_query("UPDATE DotWarsGameCreator SET `Bot4` = '1' WHERE `ID` = '$row2'");
                }
                $ins6 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '1' WHERE `ID` = '$row2'");
            }
            else if($row1 == 2){
                if($numrow == 2){
                    $ins7 = mysql_query("UPDATE DotWarsGameCreator SET `Bot4` = '1' WHERE `ID` = '$row2'");
                }
                $ins8 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '2' WHERE `ID` = '$row2'");
            }
            else if($row1 == 3){
                $ins9 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '3' WHERE `ID` = '$row2'");
            }
            else if($row1 == 4){
                $ins10 = mysql_query("UPDATE DotWarsGameCreator SET `Player` = '4' WHERE `ID` = '$row2'");
            }
        }
    }
    $check = mysql_query("SELECT * FROM DotWarsGameCreator WHERE `ID`='1'");
    $gamedata = mysql_fetch_row($check);
    $gameid = $gamedata[1];
}
die("Finished");
?>