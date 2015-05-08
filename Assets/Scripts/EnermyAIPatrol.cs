using UnityEngine;
using System.Collections;

public class EnermyAIPatrol : MonoBehaviour {
	private float lastUpdatedTime;
	public float maxPeriod;    //max time for each navigation
	public float minPeriod; 
	private float period;
	private float currentTime;
	private int direction;
	public float speed;
	public float rotateSpeed;
	void Start(){
		StartCoroutine("ChooseDirection");
		period = Random.Range (minPeriod, maxPeriod);
		lastUpdatedTime = Time.time;
//		Debug.Log (transform.forward);
	}
	void Update(){
	//	direction = Random.Range(0,3);  //0:forward, 1: back, 2: left, 3: right
	
//		switch (direction) {
//		case 0:
//		//	Debug.Log("go forward");
//			transform.Translate (Vector3.forward * speed * Time.deltaTime);
//			break;
//		case 1:
//		//	Debug.Log("back");
//			transform.Rotate(0,180,0);
//			transform.Translate (Vector3.forward * speed * Time.deltaTime);
//			break;
//		case 2:
//		//	Debug.Log("turn left");
//			transform.Rotate(0,90,0);
//			transform.Translate (Vector3.forward * speed * Time.deltaTime);
//			break;
//		case 3:
//		//	Debug.Log("turn right");
//			transform.Rotate(0,-90,0);
//			transform.Translate (Vector3.forward * speed * Time.deltaTime);
//			break;
	//	}
		currentTime = Time.time;
		if ((currentTime - lastUpdatedTime) >= period) {
						//		direction = Random.Range(0,3);
						StartCoroutine ("ChooseDirection");

						period = Random.Range (minPeriod, maxPeriod);
						lastUpdatedTime = Time.time;
				} else {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);		
		}
	}

	IEnumerator ChooseDirection(){
		direction = Random.Range (0, 4);
		switch (direction) {
		case 0:
				Debug.Log("go forward");
		//	transform.Translate (Vector3.forward * speed * Time.deltaTime);
			break;
		case 1:
				Debug.Log("back");
			while (Quaternion.Angle(transform.rotation, Quaternion.Euler(0, 180,0))>1){
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180, 0), rotateSpeed * Time.time);
				yield return null;
			}
		//	transform.rotation = Quaternion.RotateTowards(transform.rotation, -transform.rotation, rotateSpeed * Time.deltaTime);
		//	transform.Rotate(0,180,0);
		//	transform.Translate (Vector3.forward * speed * Time.deltaTime);
			break;
		case 2:
				Debug.Log("turn left");
			while (Quaternion.Angle(transform.rotation, Quaternion.Euler(0, 90,0))>1){
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), rotateSpeed * Time.time);
				yield return null;
			}

		//	transform.Rotate(0,90,0);
		//	transform.Translate (Vector3.forward * speed * Time.deltaTime);
			break;
		case 3:
				Debug.Log("turn right");
			while (Quaternion.Angle(transform.rotation, Quaternion.Euler(0, -90,0))>1){
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), rotateSpeed * Time.time);
				yield return null;
			}
		//	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -90, 0), rotateSpeed * Time.time);
		//	transform.Rotate(0,-90,0);
		//	transform.Translate (Vector3.forward * speed * Time.deltaTime);
			break;
		}

		yield return new WaitForSeconds (2.0f);
	}
}
