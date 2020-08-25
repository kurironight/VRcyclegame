using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour 
{
    [SerializeField] Car carPrefab;

    Car car;
    [SerializeField] public float minx = 3.0f;
    [SerializeField] public float maxx = 3.0f;
    Vector3 randompoint;
    GameObject Spawners;
    SpawnController script;
    float timer = 0; //if構文にぶち込むため

    private void Start()
    {
        Spawners = GameObject.Find("Spawners"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = Spawners.GetComponent<SpawnController>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
   
     }

    public void Spawn() 
    {
        float time = script.timer; //SpawnControllerから奪ってきた
        float timeinterval = script.spawnInterval; //SpawnControllerから奪ってきた

        if (car==null||time-timer>timeinterval*2)
        {
            randompoint = new Vector3(Random.Range(minx, maxx), transform.position.y, transform.position.z );
            car = Instantiate(carPrefab, randompoint, transform.rotation);
            timer = time;
        }
		
	}

}
