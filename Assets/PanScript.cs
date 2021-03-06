﻿using UnityEngine;
using System.Collections;

public class PanScript : MonoBehaviour {

	// Use this for initialization
	private float panSpeed = .15f;
	public static bool panning;
	public Vector3 panVector = Vector3.zero;
	void Start () {
		panning = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(panning)
		{
			Camera.main.transform.Translate(panVector);
		}
	}

	void OnCollisionEnter2D (Collision2D coll) 
	{
		if(!coll.gameObject.CompareTag("Player")) return;
		if(!panning)
		{
			panVector = Vector3.zero;
			playerState.disabled = true;
			panning = true;
			if(playerState.facing == 0) panVector.y = -panSpeed;
			else if(playerState.facing == 1) panVector.x = -panSpeed;
			else if(playerState.facing == 2) panVector.y = panSpeed;
			else if(playerState.facing == 3) panVector.x = panSpeed;
			Physics2D.IgnoreLayerCollision(8, 11, true);
			Physics2D.IgnoreLayerCollision(8, 13, true);
		}
		else
		{
			panning = false;
			playerState.disabled = false;
			Physics2D.IgnoreLayerCollision(8, 11, false);
			Physics2D.IgnoreLayerCollision(8, 13, true);
		}
	}
}
