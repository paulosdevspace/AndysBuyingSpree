using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class clientbehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public float hastoy = 0f;
    // Start is called before the first frame update
    void Start()
    {      
        hastoy = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ClientHasToy())
        {
            agent.destination = GameObject.FindWithTag("ClientWait").transform.position;
        }
        else
        {
            agent.destination = GameObject.FindWithTag("ClientGone").transform.position;
        }
      
           
        

    } 
    bool ClientHasToy()
    {
        if (hastoy <= 0)
        {
            return false;
        }
        else
        {          
            return true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ClientGone"))
        {
            Debug.Log("Cliente foi embora");
            //Destroy(gameObject);
        } 
    }
}

