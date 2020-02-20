using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debugscript : MonoBehaviour
{
    Text score_text;
    private float sc;
    // Start is called before the first frame update
    void Start()
    {
        score_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        sc = GetScore.sc;
        score_text.text = "現在の気圧値:"+sc;
      //  score_num += 1;
    }
}
