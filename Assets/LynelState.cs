using UnityEngine;
using System.Collections;

public class LynelState : MonoBehaviour {

	private float attack_timer;
	public int speed = 7;
	
	// Use this for initialization
	void Start () {
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
		int rotate = 0;
		Vector2 vel = Vector2.zero;
		
		if(direction == 0)
		{
			vel.y = -speed;
		}
		else if(direction == 1) 
		{
			vel.x = -speed;
			rotate = -90;
		}
		else if(direction == 2) 
		{
			vel.y = speed;
			rotate = 180;
		}
		else if(direction == 3) 
		{
			vel.x = speed;
			rotate = 90;
		}
		
		this.gameObject.GetComponent<FireProjectile> ().fire (vel, rotate);
	}
}
