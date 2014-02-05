using UnityEngine;
using System.Collections;

public class RandomNumberGenerator : MonoBehaviour {

	public static int getRandomNumber (int min, int max)
	{
		return Random.Range (min, max);
	}
}
