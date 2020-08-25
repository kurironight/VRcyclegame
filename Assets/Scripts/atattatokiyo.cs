using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class atattatokiyo : MonoBehaviour {

	// Use this for initialization
    void Start () {

        var rigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        other.SendMessage("OnHitBullet");

        Destroy(gameObject);
		
	}
}
