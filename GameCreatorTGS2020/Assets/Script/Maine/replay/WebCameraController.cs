using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WebCameraController : MonoBehaviour
{
    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;
    public int i = 0;

    public WebCamTexture webcamTexture;
    public Color32[] color32;

    public static bool off = false;

    string exsistFileName;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
    }


    void Update()
    {
        Debug.Log(off);
        if (off == false)
        {
            webcamTexture.Play();
            i++;
            color32 = webcamTexture.GetPixels32();
            Texture2D texture = new Texture2D(webcamTexture.width, webcamTexture.height);
            GetComponent<Renderer>().material.mainTexture = texture;
            texture.SetPixels32(color32);
            texture.Apply();
            var bytes = texture.EncodeToPNG();
            File.WriteAllBytes(Application.dataPath + "/output_images/camera" + i + ".png", bytes);
            if (i > 149)
                i = 0;
        }
        else
        {
            for (int lp = 1; lp < 151; lp++)
            {
                exsistFileName = "camera" + lp + ".png";
                var captureDirectory = Application.dataPath;
                var captureFileName = exsistFileName;
                var capturePath = Path.Combine(captureDirectory, captureFileName);
                if (File.Exists(capturePath)) File.Delete(capturePath);
                Debug.Log(exsistFileName);

            }
            webcamTexture = null;
            //webcamTexture.Pause();
            this.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.B))
        {
            webcamTexture.Pause();
            Debug.Log("Stop");
        }
    }
}

