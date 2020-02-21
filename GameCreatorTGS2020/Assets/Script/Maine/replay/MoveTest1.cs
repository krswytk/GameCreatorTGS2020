using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MoveTest1 : MonoBehaviour
{
    public int i = 0;
    //public int lp = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
            
        //if (i > WebCameraController.lp)
        //    i = 0;
        //Debug.Log(i);
        // "enemy_0" 〜 "enemy_8" の文字列をランダムで生成
        string name = "camera" + i;
        // Spriteを取得
        //Sprite sp = GetSprite("output_images", name);
        // SpriteRendererを取得する
        //if(sp!=null)
        //DestroyImmediate(GetSprite("output_images", name), true);
        //Destroy(GetSprite("output_images", name));
        File.Delete(Application.dataPath + "/Resources/output_images/camera" + i + ".png");
        i++;
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
