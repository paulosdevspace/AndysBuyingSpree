using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Follow : MonoBehaviour
{
    public timer timer;
    public NavMeshAgent agent;
    public Transform player;
    public Transform respawnpoint;
    public Animator animator;
    

    void Start()
    {
        
    }

  
    void Update()
    {
        if (timer.currenttime <= 0)
        {
            agent.destination = GameObject.FindWithTag("Player").transform.position;
            animator.SetBool("IsWalking", true);
        }
        else
        {
            agent.destination = GameObject.FindWithTag("ManagerRoom").transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.CompareTag("Player"))
        {
            timer.currentmoney = timer.currentmoney - 100;
            timer.currenttime = 10f; 
            player.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }
        if (other.CompareTag("Stop"))
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
