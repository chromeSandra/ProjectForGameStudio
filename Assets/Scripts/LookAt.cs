using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
	public GameObject target;
	public Vector3 offset;
	void Start(){
		offset = transform.position - target.transform.position;
	}
	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		transform.position = desiredPosition;
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
