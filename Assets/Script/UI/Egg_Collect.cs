using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//卵の取得数を表示するスクリプト
public class Egg_Collect : MonoBehaviour
{
   [SerializeField] Text eggCount; //テキスト

    void Update()
    {
        eggCount.text = "Egg x " + Gamerule.point; //卵の取得数を表示
    }
}
