using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bone : MonoBehaviour {

	void Start () {

	}
	void onTriggerEnter(){
		if(this.gameObject.collider){
			print ("Collection");
			if(this.gameObject != null){
				GameObject.Destroy(this.gameObject);
			}
		}
	}
	void Update () {
		onTriggerEnter();
	}

	/*void OnCollisionEnter(Collision collision){
			if(collision.gameObject.name == "enemy"){
				Destroy(this.gameObject);
			}

	}*/
}
