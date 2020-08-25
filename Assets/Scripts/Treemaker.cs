using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treemaker : MonoBehaviour {

    [SerializeField] float spawnInterval = 3f;//敵術現間隔
    [SerializeField] GameObject treeprefab;
    float timer = 0f; //出現時間判定用のタイマー変数
    [SerializeField] float haba = 3f;
    [SerializeField] float kaitenhaba = 50;

    GameObject tree;

    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        //タイマー更新
        timer += Time.deltaTime;
        float x = Random.Range(-haba, haba);

        float ry = Random.Range(-kaitenhaba, kaitenhaba);

        Transform myTransform = this.transform;
        Vector3 pos = myTransform.localPosition;
        Vector3 localAngle = myTransform.localEulerAngles;
        float local_angle_x = localAngle.x; // ローカル座標を基準にした、x軸を軸にした回転角度
        float local_angle_y = localAngle.y; // ローカル座標を基準にした、y軸を軸にした回転角度
        float local_angle_z = localAngle.z; // ローカル座標を基準にした、z軸を軸にした回転角度

        float mx = pos.x;
        float my = pos.y;
        float mz = pos.z;

        Quaternion qua = Quaternion.Euler(local_angle_x, ry, local_angle_z);



        //出現間隔の判定
        if (spawnInterval < timer)
        {
            //ランダムにEnemySprawnerを選択して敵を出現させる
            tree = Instantiate(treeprefab, myTransform.position+new Vector3(x, my, mz), qua);

            //タイマーリセット
            timer = 0f;
        }


    }
}
