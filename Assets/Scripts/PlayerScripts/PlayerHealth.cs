using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float health = 100f;
	public AudioClip beHitclip;
	
	public void beHit(float amount)
	{
		health -= amount;
		AudioSource.PlayClipAtPoint (beHitclip, transform.position);
	}
}
