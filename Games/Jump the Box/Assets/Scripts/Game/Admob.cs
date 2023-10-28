using UnityEngine;
using System.Collections;
using System;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour {

	private InterstitialAd interstitial;

	void Start (){
		BannerAd ();
	}

	void Update (){
		if (interstitial.IsLoaded ()) {
			interstitial.Show ();
		}
	}

	public void BannerAd () {

		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(
			"ca-app-pub-8870763355959902/3674961078", AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
		bannerView.Show ();

		interstitial = new InterstitialAd("ca-app-pub-8870763355959902/6086383879");
		interstitial.LoadAd(new AdRequest.Builder().Build());
	}

}
