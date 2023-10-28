using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	private int BodyType;
	private int WingType;
	private int ClawType;
	private int EyeType;
	private int BeakType;
	public SpriteRenderer Body;
	public SpriteRenderer Wing1;
	public SpriteRenderer Wing2;
	public SpriteRenderer Claw1;
	public SpriteRenderer Claw2;
	public SpriteRenderer Eye1;
	public SpriteRenderer Eye2;
	public SpriteRenderer Eye1Back;
	public SpriteRenderer Eye2Back;
	public SpriteRenderer Beak;
	public SpriteRenderer Wing1_1;
	public SpriteRenderer Wing2_1;
	public SpriteRenderer Wing1_2;
	public SpriteRenderer Wing2_2;
	public SpriteRenderer Wing1_3;
	public SpriteRenderer Wing2_3;
	public SpriteRenderer Wing1_4;
	public SpriteRenderer Wing2_4;
	public SpriteRenderer Wing1_5;
	public SpriteRenderer Wing2_5;
	public SpriteRenderer Wing1_6;
	public SpriteRenderer Wing2_6;
	public SpriteRenderer Wing1_7;
	public SpriteRenderer Wing2_7;
	public GameObject MainCamera;
	public GameObject Bird1;
	public GameObject Bird2;
	public GameObject Bird3;
	public GameObject Bird4;
	public GameObject Bird5;
	public GameObject Bird6;
	public GameObject Bird7;
	public GameObject Bird8;
	public GameObject Front1;
	public GameObject Back1;
	public GameObject Front2;
	public GameObject Back2;
	public GameObject Front3;
	public GameObject Back3;
	public GameObject Front4;
	public GameObject Back4;
	public GameObject Front5;
	public GameObject Back5;
	public GameObject Front6;
	public GameObject Back6;
	public GameObject Front7;
	public GameObject Back7;
	public GameObject Front8;
	public GameObject Back8;
	private int BodyHue = 0;
	private int BodyRed = 0;
	private int BodyGreen = 0;
	private int BodyBlue = 0;
	private int WingHue = 0;
	private int WingRed = 0;
	private int WingGreen = 0;
	private int WingBlue = 0;
	private int ClawHue = 0;
	private int ClawRed = 0;
	private int ClawGreen = 0;
	private int ClawBlue = 0;
	private int EyeHue = 0;
	private int EyeRed = 0;
	private int EyeGreen = 0;
	private int EyeBlue = 0;
	private int BeakHue = 0;
	private int BeakRed = 0;
	private int BeakGreen = 0;
	private int BeakBlue = 0;
	private float WingSize = 0f;
	private int RotCamera = 0;
	private int RotBird1 = 0;
	private int RotBird2 = 0;
	private int RotBird3 = 0;
	private int RotBird4 = 0;
	private int RotBird5 = 0;
	private int RotBird6 = 0;
	private int RotBird7 = 0;
	private int RotBird8 = 0;
	private int MoveReady = 0;
	private int MoveReady1 = 10;
	private float MoveTime1 = 0f;
	private int MoveReady2 = 10;
	private float MoveTime2 = 0f;
	private int MoveReady3 = 10;
	private float MoveTime3 = 0f;
	private int MoveReady4 = 10;
	private float MoveTime4 = 0f;
	private int MoveReady5 = 10;
	private float MoveTime5 = 0f;
	private int MoveReady6 = 10;
	private float MoveTime6 = 0f;
	private int MoveReady7 = 10;
	private float MoveTime7 = 0f;
	private int MoveReady8 = 10;
	private float MoveTime8 = 0f;
	
	void Start (){
		StartCoroutine(WaitForStart());
		BodyType = int.Parse (PlayerPref.GetString (1));
		BodyType = BodyType - 1;
		BodyHue = int.Parse (PlayerPref.GetString(2));
		if(BodyHue >= 1276){
			BodyRed = 255;
			BodyGreen = 0;
			BodyBlue = 1530 - BodyHue;
		}
		else if(BodyHue >= 1021){
			BodyRed = BodyHue - 1020;
			BodyGreen = 0;
			BodyBlue = 255;
		}
		else if(BodyHue >= 766){
			BodyRed = 0;
			BodyGreen = 1020 - BodyHue;
			BodyBlue = 255;
		}
		else if(BodyHue >= 511){
			BodyRed = 0;
			BodyGreen = 255;
			BodyBlue = BodyHue - 510;
		}
		else if(BodyHue >= 256){
			BodyRed = 510 - BodyHue;
			BodyGreen = 255;
			BodyBlue = 0;
		}
		else if(BodyHue >= 0){
			BodyRed = 255;
			BodyGreen = BodyHue;
			BodyBlue = 0;
		}
		if(BodyType == 0 || BodyType == 3 || BodyType == 8 || BodyType == 9){
			Wing1.transform.localPosition = new Vector2(-1.3f, Wing1.transform.localPosition.y);
			Wing2.transform.localPosition = new Vector2(1.3f, Wing2.transform.localPosition.y);
		}
		else if(BodyType == 1 || BodyType == 2 || BodyType == 4 || BodyType == 5 || BodyType == 6 || BodyType == 7){
			Wing1.transform.localPosition = new Vector2(-0.9f, Wing1.transform.localPosition.y);
			Wing2.transform.localPosition = new Vector2(0.9f, Wing2.transform.localPosition.y);
		}
		Body.color = new Color (BodyRed / 255f, BodyGreen / 255f, BodyBlue / 255f);
		Body.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Bodies/Bodies_" + BodyType);
		WingType = int.Parse (PlayerPref.GetString(3));
		WingType = WingType - 1;
		WingHue = int.Parse (PlayerPref.GetString(4));
		WingSize = float.Parse (PlayerPref.GetString(5));
		if(WingHue >= 1276){
			WingRed = 255;
			WingGreen = 0;
			WingBlue = 1530 - WingHue;
		}
		else if(WingHue >= 1021){
			WingRed = WingHue - 1020;
			WingGreen = 0;
			WingBlue = 255;
		}
		else if(WingHue >= 766){
			WingRed = 0;
			WingGreen = 1020 - WingHue;
			WingBlue = 255;
		}
		else if(WingHue >= 511){
			WingRed = 0;
			WingGreen = 255;
			WingBlue = WingHue - 510;
		}
		else if(WingHue >= 256){
			WingRed = 510 - WingHue;
			WingGreen = 255;
			WingBlue = 0;
		}	
		else if(WingHue >= 0){
			WingRed = 255;
			WingGreen = WingHue;
			WingBlue = 0;
		}
		Wing1.color = new Color (WingRed / 255f, WingGreen / 255f, WingBlue / 255f);
		Wing2.color = new Color (WingRed / 255f, WingGreen / 255f, WingBlue / 255f);
		Wing1.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + WingType);
		Wing2.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + WingType);
		if(WingSize != 0){
			Wing1.transform.localScale = new Vector3(WingSize * 0.018f, WingSize * 0.018f, WingSize * 0.018f);
			Wing2.transform.localScale = new Vector3(WingSize * 0.018f, WingSize * 0.018f, WingSize * 0.018f);
		}
		ClawType = int.Parse (PlayerPref.GetString (6));
		ClawType = ClawType - 1;
		ClawHue = int.Parse (PlayerPref.GetString(7));
		if(ClawHue >= 1276){
			ClawRed = 255;
			ClawGreen = 0;
			ClawBlue = 1530 - ClawHue;
		}
		else if(ClawHue >= 1021){
			ClawRed = ClawHue - 1020;
			ClawGreen = 0;
			ClawBlue = 255;
		}
		else if(ClawHue >= 766){
			ClawRed = 0;
			ClawGreen = 1020 - ClawHue;
			ClawBlue = 255;
		}
		else if(ClawHue >= 511){
			ClawRed = 0;
			ClawGreen = 255;
			ClawBlue = ClawHue - 510;
		}
		else if(ClawHue >= 256){
			ClawRed = 510 - ClawHue;
			ClawGreen = 255;
			ClawBlue = 0;
		}
		else if(ClawHue >= 0){
			ClawRed = 255;
			ClawGreen = ClawHue;
			ClawBlue = 0;
		}
		Claw1.color = new Color (ClawRed / 255f, ClawGreen / 255f, ClawBlue / 255f);
		Claw2.color = new Color (ClawRed / 255f, ClawGreen / 255f, ClawBlue / 255f);
		Claw1.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + ClawType);
		Claw2.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + ClawType);
		EyeType = int.Parse (PlayerPref.GetString (8));
		EyeHue = int.Parse (PlayerPref.GetString(9));
		if(EyeHue >= 1276){
			EyeRed = 255;
			EyeGreen = 0;
			EyeBlue = 1530 - EyeHue;
		}
		else if(EyeHue >= 1021){
			EyeRed = EyeHue - 1020;
			EyeGreen = 0;
			EyeBlue = 255;
		}
		else if(EyeHue >= 766){
			EyeRed = 0;
			EyeGreen = 1020 - EyeHue;
			EyeBlue = 255;
		}
		else if(EyeHue >= 511){
			EyeRed = 0;
			EyeGreen = 255;
			EyeBlue = EyeHue - 510;
		}
		else if(EyeHue >= 256){
			EyeRed = 510 - EyeHue;
			EyeGreen = 255;
			EyeBlue = 0;
		}
		else if(EyeHue >= 0){
			EyeRed = 255;
			EyeGreen = EyeHue;
			EyeBlue = 0;
		}
		Eye1.color = new Color (EyeRed / 255f, EyeGreen / 255f, EyeBlue / 255f);
		Eye2.color = new Color (EyeRed / 255f, EyeGreen / 255f, EyeBlue / 255f);
		Eye1.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + EyeType);
		Eye2.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + EyeType);
		BeakType = int.Parse (PlayerPref.GetString (10));
		BeakType = BeakType - 1;
		BeakHue = int.Parse (PlayerPref.GetString(11));
		if(BeakHue >= 1276){
			BeakRed = 255;
			BeakGreen = 0;
			BeakBlue = 1530 - BeakHue;
		}
		else if(BeakHue >= 1021){
			BeakRed = BeakHue - 1020;
			BeakGreen = 0;
			BeakBlue = 255;
		}
		else if(BeakHue >= 766){
			BeakRed = 0;
			BeakGreen = 1020 - BeakHue;
			BeakBlue = 255;
		}
		else if(BeakHue >= 511){
			BeakRed = 0;
			BeakGreen = 255;
			BeakBlue = BeakHue - 510;
		}
		else if(BeakHue >= 256){
			BeakRed = 510 - BeakHue;
			BeakGreen = 255;
			BeakBlue = 0;
		}
		else if(BeakHue >= 0){
			BeakRed = 255;
			BeakGreen = BeakHue;
			BeakBlue = 0;
		}
		Beak.color = new Color (BeakRed / 255f, BeakGreen / 255f, BeakBlue / 255f);
		Beak.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Beaks/Beaks_" + BeakType);
	}
	
	void Update (){
		RotCamera = Mathf.RoundToInt(MainCamera.transform.eulerAngles.y);
		int NCamera = 0;
		RotCamera = Mathf.Abs(RotCamera);
		if(RotCamera > 360){
			NCamera = Mathf.FloorToInt(RotCamera / 360);
			RotCamera = RotCamera - (NCamera * 360);
		}
		RotBird1 = Mathf.RoundToInt(Bird1.transform.eulerAngles.y);
		int NBird1 = 0;
		RotBird1 = Mathf.Abs(RotBird1);
		if(RotBird1 > 360){
			NBird1 = Mathf.FloorToInt(RotBird1 / 360);
			RotBird1 = RotBird1 - (NBird1 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird1) < 180){
			Back1.SetActive(true);
			Front1.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird1) > 180){
			Front1.SetActive(true);
			Back1.SetActive(false);
		}
		RotBird2 = Mathf.RoundToInt(Bird2.transform.eulerAngles.y);
		int NBird2 = 0;
		RotBird2 = Mathf.Abs(RotBird2);
		if(RotBird2 > 360){
			NBird2 = Mathf.FloorToInt(RotBird2 / 360);
			RotBird2 = RotBird2 - (NBird2 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird2) < 180){
			Back2.SetActive(true);
			Front2.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird2) > 180){
			Front2.SetActive(true);
			Back2.SetActive(false);
		}
		RotBird3 = Mathf.RoundToInt(Bird3.transform.eulerAngles.y);
		int NBird3 = 0;
		RotBird3 = Mathf.Abs(RotBird3);
		if(RotBird3 > 360){
			NBird3 = Mathf.FloorToInt(RotBird3 / 360);
			RotBird3 = RotBird3 - (NBird3 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird3) < 180){
			Back3.SetActive(true);
			Front3.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird3) > 180){
			Front3.SetActive(true);
			Back3.SetActive(false);
		}
		RotBird4 = Mathf.RoundToInt(Bird4.transform.eulerAngles.y);
		int NBird4 = 0;
		RotBird4 = Mathf.Abs(RotBird4);
		if(RotBird4 > 360){
			NBird4 = Mathf.FloorToInt(RotBird4 / 360);
			RotBird4 = RotBird4 - (NBird4 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird4) < 180){
			Back4.SetActive(true);
			Front4.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird4) > 180){
			Front4.SetActive(true);
			Back4.SetActive(false);
		}
		RotBird5 = Mathf.RoundToInt(Bird5.transform.eulerAngles.y);
		int NBird5 = 0;
		RotBird5 = Mathf.Abs(RotBird5);
		if(RotBird5 > 360){
			NBird5 = Mathf.FloorToInt(RotBird5 / 360);
			RotBird5 = RotBird5 - (NBird5 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird5) < 180){
			Back5.SetActive(true);
			Front5.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird5) > 180){
			Front5.SetActive(true);
			Back5.SetActive(false);
		}
		RotBird6 = Mathf.RoundToInt(Bird6.transform.eulerAngles.y);
		int NBird6 = 0;
		RotBird6 = Mathf.Abs(RotBird6);
		if(RotBird6 > 360){
			NBird6 = Mathf.FloorToInt(RotBird6 / 360);
			RotBird6 = RotBird6 - (NBird6 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird6) < 180){
			Back6.SetActive(true);
			Front6.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird6) > 180){
			Front6.SetActive(true);
			Back6.SetActive(false);
		}
		RotBird7 = Mathf.RoundToInt(Bird7.transform.eulerAngles.y);
		int NBird7 = 0;
		RotBird7 = Mathf.Abs(RotBird7);
		if(RotBird7 > 360){
			NBird7 = Mathf.FloorToInt(RotBird7 / 360);
			RotBird7 = RotBird7 - (NBird7 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird7) < 180){
			Back7.SetActive(true);
			Front7.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird7) > 180){
			Front7.SetActive(true);
			Back7.SetActive(false);
		}
		RotBird8 = Mathf.RoundToInt(Bird8.transform.eulerAngles.y);
		int NBird8 = 0;
		RotBird8 = Mathf.Abs(RotBird8);
		if(RotBird8 > 360){
			NBird8 = Mathf.FloorToInt(RotBird8 / 360);
			RotBird8 = RotBird8 - (NBird8 * 360);
		}
		if(Mathf.Abs(RotCamera - RotBird8) < 180){
			Back8.SetActive(true);
			Front8.SetActive(false);	
		}
		else if(Mathf.Abs(RotCamera - RotBird8) > 180){
			Front8.SetActive(true);
			Back8.SetActive(false);
		}
		if(MoveReady == 10){
			if(MoveReady1 == 10){
				MoveReady1 = 0;
				MoveTime1 = Time.time;
			}
			if(MoveReady1 == 0){
				Wing1_1.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime1) * 4f);
				Wing2_1.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime1) * 4f);
				Wing1_1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime1) * 4f);
				Wing2_1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime1) * 4f);
				if((Time.time - MoveTime1) * 3f >= 1){
					MoveReady1 = 10;
				}
			}
			if(MoveReady2 == 10){
				MoveReady2 = 0;
				MoveTime2 = Time.time;
			}
			if(MoveReady2 == 0){
				Wing1_2.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime2) * 4f);
				Wing2_2.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime2) * 4f);
				Wing1_2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime2) * 4f);
				Wing2_2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime2) * 4f);
				if((Time.time - MoveTime2) * 3f >= 1){
					MoveReady2 = 10;
				}
			}
			if(MoveReady3 == 10){
				MoveReady3 = 0;
				MoveTime3 = Time.time;
			}
			if(MoveReady3 == 0){
				Wing1_3.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime3) * 4f);
				Wing2_3.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime3) * 4f);
				Wing1_3.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime3) * 4f);
				Wing2_3.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime3) * 4f);
				if((Time.time - MoveTime3) * 3f >= 1){
					MoveReady3 = 10;
				}
			}
			if(MoveReady4 == 10){
				MoveReady4 = 0;
				MoveTime4 = Time.time;
			}
			if(MoveReady4 == 0){
				Wing1_4.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime4) * 4f);
				Wing2_4.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime4) * 4f);
				Wing1_4.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime4) * 4f);
				Wing2_4.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime4) * 4f);
				if((Time.time - MoveTime4) * 3f >= 1){
					MoveReady4 = 10;
				}
			}
			if(MoveReady5 == 10){
				MoveReady5 = 0;
				MoveTime5 = Time.time;
			}
			if(MoveReady5 == 0){
				Wing1_5.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime5) * 4f);
				Wing2_5.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime5) * 4f);
				Wing1_5.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime5) * 4f);
				Wing2_5.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime5) * 4f);
				if((Time.time - MoveTime5) * 3f >= 1){
					MoveReady5 = 10;
				}
			}
			if(MoveReady6 == 10){
				MoveReady6 = 0;
				MoveTime6 = Time.time;
			}
			if(MoveReady6 == 0){
				Wing1_6.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime6) * 4f);
				Wing2_6.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime6) * 4f);
				Wing1_6.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime6) * 4f);
				Wing2_6.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime6) * 4f);
				if((Time.time - MoveTime6) * 3f >= 1){
					MoveReady6 = 10;
				}
			}
			if(MoveReady7 == 10){
				MoveReady7 = 0;
				MoveTime7 = Time.time;
			}
			if(MoveReady7 == 0){
				Wing1_7.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime7) * 4f);
				Wing2_7.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime7) * 4f);
				Wing1_7.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime7) * 4f);
				Wing2_7.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime7) * 4f);
				if((Time.time - MoveTime7) * 3f >= 1){
					MoveReady7 = 10;
				}
			}
			if(MoveReady8 == 10){
				MoveReady8 = 0;
				MoveTime8 = Time.time;
			}
			if(MoveReady8 == 0){
				if(BodyType == 0 || BodyType == 3 || BodyType == 8 || BodyType == 9){
					Wing1.transform.localPosition = Vector3.Lerp(new Vector3(-1.3f, -0.3f, 0), new Vector3(-1.3f, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing2.transform.localPosition = Vector3.Lerp(new Vector3(1.3f, -0.3f, 0), new Vector3(1.3f, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime8) * 4f);
				}
				else if(BodyType == 1 || BodyType == 2 || BodyType == 4 || BodyType == 5 || BodyType == 6 || BodyType == 7){
					Wing1.transform.localPosition = Vector3.Lerp(new Vector3(-0.9f, -0.3f, 0), new Vector3(-0.9f, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing2.transform.localPosition = Vector3.Lerp(new Vector3(0.9f, -0.3f, 0), new Vector3(0.9f, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing1.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 30), Quaternion.Euler(0, 0, 0), (Time.time - MoveTime8) * 4f);
					Wing2.transform.localRotation = Quaternion.Lerp(Quaternion.Euler(0, -180, 30), Quaternion.Euler(0, -180, 0), (Time.time - MoveTime8) * 4f);
				}
				if((Time.time - MoveTime8) * 3f >= 1){
					MoveReady8 = 10;
				}
			}
		}
	}
	
	IEnumerator WaitForStart (){
		yield return new WaitForSeconds (7);
		MoveReady = 10;
	}
}