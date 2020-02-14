using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Anime : MonoBehaviour
{
    public Sprite Before;
    public Sprite After;

    SpriteRenderer MainSpriteRenderer;

    public bool Break_borad=false;
    bool sound = false;

    AudioSource audioSource;
    public AudioClip baki1;
    public AudioClip baki2;
    public AudioClip baki3;
    public AudioClip baki4;
    public AudioClip baki5;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = this.GetComponent<SpriteRenderer>();

        audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.clip = baki1;
        //audioSource.time = 3.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Break_borad==true)
        {
            if (sound == false)
            {
                MainSpriteRenderer.sprite = After;
                audioSource.Play();
                sound = true;
            }
        }
    }
}
