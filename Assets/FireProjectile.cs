using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public Transform shotPrefab;
	// Use this for initialization
	public void fire(Vector2 vel)
	{
		var shot = Instantiate (shotPrefab) as Transform;
		shot.position = transform.position;
		shot.gameObject.rigidbody2D.velocity = vel;
	}
}
