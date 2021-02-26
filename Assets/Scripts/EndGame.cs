using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

	public Text scoreText;
	public Text bestText;

	public int bestScore;

	public GameObject endGameCanvas;

	// Start is called before the first frame update
	void Start ()
	{	
		endGameCanvas.SetActive(false);
		//get last best score
		bestScore = PlayerPrefs.GetInt("bestScore");
	}

	// Update is called once per frame
	void Update ()
	{
        if(DestroyCircleSquare.endGame == true){
			endGameScores();
		}
	}
	public void endGameScores(){
		//endGameCanvas controller
		endGameCanvas.SetActive(true);
		//bestscore controller
		if(ScoreManager.score > bestScore){
			PlayerPrefs.SetInt("bestScore",ScoreManager.score);
		}
		//get best score
		bestScore = PlayerPrefs.GetInt("bestScore");

		//text scores
		scoreText.text = "" + ScoreManager.score;
		bestText.text = "" + bestScore;

		DestroyCircleSquare.endGame = false;

	}
	public void RestartButton(){
		
		SceneManager.LoadScene("inGame");
	}
}
