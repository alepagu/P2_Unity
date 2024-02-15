using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public int PuntosTotales { get { return totalPuntos; } }
    private int totalPuntos;

    public void SumarPuntos(int puntosASumar)
    {
        totalPuntos += puntosASumar;
        Debug.Log(totalPuntos);
    }

}
