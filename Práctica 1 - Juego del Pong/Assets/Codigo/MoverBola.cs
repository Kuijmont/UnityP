using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour
{
    public float velocidadInicial = 300f;
    public Rigidbody rig;
    public Transform barra;
    bool enJuego;
    public ElementoInteractivo empezar;
    private static float posX;
    private static float posY;
    private static Vector3 posicionInicial;
    // Use this for initialization
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posicionInicial = new Vector3(posX, posY);

    }

    // Update is called once per frame
    void Update()
    {
        if (!enJuego)
        {
            if (Input.GetKeyDown("left ctrl") || empezar.pulsado)
            {
                enJuego = true;
                transform.SetParent(null);
                rig.isKinematic = false;
                rig.AddForce(new Vector3(-velocidadInicial, velocidadInicial));
            }
        }
    }
    public void Reset()
    {

        transform.position = new Vector3(posicionInicial.x, posicionInicial.y);
        transform.SetParent(barra);
        enJuego = false;
        rig.isKinematic = true;
        rig.AddForce(Vector3.zero);
    }
}
