using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public int score = 0;
	//public int money = 10;

	public Text scoreText;

	void Update() {
		
		scoreText.text = "Score: " + score.ToString();

	}

}