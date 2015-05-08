using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
	//private bool takeDamage = false;
	PlayerHealth playerHealth;
	public float damage;
	void Start(){
		playerHealth = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player")
		{	
			playerHealth.Damage(damage);
			Debug.Log("Be Hitten");
		}
	}

}
