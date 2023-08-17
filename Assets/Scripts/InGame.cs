using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public Text Pontinhos;

    // Update is called once per frame
    void Update()
    {
        
     this.Pontinhos.text = ControladorPontuacao.Pontuacao.ToString();

    }
}
