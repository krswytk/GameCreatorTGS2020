using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_v2 : MonoBehaviour
{
    static public bool TitleSwitch;
    static public int SceneNumber;
    private float time;
    public float outtime = 10.0f;
    private  float scanTime;
    private bool DebagMode = false;

    public static bool PlayerMove;
    // Start is called before the first frame update
    void Start()
    {
        scanTime = 0;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(DebagMode);
        //////////////////////////////////////////////////////ここからボタンを使用したシーン移動についてのスクリプト
        ///エンターもしくはマウス左クリックで次のシーンに移動
        ///スペースでランキング後の移動シーンの変更　デフォルトはタイトル
        ///左シフトでタイトルもしくはメインへの強制移動　移動先は上記記述を参照
        ///
        scanTime += Time.deltaTime;
        PlayerMove = Player_Move.feed_out;


        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (scanTime > 1.0f)
            {
                if (DebagMode == false)
                {
                    DebagMode = true;
                    Application.LoadLevelAdditive("Debag");
                }
                else if(DebagMode == true)
                {
                    DebagMode = false;
                    Application.UnloadLevel("Debag");
                }
                scanTime = 0;
            }
        }

        */
        if (SceneManager.GetActiveScene().name == "Title" || SceneManager.GetActiveScene().name == "Demo" || SceneManager.GetActiveScene().name == "Ranking")
        {
            if (DebagMode == false)
            {
                
                time += Time.deltaTime;
            }
        }
        //Debug.Log(time);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (scanTime > 1.0f)
            {
                //SceneNumber++;

                if (SceneManager.GetActiveScene().name == "Title")
                {

                    GetScore.Score = 0;
                    FadeManager.Instance.LoadScene("Maine", 2.0f);

                }
                if (SceneManager.GetActiveScene().name == "Demo")
                {

                    GetScore.Score = 0;
                    FadeManager.Instance.LoadScene("Maine", 2.0f);

                }
                if (SceneManager.GetActiveScene().name == "Ranking")
                {

                    GetScore.Score = 0;
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

                        GetScore.Score = 0;
                        FadeManager.Instance.LoadScene("Maine", 2.0f);
                    }
                    //SceneManager.LoadScene(SceneNumber);
                }

                scanTime = 0;

            }

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            SetTitleSwotch();
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            if (TitleSwitch == true)
            {
        
                FadeManager.Instance.LoadScene("Title", 2.0f);
            }
            else
            {

                GetScore.Score = 0;
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


        
        if (PlayerMove == true)
        {
            Player_Move.feed_out = false;
            PlayerMove = false;
            //Debug.Log("シーンマネＶＥＲ２で移動" +"史ね" );
            FadeManager.Instance.LoadScene("Score", 2.0f);
            
        }
        /*if(GetScore.Score > 0)
        {
            GetScore.Score = -GetScore.Score;
            Debug.Log("シーンマネＶＥＲ２で移動" + "史ね");
            FadeManager.Instance.LoadScene("Score", 2.0f);
        }*/

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