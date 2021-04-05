using UnityEngine;
using System.Collections;

public class PlayerCollision:MonoBehaviour {
	
	public GameObject Life, Life2, Life3;
	public GameObject GO;
	public float invulnPeriod = 0;
	//public int health;
	
	float invulnTimer = 0;
	int correctLayer;
	
	void Start(){
		correctLayer = gameObject.layer;
		
	}
	
	void OnTriggerEnter2D(){
		//Debug.Log("Trigger!");
		
		
		ScoreUsername.health--;
		invulnTimer = invulnPeriod;
		gameObject.layer = 10;
		GO.SetActive (true); //new line
		
	}
	
	
	void Update(){
		
		invulnTimer -= Time.deltaTime;
		if (invulnTimer <= 0) {
			gameObject.layer = correctLayer;
			GO.SetActive (false); //new line
			
		}
		
		if(ScoreUsername.health < 3){
			Life3.SetActive(false);
			
		}
		if(ScoreUsername.health < 2){
			Life2.SetActive(false);
		}
		
		
		
		if(ScoreUsername.health <= 0){
	
			Life.SetActive(false);  
			Die();          // 
			ScoreUsername.GetScore (); //Activates this function when player dies which puts the score into ScoreUsername

		
			
			Application.LoadLevel ("Gameover"); //Loads gameover scene
		}
	}
	
	void Die()
	{
		Destroy (gameObject);
		
	}
	
}