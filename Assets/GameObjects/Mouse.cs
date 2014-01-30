using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	
	void Start () {
		
	}
	void onTriggerEnter(){
		print ("Collection");
		if(this.gameObject != null){
			GameObject.Destroy(this.gameObject);
		}
	}
	void Update () {
		onTriggerEnter();
	}
}
