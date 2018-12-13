using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    
    //巡回する位置
    public Transform[] patrolPositions;
    //次に巡回する位置
    private int nowPos = 0;
    //NavMashコンポーネント変数
    private NavMeshAgent agent;
    //回転
    private float rotationSmooth = 5f;
    //Playerの位置
    private Transform player;
    //カウント変数
    public float cnt = 0;
    private float ranmax;
    //flg変数
    public bool flg = false;
  

    // Use this for initialization
    void Start(){
        player = GameObject.FindWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = true;

        flg = true;

        GotoNextPoint();
    }
	
	// Update is called once per frame
	void Update () {
        ranmax = Random.Range(300, 400);
        //Pointに近づいたら次の地点を選択
        if (!agent.pathPending && agent.remainingDistance < 0.03f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime *
                rotationSmooth);
            cnt++;
            if (cnt >= ranmax)
            {
                GotoNextPoint();
                cnt = 0;
            }
        }
	}
    void GotoNextPoint()
    {
        //次の地点がないとき
        if(patrolPositions.Length == 0)
        {
            return; 
        }
        //エージェントが現在設定された目標地点に行くように
        agent.destination = patrolPositions[nowPos].position;

        //配列倍の次の位置を目標に設定、必要ならば出発地点に戻ります
        nowPos = (nowPos + 1) % patrolPositions.Length;
    }
}
