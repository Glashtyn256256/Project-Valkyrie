 using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {

	public float timer = 5f;

	
	void Update () {   //Used to kill Of the axes after a certain Time Limit.
		timer -= Time.deltaTime;

		if (timer <= 0) {  
			Destroy(gameObject);
		}
	}
}
