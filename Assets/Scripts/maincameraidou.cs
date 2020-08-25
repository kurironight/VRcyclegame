using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincameraidou : MonoBehaviour {

public Camera mainCamera;
    public float moveSpeed = 2.0f;
    public float moveAngleZ = 20.0f;
    [SerializeField] public float minx = 3.0f;
    [SerializeField] public float maxx = 3.0f;
    public float zoffset = 0.0f;


    // Use this for initialization
    void Start()
    {
        zoffset = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        // 1.カメラの傾きを取得
        float z = mainCamera.transform.eulerAngles.z;


        // 2.ある角度以内であれば前進させる
        if (-90.0f < z - 360 && z - 360 < -moveAngleZ)
        {
            moveForward(z - 360);
        }
        else if (moveAngleZ <= z && z < 90.0f)
        {
            moveForward(z);
        }
        Clamp();

    }

    private void moveForward(float i)
    {
        Vector3 direction = new Vector3(1, 0, 0).normalized * moveSpeed * i * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, -this.transform.rotation.eulerAngles.z));
        this.transform.Translate(rotation * direction);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, zoffset);


    }

    void Clamp()
    {
        Vector3 pos = this.transform.position;
        pos.x = Mathf.Clamp(pos.x, minx, maxx);
        this.transform.position = pos;
    }


}