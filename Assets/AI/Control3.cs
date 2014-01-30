using UnityEngine;
using System.Collections;

public class Control3 : EnemyControl {

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		setDisplacement(.94f);
		setSpeed(.02f);
	}
	
	// Update is called once per frame
	void Update () {
		movement();
	}
}
