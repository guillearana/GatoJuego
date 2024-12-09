using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // Prefab de la cuchilla que se generará
    public GameObject Cuchilla;

    // Área de generación
    float areaMinimaX = -3f;
    float areaMaximaX = 3f;

    // Tiempo entre generaciones
    public float tiempoEntreCuchillas = 4f;

    // Velocidad mínima permitida para la generación de cuchillas
    public float tiempoMinimo = 0.5f;

    // Referencia al sistema de puntuación
    public int puntuacion = 0;

    // Start se llama al inicio
    void Start()
    {
        // Comenzar a generar cuchillas repetidamente
        InvokeRepeating("GenerarCuchilla", 1f, tiempoEntreCuchillas);
    }

    // Método para generar una cuchilla
    void GenerarCuchilla()
    {
        // Generar una posición aleatoria dentro del área
        float randomX = Random.Range(areaMinimaX, areaMaximaX);
        Vector3 posicionAleatoria = new Vector3(randomX, transform.position.y);

        // Instanciar una nueva cuchilla en la posición aleatoria
        Instantiate(Cuchilla, posicionAleatoria, Quaternion.identity);
    }

    // Método para incrementar la puntuación y acelerar la generación
    public void AumentarVelocidad()
    {
        // Disminuir el tiempo entre cuchillas
        tiempoEntreCuchillas = Mathf.Max(tiempoMinimo, tiempoEntreCuchillas - 0.1f);

        // Reiniciar el InvokeRepeating con el nuevo tiempo
        CancelInvoke("GenerarCuchilla");
        InvokeRepeating("GenerarCuchilla", 0f, tiempoEntreCuchillas);
    }

    public void StopSpawning()
    {
        CancelInvoke("GenerarCuchilla");
    }
}
