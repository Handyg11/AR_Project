using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
	public float timeAfterHit = .5f;

	public int enemyHealth = 100;
	public Text healthText;
	public GameObject winCanvas, healthObject;

	void Start(){
		winCanvas.SetActive(false);
	}

	void Update(){
		healthText.text = "Health: " + enemyHealth;
	}
	public void Hit()
	{
		enemyHealth= enemyHealth-10;
		if(enemyHealth<=0){
			healthObject.SetActive(false);
			winCanvas.SetActive(true);
			Destroy(gameObject, timeAfterHit);
		}
	}

	public void OnResetTracking(){
		enemyHealth = 100;
	}
}
