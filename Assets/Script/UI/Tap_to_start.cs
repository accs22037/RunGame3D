using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap_to_start : MonoBehaviour
{
    RectTransform rect;
    public static float up_down = 0.02f;
    public static float udCount = 1.5f;
    public static bool ud = true;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        udCount += Time.deltaTime;
        if(ud == true && rect.localPosition.y != -140)
        {
            rect.localPosition += new Vector3(0,up_down,0);
        }
        if(ud == true && rect.localPosition.y >= -140)
        {
            ud = false;
        }
        if(ud == false && rect.localPosition.y != -160)
        {
            rect.localPosition -= new Vector3(0,up_down,0);
        }
        if(ud == false && rect.localPosition.y <= -160)
        {
        ud = true;
        }
    }
}
