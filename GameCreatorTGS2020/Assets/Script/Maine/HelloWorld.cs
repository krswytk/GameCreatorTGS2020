using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{

    public SerialHandler serialHandler;
    public Text text;

    private int val;
    // Use this for initialization
    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
        val = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * シリアルを受け取った時の処理
     */
    void OnDataReceived(string message)
    {
        try
        {
            if(val < int.Parse(message)){
                val = int.Parse(message);
                text.text = message; // シリアルの値をテキストに表示
            }
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }

}