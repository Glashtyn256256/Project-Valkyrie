using UnityEngine;
using System.Collections;

public class LungsCollisions : MonoBehaviour {

	private Animator animator;
	public int health;

	
	

	
	void Start(){
		animator = GetComponent<Animator>();
	}
	
	void OnTriggerEnter2D(){  //When hit lose health
		health--;
	}
	
	
	void Update(){
		

		if (health <= 0) 
		{
			Die (); 
		}
		
		
	}
	
	
	
	void Die()
	{	
		animator.SetTrigger("IsDead");  //triggers death animation

	}
	public void DestroyMe()
	{   
		Destroy(gameObject);
		ScoreUsername.IncreaseScorelungs();
	}
	
	
}

