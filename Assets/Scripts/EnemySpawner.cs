﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	[SerializeField]
	GameObject[] prefabs;
	[SerializeField]
	Vector2 spawnPosition;
	[SerializeField]
	List <GameObject> enemyList;
	[Header("Random")]
	[SerializeField]
	float minRand;
	[SerializeField]
	float maxRand;

	void Start () {
		Repeat();
	}
	

	void Update () {
		DestroyEnemy();
	}

	void DestroyEnemy(){
		for(int i=0;i<enemyList.Count;i++){
			if(enemyList[i].transform.position.x<-12){
				Destroy(enemyList[i]);
				enemyList.Remove(enemyList[i]);
				
				
			}
		}
	}
	IEnumerator Spawn(){
		int rand= Random.Range(0,prefabs.Length);
		GameObject enemy=	Instantiate(prefabs[rand], spawnPosition,Quaternion.identity,transform);
		enemyList.Add(enemy);
		yield return new WaitForSeconds(Random.Range(minRand,maxRand));
		Repeat();
	}
	void Repeat(){
		StartCoroutine(Spawn());
	}
}
