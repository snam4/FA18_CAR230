using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w10_Friday_CharMove : MonoBehaviour {
	
	void Start () {

	}
	
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		transform.Translate (Vector3.forward * v *0.05f);
		transform.Rotate (Vector3.up * h);
	}
}
