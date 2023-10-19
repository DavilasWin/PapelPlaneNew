using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameover;
    public Player player; // Arraste a referência do jogador aqui na interface Unity
    public GameObject Pontas;
    public bool animador;
    public GameObject playerzinho;
    public int morrer = 3;

    void Start()
    {
        painelGameover.SetActive(false);
        Time.timeScale = 1f;
        animador = GetComponent<Animator>();

    }

    void Update()
    {
        if (player.vidaPlayer == 0)
        {
            Pontas.SetActive(false);
            player.animador.SetBool("estaMorto", true);
           
            

        }
    }
}
