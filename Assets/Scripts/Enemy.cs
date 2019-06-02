using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	background groundSpeed;
	float speed;
	Rigidbody2D rb;

	void Start () {
		groundSpeed=GameObject.FindGameObjectWithTag("Ground").GetComponent<background>();
		rb=GetComponent<Rigidbody2D>();
	}

	void Update () {
		speed=groundSpeed.speed;
		rb.velocity= Vector2.right*speed;		
		
	}
}
