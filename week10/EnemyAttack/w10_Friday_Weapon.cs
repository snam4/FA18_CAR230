using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w10_Friday_Weapon : MonoBehaviour {
	public Transform bullet;
	public GameObject weapon;
	public float fireRate = 3.0f;
	public float nextFire;
	
	void OnTriggerEnter(){
		nextFire = Time.time + fireRate;
	}
	void OnTriggerStay(Collider other){
		if (Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Transform clone = Instantiate(bullet, weapon.transform.position, weapon.transform.rotation);
		}
	}
}
