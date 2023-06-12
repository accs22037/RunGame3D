using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fadeout : MonoBehaviour
{
    public GameObject Panelfade;   //フェードパネルの取得
    Image fadealpha;               //フェードパネルのイメージ取得変数
    private float alpha;           //パネルのalpha値取得変数
    public static bool fadeout = false;  //フェードアウトのフラグ変数
    private Canvas canvas;         //キャンバス取得変数
     void Start()
   {
       fadeout = false;
       fadealpha = Panelfade.GetComponent<Image>(); //パネルのイメージ取得
       alpha = fadealpha.color.a;                 //パネルのalpha値を取得
       canvas = GetComponent<Canvas>();            //キャンバスを取得
       canvas.sortingOrder = -1;                   //ボタンが押せなくなる為レイヤーを後ろにする
   }
     void Update()
   {
        //フェードアウトの処理
       if (fadeout == true) //ボタンを押すとtrueになる
       {
           FadeOut(); //FadeOutを実行
       }
       Debug.Log(fadeout); //bool値確認用
   }

   void FadeOut() //フェードアウトの設定
   {
       canvas.sortingOrder = 1;                     //キャンバスのレイヤーを最前面にする
       alpha += 0.005f;                             //フェードアウトの速度
       fadealpha.color = new Color(0, 0, 0, alpha); //フェードアウトの処理
       if (alpha >= 1)                              //フェードアウト終了後の処理
       {
        if(SceneManager.GetActiveScene().name == "Finish") //現在のシーンに合わせて遷移するシーンを変える
        {
           //SceneManager.LoadScene("Start");
        }
        else
        {
            //SceneManager.LoadScene("PF");
        }
       }
   }
}



