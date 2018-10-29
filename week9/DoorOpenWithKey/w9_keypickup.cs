using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w9_keypickup : MonoBehaviour {
	public GameObject player;
	public w9_playerInventory pInventory;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		pInventory = player.GetComponent<w9_playerInventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			pInventory.hasKey = true;
			Destroy(gameObject);
		}
	}
}
