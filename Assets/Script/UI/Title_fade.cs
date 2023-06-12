using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_fade : MonoBehaviour
{
    public GameObject imageFade;   //フェードパネルの取得
    public GameObject textFade;
    Image image;               //フェードアウトするイメージ取得変数
    Text text;                  //フェードアウトする文字の取得
    private float alpha;           //パネルのalpha値取得変数
    public static bool fadeTitle = false;  //フェードアウトのフラグ変数
    private Canvas canvas;         //キャンバス取得変数
    public static bool selectDown = false;

     void Start()
   {
       Application.targetFrameRate = 60;
       fadeTitle = false;
       selectDown = false;
       image = imageFade.GetComponent<Image>(); //パネルのイメージ取得
       text = textFade.GetComponent<Text>();  //パネルのテキスト取得
       alpha = image.color.a;                 //パネルのalpha値を取得
       canvas = GetComponent<Canvas>();            //キャンバスを取得
   }
     void Update()
   {
        //フェードアウトの処理
       if (fadeTitle == true) //ボタンを押すとtrueになる
       {
           FadeOut(); //FadeOutを実行
       }
   }

   void FadeOut() //フェードアウトの設定
   {
       alpha -= 0.01f;                             //フェードアウトの速度
       image.color = new Color(0, 0, 0, alpha); //フェードアウトの処理
       text.color = new Color(0, 0, 0, alpha); //フェードアウトの処理
       if (alpha <= 0.01)                              //フェードアウト終了後の処理
       {
            selectDown = true;
       }
   }
}



