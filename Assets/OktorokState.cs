using UnityEngine;
using System.Collections;

public class OktorokState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CreatureState cs = this.gameObject.GetComponent<CreatureState> ();
		cs.setHealth (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
