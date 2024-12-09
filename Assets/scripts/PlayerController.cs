using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer rbSprite;
    public float moveSpeed = 4f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rbSprite = rb.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
    }

    void Update()
    {
        // No se necesita nada aquí por ahora, todo ocurre en FixedUpdate.
    }

    private void FixedUpdate()
    {
        // Variable para el movimiento horizontal
        float horizontalInput = Input.GetAxis("Horizontal");

        // Si se detecta entrada del teclado
        if (horizontalInput != 0)
        {
            // Mover según las flechas (teclado)
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

            // Voltear el sprite según la dirección
            rbSprite.flipX = horizontalInput < 0;
        }
        // Si no hay entrada de teclado, revisar el clic del ratón
        else if (Input.GetMouseButton(0))
        {
            // Si el clic está a la izquierda de la pantalla
            if (Input.mousePosition.x < Screen.width / 2)
            {
                rb.velocity = Vector2.left * moveSpeed;
                rbSprite.flipX = true;
            }
            // Si el clic está a la derecha de la pantalla
            else
            {
                rb.velocity = Vector2.right * moveSpeed;
                rbSprite.flipX = false;
            }
        }
        // Si no hay entrada, detener al personaje
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
