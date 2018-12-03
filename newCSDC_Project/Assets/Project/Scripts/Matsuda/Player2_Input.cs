﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 制作者：松田
public class Player2_Input : MonoBehaviour
{
    SpriteRenderer Render;

    private Image image;

    // プレイヤー待機のスプレイと画像
    public Sprite sprite_wait;

    // プレイヤースタートのスプライト画像
    public Sprite sprite_start;

    // プレイヤーのステータス
    private bool player2_changeflg = false;

    private bool player2_button_push = false;

    private AudioSource AudioSource;

    // Use this for initialization
    void Start()
    {
        // 画像の読み込み
        image = GetComponent<Image>();
        image.sprite = sprite_wait;

        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤー入力関数
        ChangeInput();
    }

    public void ChangeInput()
    {
        // プレイヤー２が入力を読み取った時
        if (player2_changeflg == true)
        {
            // プレイヤー２の状態をスタートにする。
            image.sprite = sprite_start;
            if (player2_button_push == false)
            {
                AudioSource.Play();
                player2_button_push = true;
            }
        }
        else
        {
            // プレイヤー２の状態を待機。
            image.sprite = sprite_wait;
        }
        // ＰＳ４のコントローラーの○ボタンもしくはキーボードの２ボタンを押している時
        if (Input.GetButtonDown("Player2_Kettei"))
        {
            player2_changeflg = true;
        }
    }
}
