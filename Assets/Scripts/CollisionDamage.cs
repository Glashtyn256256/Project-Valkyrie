using UnityEngine;
using System.Collections;

public class CollisionDamage : MonoBehaviour {

  	private Animator animator;
	public int health;
	

	void Start(){
       animator = GetComponent<Animator>();
	}

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
		animator.SetTrigger("IsDead");
		//Debug.Log ("broke");
		//Debug.Log ("work");

	}
	public void DestroyMe()
	{   
		Destroy (gameObject);
		ScoreUsername.IncreaseScorerbc();

	}
}
