using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w9_coinDestroy : MonoBehaviour {

	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime *50);
	}

	void OnCollisionEnter(Collision col){
		Destroy (gameObject);
	}
}
