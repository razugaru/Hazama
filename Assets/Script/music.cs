using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

    public AudioSource Camera;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Camera.Play();
        }
    }
}
