using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBrick : MonoBehaviour {

	// Use this for initialization
	bool coinDispensed = false;
	public string s;
	void Start () {
		s = "Prefabs/Mushroom";

	}


	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collider)
	{	//print ("toucing player");
		//print (collider.gameObject.name);
		if (collider.gameObject.name == "Mario") 
		{	
			if (!coinDispensed) 
			{
				coinDispensed = true;
				GetComponent<Animator> ().Play ("QuestionBrickDispense");
				ObjectSpawner g = GameObject.Find ("InteractableObjects").GetComponent<ObjectSpawner> ();
				g.spawn(s,new Vector2(transform.position.x,transform.position.y+1));
			}
			/*Vector2 v1 = new Vector2 (collider.transform.position.x, collider.transform.position.y);
			Vector2 v2 = new Vector2 (transform.position.x, transform.position.y);
			print (Vector2.Dot (v1, v2));
			if (Vector2.Dot (v1, v2) < 0) {*/
				print ("Below");
			//}
		}
	}

	//void dispense
}
