using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ゴールしたときの処理をするスクリプト
//ゴールした際には待機状態のアニメーションにする
public class Goal : MonoBehaviour
{
    public static bool goal = false; //ゴールしているかどうか確認する変数
    [SerializeField] Animator animator; //アニメーションをアタッチする
    private void OnTriggerEnter(Collider other) //Playerとの衝突を検知(On Trigger)
    {   
        //ゴールに触れた時の処理
        if(other.CompareTag("goal_Object"))
        {
            goal = true; //ゴールをtrueにする
            //音を鳴らす;
        }
    }
    void Update()
    {
        //ゴールした時に待機状態のアニメーションにする
        if(goal == true)
        {
            Gamerule.ready = true; //待機状態にする
            animator.SetBool("Goal",true);
        }
        else
        {
            animator.SetBool("Goal",false);
        }
    }
}
