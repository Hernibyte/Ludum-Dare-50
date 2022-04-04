using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackScreenController : MonoBehaviour
{
    [SerializeField] Image blackPanel;
    [SerializeField] MenuManager menuManager;

    public void FundidoNegro()
    {
        blackPanel.gameObject.SetActive(true);
        StartCoroutine(SetBlackScreen());
    }

    IEnumerator SetBlackScreen()
    {
        Color color = Color.clear;
        for (int i = 0; i <= 100; i++)
        {
            color.a = (float)i / 100;
            blackPanel.color = color;
            yield return new WaitForSeconds(0.05f);
        }

        menuManager.ReturnToMenu();
        yield return null;
    }
}
