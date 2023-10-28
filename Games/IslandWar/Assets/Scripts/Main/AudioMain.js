#pragma strict

public class AudioMain extends MonoBehaviour
{
    
    function Update (){
    if(PlayerPrefs.GetInt("MusicChanged") == 10){
        audio.volume = PlayerPrefs.GetFloat("Music");
        }
        else {
        audio.volume = 1;
        }
    }
    function OnLevelWasLoaded (level : int){
    if(level == 1){
    Destroy( this.gameObject );
    }
    }
}