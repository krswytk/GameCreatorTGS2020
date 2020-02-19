using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int START_UP;

    public Text scoreGUI;
    public Text highScoreGUI;

    private Text[] highScoreGUIs;
    private float score;
    private float[] highScore;
    private float tmp;


    // 初期化時の処理
    void Start()
    {
        score = GetScore.Score;

        START_UP = PlayerPrefs.GetInt("START_UP", 0);
        START_UP++;


        highScore = new float[START_UP];

        highScoreGUIs = new Text[START_UP];

        // キーを使って値を取得
        // キーがない場合は第二引数の値を取得
        for (int i = 0; i < START_UP; i++)
        {
            highScore[i] = PlayerPrefs.GetFloat("highScoreKey" + i, 0);
            highScoreGUIs[i] = Instantiate(highScoreGUI, new Vector3(-0.60f, -7.0f + -2.0f * i, 0.1f * i), Quaternion.identity);
            highScoreGUIs[i].rectTransform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
            highScoreGUIs[i].transform.parent = this.transform;

        }
        if (highScore[START_UP - 1] < score)
        {
            highScore[START_UP - 1] = score;
        }

    }
    // 削除時の処理
    void OnDestroy()
    {
        // メソッドが呼ばれたときのキーと値をセットする
        for (int i = 0; i < START_UP; i++)
        {
            PlayerPrefs.SetFloat("highScoreKey" + i, highScore[i]);
        }
        PlayerPrefs.SetInt("START_UP", START_UP);
        // キーと値を保存
        PlayerPrefs.Save();
    }

    // 更新
    void Update()
    {

        for (int i = 0; i < START_UP; ++i)
        {
            for (int j = i + 1; j < START_UP; ++j)
                if (highScore[i] < highScore[j])
                {
                    tmp = highScore[i];
                    highScore[i] = highScore[j];
                    highScore[j] = tmp;
                }
            highScoreGUIs[i].text = i + 1 + "位:" + highScore[i];
        }
    
    }

    public void Reset()
    {
        // キーを全て消す
        PlayerPrefs.DeleteAll();
    }
}