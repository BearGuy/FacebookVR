using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePostCard : MonoBehaviour {
	public GameObject otherObject;

	void Start() {
		otherObject = GameObject.FindWithTag("postCard");
		otherObject.SetActive(false);
	}

	public void togglePostCard(){
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
	}
}
