using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMaine : MonoBehaviour
{
    private GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Arudino_Manager");
        gm.GetComponent<GetScore>().Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
