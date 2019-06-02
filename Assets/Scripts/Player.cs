 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpHeight;
	Rigidbody2D rb;
	bool isGrounded;
	void Start () {
		rb=GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Jump(){
		if(isGrounded)
		rb.velocity= new Vector2(rb.velocity.x,jumpHeight);
	}
	void OnCollisionStay2D(Collision2D col) {
		if(col.gameObject.tag=="Ground")
			 isGrounded=true;
	}
	void OnCollisionExit2D(Collision2D col) {
		if(col.gameObject.tag=="Ground")
			 isGrounded=false;
	}
}
