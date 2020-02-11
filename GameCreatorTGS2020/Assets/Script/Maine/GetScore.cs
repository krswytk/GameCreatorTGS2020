using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public static float Score;//スコアを格納している変数
    public Text tex;//
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Score = Random.value * 100;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            Score += 1.0f;
            Debug.Log(Score);
        }*/
        tex.text =  Score.ToString();
    }


}
