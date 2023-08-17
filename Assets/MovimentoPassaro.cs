using UnityEngine;

public class MovimentoObjeto : MonoBehaviour
{
    public float velocidade = 5f;
    public float pontoDestino = 10f;

    private void Update()
    {
        // Move o objeto da esquerda para a direita
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);

        // Verifica se o objeto atingiu o ponto de destino
        if (transform.position.x >= pontoDestino)
        {
            // Destroi o objeto
            Destroy(gameObject);
        }
    }
}