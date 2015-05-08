using UnityEngine;
using System.Collections;

public class DamageTrashCan : MonoBehaviour {
	PlayerHealth health;
	// Use this for initialization
	void Start () {
		health = GameObject.Find ("Player").GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{
		
				if (col.gameObject.name == "Player") {
			health.Damage(10);
				}

		}
}
