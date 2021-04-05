using UnityEngine;
using System.Collections;

public class AxeMove : MonoBehaviour {

	public float maxSpeed = 10f;
	public float leftLimit, rightLimit, bottomLimit, topLimit;

	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;

		transform.position = pos; 
	

		if (transform.position.x <= leftLimit || (transform.position.x  >= rightLimit) ||(transform.position.y  >= topLimit)||(transform.position.y  <= bottomLimit)) 
		
		{
			Destroy(gameObject);
		} 


	}
}
