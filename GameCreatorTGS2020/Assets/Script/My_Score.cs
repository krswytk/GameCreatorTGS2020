using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class My_Score : MonoBehaviour
{
    float ScoreNum;
    int n;

    void Start()
    {
        ScoreNum = 0;
        n = 0;
    }

    // Update is called once per frame
    void Update()
    {

        ScoreNum = GetScore.Score;
        //ScoreNum = ScoreNum + 1;

        n = Mathf.FloorToInt(ScoreNum);

        Text uiText = GetComponent<Text>();
        uiText.text = "Score:"+n;
    }
}