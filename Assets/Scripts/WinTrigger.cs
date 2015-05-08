using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {
	Text win;
	// Use this for initialization
	void Start(){
		win = GameObject.Find("Win").GetComponent<Text>();
	}
	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.name == "Player") {
			Debug.Log ("Win");
			win.enabled = true;
		}
	}
}
