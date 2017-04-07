using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class AutofillSearch : MonoBehaviour {
	InputField iField;
	// Use this for initialization
	void Start () {
		iField = this.gameObject.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void autofill() {
		StartCoroutine(populateInputField());
	}

	IEnumerator populateInputField() {
		string text = "";
		char[] text_target = {'P', 'a', 't', 'r', 'i', 'c', 'k'};
		for (int i = 0; i < text_target.Length; i++) {
			text += text_target [i];
			yield return new WaitForSeconds ((float)0.25);
			gameObject.GetComponent<InputField> ().text = text;
		}

	}
}
