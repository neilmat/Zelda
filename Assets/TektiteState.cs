using UnityEngine;
using System.Collections;

public class TektiteState : MonoBehaviour {
	private float timer;
	private Vector2 vel;
	public bool jumping = false;
	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > 5 && !jumping)
		{
			vel.x = Random.Range(-5,6);
			vel.y = Random.Range(3,9);
			this.gameObject.GetComponent<Rigidbody2D>().velocity = vel;
			this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
			timer = 0;
			jumping = true;
			this.gameObject.GetComponent<Animator>().SetBool("Jumping", true);
		}
		else if(timer > 1 && jumping)
		{
			vel.x = vel.y = 0;
			this.gameObject.GetComponent<Rigidbody2D>().velocity = vel;
			this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
			timer = 0;
			jumping = false;
			this.gameObject.GetComponent<Animator>().SetBool("Jumping", false);
		}
	}
}

