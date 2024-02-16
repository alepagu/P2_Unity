using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    // Referencia al objeto que finaliza la partida
    public GameObject trofeo;

    // M�todo que se llama cuando otro collider entra en contacto con el collider de este objeto
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("El personaje ha logrado llegar a meta. �Has terminado la partida!");
            Destroy(this.gameObject);
            Application.Quit(); //Salir de la partida.
        }

}