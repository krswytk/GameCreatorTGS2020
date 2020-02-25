using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetScore : MonoBehaviour
{
    public static float Score;//スコアを格納している変数

    public SerialHandler serialHandler;


    private float[] yuudati = new float[21];
    private float[] copy = new float[21];
    public static float sc;
    private float total;
    int time;
    private float Max;
    private float ave;
    public static bool ScoreSwitch;

    private bool AVSwitch;

    


    public float noise = 3;
    // Start is called before the first frame update
    public void Start()
    {
        sc = 0;
        total = 0;
        time = 0;
        Max = 0;
        ave = 0;
        ScoreSwitch = false;
        AVSwitch = false;
        
        serialHandler.OnDataReceived += OnDataReceived;

        for(int lp = 0;lp < yuudati.Length; lp++)
        {
            yuudati[lp] = 0f;
            copy[lp] = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 1000) { time++; }
        ///////////////////////////////////////空気圧の平均を算出しておく処理
        ///
        if (AVSwitch == false)
        {
            if (sc != 0)
            {
                ScoreSwitch = false;
                ave = sc;
                AVSwitch = true;
            }
        }





        for (int lp = 0; lp < yuudati.Length; lp++)
        {
            copy[lp] = yuudati[lp];//copyに夕立を複製
        }

        yuudati[0] = sc;//夕立1番に最新の値を代入

        for(int lp = 1;lp<yuudati.Length; lp++)
        {
            yuudati[lp] = copy[lp - 1];//夕立一番以外を更新
        }
        //Debug.Log(yuudati[0]);
        if (time > 100)
        {
            Debug.Log("タイムフェーズ突破");
            if (yuudati[10] > yuudati[0] && yuudati[10] > yuudati[20])
            {
                Debug.Log("フェーズ1突破");
                if (yuudati[10] > yuudati[5] && yuudati[10] > yuudati[15])
                {
                    Debug.Log("フェーズ2突破");
                    if (yuudati[10] >= yuudati[9] && yuudati[10] >= yuudati[11])
                    {
                        Debug.Log("フェーズ3突破");
                        if (ave + noise < yuudati[11])
                        {
                            Debug.Log("最終フェーズ突破   " + ScoreSwitch);
                            if (ScoreSwitch == false)
                            {
                                Debug.Log("スコアに値を代入");
                                for (int lp = 0; lp < yuudati.Length; lp++)
                                {
                                    total += yuudati[lp];
                                }
                                Score = total;
                                ScoreSwitch = true;
                            }
                        }
                    }
                }
            }
        }
        //Debug.Log(sc + "  "+ time);
        //Debug.Log(Score + "   " + yuudati[9] + "  " + yuudati[10] + "  " + yuudati[11]);
        //Debug.Log(yuudati[0] + "  " + yuudati[1] + "  " + yuudati[2] + "  " + yuudati[3] + "  " + yuudati[4] + "  " + yuudati[5] + "  " + yuudati[6] + "  " + yuudati[7] + "  " + yuudati[8] + "  " + yuudati[9] + "  " + yuudati[10] + "  " + yuudati[11] + "  " + yuudati[12] + "  " + yuudati[13] + "  " + yuudati[14] + "  " + yuudati[15] + "  " + yuudati[16] + "  " + yuudati[17] + "  " + yuudati[18] + "  " + yuudati[19] + "  " + yuudati[20] + "  " );

        Debug.Log(Score);

    }


    void OnDataReceived(string message)
    {
        //Debug.Log(message);
        try { 
        
            sc = float.Parse(message);
            //Debug.Log(" SC = " + sc);



        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }


}
