using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButton(0) && rb.velocity == Vector2.zero)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2) (mousePosition - transform.position);
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hole")
        {
            rb.velocity = Vector2.zero;
            if (collision.GetComponent<Hole>().GetNextScene()!= ""){
                SceneManager.LoadScene(collision.GetComponent<Hole>().GetNextScene());
            }
            
            Debug.Log("Score!");
        }
    }

}
