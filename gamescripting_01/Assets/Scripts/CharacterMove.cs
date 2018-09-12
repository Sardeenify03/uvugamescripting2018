using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
	public int MoveSpeed;
	public float JumpHeight;

	//Player grounded vars
	public transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	// Use this for initialization
	void Start () {
		print("alsdkfasdlkfj");
			
		
	}

	void Fixedupdate () {
		grounded = physics2D.overlapcircle(groundCheck,position,groundCheckRadius,whatIsGround);
	}
	
	// Update is called once per frame
	void Update () {
		
		//jump
		if(input.GetKeyDown (KeyCode.Space)&& grounded){
			Jump();
		}
		// move
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			
		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			
		}

	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
	}

	public void Jump(){
		getComponent<RigidBody2D>().velocity = new Vector2(getComponent<RigidBody2D>().velocity.x, JumpHeight);
	}

	//move
pu
	
}
