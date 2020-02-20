using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCText : MonoBehaviour
{
    private Text text;
    private float sc;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        sc = GetScore.sc;
        text.text = sc.ToString();
    }
}
