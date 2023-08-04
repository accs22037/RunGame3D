using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//レベルセレクトの文字が降りてくるアニメーションのスクリプト
public class Select_down : MonoBehaviour
{
    RectTransform rect; //UI座標用
    
    void Start()
    {
        rect = GetComponent<RectTransform>(); //UIの座標を取得
    }

    void Update()
    {
        //タイトル画面を押した後に実行する
        if(Title_fade.selectDown == true)
        {
            //目標地点まで落下し続ける
            if(rect.localPosition.y > 160)
            {
                rect.localPosition += new Vector3(0,-5,0);  
            }
        }
    }
}
