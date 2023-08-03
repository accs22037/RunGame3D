using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ミスした回数を表示
public class miss_count : MonoBehaviour
{
    [SerializeField] Text missText; //テキスト

    void Update()
    {
        missText.text = "miss x " + Gamerule.missCount; //ミスした回数を表示
    }
}

