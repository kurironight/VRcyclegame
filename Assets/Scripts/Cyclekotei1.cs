using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclekotei1 : MonoBehaviour {
    public Camera mainCamera;

    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        float angles; 
        angles = mainCamera.transform.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0,0,angles);
		
	}
}
