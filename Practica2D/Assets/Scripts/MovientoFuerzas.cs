using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovientoFuerzas : MonoBehaviour
{
    public float speed;
    float inputMovement;
    Rigidbody2D rigidBody2D;
    public bool isLookingRight;
    public float jumpSpeed;

    //Arregle Jump
    BoxCollider2D boxCollider;
    public bool isOnFloor;
    public LayerMask surfaceLayer;

    //Transition Animations
    public bool isRunning;
    private Animator animator;

    // Contador de saltos
    private int jumpCount;
    public int maxJumpCount = 1;

    private void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    bool ChekingFloor()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(
                                    boxCollider.bounds.center, //Origen de la caja
                                    new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), //Tamaño, por defecto 1
                                    0f, //Ángulo
                                    Vector2.down, //Direccion hacia la que va la caja
                                    0.2f, //Distancia a la que aparece la caja
                                    surfaceLayer//Layer mask
                                    );

        return raycastHit.collider != null;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
        isOnFloor = ChekingFloor();
        ProcessingJump();
    }

    //Función para las fuerzas
    void ProcessingMovement () 
    {
        inputMovement = Input.GetAxis("Horizontal");
        isRunning = inputMovement != 0 ? true : false;
        animator.SetBool("isRunning", isRunning);
        rigidBody2D.velocity = new Vector2(speed * inputMovement, rigidBody2D.velocity.y);
        CharacterHOrientation(inputMovement);
    }

    private void ProcessingJump()
    {
        animator.SetBool("isJumping", !isOnFloor);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpCount++;

            if (isOnFloor || jumpCount < maxJumpCount)
            {
                jumpCount++;
                rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, 0f); // Eliminar la velocidad vertical antes de saltar
                rigidBody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }

        if (isOnFloor)
        {
            jumpCount = 0; // Reiniciar el contador de saltos si está en el suelo
        }
    }

    private void CharacterHOrientation(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }
}
