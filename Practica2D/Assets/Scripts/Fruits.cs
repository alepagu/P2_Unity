using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fruits : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;

    //Sonid
    public AudioClip comer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("El personaje me ha comido");
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
            AudioManager.Instance.ReproducirSonido(comer);
        }
        
    }
}
