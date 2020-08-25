using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] public float susumuspeed = 3.0f;
    [SerializeField] public float yokonospeed = 3.0f;

   

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
       
        transform.position += transform.forward * susumuspeed * Time.deltaTime;

        if (Input.GetKey("right"))
        {
            transform.position += transform.right * yokonospeed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * yokonospeed * Time.deltaTime;
        }


    }

   

}