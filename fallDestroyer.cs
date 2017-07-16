using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fallDestroyer : MonoBehaviour {

	public Button[] buttons;
	public Text scoretxt,high;
	int score;
	bool gameOver;
	int highscore;
	float highscoreCount=0f;
	public Image deathScreen;
	AudioSource playerDeathSound;

	void Start () {
		if (PlayerPrefs.GetFloat ("HIGHEST") != null) {
			highscoreCount = PlayerPrefs.GetFloat ("HIGHEST");
		}
		gameOver = false;
		score = 0;
		highscore = PlayerPrefs.GetInt ("score",highscore);
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
		playerDeathSound = GetComponent<AudioSource> ();
	} 

	void Update () {
		if (score > highscoreCount) {
			highscoreCount = score;
			PlayerPrefs.SetFloat ("HIGHEST", highscoreCount);
		}
		high.text = "HIGHEST: " + Mathf.Round (highscoreCount);
		scoretxt.text = "Score: " + score;	//Maybe put + coinScore here...
	} 

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			playerDeathSound.Play ();
			Destroy (other.gameObject);
			CancelInvoke ();
			makeDead ();
		}
	}
	public void makeDead(){

		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);
			deathScreen.gameObject.SetActive (true);

		}

	}


	void scoreUpdate(){
		if (gameOver == false) {
			score += 5;

		}
	} 

	public void increaseScore(int amount){

		score += amount;
		//scoreUpdate ();
	}

	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}

	public void Play(){
		SceneManager.LoadScene ("one");	
	}

	public void Menu(){
		SceneManager.LoadScene ("menu");
	}

}