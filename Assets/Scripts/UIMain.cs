using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIMain : MonoBehaviour {
	[SerializeField]
	Text scoreTxt;
	float score;
	[SerializeField]
	float scoreCoef;
	[SerializeField]
	background bg;
	[SerializeField]
	Player player;
	[SerializeField]
	GameObject losePanel;
	[SerializeField]
	Text gameOver_score;
	[SerializeField]
	Text gameOver_bestScore;
	float bestScore;
	[SerializeField]
	Text weedText;

	void Update () {
		Score();
		if(player.lose)
		GameOver();
		Weed();
	}
	void Score(){
		score+=scoreCoef;
		scoreTxt.text="Score: "+Mathf.Ceil(score).ToString();
	}
	void Weed(){
		weedText.text=player.weed.ToString();
	}
	void GameOver(){
		bestScore=PlayerPrefs.GetFloat("bestScore");
		if(bestScore<score)
		PlayerPrefs.SetFloat("bestScore",score);
		bestScore=PlayerPrefs.GetFloat("bestScore");
		losePanel.SetActive(true);
		gameOver_score.text="Score : "+Mathf.Ceil(score).ToString();		
		gameOver_bestScore.text="Best: "+Mathf.Ceil(bestScore).ToString();
		scoreCoef=0;
		player.GetComponent<CapsuleCollider2D>().isTrigger=true;
		if(player.transform.position.y<-10)
		player.rb.constraints=RigidbodyConstraints2D.FreezeAll;

	}
	
}
