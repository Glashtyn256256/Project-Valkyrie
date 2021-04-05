using UnityEngine;
using System.Collections;

public class CollisionDamageboss : MonoBehaviour {

    private Animator animator;
	public int health;
	public int wbcpoint = 1;

	void Start(){
        animator = GetComponent<Animator>();
   
	}

	void OnTriggerEnter2D(){   //When collided with do whatever is in function.
		//Debug.Log("Trigger!");

	
			health--;
			animator.SetTrigger("IsDamaged");
			
	}
	
	void Update(){
	

		if (health <= 0) 
		{
			Die ();

		}
	}


    void Die()
	{	
        animator.SetTrigger("IsDead");

    }
    public void DestroyMe()

    {   
		if (GameObject.FindGameObjectWithTag ("Enemy")) 	//Only if has enemy tag.					
		{																		
			GameObject Player = GameObject.Find ("Player");						
			BossLevel bosslevel = Player.GetComponent<BossLevel> (); 			 
			bosslevel.KillCount++;				//Add onto the killcount which will activate boss level. 				
		}																		
        Destroy(gameObject);
		ScoreUsername.IncreaseScorewbc();
    }


}

