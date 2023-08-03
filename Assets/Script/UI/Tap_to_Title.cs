using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//リザルト画面に「Tap to Title」を表示するスクリプト
public class Tap_to_Title : MonoBehaviour
{
    public GameObject canvas;       //キャンバス用のゲームオブジェクト変数
    public GameObject text_Fade;    //ゲームオブジェクト
    Text text;  //テキスト
    Canvas cvs; //キャンバス
    private float alpha; //透明度

    void Start()
    {
        cvs = canvas.GetComponent<Canvas>();
        text = text_Fade.GetComponent<Text>();  //パネルのテキスト取得
    }

    public void OnclickTitle()
        {
            Title_fade.fadeTitle = false;
            SceneManager.LoadScene("Title");
        }
    void Update()
    {
        if(Goal.goal == true)
        {
          cvs.sortingOrder = -1;
          text.color = new Color(255,255,255,255);
        }
        
    }
}
