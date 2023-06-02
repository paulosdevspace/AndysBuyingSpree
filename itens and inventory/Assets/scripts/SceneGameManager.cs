using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class SceneGameManager
{
    public enum Scene
    {
        Menu,
        CutsceneInicial,
        OptionMenu,
        fase1,
        cutscene1,
        fase2,
        cutscene2,
        fase3,
        cutscenefinal,
        
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
