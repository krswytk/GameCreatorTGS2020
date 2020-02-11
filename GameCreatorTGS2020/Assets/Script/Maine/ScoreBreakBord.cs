using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBreakBord : MonoBehaviour
{

    private GameObject[] Bords;
    private int Number;
    private float Score;

    private Animator[] animator;
    // Start is called before the first frame update
    void Start()
    {
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

        for(int lp = 0;lp < Number; lp++)
        {
            if(lp < Score-1)
            {
                animator[lp] = Bords[lp].GetComponent<Animator>();
                animator[lp].SetBool("Break",true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Bords[0].SetActive(false);
        }


        Bords[0] = this.GetComponent<InstantiateBord>().GetBords()[0];
        Debug.Log(Bords[0]);

    }
}
