using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerule : MonoBehaviour
{
    public static bool alive = true; //プレイヤーが生きてるか確認
    public static int point = 0; //ポイント管理
    private void OnTriggerEnter(Collider other) //Playerとの衝突を検知(On Trigger)
    {   
        if(other.CompareTag("damage_Object"))
        {
            alive = false;
            Destroy(this.gameObject);
        }
    }
}
