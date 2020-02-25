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

    [SerializeField]
    private GameObject damagePrefab;
    [SerializeField]
    private TimeManager timeManager;
    public ShakeableTransform m_shakeable;

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
        if ((collision.gameObject.tag == "Player_rb") && (Player_Move.time > 2))
        {
            Debug.Log("114514");
            Player_rb.off = true;
        }

        if (sound_on == false)
        {
            if (collision.tag == "Player")
            {
                if (Player_Move.break_stop == false)
                {
                    var damageParticle = GameObject.Instantiate(damagePrefab, collision.transform.position, Quaternion.identity) as GameObject;
                    m_shakeable.InduceStress(1);
                    //　全体のタイムスケールを変更する
                    timeManager.SlowDown();

                    //shake.Shake(1.25f, 2.1f);
                    MainSpriteRenderer.sprite = After;
                    sound_on = true;
                    if (Sound_stop == false) audioSource.Play();
                    Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                    //Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                    this.gameObject.AddComponent<PolygonCollider2D>();
                    this.gameObject.tag = "Break";
                    Player_Move.hit++;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player_rb") && (Player_Move.time != 0))
        {
            //Debug.Log("114514");
           // Player_rb.off = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if ((col.gameObject.tag == "Player_rb") && (Player_Move.time != 0))
        {
            //Debug.Log("114514");
            //Player_rb.off = true;
        }
    }
}
