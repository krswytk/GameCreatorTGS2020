using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegers : MonoBehaviour
{
    static private bool TitleSwitch = true;
    static private int SceneNumber;
    static private float time;
    public float outtime  = 10;
    // Start is called before the first frame update
    void Start()
    {
        SceneNumber = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
//////////////////////////////////////////////////////ここからボタンを使用したシーン移動についてのスクリプト
///エンターもしくはマウス左クリックで次のシーンに移動
///スペースでランキング後の移動シーンの変更　デフォルトはタイトル
///左シフトでタイトルもしくはメインへの強制移動　移動先は上記記述を参照
        if(Input.GetKey(KeyCode.KeypadEnter) || Input.GetMouseButton(0))
        {
            SceneNumber++;
            if(SceneNumber == 6)
            {
                if(TitleSwitch == true)
                {
                    SceneNumber = 0;
                }
                else
                {
                    SceneNumber = 2;
                }
            }
            SceneManager.LoadScene(SceneNumber);
        }else if (Input.GetKey(KeyCode.Space))
        {
            SetTitleSwotch();
        }else if (Input.GetKey(KeyCode.LeftShift))
        {
            if (TitleSwitch == true)
            {
                SceneNumber = 0;
            }
            else
            {
                SceneNumber = 2;
            }

            SceneManager.LoadScene(SceneNumber);
        }
        //////////////////////////////////////////////////////////////////////////ここまでキーマウスによるシーン移動
        ///ここより各位ｓｃｒｉｐｔの時間経過による移動記述
        time = Time.deltaTime;
        if(SceneNumber == 0)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }//////////////ゲーム終了
            if (time > outtime)
            {
                time = 0;
                SceneManager.LoadScene(1);
            }
        }


        if (SceneNumber == 1)
        {
            if (time > outtime)
            {
                time = 0;
                SceneManager.LoadScene(0);
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
