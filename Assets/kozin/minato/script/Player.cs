﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0f, 0, -0.1f);
        }*/

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }
}