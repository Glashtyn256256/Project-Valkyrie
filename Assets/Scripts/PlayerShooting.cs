using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Vector3 axeOffset = new Vector3(-0.5f, 0.5f, 0);
	public GameObject axePrefab;


	public float shootDelay = 0.25f;
	float shootTime = 0;
	
	// Update is called once per frame
	void Update () {
		shootTime -= shootTime * Time.deltaTime;

		if (Input.GetButtonDown ("Fire1") && shootTime <= 0 ) {

			shootTime = shootDelay;

			Vector3 offset = transform.rotation * axeOffset;  

			Instantiate(axePrefab, transform.position + offset, transform.rotation);  //Create the axe

		}
	}
}
