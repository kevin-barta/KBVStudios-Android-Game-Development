using UnityEngine;
using System.Collections;
using SVGImporter;

public class Mine : MonoBehaviour {
	public GameObject ShotPrefab;
	public Dot dot;
	public Bot bot;
	public SVGImage fade;
	public SVGImage fade1;
	public Material PlayerMat;
	private bool minedestroy;
	private bool fading;
	private float time;

	void Start (){
		time = Time.time;
	}

	void Update (){
		if (minedestroy == false) {
			if (fading == false && Time.time - time < 1) {
				fade.color = new Color (fade.color.r, fade.color.g, fade.color.b, 1 - (Time.time - time));
			}
			else if(fading == false && Time.time - time >= 1){
				fading = true;
				time = Time.time;
			}
			else if (fading == true && Time.time - time < 1) {
				fade.color = new Color (fade.color.r, fade.color.g, fade.color.b, Time.time - time);
			}
			else {
				fading = false;
				time = Time.time;
			}
		}
		else{
			if ((Time.time - time) * 2 < 1) {
				fade.color = new Color (fade.color.r, fade.color.g, fade.color.b, fade.color.a - (Time.time - time) * 2);
				fade1.color = new Color (fade1.color.r, fade1.color.g, fade1.color.b, 1 - (Time.time - time) * 2);
			}
			else {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.layer == 9 || other.gameObject.layer == 10 || other.gameObject.layer == 11 || other.gameObject.layer == 12 || other.gameObject.layer == 13 || other.gameObject.layer == 15 || other.gameObject.layer == 16 || other.gameObject.layer == 17 || other.gameObject.layer == 18) {
			if (minedestroy == false) {
				minedestroy = true;
				time = Time.time;
				if (dot != null) {
					GameObject.Find ("Main Camera").GetComponent<Encrypt> ().RunSH ("9" + dot.player.ToString() + dot.shotnumber.ToString ("00"));
				}
				else if (bot != null) {
					GameObject.Find ("Main Camera").GetComponent<Encrypt> ().RunSH ("9" + bot.player.ToString() + bot.shotnumber.ToString ("00"));
				}
				for (int i = 0; i < 360; i += 60) {
					GameObject shotpre = (GameObject)Instantiate (ShotPrefab, transform.position, transform.rotation);
					if (dot != null) {
						dot.shotnumber++;
						if (dot.shotnumber == 100) {
							dot.shotnumber = 1;
						}
						shotpre.name = "P" + dot.player + "Shot" + dot.shotnumber;
					}
					else if (bot != null) {
						bot.shotnumber++;
						if (bot.shotnumber == 100) {
							bot.shotnumber = 1;
						}
						shotpre.name = "P" + bot.player + "Shot" + bot.shotnumber;
					}
					shotpre.transform.localEulerAngles = new Vector3 (0, 0, i);
					shotpre.GetComponent<Rigidbody2D>().AddForce(shotpre.transform.up);
					shotpre.transform.localEulerAngles = new Vector3(0, 0, 0);
					shotpre.GetComponent<SVGImage>().material = PlayerMat;
					shotpre.GetComponent<TrailRenderer>().material = PlayerMat;
					shotpre.transform.SetParent(transform.parent);
					shotpre.transform.SetAsFirstSibling ();
				}
			}
		}
	}

}
