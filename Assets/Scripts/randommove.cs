using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class randommove : MonoBehaviour {

    [SerializeField] float speed = 3.0f;
    [SerializeField] float zspeed=3.0f;
    private float timeElapsed;
    [SerializeField] float timekeeper = 3.0f;
    Vector3 nextpoint;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        timeElapsed += Time.deltaTime;

        if (timeElapsed%timekeeper < 2*Time.deltaTime)
        {
            nextpoint = new Vector3(Random.Range(-8.1f, 10.0f), transform.position.y, transform.position.z - zspeed);
        }
        transform.position = Vector3.MoveTowards(transform.position,nextpoint, step);


    }


}
