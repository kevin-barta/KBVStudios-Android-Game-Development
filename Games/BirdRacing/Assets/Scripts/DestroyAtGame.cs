using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyAtGame : MonoBehaviour {
	public Text Loading1;
	private int x = 10;
	private int y = 10;

	void Awake (){
		if(Application.loadedLevel == 1){
			DontDestroyOnLoad(transform.gameObject);
		}
	}

	void Update (){
		if(Application.loadedLevel == 3){
			Destroy(gameObject);
		}
		if(gameObject.name == "Loading"){
			if(Application.loadedLevel == 2){
				if(x == 10){
					x = 0;
					StartCoroutine(Loading());
				}
				if(y == 10){
					y = 0;
					StartCoroutine(UnLoading());
				}
			}
		}
		if(Application.loadedLevel == 2){
			if(gameObject.name == "Audio"){
				Destroy (gameObject);
			}
		}
	}

	IEnumerator UnLoading (){
		System.GC.Collect();
		Resources.UnloadUnusedAssets();
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel(3);
	}

	IEnumerator Loading () {
		Loading1.GetComponent<Text>().text = "Loading ";
		yield return new WaitForSeconds(0.25f);
		Loading1.GetComponent<Text>().text = "Loading .";
		yield return new WaitForSeconds(0.25f);
		Loading1.GetComponent<Text>().text = "Loading ..";
		yield return new WaitForSeconds(0.25f);
		Loading1.GetComponent<Text>().text = "Loading ...";
		yield return new WaitForSeconds(1);
		x = 10;
	}
}
