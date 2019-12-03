using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBinding : MonoBehaviour {


    Rigidbody rigidBody;
    float thrust = 10f;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        Thrust();
        Rotate();
       
    }

    private void Rotate()
    {
         Thrust();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward );
            print("left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward);
            print("right");
        }
       
    }

    private void Thrust()
    {
        float rotationSpeed = Time.deltaTime * thrust;
        if (Input.GetKey(KeyCode.Space))
        {
            print("speed");
            rigidBody.AddRelativeForce(Vector3.up); //relative force = adding force in the direction the ship is facing
        }

       
    }
}
