using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAll : MonoBehaviour {


	public GameObject platformDestroyer;

	void Start(){
		platformDestroyer = GameObject.Find ("platformDestroyer");

	}

	void Update(){
		if (transform.position.x < platformDestroyer.transform.position.x) {
			Destroy (gameObject);

		}
	}
}