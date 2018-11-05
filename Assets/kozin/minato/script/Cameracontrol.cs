using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{

    public Camera MainCamera;
    public Camera SubCamera;

    private bool MainCameraON = true;


    // Use this for initialization
    void Start()
    {
        MainCamera.enabled = true;
        SubCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1) && MainCameraON == true)
        {
            MainCamera.enabled = false;
            SubCamera.enabled = true;

            MainCameraON = false;
        }else if(Input.GetMouseButtonDown(1) && MainCameraON == false)
        {
            MainCamera.enabled = true;
            SubCamera.enabled = false;
            MainCameraON = true;

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            transform.position += transform.forward * scroll;
            /*
            float fWheel = Input.GetAxis("Mouse ScrollWheel");
            transform.Translate(0, 0, fWheel);*/
        }
    }
}
