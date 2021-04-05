using UnityEngine;
using System.Collections;

public class BossHeart : MonoBehaviour {
	
		private Animator animator;
		public int health;
		
		
		
		
		
		void Start(){
			animator = GetComponent<Animator>();
		}
		
		void OnTriggerEnter2D(){
			health--;
		}
		
		
		void Update(){
			

		if (GameObject.FindGameObjectWithTag("Lung")) 
		{
		
			animator.SetTrigger ("Stage1");
		}

		else {
			animator.SetTrigger ("Stage2");
		}
			
		if (health <= 0)
		{
			Die ();

		}
			
			



	}
		
		void Die()
		{	
		animator.SetTrigger("IsDead");
		//Destroy(gameObject);
		}
		public void DestroyMe()
		{   
			//ScoreUsername.IncreaseScoreboss();
			Destroy(gameObject);
			ScoreUsername.IncreaseScoreboss();
			Application.LoadLevel ("MergedVersion");
		}
		
		
	}
	
