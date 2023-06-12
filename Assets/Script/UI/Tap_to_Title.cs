using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tap_to_Title : MonoBehaviour
{
    public GameObject canvas;
    public GameObject text_Fade;
    Text text;
    Canvas cvs;
    private float alpha;

    void Start()
    {
        cvs = canvas.GetComponent<Canvas>();
        text = text_Fade.GetComponent<Text>();  //パネルのテキスト取得
    }

    public void OnclickTitle()
        {
            Title_fade.fadeTitle = false;
            SceneManager.LoadScene("Title");
        }
    void Update()
    {
        if(Goal.goal == true)
        {
          cvs.sortingOrder = -1;
          text.color = new Color(255,255,255,255);
        }
        
    }
}
