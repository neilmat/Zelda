using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
	public float speed = 1;
	protected Animator animator;
	public int face = 0;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("Direction", face);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
