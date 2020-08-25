using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]

public class hearthyouji : MonoBehaviour
{
    private const char C = '❤';
    Text uitext;
    [SerializeField] int HP = 2;

    // Use this for initialization
    void Start () {
        uitext = GetComponent<Text>();
        string text = new string(C, HP);
        uitext.text = text;
    }
	
	// Update is called once per frame
public void HPpoint (int minusHP) {
        HP -= minusHP;
        //HPの更新
        string text = new string(C, HP);
        uitext.text = text;
		
	}
}
