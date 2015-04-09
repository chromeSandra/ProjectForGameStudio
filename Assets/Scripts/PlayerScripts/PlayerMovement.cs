using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float tilt;
	public float speed;
	public float jumpHeight;
	public AudioClip walkSound;
	Animation anim;


	// Use this for initialization
	void Awake () {
		anim = GameObject.Find ("SpartanKing").GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		float h = Input.GetAxis ("Horizontal")* tilt * Time.deltaTime;
//		float v = Input.GetAxis ("Vertical")*speed * Time.deltaTime;
		float j = Input.GetAxis ("Jump")*jumpHeight * Time.deltaTime;
		transform.Translate (0, j, 0);
		transform.Rotate (0, h, 0);
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed * Time.deltaTime;
						anim.Play ("walk");	
				} else
						anim.Play ("idle");
		}
	
}
