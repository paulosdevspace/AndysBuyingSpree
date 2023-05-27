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
        SampleScene,
        OptionMenu,
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
