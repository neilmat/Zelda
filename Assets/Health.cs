using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health;
	public Transform itemPrefab;
	public void setHealth(int health_){
		health = health_;
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(!col.CompareTag("Player") || !playerState.attacking) return;
		health--;
		if(health == 0) 
		{
			drop();
			Destroy(this.gameObject);
		}
	}

	private void drop()
	{
		int rate = RandomNumberGenerator.getRandomNumber (1, 2);
		if(rate == 1)
		{
			var item = Instantiate (itemPrefab) as Transform;
			item.position = transform.position;
		}
	}
}

