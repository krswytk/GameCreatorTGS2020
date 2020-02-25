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
        //\
        if (Input.GetKeyDown(KeyCode.Alpha0)){
            SerialHandler.portName = "COM0";
            COMCH = true;
            Debug.Log("COM0");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SerialHandler.portName = "COM1";
            COMCH = true;
            Debug.Log("COM1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SerialHandler.portName = "COM2";
            COMCH = true;
            Debug.Log("COM2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SerialHandler.portName = "COM3";
            COMCH = true;
            Debug.Log("COM3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SerialHandler.portName = "COM4";
            COMCH = true;
            Debug.Log("COM4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SerialHandler.portName = "COM5";
            COMCH = true;
            Debug.Log("COM5");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SerialHandler.portName = "COM6";
            COMCH = true;
            Debug.Log("COM6");
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SerialHandler.portName = "COM7";
            COMCH = true;
            Debug.Log("COM7");
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SerialHandler.portName = "COM8";
            COMCH = true;
            Debug.Log("COM8");
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SerialHandler.portName = "COM9";
            COMCH = true;
            Debug.Log("COM9");
        }

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
