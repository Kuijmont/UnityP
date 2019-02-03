using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public TyleManager tl;
	public Rigidbody rig;
	void OnTriggerExit(Collider other){
		
		tl.CrearBaldosas ();
		StartCoroutine(Example());
		tl.Puntuar (false);

	}
	IEnumerator Example()
	{
		
		yield return new WaitForSeconds(0.1f);
		rig.isKinematic = false;
		yield return new WaitForSeconds (0.4f);
		Destroy (gameObject);

	}
}
