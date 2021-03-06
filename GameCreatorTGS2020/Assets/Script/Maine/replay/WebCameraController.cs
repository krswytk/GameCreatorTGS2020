﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WebCameraController : MonoBehaviour
{
    public int Width = 800;
    public int Height = 500;
    public int FPS = 30;
    public int i ;
    public static int lp;

    public static WebCamTexture webcamTexture;
    public Color32[] color32;
    Texture2D texture;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        //GetComponent<Renderer>().material.mainTexture = webcamTexture;
        if (webcamTexture.isPlaying == false) webcamTexture.Play();
        texture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24, true);

    }


    void Update()
    {
        if (webcamTexture.isPlaying == false) webcamTexture.Play();
        
        color32 = webcamTexture.GetPixels32();


        //Texture2D texture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24,true);
        //GetComponent<Renderer>().material.mainTexture = texture;


        texture.SetPixels32(color32);
        texture.Apply();
        //texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0,false);
       // var bytes = texture.EncodeToPNG();
        //Destroy(texture);
        File.WriteAllBytes(Application.dataPath + "/Resources/output_images/camera" + i + ".png", texture.EncodeToPNG());
        lp = i;
        i++;
        if (i == 150)
            i = 0;

       
    }
    
}

