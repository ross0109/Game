using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform Doge;
	public Transform Cat;
	public Vector3 center;

	void Update () {
		//center = ((Doge.localPosition.x - Cat.localPosition.x)/2.0f) + Cat.localPosition.x;
		//transform.LookAt(center);
	}
}
