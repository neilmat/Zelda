using UnityEngine;
using System.Collections;

public class ActivatorScript : MonoBehaviour {
	public new bool active = false;
	public bool standby = false;

	void Start(){
		this.gameObject.GetComponent<Activation> ().deactivate ();
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.gameObject.layer != 10) return;
		standby = true;

	}

	void Update()
	{
		if(!standby || PanScript.panning) return;
		active = !active;
		standby = false;
		if(active)
		{
			this.gameObject.GetComponent<Activation>().activate();
		}
		else
		{
			this.gameObject.GetComponent<Activation>().deactivate();
		}
	}
}
