using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSelf : MonoBehaviour {

	void Start() {
	}

	void OnMouseDown() {
		this.gameObject.SetActive (false);
	}

	public void hideSelf() {
		this.gameObject.SetActive (false);
	}


	void Update () {
	}
}
