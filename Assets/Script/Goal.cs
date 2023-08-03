using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ゴールしたときの処理
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
        //ゴールした時の処理
        if(goal == true)
        {
            Gamerule.ready = true; //待機状態にする
            animator.SetBool("Goal",true); //待機状態のアニメーションに遷移
        }
        else
        {
            animator.SetBool("Goal",false); //待機状態のアニメーションを無効化
        }
    }
}
