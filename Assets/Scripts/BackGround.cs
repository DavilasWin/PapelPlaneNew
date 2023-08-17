using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float velocidade = 2f; // Velocidade do movimento
    public float limiteEsquerda = -0.08f; // Limite esquerdo do cenário
    public float limiteDireita = 24.44f; 
     public float tempo = 120.0f; // 2 minutos
    public float tempo1 = 240.0f; // 4 minutos
    public float tempo2 = 360.0f; // 6 minutos

    private void Update()
    {
        // Movimento do cenário para a esquerda
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        // Verifica se o cenário atingiu o limite esquerdo
        if (transform.position.x <= limiteEsquerda)
        {
            // Reposiciona o cenário para a direita
            RepositionCenario();
        }
        Tempin();
    }

    private void RepositionCenario()
    {
        // Calcula a nova posição do cenário
        Vector3 novaPosicao = new Vector3(limiteDireita, transform.position.y, transform.position.z);
        transform.position = novaPosicao;
    }
      private void Tempin(){

   if(Time.time > tempo){

     velocidade = 15f;



   }

   if(Time.time > tempo1){
    velocidade = 20f;
   }
   if(Time.time > tempo2){
     velocidade = 25f;
   }
}

}
