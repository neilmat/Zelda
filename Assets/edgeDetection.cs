using UnityEngine;
using System.Collections;

public class edgeDetection : MonoBehaviour {

	private bool panning;
	private int pan_direction;
	// Use this for initialization
	void Start () {
		panning = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
		
		if(!panning)
		{
			if(pos.x < 0.0085)
			{
				//Camera.main.transform.Translate(-Camera.main.orthographicSize * Screen.width / Screen.height, 0, 0);
				pan_direction = 1;
				panning = true;
				playerState.disabled = true;
			}
			
			if(0.9915 < pos.x) 
			{
				//Camera.main.transform.Translate(Camera.main.orthographicSize * Screen.width / Screen.height, 0, 0);
				pan_direction = 3;
				panning = true;
				playerState.disabled = true;
			}
			
			if(pos.y < 0.0025)
			{
				//Camera.main.transform.Translate(0, -Camera.main.orthographicSize, 0);
				pan_direction = 0;
				panning = true;
				playerState.disabled = true;
			}
			
			if(0.9975 < pos.y)
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
				if(pos.y < 0.95)Camera.main.transform.Translate(0, -9*Time.deltaTime, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 1)
			{
				if(pos.x < 0.96)Camera.main.transform.Translate(-9*Time.deltaTime, 0, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 2)
			{
				if(pos.y > 0.05)Camera.main.transform.Translate(0, 9*Time.deltaTime, 0);
				else panning = playerState.disabled = false;
			}
			else if(pan_direction == 3)
			{
				if(pos.x > 0.04)Camera.main.transform.Translate(9*Time.deltaTime, 0, 0);
				else panning = playerState.disabled = false;
			}
		}
	}
}
