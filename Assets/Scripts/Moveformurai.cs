using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveformurai : MonoBehaviour {

    [SerializeField] public float susumuspeed = 3.0f;
    [SerializeField] public float yokonospeed = 3.0f;
    [SerializeField] public float maxx = 3.0f;


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

        Clamp();
    }

    void Clamp()
    {

        // プレイヤーの座標を取得
        Vector3 pos = transform.position;

        // プレイヤーの位置が画面内に収まるように制限をかける
        pos.x = Mathf.Clamp(pos.x, -maxx, maxx);


        // 制限をかけた値をプレイヤーの位置とする
        transform.position = pos;
    }
}
