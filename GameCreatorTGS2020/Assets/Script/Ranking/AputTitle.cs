using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AputTitle : MonoBehaviour
{
    private float time;
    public float go = 0;
    private bool TitleSwitch;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TitleSwitch = SceneManegers.GetTitleSwotch();
        time += Time.deltaTime;
        if (time > go)
        {
            if (TitleSwitch == true)
            {
                SceneManager.LoadScene("Title");
            }
            else
            {
                SceneManager.LoadScene("Maine");
            }
        }
    }
}
