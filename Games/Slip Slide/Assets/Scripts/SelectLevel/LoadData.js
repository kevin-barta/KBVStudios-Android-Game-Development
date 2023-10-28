#pragma strict

public var level_1_gold : GameObject;
public var level_1_silver : GameObject;
public var level_2_gold : GameObject;
public var level_2_silver : GameObject;
public var level_2_lock : GameObject;
public var level_3_gold : GameObject;
public var level_3_silver : GameObject;
public var level_3_lock : GameObject;
public var level_4_gold : GameObject;
public var level_4_silver : GameObject;
public var level_4_lock : GameObject;
public var level_5_gold : GameObject;
public var level_5_silver : GameObject;
public var level_5_lock : GameObject;
public var level_6_gold : GameObject;
public var level_6_silver : GameObject;
public var level_6_lock : GameObject;
public var level_7_gold : GameObject;
public var level_7_silver : GameObject;
public var level_7_lock : GameObject;
public var level_8_gold : GameObject;
public var level_8_silver : GameObject;
public var level_8_lock : GameObject;
public var level_9_gold : GameObject;
public var level_9_silver : GameObject;
public var level_9_lock : GameObject;
public var level_10_gold : GameObject;
public var level_10_silver : GameObject;
public var level_10_lock : GameObject;
public var level_11_gold : GameObject;
public var level_11_silver : GameObject;
public var level_12_gold : GameObject;
public var level_12_silver : GameObject;
public var level_12_lock : GameObject;
public var level_13_gold : GameObject;
public var level_13_silver : GameObject;
public var level_13_lock : GameObject;
public var level_14_gold : GameObject;
public var level_14_silver : GameObject;
public var level_14_lock : GameObject;
public var level_15_gold : GameObject;
public var level_15_silver : GameObject;
public var level_15_lock : GameObject;
public var level_16_gold : GameObject;
public var level_16_silver : GameObject;
public var level_16_lock : GameObject;
public var level_17_gold : GameObject;
public var level_17_silver : GameObject;
public var level_17_lock : GameObject;
public var level_18_gold : GameObject;
public var level_18_silver : GameObject;
public var level_18_lock : GameObject;
public var level_19_gold : GameObject;
public var level_19_silver : GameObject;
public var level_19_lock : GameObject;
public var level_20_gold : GameObject;
public var level_20_silver : GameObject;
public var level_20_lock : GameObject;


function Start () {
if(PlayerPrefs.GetInt("1") == 2) {
level_1_gold.active = false;
level_1_silver.active = false;
}
if(PlayerPrefs.GetInt("1") == 3) {
level_1_gold.active = false;
level_1_silver.active = true;
}
if(PlayerPrefs.GetInt("1") == 4) {
level_1_gold.active = true;
level_1_silver.active = false;
}
if(PlayerPrefs.GetInt("2") == 2) {
level_2_gold.active = false;
level_2_silver.active = false;
level_2_lock.active = false;
}
if(PlayerPrefs.GetInt("2") == 3) {
level_2_gold.active = false;
level_2_silver.active = true;
level_2_lock.active = false;
}
if(PlayerPrefs.GetInt("2") == 4) {
level_2_gold.active = true;
level_2_silver.active = false;
level_2_lock.active = false;
}
if(PlayerPrefs.GetInt("3") == 2) {
level_3_gold.active = false;
level_3_silver.active = false;
level_3_lock.active = false;
}
if(PlayerPrefs.GetInt("3") == 3) {
level_3_gold.active = false;
level_3_silver.active = true;
level_3_lock.active = false;
}
if(PlayerPrefs.GetInt("3") == 4) {
level_3_gold.active = true;
level_3_silver.active = false;
level_3_lock.active = false;
}
if(PlayerPrefs.GetInt("4") == 2) {
level_4_gold.active = false;
level_4_silver.active = false;
level_4_lock.active = false;
}
if(PlayerPrefs.GetInt("4") == 3) {
level_4_gold.active = false;
level_4_silver.active = true;
level_4_lock.active = false;
}
if(PlayerPrefs.GetInt("4") == 4) {
level_4_gold.active = true;
level_4_silver.active = false;
level_4_lock.active = false;
}
if(PlayerPrefs.GetInt("5") == 2) {
level_5_gold.active = false;
level_5_silver.active = false;
level_5_lock.active = false;
}
if(PlayerPrefs.GetInt("5") == 3) {
level_5_gold.active = false;
level_5_silver.active = true;
level_5_lock.active = false;
}
if(PlayerPrefs.GetInt("5") == 4) {
level_5_gold.active = true;
level_5_silver.active = false;
level_5_lock.active = false;
}
if(PlayerPrefs.GetInt("6") == 2) {
level_6_gold.active = false;
level_6_silver.active = false;
level_6_lock.active = false;
}
if(PlayerPrefs.GetInt("6") == 3) {
level_6_gold.active = false;
level_6_silver.active = true;
level_6_lock.active = false;
}
if(PlayerPrefs.GetInt("6") == 4) {
level_6_gold.active = true;
level_6_silver.active = false;
level_6_lock.active = false;
}
if(PlayerPrefs.GetInt("7") == 2) {
level_7_gold.active = false;
level_7_silver.active = false;
level_7_lock.active = false;
}
if(PlayerPrefs.GetInt("7") == 3) {
level_7_gold.active = false;
level_7_silver.active = true;
level_7_lock.active = false;
}
if(PlayerPrefs.GetInt("7") == 4) {
level_7_gold.active = true;
level_7_silver.active = false;
level_7_lock.active = false;
}
if(PlayerPrefs.GetInt("8") == 2) {
level_8_gold.active = false;
level_8_silver.active = false;
level_8_lock.active = false;
}
if(PlayerPrefs.GetInt("8") == 3) {
level_8_gold.active = false;
level_8_silver.active = true;
level_8_lock.active = false;
}
if(PlayerPrefs.GetInt("8") == 4) {
level_8_gold.active = true;
level_8_silver.active = false;
level_8_lock.active = false;
}
if(PlayerPrefs.GetInt("9") == 2) {
level_9_gold.active = false;
level_9_silver.active = false;
level_9_lock.active = false;
}
if(PlayerPrefs.GetInt("9") == 3) {
level_9_gold.active = false;
level_9_silver.active = true;
level_9_lock.active = false;
}
if(PlayerPrefs.GetInt("9") == 4) {
level_9_gold.active = true;
level_9_silver.active = false;
level_9_lock.active = false;
}
if(PlayerPrefs.GetInt("10") == 2) {
level_10_gold.active = false;
level_10_silver.active = false;
level_10_lock.active = false;
}
if(PlayerPrefs.GetInt("10") == 3) {
level_10_gold.active = false;
level_10_silver.active = true;
level_10_lock.active = false;
}
if(PlayerPrefs.GetInt("10") == 4) {
level_10_gold.active = true;
level_10_silver.active = false;
level_10_lock.active = false;
}
if(PlayerPrefs.GetInt("11") == 2) {
level_11_gold.active = false;
level_11_silver.active = false;
}
if(PlayerPrefs.GetInt("11") == 3) {
level_11_gold.active = false;
level_11_silver.active = true;
}
if(PlayerPrefs.GetInt("11") == 4) {
level_11_gold.active = true;
level_11_silver.active = false;
}
if(PlayerPrefs.GetInt("12") == 2) {
level_12_gold.active = false;
level_12_silver.active = false;
level_12_lock.active = false;
}
if(PlayerPrefs.GetInt("12") == 3) {
level_12_gold.active = false;
level_12_silver.active = true;
level_12_lock.active = false;
}
if(PlayerPrefs.GetInt("12") == 4) {
level_12_gold.active = true;
level_12_silver.active = false;
level_12_lock.active = false;
}
if(PlayerPrefs.GetInt("13") == 2) {
level_13_gold.active = false;
level_13_silver.active = false;
level_13_lock.active = false;
}
if(PlayerPrefs.GetInt("13") == 3) {
level_13_gold.active = false;
level_13_silver.active = true;
level_13_lock.active = false;
}
if(PlayerPrefs.GetInt("13") == 4) {
level_13_gold.active = true;
level_13_silver.active = false;
level_13_lock.active = false;
}
if(PlayerPrefs.GetInt("14") == 2) {
level_14_gold.active = false;
level_14_silver.active = false;
level_14_lock.active = false;
}
if(PlayerPrefs.GetInt("14") == 3) {
level_14_gold.active = false;
level_14_silver.active = true;
level_14_lock.active = false;
}
if(PlayerPrefs.GetInt("14") == 4) {
level_14_gold.active = true;
level_14_silver.active = false;
level_14_lock.active = false;
}
if(PlayerPrefs.GetInt("15") == 2) {
level_15_gold.active = false;
level_15_silver.active = false;
level_15_lock.active = false;
}
if(PlayerPrefs.GetInt("15") == 3) {
level_15_gold.active = false;
level_15_silver.active = true;
level_15_lock.active = false;
}
if(PlayerPrefs.GetInt("15") == 4) {
level_15_gold.active = true;
level_15_silver.active = false;
level_15_lock.active = false;
}
if(PlayerPrefs.GetInt("16") == 2) {
level_16_gold.active = false;
level_16_silver.active = false;
level_16_lock.active = false;
}
if(PlayerPrefs.GetInt("16") == 3) {
level_16_gold.active = false;
level_16_silver.active = true;
level_16_lock.active = false;
}
if(PlayerPrefs.GetInt("16") == 4) {
level_16_gold.active = true;
level_16_silver.active = false;
level_16_lock.active = false;
}
if(PlayerPrefs.GetInt("17") == 2) {
level_17_gold.active = false;
level_17_silver.active = false;
level_17_lock.active = false;
}
if(PlayerPrefs.GetInt("17") == 3) {
level_17_gold.active = false;
level_17_silver.active = true;
level_17_lock.active = false;
}
if(PlayerPrefs.GetInt("17") == 4) {
level_17_gold.active = true;
level_17_silver.active = false;
level_17_lock.active = false;
}
if(PlayerPrefs.GetInt("18") == 2) {
level_18_gold.active = false;
level_18_silver.active = false;
level_18_lock.active = false;
}
if(PlayerPrefs.GetInt("18") == 3) {
level_18_gold.active = false;
level_18_silver.active = true;
level_18_lock.active = false;
}
if(PlayerPrefs.GetInt("18") == 4) {
level_18_gold.active = true;
level_18_silver.active = false;
level_18_lock.active = false;
}
if(PlayerPrefs.GetInt("19") == 2) {
level_19_gold.active = false;
level_19_silver.active = false;
level_19_lock.active = false;
}
if(PlayerPrefs.GetInt("19") == 3) {
level_19_gold.active = false;
level_19_silver.active = true;
level_19_lock.active = false;
}
if(PlayerPrefs.GetInt("19") == 4) {
level_19_gold.active = true;
level_19_silver.active = false;
level_19_lock.active = false;
}
if(PlayerPrefs.GetInt("20") == 2) {
level_20_gold.active = false;
level_20_silver.active = false;
level_20_lock.active = false;
}
if(PlayerPrefs.GetInt("20") == 3) {
level_20_gold.active = false;
level_20_silver.active = true;
level_20_lock.active = false;
}
if(PlayerPrefs.GetInt("20") == 4) {
level_20_gold.active = true;
level_20_silver.active = false;
level_20_lock.active = false;
}
}