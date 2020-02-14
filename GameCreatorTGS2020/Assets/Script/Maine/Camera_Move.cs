using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Move : MonoBehaviour
{
    public static float Num;
    [SerializeField] private GameObject Score;
    Transform myTransform;

    GameObject Camera;
    float Move;

    // Start is called before the first frame update
    void Start()
    {
        Num = 0;

        //Camera = this.GetComponent<Transform>().position.y = Num;
        myTransform = this.transform;

    }

    // Update is called once per frame
    void Update()
    {
        Num = Score.GetComponent<ScoreBreakBord>().anim_Num;
        // 座標を取得
        Move = Num * -0.5f;

        Vector3 pos = myTransform.position;
        pos.y = Move;    // y座標へ0.01加算

        myTransform.position = pos;  // 座標を設定
        //Debug.Log(Num);
    }
}
