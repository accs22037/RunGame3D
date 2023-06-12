using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Text : MonoBehaviour
{
    [SerializeField] Text startText;
    public static float startTimer;

    void Update()
    {
        {
            startTimer += Time.deltaTime;
        }
        if(startTimer <=1)
        {
            startText.text = "Ready...";
        }
        if(startTimer >= 2)
        {
            startText.text = " Start!";
        }
        if(startTimer >= 3)
        {
            startText.text = "";
        }
    }
}
