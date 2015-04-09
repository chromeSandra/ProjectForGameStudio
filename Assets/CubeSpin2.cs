using UnityEngine;
using System.Collections;

public class CubeSpin2 : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown)
		{ 
			StartCoroutine(MoveCube());
			Debug.Log("BBBBBBBB");
		}
	}

	IEnumerator MoveCube(){
		for(float i = -5f; i<5f; i+=0.01f) {	
			transform.position = new Vector3(i, transform.position.y, transform.position.z);
			yield return new WaitForSeconds(1.0f);
		}
	}
}
