using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI copas;
    public GameObject[] vidas;

    //Controlador de frutas
    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = "Puntuación Frutas: " + puntosTotales.ToString();
    }

    //Controlador de copas
    public void ActualizarCopas(int copasTotales)
    {
        copas.text = "Puntuación Copitas: " + copasTotales.ToString();
    }


    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
