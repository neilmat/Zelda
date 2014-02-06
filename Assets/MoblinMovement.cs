using UnityEngine;
using System.Collections;

public class MoblinMovement : enemyMovement {

	private int timer;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("Direction", face);
		timer = 100;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vel = rigidbody2D.velocity;
		int direction = animator.GetInteger ("Direction");
		if (timer == 0)
		{
			int new_direction = (direction + 1)%4;
			animator.SetInteger("Direction", new_direction);
			direction = new_direction;
			timer = 100;
		}
		else
		{
			timer--;
		}
		
		if(direction == 0)
		{
			vel.x = 0;
			vel.y = -speed;
		}
		else if(direction == 1)
		{
			vel.x = -speed;
			vel.y = 0;
		}
		else if(direction == 2)
		{
			vel.x = 0;
			vel.y = speed;
		}
		else if(direction == 3)
		{
			vel.x = speed;
			vel.y = 0;
		}
		rigidbody2D.velocity = vel;
	}
}
