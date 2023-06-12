using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //ゴールしているかどうか確認する変数
    public static bool goal = false;
    [SerializeField] Animator animator;
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
            animator.SetBool("Goal",true);
        }
        else
        {
            animator.SetBool("Goal",false);
        }
    }
}
