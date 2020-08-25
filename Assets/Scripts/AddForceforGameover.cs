using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class AddForceforGameover : MonoBehaviour {

    [SerializeField] float speed = 20.0f; //飛んでいくスピード
    [SerializeField] float uemuki = 20.0f; //飛んでいくスピード
    [SerializeField] float yokomuki = 20.0f; //飛んでいくスピード                                     
    // Use this for initialization
    void Start () {
        Vector3 muki = new Vector3(0.0f, uemuki, -yokomuki);
        var velocity = speed * muki;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
