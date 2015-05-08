using UnityEngine;
using System.Collections;

public class DetectPlayer : MonoBehaviour {
	GameObject player;
	GameObject seenObject;
	public float chaseSpeed;
	PlayerHealth phealth;            //player health

	void Start () {
		player = GameObject.Find ("Player");
		phealth = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
	}

	void Discover(){
		RaycastHit hit;
		Ray ray1 = new Ray (transform.position, transform.forward);
		if (Physics.Raycast (ray1, out hit, 10)) {
			seenObject = hit.transform.gameObject;
			if(seenObject.tag == "Player")
			{
				Debug.Log("Find Player, chasing start.");
				Chase();
			}
		}
	}

	void Chase(){
		transform.LookAt (player.transform);
		transform.Translate (Vector3.forward * chaseSpeed * Time.deltaTime);
	}
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		Discover ();
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
			phealth.Damage(100);	
		}


	}
}
