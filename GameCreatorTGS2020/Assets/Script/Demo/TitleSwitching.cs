using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSwitching : MonoBehaviour
{
    private float time;
    public float go = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(time);
        time += Time.deltaTime;
        if (time > go)
        {
            FadeManager.Instance.LoadScene("Title", 2.0f);
        }
    }
}
