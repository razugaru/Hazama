using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Controll : MonoBehaviour {

    [SerializeField]
    private Transform m_target = null;

    private NavMeshAgent m_navAgent = null;

    // Use this for initialization
    private void Awake()
    {
        m_navAgent = GetComponent<NavMeshAgent>();
    }
    void Start () {
		if(m_target != null)
        {
            m_navAgent.destination = m_target.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
