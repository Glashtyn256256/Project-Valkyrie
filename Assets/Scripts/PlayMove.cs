using UnityEngine;
using System.Collections;

public class PlayMove : MonoBehaviour 
{

	public float Speed = 35.0f;
	public float leftLimit, rightLimit, bottomLimit, topLimit;


	// Use this for initialization
	void Start () {
	
	}


	void Update() 
	{
		Vector3 mousePos = Camera. main. ScreenToWorldPoint(Input. mousePosition);  //Player follows the mouse
		transform. rotation = Quaternion. LookRotation(Vector3. forward, mousePos - transform. position);
	
		var Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += Movement * Speed * Time.deltaTime; //Moves the player

		if (transform.position.x <= leftLimit) //if at left limit activate if
			{
			//Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position -= Movement * Speed * Time.deltaTime;  //trasnforms position before hitting the border.
			} 

		else if (transform.position.x  >= rightLimit) 
			{
			//Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position -= Movement * Speed * Time.deltaTime;
			}
		else if (transform.position.y  >= topLimit) 
		{
			//Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position -= Movement * Speed * Time.deltaTime;
		}
		else if (transform.position.y  <= bottomLimit) 
		{
			//Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position -= Movement * Speed * Time.deltaTime;
		}
	}
}