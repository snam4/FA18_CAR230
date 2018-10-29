using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w8LightControl : MonoBehaviour {
	public GameObject sun;
	public Color c = new Color (0.5f, 0f, 0f);

	void OnTriggerEnter(){
		sun.GetComponent<Light>().color = c;
	}
}
