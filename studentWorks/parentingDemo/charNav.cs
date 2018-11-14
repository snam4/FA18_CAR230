using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charNav : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * 0.05f);
        transform.Rotate(Vector3.up * h);
	}
}
