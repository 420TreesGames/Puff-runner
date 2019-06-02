using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {
	public float speed;
	public float maxSpeed;
	public float width;
	public bool randSprite;
	
	public float speedCoef;
	public Sprite[] sprites;
	SpriteRenderer spriteRender;
	Rigidbody2D rb;

	void Start () {
		
		rb=GetComponent<Rigidbody2D>();
		if(randSprite)
			spriteRender=GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(speed>=maxSpeed)
			speed-=speedCoef;
			rb.velocity=new Vector2(speed,0);
		if(transform.position.x<-width){
			Reposition();
		}
	}
	void Reposition(){
		if(randSprite){
			int rand= Random.Range(0,sprites.Length);
			spriteRender.sprite=sprites[rand];
		}
		Vector2 vector = new Vector2(width*2f,0);
		transform.position=(Vector2)transform.position+vector;
	}
}
