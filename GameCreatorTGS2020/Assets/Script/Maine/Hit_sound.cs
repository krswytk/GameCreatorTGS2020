using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_sound : MonoBehaviour
{
    public Sprite After;
    public Sprite After2;
    public Sprite After3;
    public Sprite After4;
    public Sprite After5;

    SpriteRenderer MainSpriteRenderer;

    public bool Break_borad;
    public bool Sound_stop;
    bool sound_on;

    AudioSource audioSource;
    public AudioClip Bin;
    public AudioClip Chair;
    public AudioClip Paper;
    public AudioClip Shed;
    public AudioClip sofa_bed;
    public AudioClip TV;
    public AudioClip book;
    public AudioClip Magic;


    CameraShake shake;



    // Start is called before the first frame update
    void Start()
    {
        Break_borad = false;
        Sound_stop = false;
        sound_on = false;





        MainSpriteRenderer = this.GetComponent<SpriteRenderer>();

        shake = this.GetComponent<CameraShake>();

        audioSource = this.gameObject.GetComponent<AudioSource>();
        //audioSource.time = 3.1f;

        if (this.gameObject.tag == "Bin") audioSource.clip = Bin;
        if (this.gameObject.tag == "Chair") audioSource.clip = Chair;
        if (this.gameObject.tag == "paper") audioSource.clip = Paper;
        if (this.gameObject.tag == "Shed") audioSource.clip = Shed;
        if (this.gameObject.tag == "sofa_bed") audioSource.clip = sofa_bed;
        if (this.gameObject.tag == "TV") audioSource.clip = TV;
        if (this.gameObject.tag == "book") audioSource.clip = book;
        if (this.gameObject.tag == "Magic") audioSource.clip = Magic;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player_rb")
        {
            sound_on = true;
            MainSpriteRenderer.sprite = After;
            audioSource.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player_rb")
        {
            sound_on = true;
            MainSpriteRenderer.sprite = After;
            audioSource.Play();
        }
    }
}
