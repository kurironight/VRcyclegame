using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class Trackingmukou : MonoBehaviour {
    [SerializeField] Camera target;

    // Use this for initialization
    void Start()
    {
        XRDevice.DisableAutoXRCameraTracking(target, true);
    }

    // Update is called once per frame
    void Update()
    {
            XRDevice.DisableAutoXRCameraTracking(target, true);
       
    }
}