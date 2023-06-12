using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_bool : MonoBehaviour
{
    RectTransform rect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    public void OnclickTitle()
        {
            Title_fade.fadeTitle = true;
            rect.localPosition += new Vector3(0,5000,0);
        }
}
