using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public GameObject garota, muleke;
    public int nunber;

    // Start is called before the first frame update
    void Awake()
    {
        nunber = Random.Range(1, 3);
        if (nunber == 1)
        {
            garota.SetActive(true);
        }
        if (nunber >= 2) 
        {
            muleke.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
