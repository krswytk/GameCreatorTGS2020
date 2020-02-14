using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetScore : MonoBehaviour
{
    public static float Score;//スコアを格納している変数

    public SerialHandler serialHandler;
    public Text text;

    private float[] yuudati = new float[21];
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        //ポートが開くまで待つ
        while (!serialHandler.getIsRunning()) { }
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
        for(int lp = 0;lp < yuudati.Length; lp++)
        {
            yuudati[lp] = 0f;
        }

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Score);
        //Debug.Log(Score);
        //text.text =  Score.ToString();
    }
    void OnDataReceived(string message)
    {
        //Debug.Log(message);
        try
        {
            //Debug.Log(message);              //ここで最大値をスコアに埋め込んでいる
            /* if (Score < float.Parse(message))
             {
                 Score = float.Parse(message);
                 text.text = message; // シリアルの値をテキストに表示
             }*/
            for (int lp = yuudati.Length-1; lp >= 0; lp--)
            {
                if (lp == 0)
                {
                    yuudati[lp] = float.Parse(message);
                }
                else
                {
                    yuudati[lp] += yuudati[lp - 1];
                }
            }
            for (int lp = 0; lp < yuudati.Length; lp++)
            {
                if (lp == 0)
                {
                    Score = 0;
                }
                Score += yuudati[lp];
            }


        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }


}
