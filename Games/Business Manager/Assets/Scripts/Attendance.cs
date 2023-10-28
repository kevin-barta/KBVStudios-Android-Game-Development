using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Attendance : tk2dUIBaseDemoController {

	public tk2dUILayout prefabItem;
	public tk2dUILayout attendanceLayout;
	float itemStride = 0;

	// Manually set up a scrollable area by working out offsets manually
	public tk2dUIScrollableArea scrollableArea;
	public tk2dTextMesh numItemsTextMesh;

	// This is a representation of an entry in the list. Replace with what you need here.
	// If you create this procedurally, you can have an infinite scrollable area
	class ItemDef {
		public int id = 0;
		public int colour = 0;
		public string name = "";
		public string attended = "";
		public string paid = "";
	}
	List<ItemDef> allItems = new List<ItemDef>();

	// Internal lists for caching
	List<Transform> cachedContentItems = new List<Transform>();
	List<Transform> unusedContentItems = new List<Transform>();
	int firstCachedItem = -1;
	int maxVisibleItems = 0;

	void OnEnable() {
		scrollableArea.OnScroll += OnScroll;
	}

	void OnDisable() {
		scrollableArea.OnScroll -= OnScroll;
	}

	void Start () {
		if((Screen.width / (Screen.height * 1f)) / 1.6f > 1){
			float v = (1 - ((Screen.width / (Screen.height * 1f)) / 1.6f)) / 0.745f;
			attendanceLayout.Reshape (new Vector3(v, 0), new Vector3(-v, 0), true);
		}
		else if((Screen.width / (Screen.height * 1f)) / 1.6f < 1){
			float v = (((Screen.width / (Screen.height * 1f)) / 1.6f) - 1) / 0.745f;
			attendanceLayout.Reshape (new Vector3(-v, 0), new Vector3(v, 0), true);
		}

		// Disable the prefab item
		// don't want it visible when the game is running, as it is in the scene
		prefabItem.transform.parent = null;
		DoSetActive( prefabItem.transform, false );

		// How many items do we need to buffer?
		itemStride = (prefabItem.GetMaxBounds() - prefabItem.GetMinBounds()).x;
		maxVisibleItems = Mathf.CeilToInt(scrollableArea.VisibleAreaLength / itemStride) + 1;

		// Buffer the prefabs that we will need
		float x = 0;
		for (int i = 0; i < maxVisibleItems; ++i) {
			tk2dUILayout layout = Instantiate(prefabItem) as tk2dUILayout;
			layout.transform.parent = scrollableArea.contentContainer.transform;
			layout.transform.localPosition = new Vector3(x, 0, 0);
			DoSetActive( layout.transform, false );
			unusedContentItems.Add( layout.transform );
			x += itemStride;
		}
	}

	void Update (){
		UpdateListGraphics ();
	}

	// Customize this function to fill the contents of the item at Id
	// This will be called as an item comes into view, so don't do any crazy
	// processing in here. It is possible to start a coroutine to cache a profile
	// picture, for instance.
	void CustomizeListObject( Transform contentRoot, int itemId ) {
		string sattended = allItems[itemId].attended;
		string spaid = allItems[itemId].paid;
		contentRoot.Find("Name").GetComponent<tk2dTextMesh>().text = allItems[itemId].name;
		contentRoot.Find("Colour").GetComponent<tk2dSprite>().color = Colour(allItems[itemId].colour);
		contentRoot.Find("Attended").GetComponent<tk2dTextMesh>().text = "Attended " + sattended.Substring(4, 2) + "/" + sattended.Substring(2, 2) + "/" + sattended.Substring(0, 2);
		contentRoot.Find("Paid").GetComponent<tk2dTextMesh>().text = "Paid " + spaid.Substring(4, 2) + "/" + spaid.Substring(2, 2) + "/" + spaid.Substring(0, 2);
		Texture2D tex = new Texture2D(2, 2);
		tex.LoadImage(System.IO.File.ReadAllBytes(Application.persistentDataPath + "/" + allItems[itemId].name + ".jpg"));
		contentRoot.Find ("Portrait").GetComponent<tk2dSpriteFromTexture> ().texture = tex;
		contentRoot.Find ("Portrait").GetComponent<tk2dSpriteFromTexture> ().ForceBuild ();
		contentRoot.localPosition = new Vector3(itemId * itemStride, 0, 0);
	}

	// Populate the backing fields with some values
	public void SetItemCount(int id, int colour, string name, string attended, string paid) {
		ItemDef item = new ItemDef ();
		item.id = id;
		item.colour = colour;
		item.name = name;
		item.attended = attended;
		item.paid = paid;
		allItems.Add (item);
		allItems.Sort(delegate(ItemDef a, ItemDef b) {
			if((b.colour).CompareTo(a.colour) != 0){
				return(b.colour).CompareTo(a.colour);
			}
			return(a.name).CompareTo(b.name);
		});
		while (0 < cachedContentItems.Count) {
			DoSetActive (cachedContentItems[0], false);
			unusedContentItems.Add (cachedContentItems[0]);
			cachedContentItems.Remove (cachedContentItems[0]);
		}
		UpdateListGraphics ();
		numItemsTextMesh.text = "COUNT: " + allItems.Count;
	}

	public int ClearStudent (string name){
		foreach (ItemDef tempid in allItems) {
			if (tempid.name == name) {
				int i = tempid.id;
				allItems.Remove (tempid);
				while (0 < cachedContentItems.Count) {
					DoSetActive (cachedContentItems[0], false);
					unusedContentItems.Add (cachedContentItems[0]);
					cachedContentItems.Remove (cachedContentItems[0]);
				}
				UpdateListGraphics ();
				numItemsTextMesh.text = "COUNT: " + allItems.Count;
				return i;
			}
		}
		return -1;
	}

	public void ClearItems (){
		allItems.Clear ();
		while (0 < cachedContentItems.Count) {
			DoSetActive (cachedContentItems[0], false);
			unusedContentItems.Add (cachedContentItems[0]);
			cachedContentItems.Remove (cachedContentItems[0]);
		}
		UpdateListGraphics ();
		numItemsTextMesh.text = "COUNT: " + allItems.Count;
	}

	Color Colour (int colour){
		if(colour == 1){
			return Color.yellow;
		}
		else if(colour == 2){
			return new Color(1, 0.31f, 0);
		}
		else if(colour == 3){
			return new Color(0, 0.63f, 0);
		}
		else if(colour == 4){
			return new Color(0, 0.25f, 1);
		}
		else if(colour == 5){
			return new Color(0.28f, 0.19f, 0.09f);
		}
		else if(colour == 6){
			return Color.black;
		}
		return Color.white;
	}


	void OnScroll(tk2dUIScrollableArea scrollableArea) {
		UpdateListGraphics();
	}

	// Synchronizes the graphics with the scroll amount
	// Figures out the first and last visible list items, and if that doesn't correspond
	// to what is cached, it rectifies the situation
	// Only the items that actually need to be changed are changed, so as you scroll the one that goes out 
	// of view is removed, recycled and reused for the one coming into view.
	void UpdateListGraphics() {
		// Previous offset - we will need to reset the value to match the new content length
		float previousOffset = scrollableArea.Value * (scrollableArea.ContentLength - scrollableArea.VisibleAreaLength);
		int firstVisibleItem = Mathf.FloorToInt (previousOffset / itemStride);

		// If the number of elements has changed - we do some processing
		float newContentLength = allItems.Count * itemStride;
		if (!Mathf.Approximately (newContentLength, scrollableArea.ContentLength)) {
			// If all items are visible, we simply populate as needed
			if (newContentLength < scrollableArea.VisibleAreaLength) {
				scrollableArea.Value = 0; // no more scrolling
				for (int i = 0; i < cachedContentItems.Count; ++i) {
					DoSetActive (cachedContentItems [i], false);
					unusedContentItems.Add (cachedContentItems [i]); // clear whole list
				}
				cachedContentItems.Clear ();
				firstCachedItem = -1;
				firstVisibleItem = 0;
			}

			// The total size required to display all elements
			scrollableArea.ContentLength = newContentLength;

			// Rescale the previousOffset so it remains constant
			if (scrollableArea.ContentLength > 0) {
				scrollableArea.Value = previousOffset / (scrollableArea.ContentLength - scrollableArea.VisibleAreaLength);
			}
		}
		int lastVisibleItem = Mathf.Min (firstVisibleItem + maxVisibleItems, allItems.Count);

		// If any items are visible that shouldn't need to be visible, get rid of them
		while (firstCachedItem >= 0 && firstCachedItem < firstVisibleItem) {
			firstCachedItem++;
			DoSetActive (cachedContentItems [0], false);
			unusedContentItems.Add (cachedContentItems [0]);
			cachedContentItems.RemoveAt (0);
			if (cachedContentItems.Count == 0) {
				firstCachedItem = -1;
			}
		}

		// Ditto for end of list
		while (firstCachedItem >= 0 && (firstCachedItem + cachedContentItems.Count) > lastVisibleItem) {
			DoSetActive (cachedContentItems [cachedContentItems.Count - 1], false);
			unusedContentItems.Add (cachedContentItems [cachedContentItems.Count - 1]);
			cachedContentItems.RemoveAt (cachedContentItems.Count - 1);
			if (cachedContentItems.Count == 0) {
				firstCachedItem = -1;
			}
		}

		// Nothing visible, simply fill as needed
		if (firstCachedItem < 0) {
			firstCachedItem = firstVisibleItem;
			int maxToAdd = Mathf.Min (firstCachedItem + maxVisibleItems, allItems.Count);
			for (int i = firstCachedItem; i < maxToAdd; ++i) {
				Transform t = unusedContentItems [0];
				cachedContentItems.Add (t);
				unusedContentItems.RemoveAt (0);
				CustomizeListObject (t, i);
				DoSetActive (t, true);
			}
		}
		else {
			// Fill in items that should be visible but aren't
			while (firstCachedItem > firstVisibleItem) {
				--firstCachedItem;
				Transform t = unusedContentItems [0];
				unusedContentItems.RemoveAt (0);
				cachedContentItems.Insert (0, t);
				CustomizeListObject (t, firstCachedItem);
				DoSetActive (t, true);
			}
			while (firstCachedItem + cachedContentItems.Count < lastVisibleItem) {
				Transform t = unusedContentItems [0];
				unusedContentItems.RemoveAt (0);
				CustomizeListObject (t, firstCachedItem + cachedContentItems.Count);
				cachedContentItems.Add (t);
				DoSetActive (t, true);
			}
		}
	}

	#region ButtonHandlers

	void AttendanceSave (){
		string[] tempattended = PlayerPrefs.GetString ("Attended").Split ('|');
		string sattended = "";

		foreach (ItemDef def in allItems) {
			tempattended [def.id] = System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00");
			if (PreviewLabs.PlayerPrefs.GetString (def.name) != null) {
				string[] temps = PreviewLabs.PlayerPrefs.GetString (def.name).Split ('|');
				if (temps [temps.Length - 1].Substring (0, 4) == System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00")) {
					temps [temps.Length - 1] = System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + (int.Parse (temps [temps.Length - 1].Substring (4, 2)) + 1).ToString ("00");
					string ss = "";
					foreach (string ts in temps) {
						ss += "|" + ts;
					}
					PreviewLabs.PlayerPrefs.SetString (def.name, ss.Substring(1));
				}
				else {
					string ss = "";
					foreach (string ts in temps) {
						ss += "|" + ts;
					}
					PreviewLabs.PlayerPrefs.SetString (def.name, ss.Substring(1) + "|" + System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + "01");
				}
			}
			else {
				PreviewLabs.PlayerPrefs.SetString (def.name, System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + "01");
			}
		}
		if (PlayerPrefs.GetString ("Attendance") != "" && PlayerPrefs.GetString("AttendanceToday") != System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00")) {
			PlayerPrefs.SetString("AttendanceToday", System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00"));
			string[] temps = PlayerPrefs.GetString ("Attendance").Split ('|');
			if (temps [temps.Length - 1].Substring (0, 4) == System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00")) {
				temps [temps.Length - 1] = System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + (int.Parse (temps [temps.Length - 1].Substring (4, 2)) + 1).ToString ("00");
				string ss = "";
				foreach (string ts in temps) {
					ss += "|" + ts;
				}
				PlayerPrefs.SetString ("Attendance", ss.Substring(1));
			}
			else {
				string ss = "";
				foreach (string ts in temps) {
					ss += "|" + ts;
				}
				PlayerPrefs.SetString ("Attendance", ss.Substring(1) + "|" + System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + "01");
			}
		}
		else if(PlayerPrefs.GetString ("Attendance") == "") {
			PlayerPrefs.SetString ("AttendanceToday", System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00"));
			PlayerPrefs.SetString ("Attendance", System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + "01");
		}
		foreach (string tattended in tempattended) {
			sattended += "|" + tattended;
		}
		PlayerPrefs.SetString ("Attended", sattended.Substring(1));
		PlayerPrefs.Save ();
		PreviewLabs.PlayerPrefs.Flush();

		gameObject.GetComponent<tk2dUIDemo6Controller> ().AttendanceClear ();
		ClearItems ();
	}

	#endregion
}
