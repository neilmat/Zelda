using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	private Animator animator;
	private int timer;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		timer = 20;
	}
	
	// Update is called once per frame
	void Update () {
		if(edgeDetection.panning == true) return;
		var vertical = Input.GetAxis ("Vertical");
		var horizontal = Input.GetAxis ("Horizontal");
		int curr_direction = animator.GetInteger ("Direction");

		if (vertical > 0) 
		{
			if(curr_direction == 2 && timer == 0)
			{
				animator.SetInteger("Direction", 6);
				timer = 20;
			}
			else if(curr_direction == 6 && timer == 0)
			{
				animator.SetInteger("Direction", 2);
				timer = 20;
			}
			else if(curr_direction != 2 && curr_direction != 6)
			{
				animator.SetInteger("Direction", 2);
				timer = 20;
			}
			else
			{
				timer--;
			}
		}
		if (vertical < 0) 
		{
			if(curr_direction == 0 && timer == 0)
			{
				animator.SetInteger("Direction", 4);
				timer = 20;
			}
			else if(curr_direction == 4 && timer == 0)
			{
				animator.SetInteger("Direction", 0);
				timer = 20;
			}
			else if(curr_direction != 0 && curr_direction != 4)
			{
				animator.SetInteger("Direction", 0);
				timer = 20;
			}
			else
			{
				timer--;
			}
		}
		if (horizontal > 0) 
		{
			if(curr_direction == 3 && timer == 0)
			{
				animator.SetInteger("Direction", 7);
				timer = 20;
			}
			else if(curr_direction == 7 && timer == 0)
			{
				animator.SetInteger("Direction", 3);
				timer = 20;
			}
			else if(curr_direction != 3 && curr_direction != 7)
			{
				animator.SetInteger("Direction", 3);
				timer = 20;
			}
			else
			{
				timer--;
			}
		}
		if (horizontal < 0) 
		{
			if(curr_direction == 1 && timer == 0)
			{
				animator.SetInteger("Direction", 5);
				timer = 20;
			}
			else if(curr_direction == 5 && timer == 0)
			{
				animator.SetInteger("Direction", 1);
				timer = 20;
			}
			else if(curr_direction != 1 && curr_direction != 5)
			{
				animator.SetInteger("Direction", 1);
				timer = 20;
			}
			else
			{
				timer--;
			}
		}

	}
}
