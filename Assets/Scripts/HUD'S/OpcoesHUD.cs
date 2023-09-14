using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpcoesHUD : MonoBehaviour
{
    public Player player; // Arraste a referência do jogador aqui na interface Unity
    public GameObject pauseMenu; // Arraste o painel do menu de pausa aqui
    private bool isPaused = false;
    public ControladorPontuacao ControladorPontuacao;

    private void Start()
    {
        Voltar();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && player.vidaPlayer > 0)
        {
            if (isPaused)
            {
                Voltar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Pausar()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    public void Voltar()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void AbrirMenu()
    {
        SceneManager.LoadScene("Iniciar");
    }

    public void Reviver(){
        SceneManager.LoadScene("Jogando");
        ControladorPontuacao.pontuacao = 0;
    }
}
