using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyle : MonoBehaviour
{
    private TyleManager tm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        // probar que funciona mediante Debug.Log
        Debug.Log("Text: Funciona");
        //llamada a la función del TileManager para generar una baldosa….
        tm.CrearBaldosa();
    }
}
