using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//カメラの位置変更スクリプト
public class Camera_scr : MonoBehaviour
{
    [SerializeField]private GameObject player;
    void Update()
    {
        if(Gamerule.alive == true)
        {
            //現在の位置を取得
            Transform camTrans = this.transform;
            //取得した位置をVector3で代入
            Vector3 camPos = camTrans.position;
            Vector3 plyPos = player.transform.position;
            //位置の変更
            camPos.z = plyPos.z - 7;
            //変更した位置を代入
            camTrans.position = camPos;
        }
        
    }
}
