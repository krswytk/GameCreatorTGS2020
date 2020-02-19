using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class My_Score : MonoBehaviour
{
    float ScoreNum;
    int n;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    private float time;
    int count;
    int highflag;
    int highscore = 0;
    void Start()
    {
        ScoreNum = 0;
        n = 0;
        audioSource = GetComponent<AudioSource>();
        count = 1140;
        highflag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        ScoreNum = GetScore.Score;
        //ScoreNum = ScoreNum + 1;

        n = Mathf.FloorToInt(ScoreNum);

        Text uiText = GetComponent<Text>();
        if (n > highscore)
        {
            if (highflag == 1)
            {
                audioSource.PlayOneShot(sound1);
                highscore = n;
                highflag = 0;
            }
            if (time > 4.0f)
            {

                uiText.text = "きみのスコアは:" + n;
                if (count >= 1140)
                {
                    audioSource.PlayOneShot(sound2);
                    count = 0;

                }
                else
                {
                    count++;
                }

            }
        }
        else
        {
            uiText.text = "きみのスコアは:" + n;
            if (count >= 1140)
            {
                audioSource.PlayOneShot(sound2);
                count = 0;

            }
            else
            {
                count++;
            }
        }
    }
}