using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempo : MonoBehaviour
{
   

    
    public Sprite[] sprites; // Array com os sprites que você deseja trocar
    public float intervaloTroca = 180f; // Tempo em segundos (3 minutos)

    private SpriteRenderer spriteRenderer;
    private int spriteIndex = 0;
  


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("TrocarSprite", 0f, intervaloTroca);
    }

    private void TrocarSprite()
    {
        spriteIndex = (spriteIndex + 1) % sprites.Length;
        spriteRenderer.sprite = sprites[spriteIndex];
    }


}
