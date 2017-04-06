using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSearchCard : MonoBehaviour {
	public GameObject otherObject;

	void Awake() {
		otherObject=GameObject.FindWithTag("searchCard");
		otherObject.SetActive (false);
	}

	void OnMouseDown() {
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
	}


	void Update () {
	}
}
