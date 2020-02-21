using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Profiling;

public class WebCameraController1 : MonoBehaviour
{
    public int Width;
    public int Height;
    public int FPS;
    public int i;
    public static int lp;

    public static WebCamTexture webcamTexture;
    public Color32[] color32;

    public float span = 1f;
    private float currentTime = 0f;

    Texture2D texture;
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        // GetComponent<Renderer>().material.mainTexture = webcamTexture;
        if (webcamTexture.isPlaying == false) webcamTexture.Play();

        texture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24, true);

    }


    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > span)
        {
            Debug.LogFormat("{0}秒経過", span);
            currentTime = 0f;


            if (webcamTexture.isPlaying == false) webcamTexture.Play();



            color32 = webcamTexture.GetPixels32();


            //GetComponent<Renderer>().material.mainTexture = texture;


            texture.SetPixels32(color32);
            texture.Apply();

            var bytes = texture.EncodeToPNG();


            //Destroy(texture);

            File.WriteAllBytes(Application.dataPath + "/Resources/output_images/camera" + i + ".png", bytes);
            lp = i;
            i++;
            if (i == 150)
                i = 0;
        }
    }

}