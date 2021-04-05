using UnityEngine;
using System.Collections;

public class Tracker : MonoBehaviour {
	
	
	public Transform Player; //The position of the player.
	public float minDistance = 1f; //private float Distance;
	public float smoothTime = 1.0f; //Approximately the time it will take to reach the target. A smaller value will reach the target faster.
	private Vector3 smoothVelocity = Vector3.zero; //Vector3 used to store the velocity of the enemy
	
	
	void Update ()
	{
		transform.right = Player.position - transform.position;  //Enemy will look and follow, where the player moves.
		
		var Distance = Vector3.Distance(transform.position, Player.position); //This gives us the distance between the enemy & the player.
		
		
		if(Distance < minDistance) //If the distance is smaller than the minumin distance, it will activate to chase the player.
		{
			transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime); //Used smoothdamp to track the enmy player and follow it.
		}
	}
}	
