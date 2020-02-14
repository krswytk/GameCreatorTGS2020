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
    void Start()
    {
        ScoreNum = 0;
        n = 0;
        audioSource = GetComponent<AudioSource>();
        count = 1140;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        ScoreNum = GetScore.Score;
        //ScoreNum = ScoreNum + 1;

        n = Mathf.FloorToInt(ScoreNum);

        Text uiText = GetComponent<Text>();
        if (n > 1000)
        {
            uiText.text = "ハイスコア！";
            audioSource.PlayOneShot(sound1);
            if (time > 4.0f)
            {
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