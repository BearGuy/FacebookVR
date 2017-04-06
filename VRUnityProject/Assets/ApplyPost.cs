using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPost : MonoBehaviour {

	void Start() {
	}

	void OnMouseDown() {
		GameObject.FindWithTag ("timelineOriginal").SetActive (false);
		this.gameObject.SetActive (false);
	}
}
