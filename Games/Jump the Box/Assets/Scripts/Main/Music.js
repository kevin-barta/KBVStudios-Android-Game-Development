#pragma strict

public class Music extends MonoBehaviour
{
    public static var instance : Music;
    public var Music : AudioClip;
    
    public static function GetInstance() : Music {
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
    function OnLevelWasLoaded (level : int) {
		if (level == 1) {
			audio.volume = 0.3;
		}
		if (level == 0) {
			audio.volume = 1;
		}
	}
}