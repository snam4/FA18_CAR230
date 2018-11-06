using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w10_Friday_EnemyAttack : MonoBehaviour {
	public Transform target;
	public float speed = 0.5f;

	void OnTriggerStay (Collider other){
		if(other.transform == target){
			transform.LookAt(target);
			transform.Translate(Vector3.forward *speed *Time.deltaTime);
		}
	}
}
