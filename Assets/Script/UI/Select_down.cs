using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_down : MonoBehaviour
{
    RectTransform rect;
    Vector3 GoalPos;
    
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        if(Title_fade.selectDown == true)
        {
            if(rect.localPosition.y > 160)
            {
                rect.localPosition += new Vector3(0,-5,0);  
            }
        }
    }
}
