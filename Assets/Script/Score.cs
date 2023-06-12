using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int eggPoint = 100;
    int missPoint = -10;
    int totalScore;
    bool countEnd = false;

    // Update is called once per frame
    void Update()
    {
        if(Goal.goal == true)
        {
            if(countEnd == false)
            {
                eggPoint = 100 * Gamerule.point;
                missPoint = -10 * Gamerule.missCount;
                totalScore = eggPoint + missPoint;
                countEnd = true;
            }
            if(totalScore <= 0)
            {
                scoreText.text = "Score:0";
            }
            else
            {
                scoreText.text = "Score:" + totalScore;
            }
        }
        else
        {
            scoreText.text = "";
        }
    }
}
