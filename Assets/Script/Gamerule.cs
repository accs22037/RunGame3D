using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerule : MonoBehaviour
{
    public static bool alive = true;    //生存状態を確認する変数
    public static bool ready = false;   //待機状態か確認する変数
    public static float saveSpeed;      //速度を保存する変数
    public static int point = 0;        //ポイント管理の変数
    public static int missCount = 0;    //ミスカウント
    float damtime;      //ミス後のディレイ
    Vector3 startPos;   //スタート位置の座標
    private void OnTriggerEnter(Collider other) //Playerとの衝突を検知(On Trigger)
    {   
        //ダメージオブジェクトに当たると
        if(other.CompareTag("damage_Object"))
        {
            alive = false; //生存状態をfalseにする
            //音を鳴らす;
            //-Debug.Log("衝突判定");
        }
    }

    void Start()
    {
        saveSpeed = ChikinController.moveSpeed; //速度を保存する
        startPos = new Vector3(0,1.2f,-9);      //スタート位置の座標設定
    }

    void  Update() 
    {    
        //生存状態がfalseになると待機状態になる
        if(alive == false)
        {
            ready = true;
            damtime += Time.deltaTime;
            point = 0;                      //ミスするとポイントを0にする
            Camera_scr.tracking = false;    //カメラトラッキングをfalseにする
            //-Debug.Log("alive = false");
        }

        //待機状態である場合、歩かないようにする
        if(ready == true)
        {
            ChikinController.moveSpeed = 0;
            //-Debug.Log("ready = true");
        }
        //ミス後にスタート地点へ戻る処理
        if(damtime >= 1)
        {
            //現在の座標を取得
            Transform myTransform = this.transform;
            //スタート地点へ戻す
            myTransform.position = startPos;
            alive = true;   //生存状態をtrueにする
            damtime = 0;    //ディレイをリセットする
            ready = false;  //待機状態をfalseにする
            ChikinController.moveSpeed = saveSpeed; //移動速度を元に戻す
            missCount += 1; //ミスカウントを増やす
            //-Debug.Log("damtime >= 1");
        }
    }
}
