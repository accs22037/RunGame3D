using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//スコアを管理するスクリプト
public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;    //スコアを表示するテキスト
    int eggPoint;     //卵のポイント
    int missPoint;    //ミスのポイント(マイナス)
    int totalScore;   //トータルスコア
    bool countEnd = false;  //スコアのカウント有無を管理(バグ防止用)   

    void Update()
    {
        //ゴール判定を確認
        if(Goal.goal == true)
        {
            //スコアを換算する
            if(countEnd == false)   //スコアカウントが有効なとき
            {
                eggPoint = 100 * Gamerule.point;        //卵取得数*100ポイント
                missPoint = -10 * Gamerule.missCount;   //ミス数*-10ポイント
                totalScore = eggPoint + missPoint;      //トータルスコアを計算
                countEnd = true;    //スコアカウントを無効化
            }

            //スコアが0以下になった場合、0にして表示する
            if(totalScore <= 0)
            {
                scoreText.text = "Score:0";
            }

            //スコアを表示する
            else
            {
                scoreText.text = "Score:" + totalScore;
            }
        }

        //ゴールしていない場合何も表示しない
        else
        {
            scoreText.text = "";
        }
    }
}
