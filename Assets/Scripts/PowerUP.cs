using UnityEngine;

public class PowerUp : MonoBehaviour
{    
    public int velocidade = 15;

    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
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
