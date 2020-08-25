using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyforTerrain : MonoBehaviour {

    [SerializeField] float kierubasyo = 5f;

    // Use this for initialization
    void Update()
    {if (transform.position.z < kierubasyo)
            Destroy(gameObject);
    }
}
