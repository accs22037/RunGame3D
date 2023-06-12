using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_down1 : MonoBehaviour
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
          if(rect.localPosition.y > 40)
            {
                rect.localPosition += new Vector3(0,-5,0);  
            }  
        }
    }
}
