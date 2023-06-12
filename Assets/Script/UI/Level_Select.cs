using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Select : MonoBehaviour
{
    public void OnClickNormal()
    {
        SceneManager.LoadScene("Normal");
        Goal.goal = false;
        Gamerule.point = 0;
        Gamerule.missCount = 0;
        Gamerule.alive = true;
        Gamerule.ready = false;
        Start_Text.startTimer = 0;
        Tap_to_start.up_down = 0.02f;
        Tap_to_start.udCount = 1.5f;
        Tap_to_start.ud = true;
        ChikinController.moveSpeed = 5.0f;
    } 

    public void OnClickHard()
    {
        SceneManager.LoadScene("Hard");
        Goal.goal = false;
        Gamerule.point = 0;
        Gamerule.missCount = 0;
        Gamerule.alive = true;
        Gamerule.ready = false;
        Start_Text.startTimer = 0;
        Tap_to_start.up_down = 0.02f;
        Tap_to_start.udCount = 1.5f;
        Tap_to_start.ud = true;
        ChikinController.moveSpeed = 5.0f;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
