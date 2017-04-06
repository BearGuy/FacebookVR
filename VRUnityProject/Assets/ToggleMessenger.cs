using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMessenger : MonoBehaviour {
	public GameObject messengerOriginal;
	public GameObject messengerMessageSent;
	public bool messageSent = false;


	void Awake() {
		messengerOriginal=GameObject.FindWithTag("messengerOriginal");
		messengerMessageSent=GameObject.FindWithTag("messengerMessageSent");
		messengerOriginal.SetActive (false);
		messengerMessageSent.SetActive (false);
	}

	void OnMouseDown() {
		if (messengerMessageSent.activeSelf && !messengerOriginal.activeSelf) {
			messageSent = true;
		}

		if (messageSent) {
			if (messengerMessageSent.activeSelf) {
				messengerMessageSent.SetActive (false);
			} else {
				messengerMessageSent.SetActive (true);
			}
		} else {
			if (messengerOriginal.activeSelf && messengerMessageSent.activeSelf) {
				messengerMessageSent.SetActive (false);
				messengerOriginal.SetActive (false);
			} else {
				messengerOriginal.SetActive (true);
				messengerMessageSent.SetActive (true);
			}

		} 
	}


	void Update () {
	}
}
