using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoretxt,high;
	int score;
	bool gameOver;
	int highscore;
	float highscoreCount=0f;


	public void makeDead(){
		foreach(Button button in buttons){
			button.gameObject.SetActive (true);
		}
	}

	public void Menu(){

		SceneManager.LoadScene ("menu");
	}

	public void Play(){
		SceneManager.LoadScene ("one");

	}

	public void credits(){
		SceneManager.LoadScene ("credits");

	}
	public void Exit(){
		Application.Quit ();

	}
}