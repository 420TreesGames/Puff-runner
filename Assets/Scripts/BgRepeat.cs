using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRepeat : MonoBehaviour {
	public Sprite[] backgroundsIMG;
	[Range(1f,50f)]
	public float scrollSpeed =1f;
	public float scrollOffset;
	Vector2 startPos;
	float newPos;
	SpriteRenderer currentSprite;
	bool toChange;
	void Start () {
		startPos=transform.position;
		currentSprite=GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		newPos=Mathf.Repeat(Time.time*-scrollSpeed,scrollOffset);
		transform.position=startPos+Vector2.right*newPos;
		// if(transform.position.x<=scrollOffset+2&&toChange)
		// {
		// 	int rand=Random.Range(0,backgroundsIMG.Length);
		// 	currentSprite.sprite=backgroundsIMG[rand];
		// 	toChange=false;
		// }
	}

}
