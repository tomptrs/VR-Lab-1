using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
    [SerializeField]
    float rotationSpeed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float rotation = Time.deltaTime * rotationSpeed;
        transform.Rotate(Vector3.up*rotation);
	}
}
