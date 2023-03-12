using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Follow : MonoBehaviour
{
    public NavMeshAgent agent;

    void Start()
    {
        
    }

  
    void Update()
    {
        agent.destination = GameObject.FindWithTag("Player").transform.position;
    }
}
