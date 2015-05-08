using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {
	GameObject player;
	bool onTheTable;
	PlayerHealth health;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		health = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
	}
	
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Player") {
			onTheTable=true;
		}
	}
	void OnCollisionExit(Collision coll){
		if (coll.gameObject.name == "Player") {
			onTheTable = false;	
			health.health -= 20;
		}
	}
}
