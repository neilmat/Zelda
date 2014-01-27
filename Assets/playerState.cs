using UnityEngine;
using System.Collections;

public class playerState : MonoBehaviour {

	public static bool disabled = false;
	public static int health = 6;
	public static int facing = 0;
	public static bool attacking = false;

	void Update(){
		if(edgeDetection.panning) this.gameObject.collider2D.isTrigger = true;
		else this.gameObject.collider2D.isTrigger = false;
	}
}
