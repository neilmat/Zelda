using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D col)
	{
		playerState.health++;
		print ("Player has " + playerState.health + " Health");
		Destroy (this.gameObject);
	}
}
