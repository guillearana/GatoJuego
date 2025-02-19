using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaculo;
    public float velocidadCreaccion = 2f;
    float minimoX = -2f;
    float maximoX = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // spawnea entre el max y el min de x
    void Spawn()
    {
        float randomenX = Random.Range(minimoX, maximoX);
        Vector2 spawnPos = new Vector2(randomenX, transform.position.y);
        Instantiate(obstaculo, spawnPos, Quaternion.identity);

    }

    void StartSpawning() 
    {
        InvokeRepeating("Spawn", 1f, velocidadCreaccion);
        
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }


}
