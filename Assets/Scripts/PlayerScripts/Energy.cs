using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {
	
	public float energy = 0f;
	// Use this for initialization
	public void addEnergy(float amount){
		energy += amount;
	}

	public void deductEnergy(float amount){
		energy -= amount;
	}

	void Update(){
		if (energy < 0) {
						energy = 0;
			Debug.Log ("Reset Energy");
				}
	}
	// Update is called once per frame
}
