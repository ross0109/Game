using UnityEngine;
using System.Collections;

public class Control4 : EnemyControl {

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		setDisplacement(.15f);
		setSpeed(.01f);
	}
	
	// Update is called once per frame
	void Update () {
		movement();
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.name.Equals("DogeParent") || other.gameObject.name.Equals("CatParent")){
			print ("Captured!");
		}
	}
}
