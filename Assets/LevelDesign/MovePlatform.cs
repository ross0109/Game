using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	public Vector2 newPos = new Vector2 (0f, 0f);
	public CharacterController controller;
	public Vector2 startPos = new Vector2(0f, 0f);
	private float speed = .01f;
	private float displacement = .1f;
	private Vector2 pastPos;
	private bool goingRight = true;



	public float getDisplacement(){
		return displacement;
	}
	public void setDisplacement(float d){
		displacement = d;
	}
	public float getSpeed(){
		return speed;
	}
	public void setSpeed(float newS){
		speed = newS;
	}

	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
	
	}
	public void movement(){
		if(goingRight){
			newPos.x += speed;
		}
		else if(!goingRight){
			newPos.x -= speed;
		}
		if(Mathf.Abs(newPos.x) >= displacement && goingRight){
			goingRight = false;
		}
		else if(Mathf.Abs(newPos.x) >= displacement && !goingRight){
			goingRight = true;
		}
		controller.Move(newPos);
	}









}