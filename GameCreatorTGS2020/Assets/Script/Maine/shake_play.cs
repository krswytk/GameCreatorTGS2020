using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake_play : MonoBehaviour
{
    public static float Num;
    [SerializeField] private GameObject Score;
    CameraShake shake;
    float Move;


    // Start is called before the first frame update
    void Start()
    {
        Num = 0;
        shake = this.GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        Num = Score.GetComponent<ScoreBreakBord>().anim_Num;
        if (Move == (Num * -0.5f))
        {
            //shake.Shake(1.25f, move);
        }
        else
        {
            shake.Shake(1.25f, 0.25f);
        }

        Move = Num * -0.5f;
    }
}
