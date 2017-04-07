using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleNotificationsCard : MonoBehaviour {
	public GameObject otherObject;

	void Start() {
		otherObject = GameObject.FindWithTag("notificationsCard");
		otherObject.SetActive(false);
	}

	public void toggleNotifications(){
		if (otherObject.activeSelf == true)
			otherObject.SetActive (false);
		else
			otherObject.SetActive (true);
	}


	void Update () {
	}
}
