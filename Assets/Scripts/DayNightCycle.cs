using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Sprite[] sprites; // Array de sprites para a sequência de transição
    public float spriteDuration = 300f; // Duração de cada sprite em segundos

    private SpriteRenderer spriteRenderer; // Referência para o componente SpriteRenderer
    private float currentTime = 0f; // Tempo atual do ciclo
    private int currentSpriteIndex = 0; // Índice do sprite atual

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Obtém o componente SpriteRenderer do objeto atual
        spriteRenderer.sprite = sprites[currentSpriteIndex]; // Define o sprite inicial
    }

    private void Update()
    {
        // Atualiza o tempo do ciclo
        currentTime += Time.deltaTime;

        // Verifica se é hora de mudar de sprite
        if (currentTime >= spriteDuration)
        {
            currentTime -= spriteDuration;
            currentSpriteIndex++;
           
            // Verifica se alcançou o final do array de sprites
            if (currentSpriteIndex >= sprites.Length)
            {
                currentSpriteIndex = 0; // Reinicia a sequência
            }

            spriteRenderer.sprite = sprites[currentSpriteIndex]; // Altera o sprite
            ControladorPontuacao.Pontuacao++;

        }
    }
}
