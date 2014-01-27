using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour
{
	public int damage;

	public void setVelocity(Vector2 vel)
	{
		rigidbody2D.velocity = vel;
	}
	void Start()
	{
		Destroy(gameObject, 5);
	}
}
