using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//ここ注意

public class zkatamukikentiyou : MonoBehaviour {

    float m_X;
    float m_Y;
    float m_Z;
    //知りたい座標のGaeObjectの設定
    public GameObject target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //それぞれに座標を挿入
        m_X = target.transform.localEulerAngles.x;
        m_Y = target.transform.localEulerAngles.y;
        m_Z = target.transform.localEulerAngles.z;

        //テキストに表示
        this.GetComponent<Text>().text ="\nZ座標は" + m_Z.ToString();

    }
}
