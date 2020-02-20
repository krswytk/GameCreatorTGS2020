using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGraph : MonoBehaviour
{
    public DD_DataDiagram diagram;

    private GameObject line;
    private float time;
    private float sc;

    private void Start()
    {
        line = diagram.AddLine("SCORE", Color.yellow);
    }

    private void Update()
    {
        sc = GetScore.sc;
        diagram.InputPoint(line, new Vector2(0.1f, sc));
    }
}