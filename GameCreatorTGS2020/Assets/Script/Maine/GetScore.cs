using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public static float Score;//スコアを格納している変数

    public SerialHandler serialHandler;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;

    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log(Score);
        //text.text =  Score.ToString();
    }
    void OnDataReceived(string message)
    {
        try
        {
            if (Score < float.Parse(message))
            {
                Score = float.Parse(message);
                text.text = message; // シリアルの値をテキストに表示
            }
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }


}
