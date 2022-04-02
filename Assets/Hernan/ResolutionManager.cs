using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] Text resolutionText;
    Resolution[] resolutions;

    int inRes;

    void Start()
    {
        inRes = 0;
        resolutions = Screen.resolutions;
        for (int i = 0; i < resolutions.Length - 1; i++)
        {
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                inRes = i;
                break;
            }
        }
        resolutionText.text = Screen.width + " x " + Screen.height;
    }

    void ChangeResText()
    {
        resolutionText.text = resolutions[inRes].width + " x " + resolutions[inRes].height;
    }

    public void PreviousRes()
    {
        inRes--;
        if (inRes < 0)
            inRes = resolutions.Length - 1;
        ChangeResText();
    }

    public void NextRes()
    {
        inRes++;
        if (inRes > resolutions.Length - 1)
            inRes = 0;
        ChangeResText();
    }

    public void SetRes()
    {
        Screen.SetResolution(resolutions[inRes].width, resolutions[inRes].height, Screen.fullScreen);
    }
}
