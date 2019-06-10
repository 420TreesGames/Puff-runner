using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gradient : MonoBehaviour {
	public Color32[] colors;
	Image sprite;
	public float maxTime;
	float time;
	void Start(){
		sprite= GetComponent<Image>();
		Repeat();
	}
	void Repeat(){
		StartCoroutine(Color(0,maxTime));
	}
	
	IEnumerator Color(float start ,float finish){
		int rand= Random.Range(0,colors.Length);
		
		while(start<finish){
			start+=Time.deltaTime;
		sprite.color= Color32.Lerp(sprite.color,colors[rand],start*0.003f);
		yield return null;}
		Repeat();
	}
}
