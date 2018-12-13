using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamerasc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("写真を撮影しました");
        }
    }
}
