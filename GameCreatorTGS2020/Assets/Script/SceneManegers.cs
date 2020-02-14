using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegers : MonoBehaviour
{
    static bool TitleSwitch = true;
    static int SceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        SceneNumber = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.KeypadEnter) || Input.GetMouseButton(0))
        {
            SceneNumber++;
            if(SceneNumber == 5)
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
    }

    static void SetTitleSwotch()
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

    public static bool GetTitleSwotch()
    {
        return TitleSwitch;
    }
}
