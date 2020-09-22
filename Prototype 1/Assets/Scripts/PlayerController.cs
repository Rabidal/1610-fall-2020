using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed=25.0f;
    private float _horizontalInput;
    private float _forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get player input
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
       //We move the vehicle forward  
       transform.Translate(Vector3.forward * (Time.deltaTime * speed*_forwardInput));
       //we turn the vehicle
       transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed*_horizontalInput);
    }
}
