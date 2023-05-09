using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerule : MonoBehaviour
{
    public bool alive = true; //プレイヤーが生きてるか確認
    public static int point = 0; //ポイント管理
    
    void Start()
    {
        point = 0;
    }

    void Update()
    {
        
    }
}
