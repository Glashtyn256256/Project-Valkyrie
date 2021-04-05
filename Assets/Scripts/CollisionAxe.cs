using UnityEngine;
using System.Collections;

public class CollisionAxe : MonoBehaviour {
	
	public int health;

	
	void OnTriggerEnter2D(){		
		health--;
	}
	
	
	void Update(){
		
		if(health <= 0){
			Die();
		}
	}
	
	
	
	void Die()
	{
		Destroy(gameObject);
	}

	
}
