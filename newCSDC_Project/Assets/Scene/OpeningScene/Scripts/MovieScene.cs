using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieScene : MonoBehaviour
{

    [SerializeField]
    private float MovieTime;        // 動画の再生時間


    [SerializeField]
    private int next_number;        // 次のシーンに飛ぶ番号
    //   public AudioSource audiosource;

    // Use this for initialization
    void Start ()
    {
        // マウスカーソル非表示
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
//        audiosource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // 時間経過処理
        MovieTime -= Time.deltaTime;

        // 動画が終了した時、次のシーンに入る
        if(MovieTime <= 0)
        {
//            audiosource.Stop();
            Fade.FadeOut(next_number);
        }

        if(Input.GetButtonDown("Player1_Kettei"))
        {
            Fade.FadeOut(next_number);
//            SceneNavigator.Instance.Change("Priproment");
        }

        if (Input.GetButtonDown("Player2_Kettei"))
        {
           //  audiosource.Stop();

        }

        if (Input.GetButtonDown("Player3_Kettei"))
        {
        }

        if (Input.GetButtonDown("Player4_Kettei"))
        {
            
        }
    }
}
