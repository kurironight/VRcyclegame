using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour 
{
    [SerializeField] public float spawnInterval = 3f;//敵術現間隔

    CarSpawner[] spawners; // EnemySpawnerのリスト
    public float timer = 0f; //出現時間判定用のタイマー変数
    [SerializeField] float dondonhayaku = 0f; //出現時間判定用のタイマー変数
    [SerializeField] float saisyuuInterval = 0f; //出現時間判定用のタイマー変数
    // Use this for initialization
    void Start () {
        //子オブジェクトに存在するEnemySpawnerのリストを取得
        spawners = GetComponentsInChildren<CarSpawner>();
	}
	

	// Update is called once per frame
	void Update () 
    {
        //タイマー更新
        timer += Time.deltaTime;

        //出現間隔の判定
        if (timer % spawnInterval<Time.deltaTime)
        {
            //ランダムにEnemySprawnerを選択して敵を出現させる
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();
            if (spawnInterval > saisyuuInterval)
            {
                spawnInterval -= dondonhayaku;
            }
        }
		
	}
}
