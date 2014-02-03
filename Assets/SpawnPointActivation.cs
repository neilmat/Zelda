using UnityEngine;
using System.Collections;

public class SpawnPointActivation : Activation {

	public override void activate()
	{
		gameObject.GetComponent<spawnScript> ().spawn ();
	}

	public override void deactivate()
	{

	}
}
