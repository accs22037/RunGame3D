using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//リザルト画面に「Tap to Title」を表示するスクリプト
public class Tap_to_Title : MonoBehaviour
{
    public GameObject canvas;       //キャンバス用のゲームオブジェクト
    public GameObject text_Fade;    //ゲームオブジェクト
    Text text;  
    Canvas cvs;
    private float alpha; //透明度

    void Start()
    {
        cvs = canvas.GetComponent<Canvas>();    //キャンバスを取得
        text = text_Fade.GetComponent<Text>();  //パネルのテキスト取得
    }

    public void OnclickTitle() //画面がクリックされたときの処理
        {
            Title_fade.fadeTitle = false;       //
            SceneManager.LoadScene("Title");    //タイトル画面へ移動
        }
    void Update()
    {
        
        if(Goal.goal == true)   
        {
          cvs.sortingOrder = -1;    //
          text.color = new Color(255,255,255,255);
        }
        
    }
}
