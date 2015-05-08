using UnityEngine;
using System.Collections;

public class EnergyObject : MonoBehaviour {

	Energy ener;
	public AudioClip refillEnergy;
	// Use this for initialization
	void Start () {
		ener = GameObject.Find ("Player").GetComponent<Energy> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.name == "Player") {
						ener.addEnergy (10);
						Debug.Log ("Add Energy, total energy: " + ener.energy);
			AudioSource.PlayClipAtPoint(refillEnergy, transform.position);
			Destroy(gameObject);
				}
	}

}