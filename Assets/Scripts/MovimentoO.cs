using UnityEngine;

public class MovimentoO : MonoBehaviour
{
    public float velocidade = 15f;
    public float pontoDestino = -11f;
    public float tempo = 120.0f; // 2 minutos
    public float tempo1 = 240.0f; // 4 minutos
    public float tempo2 = 360.0f; // 6 minutos

    private void Update()
    {
        // Move o objeto da esquerda para a direita
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        // Verifica se o objeto atingiu o ponto de destino
        if (transform.position.x <= pontoDestino)
        {
            // Destroi o objeto
            Destroy(gameObject);
        }

     Tempin(); 
    }

     private void OnTriggerEnter2D(Collider2D other)
     {

       if (other.tag == "Tiro"){



          ControladorPontuacao.Pontuacao++;
          Destroy(this.gameObject);
          Destroy(other.gameObject);
       }

       if (other.tag == "Player"){

    Player player = other.GetComponent<Player>();

    if(player != null)
    {
        player.Dano();
    }
       }
     }

    private void Tempin(){

   if(Time.time > tempo){

     velocidade = 20f;



   }

   if(Time.time > tempo1){
    velocidade = 25f;
   }
   if(Time.time > tempo2){
     velocidade = 30f;
   }


    }




}