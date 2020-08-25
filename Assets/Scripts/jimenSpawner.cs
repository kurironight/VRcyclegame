using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jimenSpawner : MonoBehaviour {

    [SerializeField] float spawnInterval = 3f;//敵術現間隔
    [SerializeField] Jimen jimenPrefab;
    float timer = 0f; //出現時間判定用のタイマー変数

    Jimen jimen;

    void Update()
    {
        //タイマー更新
        timer += Time.deltaTime;

        //出現間隔の判定
        if (spawnInterval < timer)
        {
            //ランダムにEnemySprawnerを選択して敵を出現させる
            jimen = Instantiate(jimenPrefab, transform.position, transform.rotation);

            //タイマーリセット
            timer = 0f;
        }

    }
}
