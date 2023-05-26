using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsUI : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    private TextMeshProUGUI soundVolumeText;
    private TextMeshProUGUI musicVolumeText;
    [SerializeField] private MusicManager musicManager;

    private void Awake()
    {
        transform.Find("SoundIncrease").GetComponent<Button>().onClick.AddListener(() =>
        {
            soundManager.IncreaseVolume();
        });
        transform.Find("SoundDecrease").GetComponent<Button>().onClick.AddListener(() =>
        {
            soundManager.DecreaseVolume();
        });
        transform.Find("MusicIncrease").GetComponent<Button>().onClick.AddListener(() =>
        {
            musicManager.IncreaseVolume();
        });
        transform.Find("MusicDecrease").GetComponent<Button>().onClick.AddListener(() =>
        {
            musicManager.DecreaseVolume();
        });

        transform.Find("mainMenuBtn").GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneGameManager.Load(SceneGameManager.Scene.Menu);
        });
    }

    private void Start()
    {
        gameObject.SetActive(false);

    }


    public void ToggleVisible()
    {
        gameObject.SetActive(!gameObject.activeSelf);

        if (gameObject.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
