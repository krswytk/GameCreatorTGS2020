using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCameraTest2 : MonoBehaviour
{
    public RawImage rawImage;
    public GameObject Image;

    WebCamTexture webCamTexture;
    bool on = false;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        rawImage.texture = webCamTexture;
    }

    void Update()
    {
        if (on == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Image.SetActive(true);
                webCamTexture.Play();
                on = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("aaa");
                Image.SetActive(false);
                on = false;
            }
        }
    }
}
