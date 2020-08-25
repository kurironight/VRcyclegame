using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawner : MonoBehaviour {
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
        Spawn();
    }
    private void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        float time = script.timer; //SpawnControllerから奪ってきた
        float timeinterval = script.spawnInterval; //SpawnControllerから奪ってきた

        if (time>10* timeinterval && time%(2*timeinterval)<Time.deltaTime)
        {
            randompoint = new Vector3(Random.Range(minx, maxx), transform.position.y, transform.position.z);
            car = Instantiate(carPrefab, randompoint, transform.rotation);
            timer = time;
        }

    }
}
