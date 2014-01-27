using UnityEngine;
using System.Collections;

public class OktorokState : MonoBehaviour {
	private float attack_timer;
	// Use this for initialization
	void Start () {
		CreatureState cs = this.gameObject.GetComponent<CreatureState> ();
		cs.health = 1;
		attack_timer = 3;
	}
	
	// Update is called once per frame
	void Update () {
		attack_timer -= Time.deltaTime;
		if(attack_timer < 0)
		{
			shoot();
			attack_timer = 3;
		}
	}

	void shoot()
	{
		int direction = this.gameObject.GetComponent<Animator> ().GetInteger ("Direction");
		Vector2 vel = Vector2.zero;

		if(direction == 0) vel.y = -5;
		else if(direction == 1) vel.x = -5;
		else if(direction == 2) vel.y = 5;
		else if(direction == 3) vel.x = 5;

		this.gameObject.GetComponent<FireProjectile> ().fire (vel);
	}
}
