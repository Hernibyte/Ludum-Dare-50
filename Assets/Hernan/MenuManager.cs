using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject controlsPanel;

    [SerializeField] Slider sfxSlider;
    [SerializeField] Slider bgmSlider;
    [SerializeField] SoundManager soundManager;

    [Header("FullScreen toggle")]
    [SerializeField] Toggle toggle;

    void Start()
    {
        optionsPanel.SetActive(false);
        controlsPanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("h_Scene");
    }

    public void Controls()
    {
        controlsPanel.SetActive(true);
    }

    public void CloseControls()
    {
        controlsPanel.SetActive(false);
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ChangeSFXVol()
    {
        soundManager.SetSFX(sfxSlider.value);
    }

    public void ChangeBGMVol()
    {
        soundManager.SetBGM(bgmSlider.value);
    }

    public void ChangeFullScreen()
    {
        Screen.SetResolution(Screen.width, Screen.height, toggle.isOn);
    }
}
