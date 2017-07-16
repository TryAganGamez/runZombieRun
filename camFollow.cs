using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour {

	[SerializeField] Transform player;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}

