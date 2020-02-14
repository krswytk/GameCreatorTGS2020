using System;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using Debug = UnityEngine.Debug;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SearchCom : MonoBehaviour {
    public SerialHandler sh;
    public String SearchWord; //ハードウェア名(部分一致でおk) 
    private String PortNum;

    void Awake() {
        ProcessStart();
    } 
    /// <summary> 
    /// プロセスをたたく 
    /// </summary> 
    void ProcessStart()
    {
        //Debug.Log(Directory.GetCurrentDirectory() + @"\GetComDevices.exe");
        Process p = new Process 
        {
            StartInfo =
            {
                FileName =Directory.GetCurrentDirectory() + 
                            @"\GetComDevices.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = false,
                RedirectStandardInput = false,
                CreateNoWindow = true
            }
        };
        //イベントハンドラの設定 
        p.OutputDataReceived += OutputDataHandler;
        p.EnableRaisingEvents = true;
        p.Exited += Process_Exit; 
        
        //実行 
        p.Start();
        p.BeginOutputReadLine();
    } 
    //出力を受け取るとたたかれる 
    private void OutputDataHandler(object sender, DataReceivedEventArgs args)
    {
        if (!string.IsNullOrEmpty(args.Data))
        {
            if (args.Data.IndexOf(SearchWord) != -1)
            {
                PortNum = args.Data.Split('t')[1].Trim();
            }
        }
    } 
    //出力が終わったらSerialHandlerの設定用メソッドをたたく 
    private void Process_Exit(object sender, EventArgs e)
    {
        //Debug.Log(PortNum);
        sh.SetPortName(PortNum);
        Process proc = (Process)sender;
        proc.Kill();
    }
}