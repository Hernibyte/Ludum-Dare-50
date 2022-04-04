using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExcuseBar : MonoBehaviour
{
    public Sprite[] imagenes;
    public Image BarraProgreso;

    public void Actualizarbarra(int excusasactuales)
    {
        BarraProgreso.sprite = imagenes[excusasactuales];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
