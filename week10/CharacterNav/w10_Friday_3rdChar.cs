using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w10_Friday_3rdChar : MonoBehaviour {
	private Animator anim;
	
	void Start () {
		anim = GetComponent<Animator>();	
	}
	
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		anim.SetFloat("forward",v);
		
	}
}
