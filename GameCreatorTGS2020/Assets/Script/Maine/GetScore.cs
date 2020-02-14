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
    private float[] copy = new float[21];
    private float sc;
    private float total;
    float time;

    public float noise = 3;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
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

        /*
        //Debug.Log(sc);
        for (int lp = 0; lp < yuudati.Length; lp++)
        {
            copy[lp] = yuudati[lp];
        }
        //Debug.Log("Score" + Score);
        //Debug.Log(Score);
        //text.text =  Score.ToString();

        ////////////////気圧のパワーを順番に21個０から格納
        for (int lp = 0; lp < yuudati.Length; lp++)
        {
            if (lp == 0)
            {
                yuudati[0] = sc;
                total = 0;
            }
            else
            {
                yuudati[lp] = copy[lp - 1];
            }

            //Debug.Log(yuudati[lp]);
            total = total + yuudati[lp];
        }

        //Debug.Log(total);
        ////////////         
        ///
        time++;
        ///////////ここからもし値が上昇（人が乗った）時の処理

        if (time > 100)
        {
            Debug.Log(yuudati[10] +"    "+ yuudati[10] +"  "+ yuudati[10]);
            if (yuudati[10]> yuudati[9] && yuudati[10]> yuudati[11])
            {
                //Debug.Log("Max");
                if (yuudati[10] - noise > yuudati[0] && yuudati[10] - noise > yuudati[20])
                {
                    Debug.Log("Max");
                    Score = total;
                }
            }

        }
        ///////////////  Maxの値が中央に来た場合にScoreを0からトータルスコアの値に変換する

//        Debug.Log("Score"+ Score +"  Total"+total);

        */
    }
    void OnDataReceived(string message)
    {
        //Debug.Log(message);
        try { 
        
            sc = float.Parse(message);


            //Debug.Log(sc);
            for (int lp = 0; lp < yuudati.Length; lp++)
            {
                copy[lp] = yuudati[lp];
            }
            //Debug.Log("Score" + Score);
            //Debug.Log(Score);
            //text.text =  Score.ToString();

            ////////////////気圧のパワーを順番に21個０から格納
            for (int lp = 0; lp < yuudati.Length; lp++)
            {
                if (lp == 0)
                {
                    yuudati[0] = sc;
                    total = 0;
                }
                else
                {
                    yuudati[lp] = copy[lp - 1];
                }

                //Debug.Log(yuudati[lp]);
                total = total + yuudati[lp];
            }

            //Debug.Log(total);
            ////////////         
            ///
            time++;
            ///////////ここからもし値が上昇（人が乗った）時の処理

            if (time > 100)
            {
                Debug.Log(yuudati[10] + "    " + yuudati[10] + "  " + yuudati[10]);
                if (yuudati[10] > yuudati[9] && yuudati[10] > yuudati[11])
                {
                    //Debug.Log("Max");
                    if (yuudati[10] - noise > yuudati[0] && yuudati[10] - noise > yuudati[20])
                    {
                        Debug.Log("Max");
                        Score = total;
                    }
                }

            }
            ///////////////  Maxの値が中央に来た場合にScoreを0からトータルスコアの値に変換する

            //        Debug.Log("Score"+ Score +"  Total"+total);
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }


}
