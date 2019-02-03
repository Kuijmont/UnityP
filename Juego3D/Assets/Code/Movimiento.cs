using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour {
	private float speed=3f;
	private Vector3 dir;
	private bool start=false;
	public GameObject ps;
	public GameObject menu;
	public TyleManager tl;
	public AudioSource go;
	public AudioSource bm;
	public AudioSource point;
	private Transform hijo;
	private float posY;
	private int p=100;
	// Use this for initialization
	void Start () {
		transform.rotation = new Quaternion (0, 0, 0, 0);
		posY = transform.position.y;
		hijo = transform.GetChild (0);
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion (0, 0, 0, 0);
		if (transform.position.y  < posY ) {
			bm.Stop ();

			menu.SetActive (true);

			tl.record.text = string.Concat (PlayerPrefs.GetInt ("record"));

			if (hijo.IsChildOf(transform)) {
				transform.GetChild (0).transform.parent = null;
				go.Play ();
			}
			if (Input.GetMouseButtonDown (0)) {

			}
		} else {
			
			if (Input.GetMouseButtonDown (0)) {
				if (start == false) {
					dir = Vector3.forward;
					start = true;
				} else {
					dir = Vector3.left;
					start = false;
				}
			}
			transform.Translate (dir * speed * Time.deltaTime);
		}

		if (tl.puntos==p) {
			speed=speed+0.05f;
			p = p + 100;

		}

}

	void OnTriggerEnter(Collider other){
		if (other.tag == "PickUp") {
			point.Play ();
			other.gameObject.SetActive (false);
			Instantiate (ps, transform.position, transform.rotation);
			tl.Puntuar(true);

		}
	}
}