using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_debug : MonoBehaviour
{
    [SerializeField] Text debug_text;
    int flame_debug = 0;
    bool letter = true;

    void Update()
    {
        flame_debug = Time.frameCount - flame_debug;
        if(flame_debug == 40)
        {
            if(letter == true)
            {
                debug_text.text = "Debugging...";
                letter = false;
                flame_debug = 0;
            }
            else
            {
                debug_text.text = "";
                letter = true;
                flame_debug = 0;
            }
        }
    }
}
