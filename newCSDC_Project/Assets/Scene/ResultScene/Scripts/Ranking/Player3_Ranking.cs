using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3_Ranking : MonoBehaviour
{

    // Animator コンポーネント
    private Animator animator;

    // 勝利フラグ（現在は仮）
    private const string win_flg = "pullFlag";

    // 敗北フラグ（現在は仮）
    private const string lose_flg = "IzimerareFlg";

    // 待機フラグ
    //    private const string setting_flg = "";

    [SerializeField]
    private float StartTime;                // 何秒後に開始

    ScoreManager manager;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.Find("Score").GetComponent<ScoreManager>();

        this.animator = GetComponent<Animator>();
        //        this.animator.SetBool(setting_flg, true);
    }

    // Update is called once per frame
    void Update()
    {
        // 時間経過処理
        StartTime -= Time.deltaTime;
        if (StartTime <= 0)
        {
            Ranking();
        }
    }

    void Ranking()
    {
        // Player３が１位の場合
        if (manager.score[2] >= manager.score[0] && manager.score[2] >= manager.score[1] && manager.score[2] >= manager.score[3])
        {
            //            this.animator.SetBool(setting_flg, false);
            // 勝利モーションに入る
            this.animator.SetBool(win_flg, true);
        }
        // Player３が１位ではない場合
        else
        {
            //            this.animator.SetBool(setting_flg, false);
            // 敗北モーションに入る
            this.animator.SetBool(lose_flg, true);
        }
    }
}
