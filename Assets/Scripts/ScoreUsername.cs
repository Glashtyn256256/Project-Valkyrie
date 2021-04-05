using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreUsername : MonoBehaviour {   //The Script which we keep all our functions & data in which we will need in other scenes
	
	// Use this for initialization
	public static int health;        //Health of player (needs to be 
	public Text ScoreTxt;
	public GameObject test;              //Place a script which we want to keep from being destroyed.
	public static string username;   //Username is stored here
	public static int score;        //Score is stored here.
	public static int wbcpoints = 10;         //White Bloodcell points
	public static int rbcpoints = 1;         // Redbloodcell points
	public static int bosspoints = 600;    //boss points
	public static int lungpoints = 200;    //LungPoints
	
	//public Text NameTxt;
	
	void Start () 
	{
		DontDestroyOnLoad(test);     //Doesnt destroy the gameobject on new scene.
		
		//Application.DontDestroyOnLoad(this);
		//NameTxt.text = username;
	}
	
	// Update is called once per frame
	
	public static void SetScoreToZero()  //Reset Score and health function. (When a new game is started)
	{
		score = 0;
		health = 3;
	}
	
	public static void GetUsername()    //Get username from input box function
	{
		username = MenuFunctions.username;
		// Debug.Log(username);
		
	}
	
	public static void GetScore()   //Retreive the current score in-game.
	{
		score = ScoreUsername.score;
		
	}
	
	public static void AddHighscore()  //Uploads the username and score onto the highscore/website that stores the data.. 
	{
		Highscores.AddNewHighscore (username, score);
		
		
	}
	public static void IncreaseScorewbc()  //Add white blood cell points onto score function
	{
		score = score + wbcpoints;
	}
	
	public static void IncreaseScorerbc() //add red blood cell points onto score function
	{
		score = score + rbcpoints;
	}
	
	public static void IncreaseScoreboss() //add the Boss onto the score functin.
	{
		score = score + bosspoints;
	}
	public static void IncreaseScorelungs() //Adds the lungs points onto the score function
	{
		score = score + lungpoints;
	}
}


