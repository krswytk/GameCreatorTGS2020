using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBord : MonoBehaviour
{
    public GameObject Bord;
    private GameObject[] Bords;
    public int Number = 100;
    // Start is called before the first frame update
    void Start()
    {
        Bords = new GameObject[Number];

        for (int lp = 0; lp < Number; lp++)
        {
           Bords[lp] = Instantiate(Bord, new Vector3(-0.63f, -10.5f * lp, 0.1f*lp), Quaternion.identity);
            Bords[lp].name = "Bord" + lp;
            Bords[lp].transform.parent = this.transform;
        }
        //Debug.Log(Bords[0]);
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject[] De = new GameObject[Number];
            De[0] = GetBords()[0];
        Debug.Log(De[0]);*/
    }

    public GameObject[] GetBords()
    {
        return Bords;
    }
    public int GetNumber()
    {
        return Number;
    }
}
