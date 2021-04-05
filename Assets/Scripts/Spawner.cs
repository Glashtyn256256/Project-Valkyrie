using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	
	public int Max; //Amount that should be on the screen, at only a given time.
	public GameObject enemy; // Drag a enemy prefab into the script into the editor
	public float spawnTime1; //Time limit on how often a enemy spawns.
	public float spawnTime2;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("EnemySpawn", spawnTime1, spawnTime2); //will keep repeating function enemyspawn, this gives us random spawns constantly.
		
	}
	
	
	void EnemySpawn(){
		Transform playerTransform = GameObject.FindObjectOfType<PlayMove> ().gameObject.transform;   //Gets players position.
		
		for (int i = 0; i < Max; i++) { //go through for loop till we hit the max number.
			float xMin = (transform.position.x - (transform.localScale.x / 2));// used to workout the boxes transform, which is used to spawn enemies within the box.
			float xMax = (transform.position.x + (transform.localScale.x / 2));
			
			float yMin = (transform.position.y - (transform.localScale.y / 2));
			float yMax = (transform.position.y + (transform.localScale.y / 2));
			
			float x = Random.Range (xMin, xMax);   //Gets a random range from co-ords which will spawn a enemy on whats chosen.
			float y = Random.Range (yMin, yMax);
			
			Vector3 pos = new Vector3 (x, y, 0);
			GameObject t = (GameObject)Instantiate (enemy, pos, Quaternion.identity); //Will spawn enemy.
			Tracker tracker = t.GetComponent<Tracker>(); //we need to make sure the wbc gets the script tracker, so they all follow the player.
			if(GameObject.FindGameObjectWithTag("Player"))
				tracker.Player = playerTransform;
		}
		
	}
	
	
	void OnDrawGizmos() {   //invisible in-game but not in the editor, allows us to change the size of the spawner at will in editor.
		Gizmos.color = Color.yellow;
		Gizmos.DrawCube(transform.position,transform.localScale);
	}
}
