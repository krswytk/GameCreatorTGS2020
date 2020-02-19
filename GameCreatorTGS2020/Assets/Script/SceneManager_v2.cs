using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_v2 : MonoBehaviour
{
    static private bool TitleSwitch = false;
    static public int SceneNumber;
    static private float time;
    public float outtime;
    private static float scanTime;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //////////////////////////////////////////////////////ここからボタンを使用したシーン移動についてのスクリプト
        ///エンターもしくはマウス左クリックで次のシーンに移動
        ///スペースでランキング後の移動シーンの変更　デフォルトはタイトル
        ///左シフトでタイトルもしくはメインへの強制移動　移動先は上記記述を参照
        ///
        scanTime += Time.deltaTime;

        if (SceneManager.GetActiveScene().name == "Title" || SceneManager.GetActiveScene().name == "Demo" || SceneManager.GetActiveScene().name == "Ranking")
        {
            time += Time.deltaTime;
        }
        //Debug.Log(time);

        if (Input.GetKey(KeyCode.KeypadEnter) || Input.GetMouseButton(0))
        {
            if (scanTime < 3.0f)
            {
                return;
            }
            else
            {
                scanTime = 0;
            }
            SceneNumber++;


            if (SceneManager.GetActiveScene().name == "Demo")
            {
              
                FadeManager.Instance.LoadScene("Maine", 2.0f);

            }
            if (SceneManager.GetActiveScene().name == "Ranking")
            {
                
                FadeManager.Instance.LoadScene("Maine", 2.0f);

            }
            if (SceneManager.GetActiveScene().name == "Maine")
            {
                FadeManager.Instance.LoadScene("Score", 2.0f);

            }
            if (SceneManager.GetActiveScene().name == "Score")
            {
                FadeManager.Instance.LoadScene("Replay", 2.0f);
            }
            if (SceneManager.GetActiveScene().name == "Replay")
            {

                if (TitleSwitch == true)
                {
                  
                    FadeManager.Instance.LoadScene("Title", 2.0f);
                }
                else
                {
                  
                    FadeManager.Instance.LoadScene("Maine", 2.0f);
                }
                //SceneManager.LoadScene(SceneNumber);
            }

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            SetTitleSwotch();
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {

            if (TitleSwitch == true)
            {
        
                FadeManager.Instance.LoadScene("Title", 2.0f);
            }
            else
            {
          
                FadeManager.Instance.LoadScene("Maine", 2.0f);
            }

            //SceneManager.LoadScene(SceneNumber);
        }
        //////////////////////////////////////////////////////////////////////////ここまでキーマウスによるシーン移動
        ///ここより各位ｓｃｒｉｐｔの時間経過による移動記述

        if (SceneManager.GetActiveScene().name == "Title")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }//////////////ゲーム終了
            if (time > outtime)
            {
                time = 0;
                //SceneManager.LoadScene(1);
              
                FadeManager.Instance.LoadScene("Demo", 2.0f);
            }
        }


        if (SceneManager.GetActiveScene().name == "Demo")
        {
            if (time > outtime)
            {
                time = 0;
                //SceneManager.LoadScene(0);
                
                FadeManager.Instance.LoadScene("Ranking", 2.0f);
            }
        }

        if (SceneManager.GetActiveScene().name == "Ranking")
        {
        
            if (time > outtime)
            {
                time = 0;
                //SceneManager.LoadScene(0);
            
                FadeManager.Instance.LoadScene("Title", 2.0f);
            }
        }
        //////////////////////////////////////////ここまで時間経過によるタイトルとデモの移動
    }

    static void SetTitleSwotch()//////////////タイトルとメインへの切り替えボタン関数
    {
        if (TitleSwitch == false)
        {
            TitleSwitch = true;
        }
        else
        {
            TitleSwitch = false;
        }
    }

    public static bool GetTitleSwotch()//////現在のタイトルメインへの切り替えを返す関数trueでタイトル
    {
        return TitleSwitch;
    }
}