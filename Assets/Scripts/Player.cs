using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 15.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;
    public float limiteSuperior = 4.2f ;
    public float limiteInferior = -5.75f ;
    public float limiteFrente = 7.55f ; 
    public float limiteAtras = -8.4f ;

    public GameOver morreukkk;

    public int vidaPlayer = 1 ;

    public GameObject BolinhaPapel ;

    public GameObject TresBolasKKJ ;

    public GameObject tirar;

    public float tempoDeDisparo = 0.3f ;

    public float podeDisparar = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        velocidade = 8.0f ;
        transform.position = new Vector3(-5.55f,0.29f,0);
    }

    // Update is called once per frame
    void Update()
    {
       


   
       Movimento();

        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {

            if (Time.time > podeDisparar ){

            Instantiate( BolinhaPapel, transform.position + new Vector3(0,0.2f,0), Quaternion.identity);
        
            podeDisparar = Time.time  + tempoDeDisparo ; }
        }
  

    }

   private void Movimento(){

         // Verifica se a tecla "W" está pressionada para mover o personagem para cima
        if (Input.GetKey(KeyCode.W) && transform.position.y < limiteSuperior )
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }

        // Verifica se a tecla "S" está pressionada para mover o personagem para baixo
        if (Input.GetKey(KeyCode.S) && transform.position.y > limiteInferior)
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x < limiteFrente)
        {
            transform.Translate(Vector3.up * velocidade * Time.deltaTime);
        
        
     }

       if (Input.GetKey(KeyCode.A) && transform.position.x > limiteAtras)
       {


       transform.Translate(Vector3.down * velocidade * Time.deltaTime);

       } 
  

       if (transform.position.y < limiteInferior)
       {
     vidaPlayer --;
     tirar.SetActive(false);
     morreukkk.painelGameover.SetActive(true);
     Time.timeScale = 0f;

   }


    }

   

    public void Dano()
    {

    vidaPlayer --;

    if(vidaPlayer < 1){

  

    }

    }

}

