using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {



	public Text ScoreTxt;




	
	void LateUpdate()
	{
		ScoreTxt.text = "Score: " + ScoreUsername.score;  //Shows the score on the boss and normal level
	}
}
