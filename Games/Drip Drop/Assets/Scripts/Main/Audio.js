#pragma strict

private static var instance: Audio;
public static function GetInstance() : Audio {
return instance;
}
 
function Awake() {
    if (instance != null && instance != this) {
        Destroy(this.gameObject);
        return;
    } else {
        instance = this;
    }
    DontDestroyOnLoad(this.gameObject);
}