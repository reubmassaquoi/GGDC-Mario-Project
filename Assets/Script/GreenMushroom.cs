using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMushroom : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D mushroomBody;
	int direction;
	int speed = 10;
	int MAX_SPEED = 5;
	bool move = true;
	void Start () {
		mushroomBody = GetComponent<Rigidbody2D>();
		direction = -1;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Mathf.Abs(mushroomBody.velocity.x) < MAX_SPEED) {

				mushroomBody.AddForce (new Vector2 (direction * speed, 0));
			}


	}
}
