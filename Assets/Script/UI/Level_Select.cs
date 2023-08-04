using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//レベルセレクトとアニメーションを行うスクリプト
//ロード時にゲームのリセットも行う
public class Level_Select : MonoBehaviour
{
    //アニメーションの処理

    RectTransform rect; //UI座標用
    
    void Start()
    {
        rect = GetComponent<RectTransform>(); //UI座標取得
    }

    void Update()
    {
        if(Title_fade.selectDown == true)
        {
            //目標地点まで落下
          if(rect.localPosition.y > 40)
            {
                rect.localPosition += new Vector3(0,-5,0);  
            }  
        }
    }

    //レベルセレクト

    //Normal選択時の処理
    public void OnClickNormal()
    {
        SceneManager.LoadScene("Normal");
        Reset();
    } 

    //Hard選択時の処理
    public void OnClickHard()
    {
        SceneManager.LoadScene("Hard");
        Reset();
    } 

    //変数のリセットを行うメソッド
    void Reset()
    {
        Goal.goal = false;
        Gamerule.point = 0;
        Gamerule.missCount = 0;
        Gamerule.alive = true;
        Gamerule.ready = false;
        Start_Text.startTimer = 0;
        Tap_to_start.up_down = 0.02f;
        Tap_to_start.ud = true;
        ChikinController.moveSpeed = 5.0f;
    }
}
