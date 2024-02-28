using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Puntuación Frutas
    public int PuntosTotales { get { return puntosTotales; }}
    private int puntosTotales;

    //Pûntuación Copas
    public int CopasTotales { get { return copasTotales; } }
    private int copasTotales;

    //Vidas
    public HUD hud;
    private int vidas = 3;

    //Para instancias
    public static GameManager Instance { get; private set; }

    //Suma de Frutas
    public void SumarPuntos (int puntosASumar)
    {
        puntosTotales += puntosASumar;
        hud.ActualizarPuntos(PuntosTotales);
        Debug.Log(puntosTotales);
    }

    //Suma de Copas
    public void SumarCopas (int copasASumar)
    {
        copasTotales += copasASumar;
        hud.ActualizarCopas(CopasTotales);
        Debug.Log(copasTotales);
    }

    public void PerderVida()
    {
        vidas -= 1;
        hud.DesactivarVida(vidas);
    }

    public void ActivarVida()
    {
        hud.ActivarVida(vidas);
        vidas += 1;
    }
}
