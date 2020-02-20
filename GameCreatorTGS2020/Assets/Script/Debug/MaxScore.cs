using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    Text score_text;
    private float Score;
    // Start is called before the first frame update
    void Start()
    {
        score_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score = GetScore.Score;
        score_text.text = "Score:" + Score;
        //  score_num += 1;
    }
}
