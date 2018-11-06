using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w10_Friday_bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward *10.0f *Time.deltaTime);
		Destroy(gameObject,5);
	}
}
