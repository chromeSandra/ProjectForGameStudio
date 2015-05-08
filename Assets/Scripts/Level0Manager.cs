using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level0Manager : MonoBehaviour {
	PlayerHealth playerHealth;
	BeKilled killPlayer;
	Text gameover;
	// Use this for initialization
	void Start () {
		playerHealth = GameObject.FindWithTag ("Player").GetComponent<PlayerHealth> ();
		killPlayer = GameObject.FindWithTag ("Player").GetComponent<BeKilled> ();
		gameover = GameObject.Find("GameOver").GetComponent<Text>();
	//	Debug.Log (playerHealth.health);
	}
	
	// Update is called once per frame
	void Update () {

//		if(Input.GetKeyDown(KeyCode.P)){			
//			gameover.enabled = true;
//		}
	if (playerHealth.health <= 0) {
			killPlayer.Dying();
			gameover.enabled = true;
			StartCoroutine(Wait());
			Application.LoadLevel(0);
		}
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds (8);
	}
}
