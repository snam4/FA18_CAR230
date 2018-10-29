using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w9_doorOpen : MonoBehaviour {
	public Animator anim;
	public GameObject player;
	public w9_playerInventory pInventory;

	void Start () {
		anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");
		pInventory = player.GetComponent<w9_playerInventory>();
	}
	
	void OnTriggerEnter(Collider other){
		if(pInventory.hasKey == true){
			anim.SetBool("open",true);
			anim.SetBool("close",false);
		}
	}

	void OnTriggerExit(Collider other){
        if(pInventory.hasKey == true){
            anim.SetBool("close",true);
            anim.SetBool("open", false);
	   }
    }
}
