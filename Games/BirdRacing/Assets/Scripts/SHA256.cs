using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SHA256 : MonoBehaviour {
	private int BodyType;
	private int WingType;
	private int ClawType;
	private int EyeType;
	private int BeakType;
	public Image Body;
	public Image Wing1;
	public Image Wing2;
	public Image Claw1;
	public Image Claw2;
	public Image Eye1;
	public Image Eye2;
	public Image Eye1Back;
	public Image Eye2Back;
	public Image Beak;
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
	public Slider SliderWingSize;
	public Slider SliderBody;
	public Slider SliderWing;
	public Slider SliderClaw;
	public Slider SliderEye;
	public Slider SliderBeak;
	public Image BodyKnob;
	public Image WingKnob;
	public Image ClawKnob;
	public Image EyeKnob;
	public Image BeakKnob;
	private int section = 0;
	private int type = 0;

	void Start (){
		SliderData ();
		Eye1Back.color = new Color(1f, 1f, 1f, 1f);
		Eye2Back.color = new Color(1f, 1f, 1f, 1f);
	}

	public void Store (string cdata1){
		string cdata2 = cdata1.Substring (0, 2);
		cdata1 = cdata1.Substring (2);
		PlayerPref.SetString (int.Parse(cdata2), cdata1);
		SliderData ();
	}

	public void OnValueChanged (float wingsize){
		PlayerPref.SetString (5, wingsize.ToString());
		SliderData ();
	}
	
	public void OnValueChangedBody (float Hue){
		PlayerPref.SetString (2, Hue.ToString("0000"));
		SliderData ();
	}
	
	public void OnValueChangedWing (float Hue){
		PlayerPref.SetString (4, Hue.ToString("0000"));
		SliderData ();
	}
	
	public void OnValueChangedClaw (float Hue){
		PlayerPref.SetString (7, Hue.ToString("0000"));
		SliderData ();
	}
	
	public void OnValueChangedEye (float Hue){
		PlayerPref.SetString (9, Hue.ToString("0000"));
		SliderData ();
	}
	
	public void OnValueChangedBeak (float Hue){
		PlayerPref.SetString (11, Hue.ToString("0000"));
		SliderData ();
	}
		
	public void SliderData () {
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
			Wing1.rectTransform.localPosition = new Vector2(-165.1f, Wing1.rectTransform.localPosition.y);
			Wing2.rectTransform.localPosition = new Vector2(-115.1f, Wing2.rectTransform.localPosition.y);
		}
		else if(BodyType == 1 || BodyType == 2 || BodyType == 4 || BodyType == 5 || BodyType == 6 || BodyType == 7){
			Wing1.rectTransform.localPosition = new Vector2(-145.1f, Wing1.rectTransform.localPosition.y);
			Wing2.rectTransform.localPosition = new Vector2(-135.1f, Wing2.rectTransform.localPosition.y);
		}
		Body.color = new Color (BodyRed / 255f, BodyGreen / 255f, BodyBlue / 255f);
		Body.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Bodies/Bodies_" + BodyType);
		SliderBody.value = BodyHue;
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
		Wing1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + WingType);
		Wing2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + WingType);
		SliderWing.value = WingHue;
		if(WingSize != 0){
			SliderWingSize.value = WingSize;
			Wing1.rectTransform.sizeDelta = new Vector2( WingSize, 98);
			Wing2.rectTransform.sizeDelta = new Vector2( WingSize, 98);
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
		Claw1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + ClawType);
		Claw2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + ClawType);
		SliderClaw.value = ClawHue;
		EyeType = int.Parse (PlayerPref.GetString (8));
		EyeType = EyeType - 1;
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
		Eye1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + EyeType);
		Eye2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + EyeType);
		SliderEye.value = EyeHue;
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
		Beak.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Beaks/Beaks_" + BeakType);
		SliderBeak.value = BeakHue;
	}
	
	public void Preview (string view){
		section = int.Parse(view.Substring(0,2));
		type = int.Parse(view.Substring(2));
		type = type - 1;
		if(section == 1){
			if(type == 0 || type == 3 || type == 8 || type == 9){
				Wing1.rectTransform.localPosition = new Vector2(-165.1f, Wing1.rectTransform.localPosition.y);
				Wing2.rectTransform.localPosition = new Vector2(-115.1f, Wing2.rectTransform.localPosition.y);
			}
			else if(type == 1 || type == 2 || type == 4 || type == 5 || type == 6 || type == 7){
				Wing1.rectTransform.localPosition = new Vector2(-145.1f, Wing1.rectTransform.localPosition.y);
				Wing2.rectTransform.localPosition = new Vector2(-135.1f, Wing2.rectTransform.localPosition.y);
			}
			Body.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Bodies/Bodies_" + type);
			Body.color = new Color(BodyKnob.color.r, BodyKnob.color.g, BodyKnob.color.b, 1f);
		}
		if(section == 3){
			Wing1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + type);
			Wing2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Wings/Wings_" + type);
			Wing1.color = new Color(WingKnob.color.r, WingKnob.color.g, WingKnob.color.b, 1f);
			Wing2.color = new Color(WingKnob.color.r, WingKnob.color.g, WingKnob.color.b, 1f);
		}
		if(section == 6){
			Claw1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + type);
			Claw2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Claws/Claws_" + type);
			Claw1.color = new Color(ClawKnob.color.r, ClawKnob.color.g, ClawKnob.color.b, 1f);
			Claw2.color = new Color(ClawKnob.color.r, ClawKnob.color.g, ClawKnob.color.b, 1f);
		}
		if(section == 8){
			Eye1.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + type);
			Eye2.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Eyes/Eyes_" + type);
			Eye1.color = new Color(EyeKnob.color.r, EyeKnob.color.g, EyeKnob.color.b, 1f);
			Eye2.color = new Color(EyeKnob.color.r, EyeKnob.color.g, EyeKnob.color.b, 1f);
		}
		if(section == 10){
			Beak.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Beaks/Beaks_" + type);
			Beak.color = new Color(BeakKnob.color.r, BeakKnob.color.g, BeakKnob.color.b, 1f);
		}
	}
}