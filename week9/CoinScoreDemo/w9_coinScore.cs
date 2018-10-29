using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w9_coinScore : MonoBehaviour {
	public int score = 0;
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Coin"){
			score++; // score = score + 1;
		}
	}

}
