using UnityEngine;
using System.Collections;

public class WinningBlockCode : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name.Equals("CatParent")||other.gameObject.name.Equals("DogeParent")){
			print("SAVIOR!");

		}
	}
}
