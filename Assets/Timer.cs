using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text timer;
	public float time;
	public Text gameOverText;
	// Use this for initialization
	void Start () {
		//time = 5;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;

		float seconds = time % 60;
		float fraction  = (time * 100) % 100;
		
		if (time > 0) 
			timer.text = "Time Remaining: "+time; 

		if (time <= 0){
			timer.text ="Time Remaining: 0";
			gameOverText.text = "Game Over";

		}

	}

}
