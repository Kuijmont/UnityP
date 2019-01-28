using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPala : MonoBehaviour
{
    public float velocidad = 1f;
    private float posY;
    private float posX;
    static float limiteBajo = -0.4f;
    static float limiteAlto = 0.4f;
    private static Vector3 posicionIni;
    public ElementoInteractivo botonUp;
    public ElementoInteractivo botonDown;

    // Use this for initialization
    void Start()
    {

        posY = transform.position.y;
        posX = transform.position.x;


        posicionIni = new Vector3(posX, posY);

    }

    // Update is called once per frame
    void Update()
    {
        float direccion;
        
        direccion = Input.GetAxisRaw("Vertical");
        if (botonUp.pulsado)
        {
            posY = posY + (1 * velocidad * Time.deltaTime);
        }
        else
        {
            if (botonDown.pulsado || Input.GetKey("up"))
            {
                posY = posY + (-1 * velocidad * Time.deltaTime);
            }
            else
            {
                posY = posY + (direccion * velocidad * Time.deltaTime);
            }
        }

        if (posY >= limiteAlto)
        {
            posY = limiteAlto;
            transform.position = new Vector3(posX, posY);
        }
        else
        {
            if (posY <= limiteBajo)
            {
                posY = limiteBajo;
                transform.position = new Vector3(posX, posY);
            }
            else
            {
                transform.position = new Vector3(posX, posY);
            }
        }


    }
    public void Reset()
    {

        transform.position = posicionIni;

        posY = transform.position.y;
        posX = transform.position.x;
        print(posicionIni);

    }
}
