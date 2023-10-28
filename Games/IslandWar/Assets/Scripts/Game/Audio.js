#pragma strict

public class Audio extends MonoBehaviour
{
    public static var instance : Audio;
    public var music : AudioClip;
    
    public static function GetInstance() : Audio {
    return instance;
    }
 
    function Awake() 
    {
        if ( instance != null && instance != this ) 
        {
            Destroy( this.gameObject );
            return;
        } 
        else 
        {
            instance = this;
        }
 
        DontDestroyOnLoad( this.gameObject );
    }
    function Update (){
    if(PlayerPrefs.GetInt("MusicChanged") == 10){
        audio.volume = PlayerPrefs.GetFloat("Music");
        }
        else {
        audio.volume = 1;
        }
    }
}