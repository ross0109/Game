using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	public int mouseCount = 0;
	public GUIText CatHUD;

	void Start () {

	}

	void Update () {
		CatHUD.text = "Cat Mice: " + (int)mouseCount;
	}


	void OnTriggerEnter(Collider other){
		//print ("Collision");
		if(other.gameObject.name.Equals("CatParent")){
			print ("MOUSE COLLECTED");
			GameObject.Destroy(this.gameObject);
			++mouseCount;
		}
	}
}