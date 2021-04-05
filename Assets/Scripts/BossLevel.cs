using UnityEngine;
using System.Collections;

public class BossLevel : MonoBehaviour {

	public int KillCount = 0;

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

		//Debug.Log (KillCount);

		if (KillCount >= 10)    //When killcount reaches do if statement
		{
			
			Application.LoadLevel("Boss");  //activates boss level
			KillCount = 0;  //Reset killcount to zero
		}
		
	}

}
