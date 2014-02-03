using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour
{
	public int damage;

	public void setVelocity(Vector2 vel)
	{
		rigidbody2D.velocity = vel;
	}

	void Update()
	{
		if(PanScript.panning)Destroy (gameObject);
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
