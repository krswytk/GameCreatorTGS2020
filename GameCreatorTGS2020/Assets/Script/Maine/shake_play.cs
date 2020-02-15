using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake_play : MonoBehaviour
{
    public static float Num;
    [SerializeField] private GameObject Score;
    CameraShake shake;
    float Move;
    float Break;


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
        if (((Num-2) != Break)&&(Num!=0))
        {
            shake.Shake(0.25f, 1.1f);
            Break = Num - 2;
        }
    }
}
