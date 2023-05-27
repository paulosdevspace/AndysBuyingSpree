using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    private void Awake()
    {
        /*transform.Find("playBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneGameManager.Load(SceneGameManager.Scene.CutsceneInicial);
        });
        */
        transform.Find("OptionsBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneGameManager.Load(SceneGameManager.Scene.OptionMenu);
        });
        
        transform.Find("quitBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}