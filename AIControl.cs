using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform objective;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = objective.position;
    }

    
}
