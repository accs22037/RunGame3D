using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//カメラの位置変更スクリプト
//プレイヤーがやられた後、スタート地点にカメラが向かうようにする
public class Camera_scr : MonoBehaviour
{
    public static bool tracking = true;
    [SerializeField]private GameObject player;
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
            //位置の変更
            camPos.z = plyPos.z - 7;
            //変更した位置を代入
            camTrans.position = camPos;
        }
        //トラッキングが無効な時(プレイヤーがやられた後)の処理
        if(tracking == false)
        {
            //プレイヤーの位置までカメラを移動させる
            if(camPos.z >= plyPos.z - 6f)
            {
                camPos.z -= 2f;
                camTrans.position = camPos;
            }
            //移動が終了したらトラッキングを有効にする
            else
            {
                tracking = true;
            }
        }
    }    
}
