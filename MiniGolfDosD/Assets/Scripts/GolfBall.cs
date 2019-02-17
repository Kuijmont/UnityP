using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    [SerializeField]
    private float force = 100;
    [SerializeField]
    private float maxForce = 500;
    [SerializeField]
    private float minForce = 50;
    [SerializeField]
    private float forceChangeAmount = 25;


    private Vector2 direction;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (Vector2) (mousePosition - transform.position);
        if (Input.GetMouseButton(0) && rb.velocity == Vector2.zero)
        {
            rb.AddForce(direction * force);
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0 && force < maxForce)
        {
            force += forceChangeAmount;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0 && force > minForce)
        {
            force -= forceChangeAmount;
        }

    }
}
