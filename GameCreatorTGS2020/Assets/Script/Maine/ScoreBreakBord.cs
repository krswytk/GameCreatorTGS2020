using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBreakBord : MonoBehaviour
{
    private GameObject[] audioobjects;
    private GameObject[] audioobjects2;
    private GameObject[] Bords;
    private int Number;
    private float Score;

    private Animator[] animator;

    private float time;
    private int loop;
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
        }

        /////////////////////////////////////本来Updateのほうが適しているがprtでは処理のためこちらに記入

        Score = GetScore.Score;//ベットダイブ時のスコアを毎フレーム取得

        /*for(int lp = 0;lp < Number; lp++)
        {
            if(lp < Score-1)
            {
                animator[lp] = Bords[lp].GetComponent<Animator>();
                animator[lp].SetBool("Break",true);
            }
        }*/
        time = 5;
        loop = 0;
    }

    // Update is called once per frame
    void Update()
    {


        time += Time.deltaTime;

        if(time >= 1)
        {
            if (loop <= Score - 1)
            {
                var audioobject = audioobjects[Random.Range(1, 5)];
                audioobject.GetComponent<AudioSource>().Play();
                animator[loop] = Bords[loop].GetComponent<Animator>();
                animator[loop].SetBool("Break", true);
                loop = loop + 1;
                time = 0;
                //Debug.Log(Bords[loop]);
            }else{
                var audioobject2 = audioobjects2[0];
                audioobject2.GetComponent<AudioSource>().Play();
            }
        }
        //Debug.Log(time);
    }
}
