using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoController : MonoBehaviour
{
    public Dialogo dialogo;
    public DialogoContainer container;

    public void MostrarDialog()
    {
        dialogo.gameObject.SetActive(true);
        dialogo.StartDialogue();
    }

    public void NextDialog()
    {
        dialogo.NextLine();
    }

    public void ChangeDialog(int index)
    {
        dialogo.textComponent.text = string.Empty;
        dialogo.lines.Clear();
        dialogo.lines.Add(container.dialogos[index]);
    }

    public void OcultarDialog()
    {
        StopAllCoroutines();
        dialogo.gameObject.SetActive(false);
    }
}
