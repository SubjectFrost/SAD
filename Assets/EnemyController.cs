using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	CharacterController controller;
	public int direction;
	public float speed;
	public float turn;
	private float time;

	// Use this for initialization
	void Start () {
		controller = this.GetComponent<CharacterController>();
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - time >= turn) {
			direction *= -1;
			time = Time.time;
		}
		this.transform.Rotate(new Vector3(-5, -5, 5));
		this.transform.position += Vector3.left * speed * direction;
		
	}
}
