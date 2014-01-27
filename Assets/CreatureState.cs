using UnityEngine;
using System.Collections;

public class CreatureState : MonoBehaviour {

	public int health;

	public void setHealth(int health_){
		health = health_;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(!col.CompareTag("Player") || !playerState.attacking) return;
		health--;
		if(health == 0) Destroy(this.gameObject);
	}
}

