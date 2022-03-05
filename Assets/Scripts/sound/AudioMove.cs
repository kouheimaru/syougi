﻿using UnityEngine;
using UnityEngine.UI;

public class AudioMove : MonoBehaviour
{
    private AudioSource Audio;//AudioSourceを入れる
    bool isAudioStart = false; //曲再生の判定
    void Awake()
    {
        Audio = GetComponent<AudioSource>();//AudioSourceの取得
        Audio.Play();//AudioSourceを再生
        isAudioStart = true;//曲の再生を判定
    }
    void Update()
    {
        if (!Audio.isPlaying && isAudioStart)
        //曲が再生されていない、尚且つ曲の再生が開始されている時
        {
            Destroy(gameObject);//オブジェクトを消す
        }
    }
}