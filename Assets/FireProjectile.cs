using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public Transform shotPrefab;
	// Use this for initialization
	public void fire(Vector2 vel, int rotate = 0)
	{
		var shot = Instantiate (shotPrefab) as Transform;
		shot.position = transform.position;
		shot.gameObject.rigidbody2D.velocity = vel;
		shot.transform.Rotate (0,0,rotate);
	}
}
