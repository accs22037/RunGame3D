using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ゲーム開始時に画面中央にテキストを表示する
public class Start_Text : MonoBehaviour
{
    [SerializeField] Text startText;
    public static float startTimer;

    void Update()
    {
        //時間経過で表示する文字を変更する
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
