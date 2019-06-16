using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class background : MonoBehaviour {
	public float speed;
	
	[SerializeField]
	float maxSpeed;
	[SerializeField]
	bool randSprite;
	[SerializeField]
	float speedCoef;
	[SerializeField]
	Sprite[] sprites;
	[SerializeField]
	Player player;
	float width;
	Image spriteRender;
	Rigidbody2D rb;
	Image imgWidth;

	void Start () {
		width=GetComponent<Image>().rectTransform.sizeDelta.x;
		Debug.Log(width);
		rb=GetComponent<Rigidbody2D>();
		if(randSprite)
			spriteRender=GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!player.lose){
		Move();
		}
		else {speed=0;rb.velocity=new Vector2(0,0);}
	}
	void Reposition(){
		
		if(randSprite){
			int rand= Random.Range(0,sprites.Length);
			spriteRender.sprite=sprites[rand];
		}
		Vector2 vector = new Vector2(width*2f,0);
		transform.localPosition=(Vector2)transform.localPosition+vector;
	}
	void Move(){
		if(speed>=maxSpeed)
			speed-=speedCoef;
			rb.velocity=new Vector2(speed,0);
		if(transform.localPosition.x<-width){
			Reposition();
		}
	}
 
}
