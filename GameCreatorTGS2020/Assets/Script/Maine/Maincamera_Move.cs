using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera_Move : MonoBehaviour
{

    Transform myTransform;
    Vector3 pos;
    float pos_num;
    float pos_x;
    float pos_y;
    float pos_z;

    float pos_y_num;
    float pos_y_def;

    // Start is called before the first frame update
    void Start()
    {
        pos_y_num = 0;
        pos_y_def = 0;


        myTransform = this.transform;
        Vector3 pos = myTransform.position;
        pos = myTransform.position;
        pos_y = pos.y;

        pos_x = pos.x;
        pos_z = pos.z;

        pos_y_def = Player_Move.Player_pos;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player_Move.pos.y);
        //Debug.Log(pos_y_def);

        //pos.y = Player_Move.Speed;
        //myTransform.position = pos;
        if (pos_y_def == 0)
            pos_y_def = Player_Move.Player_pos;

        pos_y_num = pos_y + Player_Move.Player_pos - pos_y_def;
        //pos.z = 0;
        pos.y = pos_y_num;
        pos.z = pos_z;
        pos.x = pos_x;
        //Debug.Log(this.transform.position.z);
        myTransform.position = pos;  // 座標を設定
    }
}
