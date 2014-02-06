using UnityEngine;
using System.Collections;

public class LinkSwordScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		playerState.canShoot = false;
	}
	
	// Update is called once per frame
	void OnDestroy()
	{
		playerState.canShoot = true;
	}
}
