using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (!col.gameObject.CompareTag ("Player"))
			return;
		playerState.health++;
		if (playerState.health > playerState.maxHealth)
						playerState.health = playerState.maxHealth;
		print ("Player has " + playerState.health + " Health");
		Destroy (this.gameObject);
	}
}
