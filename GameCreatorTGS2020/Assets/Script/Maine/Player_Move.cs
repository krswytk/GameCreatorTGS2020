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
            //Speed = Speed - 0.1f;
            //pos.y = Speed;
            //myTransform.position = pos;  // 座標を設定
            //this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            Num = 4;
        }
        if (Input.GetKey(KeyCode.B))
        {
            Num++;
        }

        if ((Score == 0)&&(Num<1))
        {
            Score = GetScore.Score;
            if (Mathf.Floor(((Score - 1000) / 100) * 2) < 6)
            {
                Num = Mathf.Floor(((Score - 1000) / 100) * 2);
                if (Num < 0) Num = 0;
            }
            else
            {
                Num = 5;
            }
        }
        else
        {
            if ((hit < Num) && (Num != 0))
            {
                this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                //Speed = Speed - 1.4f;
                //pos.y = Speed;
                //myTransform.position = pos;  // 座標を設定
            }
            if ((hit == Num) && (Num != 0))
            {
                break_stop = true;
                //this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                Rigidbody2D rb = this.GetComponent<Rigidbody2D>();  // rigidbodyを取得
                Vector2 force = new Vector2(0.0f, 0.0f);    // 力を設定
                //rb.velocity = force;
                //Debug.Log("fack");
            }
        }
        //Debug.Log(myTransform.position.y);
        //Debug.Log(Num);
        //Debug.Log("hit:"+hit);
        //Debug.Log(break_stop);

        //////////////////////
        ///
        pos = myTransform.position;
        Player_pos = pos.y;///cameramove
        //Debug.Log(pos.y);
        ///////////////////


        if ((hit == Num) && (Num != 0))
        {
            time++;
            if (time > 150)
            {
                feed_out = true;
                time = 0;
            }
            this.gameObject.GetComponent<CircleCollider2D>().enabled = true;
            //Player_rb.off = true;
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
