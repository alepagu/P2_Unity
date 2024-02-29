using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copitas : MonoBehaviour
{
    private int valor = 20;
    public GameManager gameManager;

    //Sonido
    public AudioClip copitas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("El personaje me ha cogido");
        gameManager.SumarCopas(valor);
        Destroy(this.gameObject);
        AudioManager.Instance.ReproducirSonido(copitas);
    }
}
