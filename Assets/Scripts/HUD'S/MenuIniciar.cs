using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIniciar : MonoBehaviour
{

  public ControladorPontuacao Pontin;
  public int pontos = ControladorPontuacao.pontuacao;
  public float tempoJogo = 0f;
  public MovimentoO MovimentoO;
  public timer timerzin;

 void Update(){
        tempoJogo += Time.deltaTime;
       
        }





public void ZerarTempo()
    {

      

        timer.timerzin = 0f;
        Debug.Log("O Tempo foi zerado");

    }

   public void Jogar()
    {
       SceneManager.LoadScene("Jogando");
       ControladorPontuacao.pontuacao = 0;
       ZerarTempo();
     
      
    }

    // Update is called once per frame
  public void Sair()
    {
        Application.Quit();
    }

}