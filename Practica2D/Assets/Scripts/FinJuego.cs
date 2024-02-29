using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    // Referencia al objeto que finaliza la partida
    public GameObject trofeo;

    //Sonido final
    public AudioClip winner;

    // Método que se llama cuando otro collider entra en contacto con el collider de este objeto
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("El personaje ha logrado llegar a meta.");
            Debug.Log("¡Has terminado la partida!");
            Destroy(this.gameObject);
        AudioManager.Instance.ReproducirSonido(winner);
            Application.Quit();
            
            
            
        }

}