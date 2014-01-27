using UnityEngine;
using System.Collections;
using System;

public class enemyCollision : MonoBehaviour {

	public static bool hurt = false;
	public static int timer = 20;
	// Use this for initialization

	void OnTriggerEnter2D(Collider2D col)
	{
		int direction = getDirection (col);
		if(col.CompareTag("Enemy")) enemyTouch(direction);
		else if(col.CompareTag("Projectile")) projectileTouch(direction, col);
	}

	void projectileTouch(int direction, Collider2D col)
	{
		/*
		if(direction != playerState.facing || playerState.attacking)
		{
			playerState.health -= col.gameObject.GetComponent<ProjectileScript>().damage;
			Destroy(col.gameObject);
		}
		else
		{
			Vector2 vel = col.gameObject.rigidbody2D.velocity;
			if(playerState.facing % 2 == 1) vel.x = -vel.x;
			else vel.y = -vel.y;
			col.gameObject.rigidbody2D.velocity = vel;
		}
		*/
		if(direction == playerState.facing && !playerState.attacking)
		{
			Vector2 vel = col.gameObject.rigidbody2D.velocity;
			if(playerState.facing % 2 == 1) vel.x = -vel.x;
			else vel.y = -vel.y;
			col.gameObject.rigidbody2D.velocity = vel;
		}
		else
		{
			playerState.health -= col.gameObject.GetComponent<ProjectileScript>().damage;
			Destroy(col.gameObject);
		}
	}

	void enemyTouch(int direction)
	{
		if(playerState.attacking && direction == playerState.facing) return;
		
		playerState.health--;
		playerState.disabled = true;
		hurt = true;
		rebound(direction);
	}
	void rebound(int direction)
	{
		Vector2 vel = rigidbody2D.velocity;
		vel.x = vel.y = 0;
		int flip = 1;
		if (direction == playerState.facing)
						flip = -1;
		if(playerState.facing == 0) vel.y = -5 * flip;
		else if(playerState.facing == 1) vel.x = -5 * flip;
		else if(playerState.facing == 2) vel.y = 5 * flip;
		else if(playerState.facing == 3) vel.x = 5 * flip;

		rigidbody2D.velocity = vel;
	}

	int getDirection(Collider2D col)
	{
		Vector2 pos = this.gameObject.transform.position - col.gameObject.transform.position;
		Vector2 npos = pos.normalized;

		if(Math.Abs(npos.x)>Math.Abs(npos.y))
		{
			if(npos.x > 0) return 1;
			else return 3;
		}
		else
		{
			if(npos.y > 0) return 0;
			else return 2;
		}
	}
}
