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

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shot();
        }

    }
    void Shot()
    {
            ScreenCapture.CaptureScreenshot(Application.dataPath + "/screenshot.PNG");
            print("スクショしたぜ");
    }
}