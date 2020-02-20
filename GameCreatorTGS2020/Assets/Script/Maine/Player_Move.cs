﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public static  float Speed=0;
    GameObject Camera;
    Transform myTransform;
    public static  Vector3 pos;

    int hit = 0;

    float Score=0;
    float Num = 0;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
        pos = myTransform.position;
        Speed = pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Speed = Speed - 0.1f;
            pos.y = Speed;
            myTransform.position = pos;  // 座標を設定
        }

        if (Score == 0)
        {
            Score = GetScore.Score;
        }
        else
        {
            if (hit < Num)
            {
                Speed = Speed - 0.1f;
                pos.y = Speed;
                myTransform.position = pos;  // 座標を設定
            }
        }

        Num = Mathf.Floor((Score - 1000) / 100);
        //Debug.Log(Num);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit++;
        //Debug.Log(hit);
    }
}
