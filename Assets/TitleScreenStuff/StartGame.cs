using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Application.LoadLevel(2);
		}
		if (Input.GetButtonDown ("Fire2")) {
			Application.LoadLevel(1);
		}
	}
}
