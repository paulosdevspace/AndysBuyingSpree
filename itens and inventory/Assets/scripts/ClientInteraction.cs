using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientInteraction : MonoBehaviour
{
    public float radius = 7f;
    public Transform clientwait;
    public Transform interactionTransform;
    public Transform clientgone;
    public string toy;
    public string toywant;
    public Inventory inventory;
    public clientbehaviour clientbehaviour;


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
    }
    void Start()
    {
        toy = "not ok"; 
        inventory= GameObject.FindWithTag("Player").GetComponent<Inventory>();
        clientbehaviour = GetComponent<clientbehaviour>();
    }
    void Update()
    {
        
        float distance = Vector3.Distance(inventory.transform.position, transform.position);
        //print(distance);
        if (distance <= radius)
        {
            
                if (Input.GetKeyDown(KeyCode.E))
                {
               
                   Interact();
                                                  
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
        if(inventory.item.Count < 1)
        {
            print("INVENTÁRIO VAZIO!!!");
            return;
        }

        bool brinquedoErrado = true;
        foreach (Itens item in inventory.item) {
            if(item.name == toywant) {
                Debug.Log("Entregou");
                inventory.Remove(item);
                clientbehaviour.hastoy++;
                brinquedoErrado=false;  
            }
        }

        if(brinquedoErrado) {
            print("BRINQUEDO ERRADOOOOOO!!!!!!!!!!!!!!!!!!!!!");
        }
    }
   
}
