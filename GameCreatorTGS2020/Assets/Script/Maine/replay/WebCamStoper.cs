using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamStoper : MonoBehaviour
{
    bool wcon=true;
    void Start()
    {
        //Debug.Log(WebCameraController1.webcamTexture.isPlaying);
        if (WebCameraController1.webcamTexture.isPlaying == false&& wcon == true) WebCameraController1.webcamTexture.Play();
        //Debug.Log(WebCameraController1.webcamTexture.isPlaying);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WebCameraController1.webcamTexture.isPlaying);
        if (WebCameraController1.webcamTexture.isPlaying == true) WebCameraController1.webcamTexture.Stop();
        Debug.Log(WebCameraController1.webcamTexture.isPlaying);
        wcon = false;

    }
}
