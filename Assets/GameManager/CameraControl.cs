using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject DogeSprite;
	public GameObject CatSprite;
	public Vector3 center;

	void Start(){
		DogeSprite = GameObject.Find ("DogeParent");
		CatSprite = GameObject.Find ("CatParent");
	}

	void Update () {
		center = ((DogeSprite.transform.localPosition + CatSprite.transform.localPosition) / 2.0f);
		center.z = -15f;
		transform.localPosition = center;
	}
}