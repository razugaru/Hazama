using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class Sshot : MonoBehaviour
{
    
    private string saveFilePath = "/Prijects/ScreenShot";
    private string saveFileName = "/screenshot.PNG";
    private int flg = 0;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //shot();
        }
            if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Yomikomi");
        }
    }
    /*void shot()
    {
        if (flg == 0)
        {
            System.IO.File.Delete(@"C:\Users\nwuser\Documents\paparachi\Assets.savedata.png");
            ScreenCapture.CaptureScreenshot(Application.dataPath + "/savedata.PNG");
            print("スクショしたぜ");
            flg = 1;
        }
    }*/
}