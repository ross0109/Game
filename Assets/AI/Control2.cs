using UnityEngine;
using System.Collections;

public class Control2 : EnemyControl {

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		setDisplacement(.375f);
		setSpeed(.02f);
	}
	
	// Update is called once per frame
	void Update () {
		movement();
	}
}
