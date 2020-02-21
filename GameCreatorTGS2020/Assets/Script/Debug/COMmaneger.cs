using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class COMmaneger : MonoBehaviour
{
    public static bool COMCH;
    private string keycode;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        COMCH = false;
        keycode = null;
        num = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            keycode = Input.inputString;
            num = int.Parse(keycode);
            Debug.Log(num);
        }
        switch (num)
        {
            case 0:
                SerialHandler.portName = "COM0";
                COMCH = true;
                Debug.Log("COM0");
                break;
            case 1:
                SerialHandler.portName = "COM1";
                COMCH = true;
                Debug.Log("COM1");
                break;
            case 2:
                SerialHandler.portName = "COM2";
                COMCH = true;
                Debug.Log("COM2");
                break;
            case 3:
                SerialHandler.portName = "COM3";
                COMCH = true;
                Debug.Log("COM3");
                break;
            case 4:
                SerialHandler.portName = "COM4";
                COMCH = true;
                Debug.Log("COM4");
                break;
            case 5:
                SerialHandler.portName = "COM5";
                COMCH = true;
                Debug.Log("COM5");
                break;
            case 6:
                SerialHandler.portName = "COM6";
                COMCH = true;
                Debug.Log("COM6");
                break;
            case 7:
                SerialHandler.portName = "COM7";
                COMCH = true;
                Debug.Log("COM7");
                break;
            case 8:
                SerialHandler.portName = "COM8";
                COMCH = true;
                Debug.Log("COM8");
                break;
            case 9:
                SerialHandler.portName = "COM9";
                COMCH = true;
                Debug.Log("COM9");
                break;
            default:
                //Debug.Log("該当値なし");
                break;
        }
        num = 100;
    }

    public void COM0()
    {
        SerialHandler.portName = "COM0";
        COMCH = true;
        Debug.Log("COM0");
    }

    public void COM1()
    {
        SerialHandler.portName = "COM1";
        COMCH = true;
        Debug.Log("COM1");
    }
    public void COM2()
    {
        SerialHandler.portName = "COM2";
        COMCH = true;
        Debug.Log("COM2");
    }
    public void COM3()
    {
        SerialHandler.portName = "COM3";
        COMCH = true;
        Debug.Log("COM3");
    }
    public void COM4()
    {
        SerialHandler.portName = "COM4";
        COMCH = true;
        Debug.Log("COM4");
    }
    public void COM5()
    {
        SerialHandler.portName = "COM5";
        COMCH = true;
        Debug.Log("COM5");
    }
    public void COM6()
    {
        SerialHandler.portName = "COM6";
        COMCH = true;
        Debug.Log("COM6");
    }
    public void COM7()
    {
        SerialHandler.portName = "COM7";
        COMCH = true;
        Debug.Log("COM7");
    }
    public void COM8()
    {
        SerialHandler.portName = "COM8";
        COMCH = true;
        Debug.Log("COM8");
    }
    public void COM9()
    {
        SerialHandler.portName = "COM9";
        COMCH = true;
        Debug.Log("COM9");
    }
}
