using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class tk2dUIDemo6Controller : tk2dUIBaseDemoController {

	public GameObject holder;
	public GameObject prefabTemplate;
	public tk2dUILayout prefabItem;
	public tk2dUILayout studentLayout;
	public tk2dUILayout attendanceLayout;
	float itemStride = 0;
	int ddmenuLastIndex = 0;
	public int editid = 0;
	bool editactive = false;
	bool editpic = false;


	// Manually set up a scrollable area by working out offsets manually
	public tk2dUIScrollableArea scrollableArea;
	public tk2dTextMesh numItemsTextMesh;


	public tk2dUIDropDownMenu ddmenu;
	public tk2dUIToggleButtonGroup orderGroup;
	public Texture profilePic;
	public Text addAge;
	public Text editAge;
	public ToggleGroup addStudentGroup;
	public ToggleGroup editStudentGroup;
	public InputField addStudentName;
	public InputField editStudentName;
	public InputField overdueName;
	public InputField addStudentPaid;
	public InputField editStudentPaid;
	public InputField overduePaid;
	public InputField editStudentAttended;
	public InputField overdueAttended;
	public InputField overdueToday;
	public InputField addStudentDescription;
	public InputField editStudentDescription;
	public RawImage addStudentPicture;
	public RawImage editStudentPicture;
	public RawImage overduePicture;
	public RawImage overdueColour;
	public GameObject addStudent;
	public GameObject editStudent;
	public GameObject overduePayment;
	public GameObject attendanceHistory;
	public GameObject historyContent;
	public GameObject blocker;

	// This is a representation of an entry in the list. Replace with what you need here.
	// If you create this procedurally, you can have an infinite scrollable area
	class ItemDef {
		public int id = 0;
		public int colour = 0;
		public string age = "";
		public string name = "";
		public string attended = "";
		public string paid = "";
		public string description = "";
	}
	ItemDef overdueItem = new ItemDef ();
	List<ItemDef> allItems = new List<ItemDef>();
	List<int> attendanceItems = new List<int>();

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
			studentLayout.Reshape (new Vector3(v, 0), new Vector3(-v, 0), true);
		}
		else if((Screen.width / (Screen.height * 1f)) / 1.6f < 1){
			float v = (((Screen.width / (Screen.height * 1f)) / 1.6f) - 1) / 0.745f;
			studentLayout.Reshape (new Vector3(-v, 0), new Vector3(v, 0), true);
		}
		if (PlayerPrefs.GetInt ("Order", 0) == 0) {
			orderGroup.SelectedIndex = 0;
		}
		else {
			orderGroup.SelectedIndex = 1;
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

		// Add some items to the List
		SetItemCount();
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
	void SetItemCount() {
		if (PlayerPrefs.GetString("Name") != ""){
			List<string> sname = new List<string> ();
			List<string> scolour = new List<string> ();
			List<string> sage = new List<string> ();
			List<string> sattended = new List<string> ();
			List<string> spaid = new List<string> ();
			List<string> sdescription = new List<string> ();
			allItems.Clear ();
			string[] tempname = PlayerPrefs.GetString ("Name").Split ('|');
			foreach (string tname in tempname) {
				sname.Add (tname);
			}
			string[] tempcolour = PlayerPrefs.GetString ("Colour").Split ('|');
			foreach (string tcolour in tempcolour) {
				scolour.Add (tcolour);
			}
			string[] tempage = PlayerPrefs.GetString ("Age").Split ('|');
			foreach (string tage in tempage) {
				sage.Add (tage);
			}
			string[] tempattended = PlayerPrefs.GetString ("Attended").Split ('|');
			foreach (string tattended in tempattended) {
				sattended.Add (tattended);
			}
			string[] temppaid = PlayerPrefs.GetString ("Paid").Split ('|');
			foreach (string tpaid in temppaid) {
				spaid.Add (tpaid);
			}
			string[] tempdescription = PlayerPrefs.GetString ("Description").Split ('|');
			foreach (string tdescription in tempdescription) {
				sdescription.Add (tdescription);
			}
			string todaydate = System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00");
			int date = int.Parse(todaydate) - 100;
			if(date.ToString("000000").Substring(2, 2) == "00"){
				date = date - 8800;
			}
			for (int j = 0; j < sname.Count; ++j) {
				if (PlayerPrefs.GetInt("Order", 0) == 0 || int.Parse(sattended [j]) >= date && PlayerPrefs.GetInt("Order", 0) == 1) {
					ItemDef item = new ItemDef ();
					item.id = j;
					item.colour = int.Parse(scolour [j]);
					item.age = sage [j];
					item.name = sname [j];
					item.attended = sattended [j];
					item.paid = spaid [j];
					item.description = sdescription [j];
					allItems.Add (item);
				}
			}
			foreach (int i in attendanceItems) {
				foreach (ItemDef def in allItems) {
					if (def.id == i) {
						allItems.Remove (def);
						break;
					}
				}
			}
			string ddmenuAge = "";
			if (ddmenu.Index == 0 || ddmenu.Index == 1) {
				ddmenuAge = "A";
			}
			else if (ddmenu.Index == 2 || ddmenu.Index == 3) {
				ddmenuAge = "C";
			}
			foreach (ItemDef def in allItems.ToList()) {
				if (def.age == ddmenuAge) {
					allItems.Remove (def);
				}
			}
			allItems.Sort(delegate(ItemDef a, ItemDef b) {
				if((b.colour).CompareTo(a.colour) != 0){
					return(b.colour).CompareTo(a.colour);
				}
				return(a.name).CompareTo(b.name);
			});
		}
		while (0 < cachedContentItems.Count) {
			DoSetActive (cachedContentItems[0], false);
			unusedContentItems.Add (cachedContentItems[0]);
			cachedContentItems.Remove (cachedContentItems[0]);
		}
		UpdateListGraphics();
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

	bool DateValid (string date){
		bool day = false;
		bool month = false;
		bool year = false;
		for(int i = 1; i < 32; ++i){
			if(date.Substring(0, 2) == i.ToString("00")){
				day = true;
			}
		}
		for(int i = 1; i < 13; ++i){
			if(date.Substring(3, 2) == i.ToString("00")){
				month = true;
			}
		}
		for(int i = 0; i < 100; ++i){
			if(date.Substring(6, 2) == i.ToString("00")){
				year = true;
			}
		}

		if(day == true && month == true && year == true){
			return true;
		}
		else{
			return false;
		}
	}

	string Month (int month){
		string date = "";
		if (month == 1) {
			date = "JANUARY";
		}
		else if (month == 2) {
			date = "FEBRUARY";
		}
		else if (month == 3) {
			date = "MARCH";
		}
		else if (month == 4) {
			date = "APRIL";
		}
		else if (month == 5) {
			date = "MAY";
		}
		else if (month == 6) {
			date = "JUNE";
		}
		else if (month == 7) {
			date = "JULY";
		}
		else if (month == 8) {
			date = "AUGUST";
		}
		else if (month == 9) {
			date = "SEPTEMBER";
		}
		else if (month == 10) {
			date = "OCTOBER";
		}
		else if (month == 11) {
			date = "NOVEMBER";
		}
		else if (month == 12) {
			date = "DECEMBER";
		}
		return date;
	}

	int Toggles (ToggleGroup tg){
		Toggle t = tg.ActiveToggles ().FirstOrDefault();
		int i = 0;
		if (t.name == "Yellow") {
			i++;
		}
		else if (t.name == "Orange") {
			i = 2;
		}
		else if (t.name == "Green") {
			i = 3;
		}
		else if (t.name == "Blue") {
			i = 4;
		}
		else if (t.name == "Brown") {
			i = 5;
		}
		else if (t.name == "Black") {
			i = 6;
		}
		return i;
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

	void ClickStudent (tk2dUIItem uiitem){
		if(editactive == true){
			editStudent.SetActive (true);
			blocker.SetActive(true);
			string tempname = uiitem.transform.Find("Name").GetComponent<tk2dTextMesh>().text;
			foreach (ItemDef tempid in allItems) {
				if (tempid.name == tempname) {
					editStudentName.text = tempid.name;
					editStudentGroup.transform.GetChild (tempid.colour).GetComponent<Toggle> ().isOn = true;
					editAge.text = tempid.age;
					editStudentPaid.text = tempid.paid.Substring(4, 2) + "/" + tempid.paid.Substring(2, 2) + "/" + tempid.paid.Substring(0, 2);
					editStudentAttended.text = tempid.attended.Substring(4, 2) + "/" + tempid.attended.Substring(2, 2) + "/" + tempid.attended.Substring(0, 2);
					editStudentDescription.text = tempid.description;
					editStudentPicture.texture = uiitem.transform.Find("Portrait").GetComponent<tk2dSpriteFromTexture>().texture;
					editid = tempid.id;
					return;
				}
			}
		}
		else if(ddmenu.Index == 0 || ddmenu.Index == 2){
			string tempname = uiitem.transform.Find("Name").GetComponent<tk2dTextMesh>().text;
			foreach (ItemDef tempid in allItems) {
				if (tempid.name == tempname) {
					string date = System.DateTime.Today.Year.ToString ().Substring (2, 2) + System.DateTime.Today.Month.ToString ("00") + System.DateTime.Today.Day.ToString ("00");
					if (int.Parse (date) <= int.Parse (tempid.paid)) {
						gameObject.GetComponent<Attendance> ().SetItemCount (tempid.id, tempid.colour, tempid.name, tempid.attended, tempid.paid);
						attendanceItems.Add (tempid.id);
						SetItemCount ();
						return;
					}
					else {
						overduePayment.SetActive(true);
						blocker.SetActive(true);
						overdueColour.color = Colour (tempid.colour);
						overdueName.text = tempid.name;
						overduePaid.text = tempid.paid.Substring(4, 2) + "/" + tempid.paid.Substring(2, 2) + "/" + tempid.paid.Substring(0, 2);
						overdueAttended.text = tempid.attended.Substring(4, 2) + "/" + tempid.attended.Substring(2, 2) + "/" + tempid.attended.Substring(0, 2);
						overdueToday.text = date.Substring(4, 2) + "/" + date.Substring(2, 2) + "/" + date.Substring(0, 2);
						overduePicture.texture = uiitem.transform.Find("Portrait").GetComponent<tk2dSpriteFromTexture>().texture;
						overdueItem = tempid;
						return;
					}
				}
			}
			attendanceItems.Remove(gameObject.GetComponent<Attendance> ().ClearStudent (tempname));
			SetItemCount ();
		}
	}

	void OrderChange (tk2dUIToggleButtonGroup tbutton){
		if(PlayerPrefs.GetInt ("Order") != tbutton.SelectedIndex){
			PlayerPrefs.SetInt ("Order", tbutton.SelectedIndex);
			PlayerPrefs.Save ();
			while (0 < cachedContentItems.Count) {
				DoSetActive (cachedContentItems [0], false);
				unusedContentItems.Add (cachedContentItems [0]);
				cachedContentItems.Remove (cachedContentItems [0]);
			}
			firstCachedItem = -1;
			allItems.Clear ();
			UpdateListGraphics ();
			SetItemCount ();
		}
	}

	void DropDrownList () {
		if (ddmenu.Index == 0 || ddmenu.Index == 2) {
			editactive = false;
			ddmenuLastIndex = ddmenu.Index;
		}
		else if (ddmenu.Index == 1 || ddmenu.Index == 3) {
			editactive = true;
			ddmenuLastIndex = ddmenu.Index;
		}
		else if (ddmenu.Index == 4) {
			addStudent.SetActive(true);
			blocker.SetActive(true);
			editactive = false;
		}
		attendanceItems.Clear ();
		SetItemCount ();
		gameObject.GetComponent<Attendance> ().ClearItems ();
	}

	public void AddStudentSave (){
		addStudentName.text = addStudentName.text.Replace ("|", "");
		addStudentDescription.text = addStudentDescription.text.Replace ("|", "");
		List<string> dn = new List<string>(PlayerPrefs.GetString ("Name").Split('|'));
		if(addStudentName.text != "" && dn.Contains (addStudentName.text) == false && addStudentPaid.text.Length == 8 && DateValid(addStudentPaid.text) == true){
			if (PlayerPrefs.GetString ("Name") != "") {
				PlayerPrefs.SetString ("Name", PlayerPrefs.GetString ("Name") + "|" + addStudentName.text);
				PlayerPrefs.SetString ("Colour", PlayerPrefs.GetString ("Colour") + "|" + Toggles(addStudentGroup).ToString("0"));
				PlayerPrefs.SetString ("Age", PlayerPrefs.GetString ("Age") + "|" + addAge.text);
				PlayerPrefs.SetString ("Paid", PlayerPrefs.GetString ("Paid") + "|" + addStudentPaid.text.Substring(6, 2) + addStudentPaid.text.Substring(3, 2) + addStudentPaid.text.Substring(0, 2));
				PlayerPrefs.SetString ("Attended", PlayerPrefs.GetString ("Attended") + "|" + System.DateTime.Today.Year.ToString().Substring(2, 2) + System.DateTime.Today.Month.ToString("00") + System.DateTime.Today.Day.ToString("00"));
				if (addStudentDescription.text != "") {
					PlayerPrefs.SetString ("Description", PlayerPrefs.GetString ("Description") + "|" + addStudentDescription.text);
				}
				else {
					PlayerPrefs.SetString ("Description", PlayerPrefs.GetString ("Description") + "| ");
				}
				Texture2D t2d = (addStudentPicture.texture as Texture2D);
				TextureScale.Bilinear (t2d, 256, 256);
				byte[] bytes = t2d.EncodeToJPG ();
				System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + addStudentName.text + ".jpg", bytes);
				PlayerPrefs.Save ();
			}
			else{
				PlayerPrefs.SetString ("Name", addStudentName.text);
				PlayerPrefs.SetString ("Colour", Toggles(addStudentGroup).ToString("0"));
				PlayerPrefs.SetString ("Age", addAge.text);
				PlayerPrefs.SetString ("Paid", addStudentPaid.text.Substring(6, 2) + addStudentPaid.text.Substring(3, 2) + addStudentPaid.text.Substring(0, 2));
				PlayerPrefs.SetString ("Attended", System.DateTime.Today.Year.ToString().Substring(2, 2) + System.DateTime.Today.Month.ToString("00") + System.DateTime.Today.Day.ToString("00"));
				if (addStudentDescription.text != "") {
					PlayerPrefs.SetString ("Description", addStudentDescription.text);
				}
				else {
					PlayerPrefs.SetString ("Description", " ");
				}
				Texture2D t2d = (addStudentPicture.texture as Texture2D);
				TextureScale.Bilinear (t2d, 256, 256);
				byte[] bytes = t2d.EncodeToJPG ();
				System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + addStudentName.text + ".jpg", bytes);
				PlayerPrefs.Save ();
			}
			AddStudentCancel();
			SetItemCount();
			return;
		}
		if (addStudentName.text == "" || dn.Contains (addStudentName.text) == true) {
			addStudentName.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			addStudentName.GetComponent<Image> ().color = Color.white;
		}
		if(addStudentPaid.text.Length != 8 || DateValid(addStudentPaid.text) == false){
			addStudentPaid.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			addStudentPaid.GetComponent<Image> ().color = Color.white;
		}
	}

	public void AddStudentCancel (){
		addStudentPicture.texture = profilePic;
		addStudentName.text = "";
		addStudentName.GetComponent<Image> ().color = Color.white;
		addStudentPaid.text = "";
		addStudentPaid.GetComponent<Image> ().color = Color.white;
		addStudentDescription.text = "";
		addStudentGroup.transform.GetChild (0).GetComponent<Toggle> ().isOn = true;
		addAge.text = "C";
		addStudent.SetActive(false);
		blocker.SetActive(false);
		ddmenu.Index = ddmenuLastIndex;
	}

	public void AddStudentPicture (){
		UM_Camera.Instance.OnImagePicked += OnImage;
		UM_Camera.Instance.GetImageFromCamera ();
	}

	public void EditStudentPicture (){
		UM_Camera.Instance.OnImagePicked += OnImage;
		UM_Camera.Instance.GetImageFromCamera ();
	}

	private void OnImage(UM_ImagePickResult result){
		if(result.IsSucceeded){
			if (editStudent.activeSelf == true) {
				editStudentPicture.texture = result.image;
				editpic = true;
			}
			else {
				addStudentPicture.texture = result.image;
			}
		}
		UM_Camera.Instance.OnImagePicked -= OnImage;
	}

	public void AddStudentAge (){
		if(addAge.text == "C"){
			addAge.text = "A";
		}
		else if(addAge.text == "A"){
			addAge.text = "C";
		}
	}

	public void EditStudentSave (){
		editStudentName.text = editStudentName.text.Replace ("|", "");
		editStudentDescription.text = editStudentDescription.text.Replace ("|", "");
		List<string> dn = new List<string>(PlayerPrefs.GetString ("Name").Split('|'));
		string dname = dn[editid];
		dn.RemoveAt(editid);
		if(editStudentName.text != "" && dn.Contains (editStudentName.text) == false && editStudentPaid.text.Length == 8 && editStudentAttended.text.Length == 8 && DateValid(editStudentPaid.text) == true && DateValid(editStudentAttended.text) == true){
			string[] tempname = PlayerPrefs.GetString ("Name").Split ('|');
			string[] tempcolour = PlayerPrefs.GetString ("Colour").Split ('|');
			string[] tempage = PlayerPrefs.GetString ("Age").Split ('|');
			string[] temppaid = PlayerPrefs.GetString ("Paid").Split ('|');
			string[] tempattended = PlayerPrefs.GetString ("Attended").Split ('|');
			string[] tempdescription = PlayerPrefs.GetString ("Description").Split ('|');
			string sname = "";
			string scolour = "";
			string sage = "";
			string spaid = "";
			string sattended = "";
			string sdescription = "";

			tempname [editid] = editStudentName.text;
			foreach (string tname in tempname) {
				sname += "|" + tname;
			}
			PlayerPrefs.SetString ("Name", sname.Substring(1));

			tempcolour [editid] = Toggles (editStudentGroup).ToString("0");
			foreach (string tcolour in tempcolour) {
				scolour += "|" + tcolour;
			}
			PlayerPrefs.SetString ("Colour", scolour.Substring(1));

			tempage [editid] = editAge.text;
			foreach (string tage in tempage) {
				sage += "|" + tage;
			}
			PlayerPrefs.SetString ("Age", sage.Substring(1));

			temppaid [editid] = editStudentPaid.text.Substring (6, 2) + editStudentPaid.text.Substring (3, 2) + editStudentPaid.text.Substring (0, 2);
			foreach (string tpaid in temppaid) {
				spaid += "|" + tpaid;
			}
			PlayerPrefs.SetString ("Paid", spaid.Substring(1));

			tempattended [editid] = editStudentAttended.text.Substring (6, 2) + editStudentAttended.text.Substring (3, 2) + editStudentAttended.text.Substring (0, 2);
			foreach (string tattended in tempattended) {
				sattended += "|" + tattended;
			}
			PlayerPrefs.SetString ("Attended", sattended.Substring(1));

			if (editStudentDescription.text != "") {
				tempdescription [editid] = editStudentDescription.text;
			}
			else {
				tempdescription [editid] = " ";
			}
			foreach (string tdescription in tempdescription) {
				sdescription += "|" + tdescription;
			}
			PlayerPrefs.SetString ("Description", sdescription.Substring(1));
			if(editpic == true){
				System.IO.File.Delete(Application.persistentDataPath + "/" + dname + ".jpg");
				Texture2D t2d = (editStudentPicture.texture as Texture2D);
				TextureScale.Bilinear (t2d, 256, 256);
				byte[] bytes = t2d.EncodeToJPG ();
				System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + editStudentName.text + ".jpg", bytes);
			}
			else if(editpic == false && dname != editStudentName.text){
				System.IO.File.Move(Application.persistentDataPath + "/" + dname + ".jpg", Application.persistentDataPath + "/" + editStudentName.text + ".jpg");
			}
			PlayerPrefs.Save ();
			EditStudentCancel();
			SetItemCount ();
			return;
		}
		if (editStudentName.text == "" || dn.Contains (editStudentName.text) == true) {
			editStudentName.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			editStudentName.GetComponent<Image> ().color = Color.white;
		}

		if(editStudentPaid.text.Length != 8 || DateValid(editStudentPaid.text) == false){
			editStudentPaid.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			editStudentPaid.GetComponent<Image> ().color = Color.white;
		}

		if(editStudentAttended.text.Length != 8 || DateValid(editStudentAttended.text) == false){
			editStudentAttended.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			editStudentAttended.GetComponent<Image> ().color = Color.white;
		}
	}

	public void DeleteStudent (){
		List<string> tempname = new List<string>(PlayerPrefs.GetString ("Name").Split ('|'));
		List<string> tempcolour = new List<string>(PlayerPrefs.GetString ("Colour").Split ('|'));
		List<string> tempage = new List<string>(PlayerPrefs.GetString ("Age").Split ('|'));
		List<string> temppaid = new List<string>(PlayerPrefs.GetString ("Paid").Split ('|'));
		List<string> tempattended = new List<string>(PlayerPrefs.GetString ("Attended").Split ('|'));
		List<string> tempdescription = new List<string>(PlayerPrefs.GetString ("Description").Split ('|'));
		string sname = "";
		string scolour = "";
		string sage = "";
		string spaid = "";
		string sattended = "";
		string sdescription = "";

		System.IO.File.Delete(Application.persistentDataPath + "/" + tempname[editid] + ".jpg");
		PreviewLabs.PlayerPrefs.DeleteKey (tempname[editid]);
		PreviewLabs.PlayerPrefs.Flush ();
		tempname.RemoveAt (editid);
		foreach (string tname in tempname) {
			sname += "|" + tname;
		}
		PlayerPrefs.SetString ("Name", sname.Substring(1));

		tempcolour.RemoveAt (editid);
		foreach (string tcolour in tempcolour) {
			scolour += "|" + tcolour;
		}
		PlayerPrefs.SetString ("Colour", scolour.Substring(1));

		tempage.RemoveAt (editid);
		foreach (string tage in tempage) {
			sage += "|" + tage;
		}
		PlayerPrefs.SetString ("Age", sage.Substring(1));

		temppaid.RemoveAt (editid);
		foreach (string tpaid in temppaid) {
			spaid += "|" + tpaid;
		}
		PlayerPrefs.SetString ("Paid", spaid.Substring(1));

		tempattended.RemoveAt (editid);
		foreach (string tattended in tempattended) {
			sattended += "|" + tattended;
		}
		PlayerPrefs.SetString ("Attended", sattended.Substring(1));

		tempdescription.RemoveAt (editid);
		foreach (string tdescription in tempdescription) {
			sdescription += "|" + tdescription;
		}
		PlayerPrefs.SetString ("Description", sdescription.Substring(1));
		PlayerPrefs.Save ();
		EditStudentCancel ();
		SetItemCount ();
	}

	public void EditStudentCancel (){
		editid = 0;
		editStudentPicture.texture = profilePic;
		editStudentName.text = "";
		editStudentName.GetComponent<Image> ().color = Color.white;
		editStudentPaid.text = "";
		editStudentPaid.GetComponent<Image> ().color = Color.white;
		editStudentAttended.text = "";
		editStudentAttended.GetComponent<Image> ().color = Color.white;
		editStudentDescription.text = "";
		editStudentGroup.transform.GetChild (0).GetComponent<Toggle> ().isOn = true;
		addAge.text = "C";
		editStudent.SetActive(false);
		blocker.SetActive(false);
	}

	public void EditStudentAge (){
		if(editAge.text == "C"){
			editAge.text = "A";
		}
		else if(editAge.text == "A"){
			editAge.text = "C";
		}
	}

	public void AttendanceHistory (){
		attendanceHistory.SetActive (true);
		string[] temp = PlayerPrefs.GetString ("Name").Split ('|');
		string[] history = PreviewLabs.PlayerPrefs.GetString (temp [editid]).Split('|');
		string[] totalhistory = PlayerPrefs.GetString ("Attendance").Split('|');
		if (history.Length != 0) {
			holder.SetActive (false);
			foreach (string h in history) {
				int totalh = 0;
				foreach(string th in totalhistory){
					if(th.Substring(0, 4) == h.Substring(0, 4)){
						totalh = int.Parse(th.Substring (4, 2));
						break;
					}
				}
				GameObject g = Instantiate (prefabTemplate, historyContent.transform) as GameObject;
				g.SetActive (true);
				g.transform.GetChild (0).GetComponent<Text> ().text = Month (int.Parse(h.Substring(2, 2))) + "\n20" + h.Substring(0, 2);
				g.transform.GetChild (1).GetComponent<Text>().text = "ATTENDED\n" + int.Parse(h.Substring(4, 2)) + " out of " + totalh;
			}
		}
	}

	public void AttendanceHistoryClose (){
		foreach (Transform child in historyContent.transform) {
			GameObject.Destroy(child.gameObject);
		}
		holder.SetActive (true);
		attendanceHistory.SetActive(false);
	}

	public void OverDueSave (){
		if (overduePaid.text.Length == 8 && DateValid (overduePaid.text) == true) {
			string[] temppaid = PlayerPrefs.GetString ("Paid").Split ('|');
			string spaid = "";

			overdueItem.paid = overduePaid.text.Substring (6, 2) + overduePaid.text.Substring (3, 2) + overduePaid.text.Substring (0, 2);
			temppaid [overdueItem.id] = overdueItem.paid;
			foreach (string tpaid in temppaid) {
				spaid += "|" + tpaid;
			}
			PlayerPrefs.SetString ("Paid", spaid.Substring (1));
		}
		
		if(overduePaid.text.Length != 8 || DateValid(overduePaid.text) == false){
			overduePaid.GetComponent<Image> ().color = new Color (1, 0.5f, 0.5f);
		}
		else {
			overduePaid.GetComponent<Image> ().color = Color.white;
		}
		PlayerPrefs.Save ();
		OverDueIgnore ();
	}

	public void OverDueIgnore (){
		gameObject.GetComponent<Attendance> ().SetItemCount (overdueItem.id, overdueItem.colour, overdueItem.name, overdueItem.attended, overdueItem.paid);
		attendanceItems.Add (overdueItem.id);
		OverDueCancel ();
		SetItemCount ();
		return;
	}

	public void OverDueCancel (){
		overdueItem = new ItemDef ();
		overduePicture.texture = profilePic;
		overdueColour.color = Color.white;
		overdueName.text = "";
		overduePaid.text = "";
		overduePaid.GetComponent<Image> ().color = Color.white;
		overdueAttended.text = "";
		overduePayment.SetActive(false);
		blocker.SetActive(false);
	}

	public void AttendanceClear (){
		attendanceItems.Clear ();
		SetItemCount ();
	}

#endregion
}
