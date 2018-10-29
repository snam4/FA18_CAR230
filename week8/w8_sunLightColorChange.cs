using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w8_sunLightColorChange : MonoBehaviour {	
	public GameObject sun;
	public Color c1 = new Color(.5f, .0f, .0f);
	public Color c2 = new Color(.9f, .9f, .9f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		sun.GetComponent<Light>().intensity = 0.5f;
		sun.GetComponent<Light>().color = c1;
	}

	void OnTriggerExit(){
		sun.GetComponent<Light>().intensity = 1;
		sun.GetComponent<Light>().color = c2;
	}
}
