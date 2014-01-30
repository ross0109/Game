using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
		if(Input.GetButtonDown("Fire2")){
			Application.LoadLevel(0);
		}
	}
}
