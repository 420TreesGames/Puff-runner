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

	void Update () {
		Score();
		if(player.lose)
		GameOver();
	}
	void Score(){
		score+=scoreCoef;
		scoreTxt.text="Score: "+Mathf.Ceil(score).ToString();
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
		player.collider.isTrigger=true;
		if(player.transform.position.y<-10)
		player.rb.constraints=RigidbodyConstraints2D.FreezeAll;

	}
	public void Restart(){
		SceneManager.LoadScene(0);
	}
}
