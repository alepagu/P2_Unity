using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;

        // Update is called once per frame
    void Update()
    {
        puntos.text = "Puntuaci�n Frutas:" + gameManager.PuntosTotales.ToString();
    }
}
