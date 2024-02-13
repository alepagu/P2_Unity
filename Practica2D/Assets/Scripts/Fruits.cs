using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fruits : MonoBehaviour
{
    public Score puntos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("El personaje me ha comido");
        Destroy(this.gameObject);
    }
}
