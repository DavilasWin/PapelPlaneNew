using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameover;
    public Player player; // Arraste a referência do jogador aqui na interface Unity
    public GameObject Pontas;

    void Start()
    {
        painelGameover.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (player.vidaPlayer == 0)
        {
            Pontas.SetActive(false);
            painelGameover.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
