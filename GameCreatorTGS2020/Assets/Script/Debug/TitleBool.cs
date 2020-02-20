using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleBool : MonoBehaviour
{
    Text titlebool_text;
    private bool titlebool;
    // Start is called before the first frame update
    void Start()
    {
        titlebool_text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        titlebool = SceneManager_v2.TitleSwitch;
        if (titlebool == false)
        {
            titlebool_text.text = "メインに飛びます";
        }else{
            titlebool_text.text = "タイトルに飛びます";
        }
        
    }
}
