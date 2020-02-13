using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Anime : MonoBehaviour
{
    public Sprite Before;
    public Sprite After;

    SpriteRenderer MainSpriteRenderer;

    public bool Break_borad=false;



    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Break_borad==true)
        {
            MainSpriteRenderer.sprite = After;
        }
    }
}
