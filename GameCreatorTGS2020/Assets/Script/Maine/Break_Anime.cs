using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Anime : MonoBehaviour
{
    public Sprite Before;
    public Sprite After;

    SpriteRenderer MainSpriteRenderer;

    public bool Break_borad=false;
    public bool Sound_stop = false;
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
        //audioSource.time = 3.1f;

        int sound = Random.Range(0, 4);
        if (sound == 0) audioSource.clip = baki1;
        if (sound == 1) audioSource.clip = baki2;
        if (sound == 2) audioSource.clip = baki3;
        if (sound == 3) audioSource.clip = baki4;
        if (sound == 4) audioSource.clip = baki5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Break_borad==true)
        {
            if (sound == false)
            {
                MainSpriteRenderer.sprite = After;
                sound = true;
                if (Sound_stop == false) audioSource.Play();
            }
        }
    }
}
