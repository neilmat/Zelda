using UnityEngine;
using System.Collections;

public class edgeDetection : MonoBehaviour {

	public static bool panning;
	private int pan_direction;
	public float pan_remaining;

	// Use this for initialization
	void Start () {
		panning = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
		//if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0) return;
		if(!panning)
		{
			if(pos.x < 0.0085 && Input.GetAxis("Horizontal") < 0)
			{
				//Camera.main.transform.Translate(-Camera.main.orthographicSize * Screen.width / Screen.height, 0, 0);
				pan_direction = 1;
				panning = true;
				playerState.disabled = true;
			}
			
			if(0.9915 < pos.x && Input.GetAxis("Horizontal") > 0) 
			{
				//Camera.main.transform.Translate(Camera.main.orthographicSize * Screen.width / Screen.height, 0, 0);
				pan_direction = 3;
				panning = true;
				playerState.disabled = true;
			}
			
			if(pos.y < 0.0025 && Input.GetAxis("Vertical") < 0)
			{
				//Camera.main.transform.Translate(0, -Camera.main.orthographicSize, 0);
				pan_direction = 0;
				panning = true;
				playerState.disabled = true;
			}
			
			if(0.9975 < pos.y && Input.GetAxis("Vertical") > 0)
			{
				//Camera.main.transform.Translate(0, Camera.main.orthographicSize, 0);
				pan_direction = 2;
				panning = true;
				playerState.disabled = true;
			}
		}
		else
		{
			if(pan_direction == 0)
			{
				if(pos.y < 0.9975)Camera.main.transform.Translate(0, -9*Time.deltaTime, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 1)
			{
				if(pos.x < 0.9915)Camera.main.transform.Translate(-9*Time.deltaTime, 0, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 2)
			{
				if(pos.y > 0.0025)Camera.main.transform.Translate(0, 9*Time.deltaTime, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 3)
			{
				if(pos.x > 0.0025)Camera.main.transform.Translate(9*Time.deltaTime, 0, 0);
				else panning = playerState.disabled = false;
			}
		}
	}
}
