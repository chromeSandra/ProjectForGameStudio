using UnityEngine;
using System.Collections;

public class PlayerMovementPhysical : MonoBehaviour {
	public float normalSpeed;
	private float moveSpeed ;
	private float fastSpeed;
	public float rotateSpeed;
	public float jumpHight;
	Energy energy;
	Rigidbody rigid;

	// Use this for initialization
	void Start () {
		energy = GameObject.Find ("Player").GetComponent<Energy> ();
		moveSpeed = normalSpeed;
		fastSpeed = moveSpeed * 2;
		rigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			rigid.AddForce(transform.forward * moveSpeed , ForceMode.Impulse);
		//	Debug.Log(transform.forward);
		}
		if (Input.GetKey("s")) {
			rigid.AddForce(-transform.forward * moveSpeed, ForceMode.Impulse);

		//	transform.Translate((Vector3.back)* moveSpeed * Time.deltaTime);
		}	
		if (Input.GetKey("a")) {
			rigid.AddTorque(-transform.up * rotateSpeed,ForceMode.Impulse);
		//	transform.Rotate(Vector3.down*rotateSpeed);
			//	Debug.Log("press a");		
		}	
		if (Input.GetKey("d")) {
			rigid.AddTorque(transform.up * rotateSpeed,ForceMode.Impulse);

		//	transform.Rotate(Vector3.up*rotateSpeed);
		}	
		if(Input.GetKeyDown(KeyCode.Space)&&energy.energy>=30){
			Debug.Log("Jump");
			rigid.AddForce(transform.up * jumpHight, ForceMode.VelocityChange);

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
