using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{


    float startingtime = 10f;
    public  float currenttime = 0f;
    public float currentmoney = 0f;
    float startingmoney = 1000f;
    [SerializeField] Text CountdownText;
    [SerializeField] Text MoneyAmmount;
    void Start()
    {
        currentmoney = startingmoney;
        currenttime = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -=1 *Time.deltaTime;
        CountdownText.text = currenttime.ToString("0");
        MoneyAmmount.text = currentmoney.ToString();
        if(currenttime <= 0)
        {
            currenttime = 0;
        }
    }
   
}
