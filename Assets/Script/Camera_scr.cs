using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//カメラの位置変更スクリプト
//プレイヤーがやられた後、スタート地点にカメラが向かうようにする
public class Camera_scr : MonoBehaviour
{
    public static bool tracking = true; //トラッキングを有効にするか判定する変数
    [SerializeField]private GameObject player;  //プレイヤーオブジェクトをアタッチ
    void Update()
    {
        //現在の位置を取得
        Transform camTrans = this.transform;
        //取得した位置をVector3で代入
        Vector3 camPos = camTrans.position;
        Vector3 plyPos = player.transform.position;

        //トラッキングが有効な時(プレイヤー生存状態)の処理
        if(tracking == true)
        {    
            camPos.z = plyPos.z - 7;    //プレイヤーから一定距離を保つ
            camTrans.position = camPos; //変更した位置を代入
            //-Debug.Log("traking = true");
        }
        //トラッキングが無効な時(プレイヤーがやられた後)の処理
        if(tracking == false)
        {
            //プレイヤーの位置までカメラを移動させる
            if(camPos.z >= plyPos.z - 6f)
            {
                camPos.z -= 2f; //カメラを後ろに移動する
                camTrans.position = camPos; //カメラの現在地を代入
                //-Debug.Log("カメラ移動");
            }
            //移動が終了したらトラッキングを有効にする
            else
            {
                tracking = true;
                //-Debug.Log("カメラ移動終了");
            }
        }
    }    
}
