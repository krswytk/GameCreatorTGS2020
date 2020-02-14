using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSwitchingClic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(time);
        if (Input.GetMouseButton(0))
        {
            FadeManager.Instance.LoadScene("Title", 2.0f);
        }
    }
}
