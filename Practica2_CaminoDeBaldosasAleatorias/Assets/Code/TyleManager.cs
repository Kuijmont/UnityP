using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyleManager : MonoBehaviour
{
    public GameObject CurrentTile;
    public GameObject[] TilePrefabs;
    private static TyleManager instance;
    private float xIni = -12.5f;
    private float zIni = 12.45f;
    private float pos = 5;
    public static TyleManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TyleManager>();
            }
            return instance;
        }
    }
    // Use this for initialization
    void Start()
    {
        //Se crean diez baldosas aleatorias iniciales
        for (int i= 0; i <= 9; i++){
            CrearBaldosa();
            Debug.Log("Hola");
        }
    }


    public void CrearBaldosa() {

        //este metodo es llamado desde Start
        //tambien desde el método TileScript
        //de los prefabs

        //genera un aleatorio 0,1
        int random = Random.Range(0, 2);
        Debug.Log(random);
        //instancia un prefab y lo asocia a CurrentTile
        if (random == 0) {
            Vector3 v3 = new Vector3(xIni, -1.24f,zIni);
            GameObject go = (GameObject)Instantiate(CurrentTile, v3, transform.rotation);
            zIni = pos + zIni;
        }else{
            Vector3 v3 = new Vector3(xIni, -1.24f, zIni);
            GameObject go = (GameObject)Instantiate(CurrentTile, v3, transform.rotation);
            xIni = -pos + xIni;
        }
    }
}
