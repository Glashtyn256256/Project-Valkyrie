using UnityEngine;
using System.Collections;

public class RedBlood : MonoBehaviour {

		
	public float maxSpeed = 50f;
	public float leftLimit, rightLimit, bottomLimit, topLimit;
	
	// Update is called once per frame
	void Update () {
		
		Vector3 pos = transform.position;    //gets the position
		
		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);  //gets the velocity force
		
		pos -= transform.rotation * velocity;    //used to create downwards movement
		
		transform.position = pos;        
		
		//hits the borders destroy the object.
		if (transform.position.x <= leftLimit || (transform.position.x  >= rightLimit) ||(transform.position.y  >= topLimit)||(transform.position.y  <= bottomLimit)) 
			
		{
			Destroy(gameObject);
		} 
		
		
	}
}