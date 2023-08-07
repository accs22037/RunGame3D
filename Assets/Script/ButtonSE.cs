using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを押した時にSEを鳴らすスクリプト
public class ButtonSE : MonoBehaviour
{
    public AudioClip buttonSE;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickButton()
    {
        audioSource.PlayOneShot(buttonSE);
    }
}
