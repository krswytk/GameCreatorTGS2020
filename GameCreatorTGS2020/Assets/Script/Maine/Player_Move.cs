using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public static float Speed;
    GameObject Camera;
    Transform myTransform;
    public static Vector3 pos;
    public static float Player_pos;

    public static bool break_stop;

    public static int hit;

    float Score;
    public static float Num;

    bool istrigger;

    public static int time;

    public static bool feed_out;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 0;
        break_stop = false;
        hit = 0;
        Score = 0;
        Num = 0;
        time = 0;
        feed_out = false;
        istrigger = false;


        //Speed = pos.y;

        myTransform = this.transform;
        pos = myTransform.position;
        Player_pos = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Num = 4;//デバック用のスコア代入
        }
        if (Input.GetKey(KeyCode.B))
        {
            Num++;//デバック用のスコア代入
        }



        if ((Score == 0)&&(Num<1))//スコアがまだ取れてない場合
        {
            Score = GetScore.Score;
            if (Mathf.Floor(((Score - 1000) / 100) * 2) < 6)//板割りすぎないように設定
            {
                Num = Mathf.Floor(((Score - 1000) / 100) * 2);//スコアを板の割れる枚数に変換
                if (Num < 0) Num = 0;//スコアが0以下の場合誤作動しないように0固定
            }
            else
            {
                Num = 5;//上限越えたら変換
            }
        }
        else//スコア取れた後の処理
        {
            if ((hit < Num) && (Num != 0))//板割った枚数がスコア以下の場合
            {
                this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;//重力をオン

            }
            if ((hit == Num) && (Num != 0))//板割った枚数がスコアと同じ場合
            {
                break_stop = true;//板が割れないようにする設定をオン
                Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得
                Vector2 force = new Vector2(0.0f, 0.0f);    // 力を設定
            }
        }

        pos = myTransform.position;//キャラの位置を取得＆記憶
        Player_pos = pos.y;//キャラの位置を取得＆記憶


        if ((hit == Num) && (Num != 0))//板を割り切った場合
        {
            time++;
            if (time > 150)
            {
                feed_out = true;//Score画面に移動
                time = 0;
            }
        }

        if(Player_rb.off == true)//後ろの疑似判定がoffになったら
        {
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = true;//キャラの判定をオンにする
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bill_rb")
        {
            this.gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }

        if (collision.gameObject.tag == "bord")
        {
            if ((hit == Num) && (Num != 0))
            {
                istrigger = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D col2)
    {
        if ((hit - 1 < Num) && (istrigger == false))
        {
            if (col2.gameObject.tag == "Break")
            {
                this.gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
            }
        }
    }



    private void OnTriggerExit2D(Collider2D col)
    {
        if ((col.gameObject.tag == "Break") || (hit > 6))
        {
            this.gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }
}
