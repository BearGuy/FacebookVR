using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleProfileCard : MonoBehaviour {
	public GameObject otherObject;

	void Start() {
		otherObject= GameObject.FindWithTag ("profileCard");
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
