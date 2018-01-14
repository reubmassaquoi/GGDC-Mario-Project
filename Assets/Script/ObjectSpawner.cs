using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void spawn(string obj, Vector2 location)
	{
		//GameObject m = (GameObject)Resources.Load(obj);
		//print (m);
		GameObject.Instantiate(Resources.Load(obj), new Vector3(location.x, location.y,-1),Quaternion.identity);//new Vector3(location.x,location.y,0),);
		//g.transform.SetParent(this);
		//m.transform.position.Set 
	}
}


