using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {
	public Transform effectPrefab;
	public Transform spawnPrefab;
	public int start_facing = 0;
	private float timer;
	private bool start;
	// Use this for initialization
	public void spawn () {
		timer = 0;
		var effect = Instantiate (effectPrefab)as Transform;
		effect.position = transform.position;
		Destroy (effect.gameObject, .75f);
		start = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(start && gameObject.GetComponent<ActivatorScript>().active) timer += Time.deltaTime;
		if(timer > .75)
		{
			var spawn = Instantiate(spawnPrefab) as Transform;
			spawn.position = transform.position;
			spawn.gameObject.GetComponent<enemyMovement>().face = start_facing;
			Destroy (this.gameObject);
		}
	}
}
