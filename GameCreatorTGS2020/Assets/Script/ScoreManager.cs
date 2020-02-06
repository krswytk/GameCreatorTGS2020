using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private const int NUM_MAX = 3;

    public Text scoreGUI;
    public Text[] highscoreGUI = new Text[NUM_MAX];


    private int score;
    private int[] highScore = new int[NUM_MAX];
    private int tmp;
    


    // 初期化時の処理
    void Start()
    {
        score = 900;
       
        // キーを使って値を取得
        // キーがない場合は第二引数の値を取得
        for (int i = 0; i < NUM_MAX; i++)
        {
            highScore[i] = PlayerPrefs.GetInt("highScoreKey" + i, 0);
    
        }
        if (highScore[NUM_MAX - 1] < score)
        {
            highScore[NUM_MAX - 1] = score;
        }
    }
    // 削除時の処理
    void OnDestroy()
    {
        // メソッドが呼ばれたときのキーと値をセットする
        for (int i = 0; i < NUM_MAX; i++)
        {
            PlayerPrefs.SetInt("highScoreKey" + i, highScore[i]);
        }
        // キーと値を保存
        PlayerPrefs.Save();
    }

    // 更新
    void Update()
    {

        
       
        for(int i = 0;i < NUM_MAX; ++i)
        {
            for (int j = i + 1; j < NUM_MAX; ++j)
                if (highScore[i] < highScore[j]){
                tmp = highScore[i];
                highScore[i] = highScore[j];
                highScore[j] = tmp;
            }
            highscoreGUI[i].text = "" + highScore[i];
        }

        scoreGUI.text = "" + score;
        
        
     
    }

    public void Reset()
    {
        // キーを全て消す
        PlayerPrefs.DeleteAll();
    }
}