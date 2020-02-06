using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSwhic : MonoBehaviour
{
    static bool TitleSwitch = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKey(KeyCode.O))
        {
            SetTitleSwotch();
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
