using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadForestScene : MonoBehaviour {

	void OnMouseDown() {
		SceneManager.LoadScene ("Forest");

	}

	public void loadForest() {
		SceneManager.LoadScene ("Forest");
	}
}
