using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentingDemo : MonoBehaviour
{

    //https://answers.unity.com/questions/1018053/how-to-parent-a-gameobject-ontriggerenter.html
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Found the chicken!");
        if (other.gameObject.tag == "Player"){
            this.transform.position = other.gameObject.transform.position + new Vector3(0.0f,1.0f,0.0f);
            this.transform.parent = other.transform;

        }
    }
}
