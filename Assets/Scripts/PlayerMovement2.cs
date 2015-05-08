using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour {
	//This is the script for animal vs human game
	//this is the animal movement script
	// Use this for initialization
	public float normalSpeed = 5.0f;
	public float moveSpeed ;
	public float fastSpeed;
	public float rotateSpeed = 5.0f;

	void Start () {
		moveSpeed = normalSpeed;
		fastSpeed = moveSpeed * 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.Translate((Vector3.forward)* moveSpeed * Time.deltaTime);
		//	Debug.Log("press w");		
		}
		if (Input.GetKey("s")) {
			transform.Translate((Vector3.back)* moveSpeed * Time.deltaTime);
		}	
		if (Input.GetKey("a")) {
			transform.Rotate(Vector3.down*rotateSpeed);
		//	Debug.Log("press a");		
		}	
		if (Input.GetKey("d")) {
			transform.Rotate(Vector3.up*rotateSpeed);
		}	
		if(Input.GetKeyDown(KeyCode.Space)){
		//	Debug.Log ("press space");
		}
		if(Input.GetMouseButton(1)){
			moveSpeed = fastSpeed;
		//	Debug.Log ("Mouse Button right");
		}
		if(!Input.GetMouseButton(1)){
			moveSpeed = normalSpeed;
		//	Debug.Log ("Mouse Button right");
		}
		if(Input.GetMouseButton(0)){
		//	Debug.Log ("Mouse Button left");
		}
	}
}
