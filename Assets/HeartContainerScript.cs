using UnityEngine;
using System.Collections;

public class HeartContainerScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		if (!col.gameObject.CompareTag ("Player"))
						return;
		playerState.maxHealth += 2;
		playerState.health += 2;
		print ("Player has " + playerState.maxHealth + " max Health");
		Destroy (this.gameObject);
	}
}
