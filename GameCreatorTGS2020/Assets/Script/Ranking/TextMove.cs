using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    private float elapsedaTime;
  
   

    // Start is called before the first frame update
    void Start()
    {
        elapsedaTime = 0.0f;
      
       
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("Move", 15.0f);
        
    
    }

    private void Move()
    {
        transform.Translate(0.0f, 0.03f, 0.0f);
    }
}
