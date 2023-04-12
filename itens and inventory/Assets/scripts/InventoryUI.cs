using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itensParent;
    Inventory inventory;
   InventorySlot[] slots;
    // Start is called before the first frame update
    void Start()
    {
     inventory =   Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itensParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {
       for (int i = 0; i < slots.Length; i++) 
       {
         if(i < inventory.item.Count)
            {
                slots[i].Additem(inventory.item[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
       }   
    }
}
