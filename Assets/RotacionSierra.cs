using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSierra : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float velocidadRotacion = 100f;

    // Update se llama una vez por frame
    void Update()
    {
        // Rotar el objeto constantemente en el eje Z
        transform.Rotate(0, 0, velocidadRotacion * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        //estoy tocando algo
        if (colision.tag == "suelo")
        {
            print("he tocando suelo");
            Destroy(gameObject);
            GameMain.Instance.IncrementScore();
        }
        //estoy tocando algo
        if (colision.tag == "gato")
        {
            print("he tocando gato");
            Destroy(colision.gameObject);
            GameMain.Instance.GameOver();
        }
    }
}
