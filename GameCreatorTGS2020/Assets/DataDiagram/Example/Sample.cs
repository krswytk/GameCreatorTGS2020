using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour {

    public DD_DataDiagram diagram;

    private GameObject line;
    private float time=0;

    private void Start()
    {
        line = diagram.AddLine("hiii", Color.red);
    }

    private void Update()
    {
        time += Time.deltaTime * 5;
        var y = (Mathf.Sin(time) + 1) * 2 + 3;
        diagram.InputPoint(line, new Vector2(0.1f, y));
    }
}
