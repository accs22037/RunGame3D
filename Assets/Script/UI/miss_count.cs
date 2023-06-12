using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miss_count : MonoBehaviour
{
    [SerializeField] Text missText;

    void Update()
    {
        missText.text = "miss x " + Gamerule.missCount;
    }
}

