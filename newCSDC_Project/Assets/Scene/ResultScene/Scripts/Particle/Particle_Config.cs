using UnityEngine;

public class Particle_Config : MonoBehaviour
{
    [SerializeField]
    private float Start_Particle;   // パーティクルの開始時間

    private ParticleSystem particle;
    ScoreManager manager;

    // Use this for initialization
    void Start()
    {
        particle = this.GetComponent<ParticleSystem>();
        manager = GameObject.Find("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // ランキング関数
        Ranking();
    }

    void Ranking()
    {
        // Player１が１位の場合
        if (manager.score[0] >= manager.score[1] && manager.score[0] >= manager.score[2] && manager.score[0] >= manager.score[3])
        {
            // 花吹雪がPlayer1の真上に来る
            Vector3 tmp = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(-2, tmp.y, tmp.z);
        }

        // Player２が１位の場合
        if (manager.score[1] >= manager.score[0] && manager.score[1] >= manager.score[2] && manager.score[1] >= manager.score[3])
        {
            // 花吹雪がPlayer2の真上に来る
            Vector3 tmp = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(-5, tmp.y, tmp.z);
        }

        // Player３が１位の場合
        if (manager.score[2] >= manager.score[0] && manager.score[2] >= manager.score[1] && manager.score[2] >= manager.score[3])
        {
            // 花吹雪がPlayer3の真上に来る
            Vector3 tmp = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(0.75f, tmp.y, tmp.z);
        }

        // Player４が１位の場合
        if (manager.score[3] >= manager.score[0] && manager.score[3] >= manager.score[1] && manager.score[3] >= manager.score[2])
        {
            // 花吹雪がPlayer4の真上に来る
            Vector3 tmp = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(2, tmp.y, tmp.z);
        }
    }
}
