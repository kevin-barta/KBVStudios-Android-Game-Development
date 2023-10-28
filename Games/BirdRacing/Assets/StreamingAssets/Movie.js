#pragma strict
var movTexture : MovieTexture;
var audioclip1 : AudioClip;

function Start () {
renderer.material.mainTexture = movTexture;
movTexture.Play();
audio.PlayOneShot(audioclip1);
//renderer.material.mainTexture.Play();
//Handheld.PlayFullScreenMovie ("kbv.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
}