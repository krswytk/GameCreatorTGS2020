using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPlayerset : MonoBehaviour
{
    public GameObject[] player;
    float time;
    public float Ctime = 0.3f;
    private int no;
    // Start is called before the first frame update
    void Start()
    {
        no = 0;
        time = 0;
        for (int lp = 0; lp < player.Length; lp++)
        {
            player[lp].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > Ctime)
        {
            switch(no){
                case 0: player[0].SetActive(true);
                    player[2].SetActive(false);
                    no++;
                    break;
                case 1: player[1].SetActive(true);
                    player[0].SetActive(false);
                    no++;
                    break;
                case 2: player[2].SetActive(true);
                    player[1].SetActive(false);
                    no = 0;
                    break;
            }

            time = 0;
        }


    }
}
