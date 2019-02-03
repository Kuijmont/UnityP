using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {
	public ParticleSystem ps;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ps.isPlaying){
			
		}else{
			Destroy (gameObject);
		}
}
}
