using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class add_Num : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Space))
        {
            n++;
        }

        Text uiText = GetComponent<Text>();
        uiText.text = "Score:" + n;
    }
}