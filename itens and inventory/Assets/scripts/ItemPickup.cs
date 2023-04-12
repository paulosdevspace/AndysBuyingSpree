using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Itens item;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }
    void PickUp()
    {
        Debug.Log("Pegou o " + item.name);
       bool wasPickedUp = Inventory.instance.Add(item);
        
        if(wasPickedUp)
        Destroy(gameObject);
    }
}
