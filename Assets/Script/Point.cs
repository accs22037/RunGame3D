using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//卵の取得処理をするスクリプト
public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //衝突を検知(On Trigger)
    {
        //Playerタグとの衝突時
        if(other.CompareTag("Player")) 
        {
            Destroy(this.gameObject);   //卵のオブジェクトを削除する
            Gamerule.point++;   //卵の取得数を加算する
            //-Debug.Log(Gamerule.point);
        }
    }
}
