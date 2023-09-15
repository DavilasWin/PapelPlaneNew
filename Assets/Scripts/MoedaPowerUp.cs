using UnityEngine;

public class MoedaPowerUp : MonoBehaviour
{
    public int velocidade = 5;

    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AtivarTiroTriplo(other.gameObject);
        }
    }

    private void AtivarTiroTriplo(GameObject jogador)
    {
        // Verifica se o jogador tem o componente Player
        Player player = jogador.GetComponent<Player>();

        if (player != null)
        {
            // Ative o tiro triplo no jogador
            player.AtivarTiroTriplo();

            // Destrua a moeda ap�s ser coletada
            Destroy(gameObject);
        }
    }
}
