using UnityEngine;
using System.Collections;

public class TektiteActivation : Activation {
	public override void activate()
	{
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		gameObject.GetComponent<Animator> ().enabled = true;
		gameObject.GetComponent<TektiteState> ().enabled = true;
	}
	
	public override void deactivate()
	{
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<Animator> ().enabled = false;
		gameObject.GetComponent<TektiteState> ().enabled = false;
		gameObject.rigidbody2D.velocity = Vector2.zero;
	}
}
