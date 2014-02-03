using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {
	public Transform effectPrefab;
	public Transform spawnPrefab;
	public int start_facing = 0;
	private float timer;
	private bool start;
	private bool effect_done = false;
	// Use this for initialization
	public void OnBecameVisible () {
		timer = 0;
		start = true;
	}

	public void spawn (){
		}
	
	// Update is called once per frame
	void Update () {
		if(!start || PanScript.panning) return;
		timer += Time.deltaTime;
		if(!effect_done)
		{
			var effect = Instantiate (effectPrefab)as Transform;
			effect.position = transform.position;
			Destroy (effect.gameObject, .75f);
			effect_done = true;
		}

		if(timer > .75f)
		{
			var spawn = Instantiate(spawnPrefab) as Transform;
			spawn.position = transform.position;
			spawn.gameObject.GetComponent<enemyMovement>().face = start_facing;
			Destroy (this.gameObject);
		}
	}
}
