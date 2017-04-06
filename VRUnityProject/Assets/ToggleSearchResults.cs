using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSearchResults : MonoBehaviour {
	public GameObject otherObject;

	void Start() {
		otherObject = GameObject.FindWithTag("searchResults");
		otherObject.SetActive(false);
	}

	public void toggleSearchResults(){
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
	}
		
}
