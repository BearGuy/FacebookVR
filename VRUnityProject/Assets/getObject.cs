using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getObject : MonoBehaviour {
	public GameObject otherObject;

	void Start() {
		otherObject = GameObject.FindWithTag("myLamp");
	}

	void OnMouseDown() {
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
		//gameObject.SetActive(false);
	}

	void Update () {
	}
}
