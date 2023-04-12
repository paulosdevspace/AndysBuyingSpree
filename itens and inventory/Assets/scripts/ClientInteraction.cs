using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientInteraction : MonoBehaviour
{
    public float radius = 3f;
    public Transform clientwait;
    public Transform interactionTransform;
    public Transform clientgone;
    public string toy;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(clientwait.position, transform.position);
        if (distance <= radius)
        {
           
                Debug.Log("O CLIENTE QUER "+ toy +", APERTE R PARA ENTREGAR");
                if (Input.GetKey("r"))
                {
               
                    //Interact();               
                }
           
        }

        float distancegone = Vector3.Distance(clientgone.position, transform.position);
        if (distancegone <= radius)
        {
            Debug.Log("Foi embora");
            Destroy(gameObject);
        }

    }
    public virtual void Interact()
    {
        Debug.Log("Entregou");
    }
   
}
