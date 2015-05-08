using UnityEngine;
using System.Collections;

public class CubeMovement2 : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			transform.position += transform.forward;
		//	transform.forward.x += 0.3f;
		//	Debug.Log(transform.forward);
		}
	}
}
