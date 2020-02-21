using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Text : MonoBehaviour
{
    public static float Num;
    [SerializeField] private GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        Num = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Num = Player_Move.Num;
        //Debug.Log(Num);
        Text uiText = GetComponent<Text>();
        uiText.text = Player_Move.Num + "";
    }
}
