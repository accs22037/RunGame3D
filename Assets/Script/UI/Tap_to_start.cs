using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//タイトル画面の「Tap to start」をアニメーションさせるするスクリプト
public class Tap_to_start : MonoBehaviour
{
    RectTransform rect; //UI座標用
    public static float up_down = 0.03f; //アニメーション速度
    public static bool ud = true;   //上昇、下降の切り替え用

    void Start()
    {
        rect = GetComponent<RectTransform>(); //UI座標取得
    }

    void Update()
    {
        //上昇するアニメーション(ud == true) y座標-140まで
        if(ud == true && rect.localPosition.y != -140)
        {
            rect.localPosition += new Vector3(0,up_down,0);
        }
        if(ud == true && rect.localPosition.y >= -140)
        {
            ud = false;
        }

        //下降するアニメーション(ud == false) y座標-160まで
        if(ud == false && rect.localPosition.y != -160)
        {
            rect.localPosition -= new Vector3(0,up_down,0);
        }
        if(ud == false && rect.localPosition.y <= -160)
        {
        ud = true;
        }
    }
}
