﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSceneChange : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //エンターキーを押してスコア画面にシーン変異
        if (Input.GetKey(KeyCode.Return))
            FadeManager.Instance.LoadScene("Score", 2.0f);
    }
}
