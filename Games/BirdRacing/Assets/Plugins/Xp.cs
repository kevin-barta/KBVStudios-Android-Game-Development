using UnityEngine;
using System.Collections;

public class Xp : MonoBehaviour {

	public static void SetXp (int XP){
		XP += int.Parse(PlayerPref.GetString (15));
		if (XP > 127499){
			XP = 127499;
		}
		PlayerPref.SetString (15, XP.ToString());
	}

	public static int GetXp (){
		int XP = int.Parse(PlayerPref.GetString (15));
		return XP;
	}

	public static string GetMinMaxLevel (){
		int Level = int.Parse (PlayerPref.GetString (15));
		Level = Mathf.FloorToInt(Mathf.Sqrt(0.25f + (Level * 0.02f)) - 0.5f);
		int LevelMax = Level + 1;
		if(Level < 50){
			Level = 50 * (Level * (Level + 1));
			LevelMax = (50 * (LevelMax * (LevelMax + 1))) - 1;
		}
		else if(Level >= 50){
			Level = 127500;
			LevelMax = 127500;
		}
		string MinMaxLevel = Level.ToString("000000") + LevelMax.ToString("000000");
		return MinMaxLevel;
	}

	public static int GetLevel (){
		int Level = int.Parse(PlayerPref.GetString (15));
		Level = Mathf.CeilToInt(Mathf.Sqrt(0.25f + (Level * 0.02f)) - 0.5f);
		return Level;
	}
}