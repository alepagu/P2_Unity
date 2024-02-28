using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fruits : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;

    //Sonido
    public AudioSource audioSource;
    public AudioClip comer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("El personaje me ha comido");
            gameManager.SumarPuntos(valor);
            audioSource.Play();
            Destroy(this.gameObject);
        }
        
        
    }
}
