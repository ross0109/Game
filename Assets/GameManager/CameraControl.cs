using UnityEngine;
using System.Collections;
using System;

public class CameraControl : MonoBehaviour {

	public static GameObject DogeParent;
	public static GameObject CatParent;
	public Vector3 center;


	void Start(){
		DogeParent = GameObject.Find ("DogeParent");
		CatParent = GameObject.Find ("CatParent");
	}

	void Update () {
		double y1 = DogeParent.transform.localPosition.y;
		double y2 = CatParent.transform.localPosition.y;
		double x1 = DogeParent.transform.localPosition.x;
		double x2 = CatParent.transform.localPosition.x;
		float distance = (float)Math.Sqrt(((y2-y1)*(y2-y1))+((x2-x1)*(x2-x1)));
		center = ((DogeParent.transform.localPosition + CatParent.transform.localPosition) / 2.0f);
		center.z = -15f;
		transform.localPosition = center;
		transform.camera.orthographicSize = distance;
		if (distance > 30) {
			transform.camera.orthographicSize = 30;
		}
		if(distance < 10){
			transform.camera.orthographicSize = 10;
		}
	}
}