using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveforTree : MonoBehaviour {

    [SerializeField] public float treespeed = 3.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(0,0,treespeed) * Time.deltaTime,Space.World);

    }
}
