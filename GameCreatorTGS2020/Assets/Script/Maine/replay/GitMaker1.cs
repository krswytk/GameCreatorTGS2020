using UnityEngine;
using System.IO;
using System.Collections;
using UnityEngine.UI;

public class GitMaker1 : MonoBehaviour
{
    public Image img;
    public string folderName;
    public string headText;
    public int _imageLength;
    public bool IsFirstNum1;
    public bool EnableSkipFirst;
    private bool Flg;
    private int firstFrameNum;
    private int _firstFrameNum;
    public int i = 0;
    RawImage rawImage;
    //public int lp = 0;
    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();
       // if (WebCameraController1.webcamTexture.isPlaying == false) WebCameraController1.webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
       // if (WebCameraController1.webcamTexture.isPlaying == true) WebCameraController1.webcamTexture.Stop();

        if (i > WebCameraController1.lp)
            i = 0;
        byte[] bytes = File.ReadAllBytes("Assets/Resources/output_images/camera" + i + ".png");
        Texture2D texture = new Texture2D(100, 100);
        texture.filterMode = FilterMode.Trilinear;
        texture.LoadImage(bytes);

        rawImage.texture = texture;
        rawImage.SetNativeSize();
        //Debug.Log(i);
        i++;

    }
    private void OnDestroy()
    {

        for (int j = 0; j < 10; j++)
        {
            File.Delete(Application.dataPath + "/Resources/output_images/camera"+j+".png");
        }
    }
}
