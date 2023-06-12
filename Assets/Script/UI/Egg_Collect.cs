using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg_Collect : MonoBehaviour
{
   [SerializeField] Text eggCount;

    void Update()
    {
        eggCount.text = "Egg x " + Gamerule.point;
    }
}
