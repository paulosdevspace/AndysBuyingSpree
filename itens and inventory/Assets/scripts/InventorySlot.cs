using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Itens item;
    public Image icon;
    public Button removebutton;
    public void Additem (Itens newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removebutton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removebutton.interactable = false;
    }
    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }
    public void SellToy()
    {
        if(item != null)
        {
            item.Use();
        }
    }
}
