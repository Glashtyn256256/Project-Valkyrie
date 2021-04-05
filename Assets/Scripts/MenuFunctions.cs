using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuFunctions : MonoBehaviour {
	
	public GameObject UserBox;
	public InputField UserEnter;
	public static string username;
	public GameObject keepscript;
	
	void Start()
	{
		UserBox.SetActive(false);    //Keeps the Enter username box hidden till you click the button play.
		
	}
	
	public void HighscoreOnClick()
	{
		Application.LoadLevel("Highscore");  //Attached to button so when clicked highscore appears.
	}
	public void InputUserNameOnClick()
	{
		UserBox.SetActive(true);  //Will show the username input box.
		
		UserEnter.text = ("Enter Name"); 
		
		
	}
	public void ExitOnClick()
	{
		Application.Quit();   //When quit is click it will close down the game in the exe. file not in the editor.
	}
	
	public void ContinueOnClick()
	{
		username = UserEnter.text;    //We get the username that has been inputted.
		//  Debug.Log(username);
		ScoreUsername.GetUsername();  //We move the username into scoreusername to preserve when the game is destoryed.
		ScoreUsername.SetScoreToZero ();  //When this is called, it will reset the score and the lives to there default values. 
		Application.LoadLevel ("MergedVersion");  // Loads up the scene mergedversion.
	}
	
	public void MainMenuOnClick()
	{
		//if (Application.loadedLevelName == "Highscore")
		//keepscript = GameObject.FindWithTag ("Script");   //Searches gameobject with the tag script, places it into keepscript.
		//Destroy (keepscript);                  //Destroy the Gameobject holding the script, so we dont have multiple copies and we get a new script (variables reset) 
		//Application.LoadLevel ("Menu");  //Loads the menu scene
	}
	
	public void InstructionsOnClick()
	{
		Application.LoadLevel ("Story");  //Load the story/insutrctions scene.
	}
}

