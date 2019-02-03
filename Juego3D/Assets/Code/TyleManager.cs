using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TyleManager : MonoBehaviour {
	public GameObject CurrentTile;
	public GameObject TilePrefabs;
	 GameObject diamond;
	private static TyleManager instance;
	private GameObject clone;
	private static Vector3 posini;
	public int puntos=0;
	public Text puntuacion;
	public Text puntosFin;
	public Text record;
	private static float x;
	private static float z;
	private static float y;
	public static TyleManager Instance{
		get{
			if (instance == null) {
				instance = GameObject.FindObjectOfType<TyleManager> ();
			}
			return instance;
		}
	}
	// Use this for initialization
	void Start () {
		posini = CurrentTile.transform.GetChild(0).position;
		x = posini.x;
		z = posini.z;
		y = 1.362f;

		for (int i = 0; i < 10; i++) {
			CrearBaldosas ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CrearBaldosas(){
		diamond= TilePrefabs.transform.GetChild (1).gameObject;
			
			int lado = Random.Range (0, 2);
		int cnt = Random.Range (0, 11);
			if (lado == 0) {
				x = x - 1;
			clone= (GameObject) Instantiate(TilePrefabs,posini,transform.rotation);

			} else {
				z = z + 1;
			clone= (GameObject) Instantiate(TilePrefabs,posini, transform.rotation);

			}

		if (cnt == 5) {
			
			diamond.SetActive (true);

		} else {
			diamond.SetActive (false);
		}
			clone.transform.position=new Vector3(x,y, z);
		}
	public void Puntuar(bool diam){
		if (diam) {
			puntos = puntos + 5;
		} else {
			puntos++;

		}	
		puntuacion.text = string.Concat (puntos);
		puntosFin.text = string.Concat (puntos);
		if (puntos > PlayerPrefs.GetInt ("record")) {
			PlayerPrefs.SetInt ("record", puntos);

		}
		record.text=string.Concat(PlayerPrefs.GetInt("record"));
		}

	public void Reset(){
		SceneManager.LoadScene (0);
	}

	public void Exit(){

		Application.Quit();
	}

}
