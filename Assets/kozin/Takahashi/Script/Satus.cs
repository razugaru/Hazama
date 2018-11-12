using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    idle, move, see
}
public class Satus : MonoBehaviour {
    // Use this for initialization
    [HideInInspector]
    private Transform player;
    public float speed = 0.3f;
    public State _state;
    public float dist;

    private float elapsedTime;

    void Start () {
       // player = GameObject.FindGameObjectsWithTag("Player").transform;
        _state = State.move;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
