using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//タイトル画面クリック時にUIをフェードアウトさせるスクリプト
//画面クリックの処理も行う
public class Title_fade : MonoBehaviour
{
    public GameObject imageFade;    //イメージ(タイトル)をアタッチ
    public GameObject textFade;     //画面下テキスト(TAP TO START)をアタッチ
    Image image;                    //フェードアウトするイメージ取得変数
    Text text;                      //フェードアウトする文字の取得
    private float alpha;            //パネルのalpha値取得変数
    public static bool fadeTitle = false;  //フェードアウトを判定する変数
    private Canvas canvas;          //キャンバス取得変数
    public static bool selectDown = false; //レベルセレクトの落下を判定する変数

    RectTransform rect; //UI座標用変数

     void Start()
   {
        Application.targetFrameRate = 60;   //フレームレートを固定
        fadeTitle = false;  
        selectDown = false; 
        image = imageFade.GetComponent<Image>(); //イメージ(タイトル)取得
        text = textFade.GetComponent<Text>();   //テキスト取得
        alpha = image.color.a;                  //パネルのalpha値を取得
        canvas = GetComponent<Canvas>();        //キャンバスを取得

        rect = GetComponent<RectTransform>();   //UIの座標を取得

   }
     void Update()
   {
        //フェードアウトの処理
       if (fadeTitle == true)
       {
           FadeOut(); //FadeOutを実行
       }
   }

   void FadeOut()
   {
       alpha -= 0.01f;      //フェードアウトの速度
       image.color = new Color(0, 0, 0, alpha); //イメージ(タイトル)のフェードアウト処理
       text.color = new Color(0, 0, 0, alpha);  //テキストのフェードアウト処理
       
       //フェードアウト終了後、レベルセレクトの落下を有効化する
       if (alpha <= 0.01)
       {
            selectDown = true;
       }
   }

    //画面(ボタン)クリック時の処理
    public void OnclickTitle()
        {
            fadeTitle = true;   //フェードアウトを有効化
            rect.localPosition += new Vector3(0,5000,0); //再度処理を行わないためにボタンを画面外に移動させておく
        }
}



