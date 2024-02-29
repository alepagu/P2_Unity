using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viditas : MonoBehaviour
{
    public AudioClip corasao;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bool anadirVida = GameManager.Instance.ActivarVida();
            if (anadirVida) 
            { 
                Destroy(this.gameObject);
                AudioManager.Instance.ReproducirSonido(corasao);
            }

        }
    }
}
