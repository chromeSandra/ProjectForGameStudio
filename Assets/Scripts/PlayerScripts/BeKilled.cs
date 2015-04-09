using UnityEngine;
using System.Collections;

public class BeKilled : MonoBehaviour {
	Animation deathAnimation;
	public AudioClip dieSound;
	// Use this for initialization
	void Awake(){
		deathAnimation = GameObject.Find ("SpartanKing").GetComponent<Animation>();
	}

	public void Dying(){
		deathAnimation.Play ("die");
		AudioSource.PlayClipAtPoint (dieSound, transform.position);
		StartCoroutine (dieDelay());
		Destroy (gameObject);
	}

	IEnumerator dieDelay(){
		yield return new WaitForSeconds (2f);
	}
}
