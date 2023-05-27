using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class krl : MonoBehaviour
{
    public Animator prota,prota2,prota3, camera;
    public GameObject cameraaa, prota3GameObject, protaGameObject, canvas, escuridao;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prota.GetCurrentAnimatorStateInfo(0).IsName("teste"))
        {
            camera.SetBool("Pronto", true);
            protaGameObject.SetActive(false);
        }
        if (camera.GetCurrentAnimatorStateInfo(0).IsName("2"))
        {
            prota3GameObject.SetActive(true);
            prota3.SetBool("Pronto", true);
            canvas.SetActive(false);
            escuridao.SetActive(false);
        }
        if (prota3.GetCurrentAnimatorStateInfo(0).IsName("carta"))
        {
            canvas.SetActive(true);
            camera.SetBool("Carta", true);
        }
        if (camera.GetCurrentAnimatorStateInfo(0).IsName("final"))
        {
            gameObject.GetComponent<ACABOOOOOOOO>().CanGo = true;
        }
    }
}
