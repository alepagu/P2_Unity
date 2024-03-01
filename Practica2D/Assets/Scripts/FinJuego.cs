using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    // Referencia al objeto que finaliza la partida
    public GameObject trofeo;

    //Tiempos para finalizar juego
    private float tiempoLimite = 16f; // Tiempo límite en segundos
    private float tiempoTranscurrido = 0f;
    private bool terminarPartida = false;

    //Sonido final
    public AudioClip winner;

    // Método que se llama cuando otro collider entra en contacto con el collider de este objeto
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("¡Has terminado la partida!");
                Destroy(this.gameObject);
                AudioManager.Instance.ReproducirSonido(winner);
                
            }
    }

}