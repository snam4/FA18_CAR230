using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDisplay : MonoBehaviour {
	public GameObject question1;
	// Use this for initialization
	void Start () {
		question1 = GameObject.Find("Q1");
		question1.SetActive(false);
		Cursor.visible = true;

	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		question1.SetActive(true);
		
	}
}
