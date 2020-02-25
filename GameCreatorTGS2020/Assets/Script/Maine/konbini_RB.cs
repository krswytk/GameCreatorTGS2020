using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class konbini_RB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player_rb")|| (col.gameObject.tag == "Player"))
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player_rb") || (collision.gameObject.tag == "Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
