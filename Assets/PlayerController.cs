using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	CharacterController controller;
	public float speed;
	public Text scoreText;
	private int score;
	// Use this for initialization
	void Start () {
		controller = this.GetComponent<CharacterController>();
		score = 0;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		//Move
		this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal")*speed*10, 0));
		controller.Move(this.transform.forward * Input.GetAxis("Vertical") * speed);
		Timer timer = FindObjectOfType<Timer> ();
		if (timer.time <= 0) {
			speed = 0;
		}
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "friend") {
			Destroy (collider.gameObject);
			score += 1;
			scoreText.text = "Score: " + score;
		}
		if (collider.gameObject.tag == "enemy") {
			Destroy (collider.gameObject);
			score -= 1;
			scoreText.text = "Score: " + score;
		}
	}
}
