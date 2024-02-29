using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Fallo con corazones");
        }
    }

    //Para instancias
    public static GameManager Instance { get; private set; }

    //Suma de Frutas
    public void SumarPuntos (int puntosASumar)
    {
        puntosTotales += puntosASumar;
        hud.ActualizarPuntos(PuntosTotales);
        Debug.Log("Frutas: " + puntosTotales);
    }

    //Suma de Copas
    public void SumarCopas (int copasASumar)
    {
        copasTotales += copasASumar;
        hud.ActualizarCopas(CopasTotales);
        Debug.Log("Copitas: " + copasTotales);
    }

    //Funciones Vidas
    public void PerderVida()
    {
        vidas -= 1;
        if (vidas == 0) 
        {
            //Reinicio de partida
            SceneManager.LoadScene(0);
        }

        hud.DesactivarVida(vidas);
    }

    public bool ActivarVida()
    {
        if (vidas == 3)
        {
            return false;
        }

        hud.ActivarVida(vidas);
        vidas += 1;
        return true;
    }
}
