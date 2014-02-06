using UnityEngine;
using System.Collections;

public class Bone : MonoBehaviour {

	void Start () {
		Doge.DogeHUD.text.Equals ("Bone Count: " + Doge.boneCount);
	}

	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name.Equals("DogeParent")){
			print ("BONE COLLECTED");
			GameObject.Destroy(this.gameObject);
			Doge.boneCount += 1;
		}
	}
}