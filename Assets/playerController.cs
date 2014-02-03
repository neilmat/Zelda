using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	private Animator animator;
	private int timer;
	private float attackTimer;
	private BoxCollider2D sword;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		timer = 20;
		attackTimer = 0;
		sword = this.gameObject.AddComponent<BoxCollider2D> ();
		sword.isTrigger = true;
		sheathe ();
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyCollision.hurt)
		{
			enemyCollision.timer--;
			if(enemyCollision.timer == 0)
			{
				enemyCollision.timer = 20;
				enemyCollision.hurt = false;
				playerState.disabled = false;
				Physics2D.IgnoreLayerCollision (8, 11, false);
			}
			return;
		}

		if(playerState.attacking)
		{
			attackTimer += Time.deltaTime;
			if(attackTimer > .25)
			{
				playerState.attacking = false;
				attackTimer = 0;
				animator.SetBool("Attacking", false);
				sheathe ();
			}
		}
		if(playerState.disabled) return;

		if(Input.GetKeyDown(KeyCode.X))
		{
			playerState.attacking = true;
			animator.SetBool("Attacking", true);
			extendSword();
		}

		var vertical = Input.GetAxis ("Vertical");
		var horizontal = Input.GetAxis ("Horizontal");
		int curr_direction = animator.GetInteger ("Direction");

		if (vertical > 0) 
		{
			playerState.facing = 2;
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
			playerState.facing = 0;
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
			playerState.facing = 3;
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
			playerState.facing = 1;
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

	void extendSword()
	{
		Vector2 center = sword.center;
		Vector2 size = sword.size;
		size.x = 1;
		size.y = 1;
		if(playerState.facing % 2 == 0) size.x = .4f;
		else size.y = .4f;
		if(playerState.facing == 0) center.y = -.5f;
		else if(playerState.facing == 1) center.x = -.5f;
		else if(playerState.facing == 2) center.y = .5f;
		else if(playerState.facing == 3) center.x = .5f;
		sword.center = center;
		sword.size = size;
		playerState.disabled = true;
		rigidbody2D.velocity = Vector2.zero;
	}

	void sheathe()
	{
		Vector2 zero = sword.size;
		zero.x = 0;
		zero.y = 0;
		sword.size = zero;
		sword.center = zero;
		playerState.disabled = false;
	}
}
