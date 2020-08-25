using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jimen : MonoBehaviour {

    [SerializeField] public float roadspeed = 3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * roadspeed * Time.deltaTime;


    }
}
