using UnityEngine;

public class MovimentoO : MonoBehaviour
{
    public static float velocidade = 15f;
    public float pontoDestino = -11f;
    public timer timerzin;
    public float tempo = 120.0f;
    public float tempo1 = 240.0f;
    public float tempo2 = 340.0f;

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

  public void Tempin(){

    if ( timer.timerzin < tempo ){
        velocidade = 15;
    }

    if( timer.timerzin > tempo ){
        velocidade = 20;
    }
    if ( timer.timerzin > tempo1 ){
        velocidade = 25;
    }
    if ( timer.timerzin > tempo2 ){
        velocidade  = 30;
    }


  }



}