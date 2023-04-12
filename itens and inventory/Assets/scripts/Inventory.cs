using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    void Awake()
    {

        if(instance != null)
        {
            Debug.LogWarning("MORE THAN 1 INSTANCE");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChange();
    public OnItemChange onItemChangedCallback;

    public int space = 3;
    public List<Itens> item = new List<Itens> ();
    public bool Add (Itens itens)
    {

        if (!itens.isDefaultItem)
        {
            if(item.Count >= space) 
            {
                Debug.Log("Not enough room");
                return false;
            }

            item.Add(itens);

            if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        }
        return true;
    }
    public void Remove (Itens itens)
    {
        item.Remove(itens);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
