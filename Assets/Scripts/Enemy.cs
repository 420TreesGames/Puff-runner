using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	[SerializeField] Sprite[] sprite;
	Image image;
	background groundSpeed;
	float speed;
	Rigidbody2D rb;

	void Start () {
		image=GetComponent<Image>();
		groundSpeed=GameObject.FindGameObjectWithTag("Ground").GetComponent<background>();
		rb=GetComponent<Rigidbody2D>();
		RandomSprite();

	}

	void Update () {
		speed=groundSpeed.speed;
		rb.velocity= Vector2.right*speed;		
		
	}
	void RandomSprite(){
		int random = Random.Range(0,sprite.Length);
		image.sprite=sprite[random];
	}
}
