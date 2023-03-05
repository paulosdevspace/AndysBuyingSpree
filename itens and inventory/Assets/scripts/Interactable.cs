using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    public Transform interactionTransform;

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
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance <= radius)
        {
            Debug.Log("APERTE E PARA PEGAR");
            if (Input.GetKey("e"))
            {

                Interact();

            }

        }
    }
    public virtual void Interact()
    {
        Debug.Log("Pegou " + transform.name);
    }
}
