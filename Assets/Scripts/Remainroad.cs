using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]

public class Remainroad : MonoBehaviour {
[SerializeField] float gamekyori = 30.0f;
    [SerializeField] float speed = 30.0f;

    Text uiText;
    float currentkyori;
    

    // Use this for initialization
    void Start () {
        //Textコンポーネント取得
        uiText = GetComponent<Text>();
        //残り時間を設定
        currentkyori = gamekyori;
        
    }
    
    // Update is called once per frame
    void Update () {
        //残り時間を計算
        currentkyori -= speed;
        //0秒以下にならない
        if (currentkyori <= 0.0f)
        { currentkyori = 0.0f; 
        }
        //残り時間テキスト更新
        uiText.text = string.Format("残り距離：{0:F}m", currentkyori);
    }
    //カウントダウンを行なっているのか
    public bool IsCountingDown()
    {
        //カウンターが0出なければ、カウント中
        return currentkyori > 0.0f;
    }

  
}

