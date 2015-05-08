using UnityEngine;
using System.Collections;

public class Rug : MonoBehaviour {
	private Collider col;
	// Use this for initialization
	void Start(){
		col = GameObject.Find ("Player").GetComponent<Collider> ();
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Player") {
			//			Debug.Log ("player");
			//			Debug.Log (col);
			col.collider.material = (PhysicMaterial)Resources.Load("Sticky");
				}
	}
}
