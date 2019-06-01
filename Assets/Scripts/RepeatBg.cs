using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour {

	public int speed;
	public float endX;
	public float startX;
	void Start(){
		Debug.Log("2");
	}
	private void Update() {
		
		transform.Translate(Vector2.left*speed*Time.deltaTime);
		if(transform.position.x<=endX){
			Vector3 pos = new Vector3(startX, transform.position.y,2);
			transform.position=pos;
		}
	}
}
