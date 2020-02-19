using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debugscript : MonoBehaviour
{
    public GameObject score_object = null;
   // public int score_num = 0;
  private float sc=GetScore.sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Score:"+sc;
      //  score_num += 1;
    }
}
