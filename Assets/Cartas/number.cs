using UnityEngine;
using TMPro;

public class number : MonoBehaviour
{
    public TextMeshProUGUI numeroTexto;  
    public int numeroActual = 1;  

    void Start()
    {
        ActualizarTexto();
    }

    public void Aumentar()
    {
        numeroActual++;

        if (numeroActual > 70)
            numeroActual = 1;

        ActualizarTexto();
    }

    public void Disminuir()
    {
        numeroActual--;

        if (numeroActual < 1)
            numeroActual = 70;

        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        numeroTexto.text = numeroActual.ToString();
    }
}
