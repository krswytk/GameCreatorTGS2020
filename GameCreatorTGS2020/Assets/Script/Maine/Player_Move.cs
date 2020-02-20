using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public static  float Speed=0;
    GameObject Camera;
    Transform myTransform;
    public static  Vector3 pos;
    public static float Player_pos;

    public static bool break_stop = false;

    int hit = 0;

    float Score=0;
    float Num = 0;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
        pos = myTransform.position;
        //Speed = pos.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Speed = Speed - 0.1f;
            //pos.y = Speed;
            //myTransform.position = pos;  // 座標を設定
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if (Input.GetKey(KeyCode.B))
        {
            Num++;
        }

        if (Score == 0)
        {
            Score = GetScore.Score;
            Num = Mathf.Floor(((Score - 1000) / 100)*3);
        }
        else
        {
            if (hit < Num)
            {
                this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                //Speed = Speed - 1.4f;
                //pos.y = Speed;
                //myTransform.position = pos;  // 座標を設定
            }
            if (hit == Num)
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
        Debug.Log(GetScore.Score);
        Player_pos = myTransform.position.y;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit++;
        //Debug.Log(hit);
    }
}
