using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_rb : MonoBehaviour
{

    Transform myTransform;
    Vector3 pos;
    Vector3 playerAngle;
    Vector3 rd_Angle;

    GameObject player;
    float rd_z;

    float rotate_def;

    public static bool off;


    // Start is called before the first frame update
    void Start()
    {
        off = false;

        myTransform = this.transform;
        pos = myTransform.position;

        player = GameObject.FindGameObjectWithTag("Player");
        playerAngle = player.transform.localEulerAngles;

        rd_Angle = myTransform.localEulerAngles;

        rotate_def = playerAngle.z;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = Player_Move.pos;  // 座標を設定
        rd_Angle.z = playerAngle.z- rotate_def;
        myTransform.localEulerAngles = rd_Angle;

        if (off == true)
        {
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            //this.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "konbini_RB")
        {
            Destroy(collision.gameObject);
        }
    }
}
