using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpHeight;
	[HideInInspector]
	public Rigidbody2D rb;
	bool isGrounded;
	[HideInInspector]
	public float score; 
	[SerializeField]
	background bg;
	[HideInInspector]
	public bool lose;
	[HideInInspector]
	public BoxCollider2D collider;
	void Start () {
		rb=GetComponent<Rigidbody2D>();
		collider=GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame

	public void Jump(){
		if(isGrounded&&!lose)
		rb.velocity= new Vector2(rb.velocity.x,jumpHeight);
	}
	void OnTriggerStay2D(Collider2D col) {
		if(col.gameObject.tag=="GroundCol")
			 isGrounded=true;
		if(col.gameObject.tag=="Enemy")
			lose=true;
	}
	void OnTriggerExit2D(Collider2D col) {
		if(col.gameObject.tag=="GroundCol")
			 isGrounded=false;
	}


}
