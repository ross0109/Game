using UnityEngine;
using System.Collections;

public class Doge : MonoBehaviour {
	Animator animator;
	public Vector2 newPos = new Vector2 (0f, 0f);
	private float gravity = -1f;
	private float speed = 12.5f;
	private float jumpHeight = .4f;
	private float maxGravity = -.4f;
	public CharacterController controller;
	private float height = 0f;
	private float checkHeight;
	public int count = 0;
	float moveDir;
	bool faceL = false;
	Vector3 scale = new Vector3(1f, 1f, 1f);
	public GUIText DogeHUD;
	public int boneCount = 0;

	public Vector3 sendLocPos(){
		return transform.localPosition;
	}
	
	void Start () {
		controller = transform.GetComponent<CharacterController>();
		animator = this.gameObject.GetComponentInChildren<Animator>();
		/*GameManager.gameStarter += gameStart;
		GameManager.gameEnder += gameEnd;*/
	}
	void Update () {
		newPos.x = Input.GetAxis ("Horizontal2")*Time.deltaTime*speed;
		if(Input.GetButtonDown("Jump2")){
			Jump ();
		}
		if(controller.isGrounded){
			count = 0;
		}
		if(newPos.y > maxGravity){
			newPos.y += gravity * Time.deltaTime;
		}
		controller.Move(newPos);
		if(!controller.isGrounded){
			height = transform.localPosition.y;
			if(height == checkHeight){
				newPos.y = 0f;
				controller.Move(newPos);
			}
		}
		checkHeight = height;

		/*if(!controller.isGrounded){
			height = transform.localPosition.y;
			if(height == checkHeight){
				newPos.y = 0f;
				controller.Move(newPos);
				checkHeight = height;
			}
		}*/
		if((transform.localPosition.y >= -10 && transform.localPosition.y <= -8) &&(transform.localPosition.x <= 265 && transform.localPosition.x >= 245) && boneCount == 7){
			print ("YOU WIN");
			enabled = false;
		}
		if(transform.localPosition.y <= -35){
			print ("YOU ARE CAPTURED AHHHHH");
			enabled = false;
		}
		moveDir = Input.GetAxis ("Horizontal2");
		if (moveDir < 0 && ! faceL) {
			faceL = true;
			scale.x *= -1f;
			transform.localScale = scale;
		}
		if (moveDir > 0 && faceL) {
			faceL = false;
			scale.x *= -1f;
			transform.localScale = scale;
		}
		if (moveDir != 0){
			animator.SetBool ("isWalkingDoge", true);
		}
		if (Input.GetAxis ("Horizontal2") != 0) {
			animator.SetBool ("isWalkingDoge", true);
		}
		if (Input.GetAxis ("Horizontal2") == 0) {
			animator.SetBool ("isWalkingDoge", false);
		}
		DogeHUD.text = "Doge Bones: " + (int)boneCount;
	}	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.name.Equals("Bone")){
			print ("BONE COLLECTED");
			GameObject.Destroy(other.gameObject);
			++boneCount;
		}
	}
	void Jump(){
		if(count < 1){
			newPos.y = jumpHeight;
			count += 1;
		}
	}
	public void gameStart() {
		enabled = true;
	}
	public void gameEnd() {
		enabled = false;
	}
}