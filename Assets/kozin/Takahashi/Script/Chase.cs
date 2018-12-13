using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    private float speed = 10f;
    private float rotationSmoth = 1f;
    private Transform player;

	// Use this for initialization
	void Start () {
        //始めにプレイヤーの位置を取得
        player = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmoth);
	}
}
