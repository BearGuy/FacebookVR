using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePost : MonoBehaviour {
	public GameObject otherObject;
	void Start() {
		otherObject = GameObject.FindWithTag("PostDialog");
		otherObject.SetActive(false);
	}

	public void togglePost(){
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
	}


	void Update () {
	}
}
