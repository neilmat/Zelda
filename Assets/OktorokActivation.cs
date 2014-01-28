using UnityEngine;
using System.Collections;

public class OktorokActivation : Activation {

	public override void activate()
	{
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		gameObject.GetComponent<Animator> ().enabled = true;
		gameObject.GetComponent<enemyMovement> ().enabled = true;
		gameObject.GetComponent<OktorokState> ().enabled = true;
	}

	public override void deactivate()
	{
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<Animator> ().enabled = false;
		gameObject.GetComponent<enemyMovement> ().enabled = false;
		gameObject.GetComponent<OktorokState> ().enabled = false;
		gameObject.rigidbody2D.velocity = Vector2.zero;
	}
}
