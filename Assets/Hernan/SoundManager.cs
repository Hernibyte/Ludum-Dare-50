using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] string sfxGroup = "sfx";
    [SerializeField] string bgmGroup = "bgm";

    float volumenBGM;
    float volumenSFX;

    public void SetSFX(float porcentaje)
    {
        volumenSFX = 20 * Mathf.Log10(Mathf.Clamp(porcentaje, 0.01f, 1f));
        audioMixer.SetFloat(sfxGroup, volumenSFX);
    }

    public void SetBGM(float porcentaje)
    {
        volumenBGM = 20 * Mathf.Log10(Mathf.Clamp(porcentaje, 0.01f, 1f));
        audioMixer.SetFloat(bgmGroup, volumenBGM);
    }
}
