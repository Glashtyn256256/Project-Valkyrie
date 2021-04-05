using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Music : MonoBehaviour 
{

	public AudioSource audioSource;  //Place audio we want to turn on or off.
	public GameObject MusicMaker;

	void Start () 
	{
		DontDestroyOnLoad(MusicMaker);  //Keep it alive
	}


	void Update() // Checks each fame to see if key has been pressed.
	{
		if(Input.GetKeyDown("0"))
		  Soundonoff();
		
	}

	public void Soundonoff()   //Will turn the sound or off depending on what the volume is currently at.
	{

	if(audioSource.volume == 1.0f)
		audioSource.volume = 0.0f;
	else
		audioSource.volume = 1.0f;
	}
	
	 
}
