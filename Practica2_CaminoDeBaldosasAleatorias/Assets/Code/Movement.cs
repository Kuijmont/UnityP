using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private float speed = 8f;
    private Vector3 dir;
    private bool start = false;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        // Click on screen to start move the ball 
        if (Input.GetMouseButtonDown(0)){
            if (start == false){
                dir = Vector3.forward;
                start = true;
            }
            else{
                dir = Vector3.left;
                start = false;
            }
        }
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
