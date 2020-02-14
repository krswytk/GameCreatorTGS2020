using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveReplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            FadeManager.Instance.LoadScene("Replay", 2.0f);
        }
        if (Input.GetMouseButton(0))
        {
            FadeManager.Instance.LoadScene("Replay", 2.0f);
        }
    }
}
