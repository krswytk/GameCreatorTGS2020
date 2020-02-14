using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreBreakBord : MonoBehaviour
{
    private GameObject[] audioobjects;
    private GameObject[] audioobjects2;
    private GameObject[] Bords;

    private int Number;
    public float Score;

    private Animator[] animator;

    private float time;
    private int loop;

    bool Score_Check=false;
    float Score_MAX = 0;
    float Score_MIN = 0;
    float Score_NUM = 0;
    float Score_difference = 0;

    int anim_save=0;

    int anim_Num=0;

    int test = 0;

    int num = 0;

    public float speed;
    float Break_speed;

    float add_num=0;
    int total=0;


    public bool[]  break_anim;

    bool Total_Check = false;

    int anim_break;

    float time_test = 0;

    float B_speed=200;
    float count=0;

    // Start is called before the first frame update
    void Start()
    {
        audioobjects = GameObject.FindGameObjectsWithTag("audio");
        audioobjects2 = GameObject.FindGameObjectsWithTag("audioend");
        Number = this.GetComponent<InstantiateBord>().GetNumber();
        Bords = this.GetComponent<InstantiateBord>().GetBords();
        animator = new Animator[Number];
        //Debug.Log(Bords[0]);

        for(int lp = 0;lp < Number; lp++)
        {
            Bords[lp] = this.GetComponent<InstantiateBord>().GetBords()[lp];
            animator[lp] = Bords[lp].GetComponent<Animator>();
        }

        /////////////////////////////////////本来Updateのほうが適しているがprtでは処理のためこちらに記入

        time = 5;
        loop = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(anim_Num - 1);
        if (anim_Num- 1 >= 0)
        {
            Bords[(anim_Num- 1)].GetComponent<Break_Anime>().Break_borad = true;
            if((anim_Num - 1)%2==0) Bords[(anim_Num - 1)].GetComponent<Break_Anime>().Sound_stop = true;
        }
        
        if ((anim_Num < Score)&&(anim_Num>-1))
        {
            if (anim_Num == 0)//最初の板割れ時
            {
                Break_speed = Score;
                Score_difference = Score;
            }
            else
            {

            }

            if (Total_Check == false)
            {
                total = 0;
                for (int lp = 0; lp < Score_difference+1; lp++)
                {
                    total = total + lp;
                }
                Total_Check = true;
            }

            if (Break_speed - (total * 30) / (Score_difference * Number * speed) > 5)
            {
                Break_speed = Break_speed - (total * 30) / (Score_difference * Number * speed);
            }

            time += Time.deltaTime;

            B_speed = 1-(1.0f*(Score_difference/ 100));

            if(Score < (anim_Num+5)) add_num = 250;//B_speedが高くなるほど速度が落ちる0.33f

            time_test = time_test + ((Score_difference) / ((add_num) + Score_difference));

            anim_Num = Mathf.FloorToInt(time_test);


        }

        if (Score_NUM == 0)//最初のスコア取得
        {
            Score_MIN = GetScore.Score*5;//スコアの初期値取得
            Score_NUM = GetScore.Score * 5;
        }
        else
        {
            Score_NUM = GetScore.Score * 5;
        }

        Score = Score_NUM - Score_MIN;

        if (Score_MAX < Score)
        {
            Score_difference = Score - Score_MAX;
            add_num = 0;
            B_speed = 200;
            if (Break_speed<Score) Break_speed = Score_difference;

            Score_MAX = Score;
            Score_Check = true;
            Total_Check = false;
            anim_save = anim_Num;
        }
        if (loop <= Score - 1)
            {
                loop = loop + 1;
            }
    }
}

