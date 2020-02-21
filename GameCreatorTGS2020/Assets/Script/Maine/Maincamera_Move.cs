using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera_Move : MonoBehaviour
{
    private Transform CameraTransform;
    private float posy_num;
    Vector3 pos;
    private float playerY;

    private bool ch;
    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = this.transform;
        pos = CameraTransform.localPosition;
        
        //Debug.Log(Player_Move.Player_pos + pos.y + posy_num);

        ch = true;
        posy_num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //pos = CameraTransform.localPosition;
        playerY = Player_Move.Player_pos;
        if (ch == true && Player_Move.Player_pos != 0)
        {
            //Debug.Log(Player_Move.Player_pos);
            //Debug.Log(pos.y);
            posy_num = playerY - pos.y;
            ch = false;
        }

        if (ch == false)
        {
            Debug.Log(Player_Move.Player_pos + " --- " + pos.y + " --- " + posy_num + " --- " + playerY);

            pos.y = playerY - posy_num;

            CameraTransform.position = pos;
        }

    }
}
