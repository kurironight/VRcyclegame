using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    [SerializeField] int damage = 1;//当たった時に村井が受けるダメージ
    hearthyouji hearthyouji;


    // Use this for initialization
    void Start()
    {
        var gameObj = GameObject.FindWithTag("HP");//ゲームオブジェクトを検索
        //gameObjに含まれるHPコンポーネントを取得
        hearthyouji = gameObj.GetComponent<hearthyouji>();

    }

    void OnHitBullet()
    {
        Destroy(gameObject);
        hearthyouji.HPpoint(damage);
    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
