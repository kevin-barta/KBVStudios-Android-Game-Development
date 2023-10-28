using UnityEngine;
using System.Collections;
using SVGImporter;

public class Tutorial : MonoBehaviour {
	public GameObject Pointer;
	public int completion = 0;
	public bool respawn = false;
	private bool pointerflashing = false;
	
	/*void Update () {
		if(respawn == true){
			if(completion == 2){
				completion = 1;
			}
		}
		if(completion == 1){
			if(Physics2D.GetIgnoreLayerCollision(9, 13) == true){
				GameObject.Find ("ClockHand").GetComponent<Hand>().speed = -60;
				completion = 2;
			}
			else if (){
				
			}
		}
	}*/

	IEnumerator PointFlash(){
		while(pointerflashing == true){
			Pointer.GetComponent<SVGImage>().enabled = false;
			yield return new WaitForSeconds(0.1f);
		}
	}
}