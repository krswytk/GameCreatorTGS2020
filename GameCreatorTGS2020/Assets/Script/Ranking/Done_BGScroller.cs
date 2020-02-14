using UnityEngine;
using System.Collections;

public class Done_BGScroller : MonoBehaviour
{

    [SerializeField] private float speed;

    

    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0);
        if (transform.position.x <= -11.0f)
        {
            transform.position = new Vector3(11.0f, 0);
        }
    }
}