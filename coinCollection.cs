using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection : MonoBehaviour {

	public AudioClip collectSound;
	//Need a scoreScript
	fallDestroyer scoreScript;
	public int scoreToGive;


	void Start(){
		scoreScript = FindObjectOfType<fallDestroyer> ();

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			scoreScript.increaseScore(scoreToGive);
			AudioSource.PlayClipAtPoint(collectSound,transform.position);
			Destroy (this.gameObject);

		}
	}
}
