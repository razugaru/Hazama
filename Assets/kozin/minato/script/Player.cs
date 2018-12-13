using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    private Animator anim;
    float horizontalSpeed = 20.0f;
    float verticalSpeed = 20.0f;

    //　メインカメラ
    [SerializeField] private GameObject MainCam;
    //　切り替える他のカメラ
    [SerializeField] private GameObject SubCam;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SubCam.SetActive(false);//サブカメラを非アクティブにしておく
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Move();//移動
        Person();//視点
        Switching();//カメラの切り替え
        Anime();
    }
    //キーボードのWASDキーまたはPS4コントローラ左スティックでplayerを移動させる
    private void Move()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);

    }
    
    private void Anime()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        if (Input.GetButtonDown("Vertical"))
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
    //PS4コントローラ右スティックでplayerの視点を変える
    private void Person()
    {
         float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
    }

   
    //マウスの左クリックまたはPS4コントローラ左L2でカメラを構える
    //マウスの右クリックまたはPS4コントローラR2で写真を撮る
    private void Switching()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (MainCam.activeSelf)
            {
                MainCam.SetActive(false);
                SubCam.SetActive(true);
            }
            else
            {            
                MainCam.SetActive(true);
                SubCam.SetActive(false);
            }
        }
    }
}
