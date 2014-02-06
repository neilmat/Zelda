using UnityEngine;
using System.Collections;

public class RupeeScript : MonoBehaviour {

	public int value = 1;
	void OnCollisionEnter2D(Collision2D col)
	{
		if (!col.gameObject.CompareTag ("Player"))
			return;
		playerState.money += value;
		print ("Player has " + playerState.money + " Money");
		Destroy (this.gameObject);
	}
}
