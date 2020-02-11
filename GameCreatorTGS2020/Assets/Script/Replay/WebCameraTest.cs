using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCameraTest : MonoBehaviour
{
    public RawImage rawImage;
    public GameObject Image;


    public WebCamTexture webCamTexture;
    public Texture replay;
    bool on = false;

    void Start()
    {
        webCamTexture = new WebCamTexture();
    }

    void Update()
    {
        /*
        foreach (GameObject i in webCamTexture)
        {
            Debug.Log(i.name);
        }*/

        if (Input.GetKey(KeyCode.A))
        {
            replay = webCamTexture;
            rawImage.texture = replay;
        }

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
