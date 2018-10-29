using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w8TriggerDemo : MonoBehaviour {
	
	public int speed = 100;
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate(Vector3.up * 100);
		//transform.Translate(Vector3.up* 0.2f);  
	}

	void OnTriggerEnter(){
		sound.Play();
	}
}
