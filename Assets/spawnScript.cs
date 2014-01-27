﻿using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {
	public Transform effectPrefab;
	public Transform spawnPrefab;
	private float timer;
	private bool start;
	// Use this for initialization
	void OnBecameVisible () {
		timer = 0;
		var effect = Instantiate (effectPrefab)as Transform;
		effect.position = transform.position;
		Destroy (effect.gameObject, .75f);
		start = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(start) timer += Time.deltaTime;
		if(timer > .75)
		{
			var spawn = Instantiate(spawnPrefab) as Transform;
			spawn.position = transform.position;
			Destroy (this.gameObject);
		}
	}
}
