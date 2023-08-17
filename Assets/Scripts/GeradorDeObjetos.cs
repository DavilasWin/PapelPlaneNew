using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{

 public GameObject[] objetos;
 public Transform[] spawns ;
 public float tempoMaximo;
 public float tempoAtual;



    // Start is called before the first frame update
    void Start()
    {
        tempoAtual = tempoMaximo;
    }

    // Update is called once per frame
    void Update()
    {
        
   tempoAtual -= Time.deltaTime;
   
if(tempoAtual <= 0){

    Spawner();
}





    }



    private void Spawner(){

  int objetoRandom = Random.Range(0, objetos.Length);
  int randomPoint = Random.Range(0, spawns.Length);

  Instantiate(objetos[objetoRandom], spawns[randomPoint].position, Quaternion.Euler(0f, 0f, 0f));
 tempoAtual = tempoMaximo;

  


    }
}
