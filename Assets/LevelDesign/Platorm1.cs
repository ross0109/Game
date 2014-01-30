using UnityEngine;
using System.Collections;

public class Platorm1 : MovePlatform {

	void Start () {
		controller = GetComponent<CharacterController>();
		setDisplacement(.3f);
		setSpeed(.005f);
	}

	void Update () {
		movement();
	}
}
