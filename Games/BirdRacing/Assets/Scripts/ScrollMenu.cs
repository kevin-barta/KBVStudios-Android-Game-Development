using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class ScrollMenu : MonoBehaviour {

	public SHA256 Encryption;
	public ScrollRect ScrollArea;
	public RectTransform SelectionMenu1;
	public RectTransform BodiesMenu1;
	public RectTransform WingsMenu1;
	public RectTransform ClawsMenu1;
	public RectTransform EyesMenu1;
	public RectTransform BeaksMenu1;
	public RectTransform AccessoriesMenu1;
	public GameObject Back1;
	public GameObject Next1;
	public GameObject SelectionMenu;
	public GameObject BodiesMenu;
	public GameObject WingsMenu;
	public GameObject ClawsMenu;
	public GameObject EyesMenu;
	public GameObject BeaksMenu;
	public GameObject AccessoriesMenu;
	public GameObject BodiesColour;
	public GameObject WingsColour;
	public GameObject ClawsColour;
	public GameObject EyesColour;
	public GameObject BeaksColour;
	public GameObject AccessoriesColour;
	public GameObject AccessoriesImg;
	public GameObject Eyes1BackImg;
	public GameObject Eyes2BackImg;
	public GameObject Eyes1Img;
	public GameObject Eyes2Img;
	public GameObject BeaksImg;
	public Text CircleText;
	public Text TriangleText;
	public Text OvalText;
	public Text SquareText;
	public Text RectangleText;
	public Text PentagonText;
	public Text ConeText;
	public Text DiamondText;
	public Text StarText;
	public Text HeartText;
	public Text TripleCurvedWingText;
	public Text DoubleCurvedWingText;
	public Text SingleCurvedWingText;
	public Text LowerCurvedWingText;
	public Text CenterCurvedWingText;
	public Text UpperCurvedWingText;
	public Text LowerPointedWingText;
	public Text CenterPointedWingText;
	public Text UpperPointedWingText;
	public Text SingleClawedText;
	public Text DoubleClawedText;
	public Text TripleClawedText;
	public Text Eye1Text;
	public Text Beak1Text;
	public Image CircleImage;
	public Image TriangleImage;
	public Image OvalImage;
	public Image SquareImage;
	public Image RectangleImage;
	public Image PentagonImage;
	public Image ConeImage;
	public Image DiamondImage;
	public Image StarImage;
	public Image HeartImage;
	public Image TripleCurvedWingImage;
	public Image DoubleCurvedWingImage;
	public Image SingleCurvedWingImage;
	public Image LowerCurvedWingImage;
	public Image CenterCurvedWingImage;
	public Image UpperCurvedWingImage;
	public Image LowerPointedWingImage;
	public Image CenterPointedWingImage;
	public Image UpperPointedWingImage;
	public Image SingleClawedImage;
	public Image DoubleClawedImage;
	public Image TripleClawedImage;
	public Image Eye1Image;
	public Image Beak1Image;
	
	void Start () {
		CircleText.GetComponent<Text>().text = "Circle Body";
		TriangleText.GetComponent<Text>().text = "Triangle Body";
		OvalText.GetComponent<Text>().text = "Oval Body";
		SquareText.GetComponent<Text>().text = "Square Body";
		RectangleText.GetComponent<Text>().text = "Rectangle Body";
		PentagonText.GetComponent<Text>().text = "Pentagon Body";
		ConeText.GetComponent<Text>().text = "Cone Body";
		DiamondText.GetComponent<Text>().text = "Diamond Body";
		StarText.GetComponent<Text>().text = "Star Body";
		HeartText.GetComponent<Text>().text = "Heart Body";
		TripleCurvedWingText.GetComponent<Text>().text = "Triple-Curved Wing";
		DoubleCurvedWingText.GetComponent<Text>().text = "Double-Curved Wing";
		SingleCurvedWingText.GetComponent<Text>().text = "Single-Curved Wing";
		LowerCurvedWingText.GetComponent<Text>().text = "Lower-Curved Wing";
		CenterCurvedWingText.GetComponent<Text>().text = "Center-Curved Wing";
		UpperCurvedWingText.GetComponent<Text>().text = "Upper-Curved Wing";
		LowerPointedWingText.GetComponent<Text>().text = "Lower-Pointed Wing";
		CenterPointedWingText.GetComponent<Text>().text = "Center-Pointed Wing";
		UpperPointedWingText.GetComponent<Text>().text = "Upper-Pointed Wing";
		SingleClawedText.GetComponent<Text>().text = "Single-Clawed";
		DoubleClawedText.GetComponent<Text>().text = "Double-Clawed";
		TripleClawedText.GetComponent<Text>().text = "Triple-Clawed";
		Eye1Text.GetComponent<Text>().text = "Eye 1";
		Beak1Text.GetComponent<Text>().text = "Beak 1";
		Sprite [] imgbodies = Resources.LoadAll<Sprite>("Bodies");
		CircleImage.GetComponent<Image>().sprite = imgbodies[0];
		TriangleImage.GetComponent<Image>().sprite = imgbodies[1];
		OvalImage.GetComponent<Image>().sprite = imgbodies[2];
		SquareImage.GetComponent<Image>().sprite = imgbodies[3];
		RectangleImage.GetComponent<Image>().sprite = imgbodies[4];
		PentagonImage.GetComponent<Image>().sprite = imgbodies[5];
		ConeImage.GetComponent<Image>().sprite = imgbodies[6];
		DiamondImage.GetComponent<Image>().sprite = imgbodies[7];
		StarImage.GetComponent<Image>().sprite = imgbodies[8];
		HeartImage.GetComponent<Image>().sprite = imgbodies[9];
		Sprite [] imgwings = Resources.LoadAll<Sprite>("Wings");
		TripleCurvedWingImage.GetComponent<Image>().sprite = imgwings[0];
		DoubleCurvedWingImage.GetComponent<Image>().sprite = imgwings[1];
		SingleCurvedWingImage.GetComponent<Image>().sprite = imgwings[2];
		LowerCurvedWingImage.GetComponent<Image>().sprite = imgwings[3];
		CenterCurvedWingImage.GetComponent<Image>().sprite = imgwings[4];
		UpperCurvedWingImage.GetComponent<Image>().sprite = imgwings[5];
		LowerPointedWingImage.GetComponent<Image>().sprite = imgwings[6];
		CenterPointedWingImage.GetComponent<Image>().sprite = imgwings[7];
		UpperPointedWingImage.GetComponent<Image>().sprite = imgwings[8];
		Sprite [] imgclaws = Resources.LoadAll<Sprite>("Claws");
		SingleClawedImage.GetComponent<Image>().sprite = imgclaws[0];
		DoubleClawedImage.GetComponent<Image>().sprite = imgclaws[1];
		TripleClawedImage.GetComponent<Image>().sprite = imgclaws[2];
		Sprite [] imgeyes = Resources.LoadAll<Sprite>("Eyes");
		Eye1Image.GetComponent<Image>().sprite = imgeyes[1];
		Sprite [] imgbeaks = Resources.LoadAll<Sprite>("Beaks");
		Beak1Image.GetComponent<Image>().sprite = imgbeaks[0];
	}

	public void Selection () {
		Encryption.SliderData();
		SelectionMenu.SetActive (true);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = SelectionMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (true);
		Next1.SetActive (true);
	}

	public void Bodies () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (true);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = BodiesMenu1;
		BodiesColour.SetActive (true);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Back ();
	}

	public void Wings () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (true);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = WingsMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (true);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Back ();
	}

	public void Claws () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (true);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = ClawsMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (true);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Back ();
	}

	public void Eyes () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (true);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = EyesMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (true);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Front ();
	}

	public void Beaks () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (true);
		AccessoriesMenu.SetActive (false);
		ScrollArea.content = BeaksMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (true);
		AccessoriesColour.SetActive (false);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Front ();
	}

	public void Accessories () {
		SelectionMenu.SetActive (false);
		BodiesMenu.SetActive (false);
		WingsMenu.SetActive (false);
		ClawsMenu.SetActive (false);
		EyesMenu.SetActive (false);
		BeaksMenu.SetActive (false);
		AccessoriesMenu.SetActive (true);
		ScrollArea.content = AccessoriesMenu1;
		BodiesColour.SetActive (false);
		WingsColour.SetActive (false);
		ClawsColour.SetActive (false);
		EyesColour.SetActive (false);
		BeaksColour.SetActive (false);
		AccessoriesColour.SetActive (true);
		Back1.SetActive (false);
		Next1.SetActive (false);
		Back ();
	}

	public void Back (){
		Encryption.SliderData();
		AccessoriesImg.SetActive (true);
		Eyes1BackImg.SetActive (false);
		Eyes2BackImg.SetActive (false);
		Eyes1Img.SetActive (false);
		Eyes2Img.SetActive (false);
		BeaksImg.SetActive (false);
	}

	public void Front (){
		Encryption.SliderData();
		AccessoriesImg.SetActive (false);
		Eyes1BackImg.SetActive (true);
		Eyes2BackImg.SetActive (true);
		Eyes1Img.SetActive (true);
		Eyes2Img.SetActive (true);
		BeaksImg.SetActive (true);
	}
}