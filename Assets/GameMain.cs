using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour
{

    public static GameMain Instance;
    bool gameOver=false;

    public Text marcador;

    private int puntuacion = 0;


    private void Awake(){
        Instance=this;
    }

    public void GameOver(){
        gameOver=true;
        GameObject.Find("GenerarCuchillas").GetComponent<Generador>().StopSpawning();
        print("GAME OVER");
        SceneManager.LoadScene("Menu");
    }
    public void IncrementScore(){
        if (!gameOver){
            puntuacion++;
            print("TU PUNTUACION ES "+ puntuacion);
            marcador.text= puntuacion.ToString();
            // Llamar al método para aumentar la velocidad
            GameObject.Find("GenerarCuchillas").GetComponent<Generador>().AumentarVelocidad();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
