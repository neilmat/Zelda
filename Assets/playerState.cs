using UnityEngine;
using System.Collections;

public class playerState : MonoBehaviour {

	public static bool disabled = false;
	public static int health = 6;
	public static int maxHealth = 6;
	public static int facing = 0;
	public static bool attacking = false;
	public static int money;

	void Update(){
		if(health > maxHealth)
		{
			health = maxHealth;
		}
	}
}
