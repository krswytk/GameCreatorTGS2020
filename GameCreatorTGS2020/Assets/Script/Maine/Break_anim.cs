using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_anim : MonoBehaviour
{
    public Sprite Before;
    public Sprite After;

    SpriteRenderer MainSpriteRenderer;

    public bool Break_borad;
    public bool Sound_stop;
    bool sound_on;

    AudioSource audioSource;
    public AudioClip baki1;
    public AudioClip baki2;
    public AudioClip baki3;
    public AudioClip baki4;
    public AudioClip baki5;


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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sound_on == false)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (Player_Move.break_stop == false)
                {
                    //shake.Shake(1.25f, 2.1f);
                    MainSpriteRenderer.sprite = After;
                    sound_on = true;
                    if (Sound_stop == false) audioSource.Play();
                    Destroy(this.gameObject.GetComponent<PolygonCollider2D>());
                    //Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                    this.gameObject.AddComponent<PolygonCollider2D>();
                    this.gameObject.tag = "Break";
                    Player_Move.hit++;
                }
            }
        }
        else
        {

        }
    }
}
