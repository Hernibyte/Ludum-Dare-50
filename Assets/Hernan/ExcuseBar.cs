using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExcuseBar : MonoBehaviour
{
    public Image BarraProgreso;

    public void Actualizarbarra(int excusasactuales)
    {
        int porcentaje = excusasactuales / 10;
        BarraProgreso.fillAmount = porcentaje;
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
