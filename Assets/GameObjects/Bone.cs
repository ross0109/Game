using UnityEngine;
using System.Collections;

public class Bone : MonoBehaviour {
	public int boneCount = 0;
	public GUIText DogeHUD;

	void Start () {

	}

	void Update () {
		DogeHUD.text = "Doge Bones: " + (int)boneCount;
	}

	void OnTriggerEnter(Collider other){
		//print ("Collision");
		if(other.gameObject.name.Equals("DogeParent")){
			print ("BONE COLLECTED");
			GameObject.Destroy(this.gameObject);
			++boneCount;
			/////coommeeentt
		}
	}
}