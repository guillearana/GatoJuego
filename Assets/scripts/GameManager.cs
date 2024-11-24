using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    bool gameOver=false;
    public Text marcador;
    private int puntuacion=0;
    public GameObject panel;
     
     

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver = true;
        //busca el obstacle spawner, de sus componentes, usa el script, de la clase, usa el método público stop
        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();
        marcador.text = "";
      panel.SetActive(true);



    }


    public void IncrementScore()
    {
        if (!gameOver) {
            puntuacion++;
            print(puntuacion);
            marcador.text = puntuacion.ToString();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
