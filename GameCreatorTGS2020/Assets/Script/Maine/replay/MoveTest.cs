using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public int i ;
    //public int lp = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        if (WebCameraController1.webcamTexture.isPlaying == false) WebCameraController1.webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (WebCameraController1.webcamTexture.isPlaying == true) WebCameraController1.webcamTexture.Stop();

        if (i > WebCameraController1.lp)
            i = 0;
        //Debug.Log(i);
        i++;
        // "enemy_0" 〜 "enemy_8" の文字列をランダムで生成
        string name = "camera" + i;
            // Spriteを取得
            Sprite sp = GetSprite("output_images", name);
            // SpriteRendererを取得する
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            // Spriteを変更する
            sr.sprite = sp;
    }
    // スプライトの取得
    // @param fileName ファイル名
    // @param spriteName スプライト名
    public Sprite GetSprite(string fileName, string spriteName)
    {
        //Debug.Log("ONGetSprite");
        //Debug.Log(fileName);
        //Debug.Log(spriteName);
        Sprite[] sprites = Resources.LoadAll<Sprite>(fileName);
        return System.Array.Find<Sprite>(sprites, (sprite) => sprite.name.Equals(spriteName));
    }
}
