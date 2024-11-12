using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    // Variável pública para definir o sprite no Inspetor da Unity
    public Sprite cardImage;
    private GameObject spriteObject;
    private SpriteRenderer renderer;

    private Sprite previousImage; // Armazena o sprite anterior para detectar mudanças

    // Método Start é chamado quando o jogo começa
    private void Start()
    {
        if (cardImage != null)
        {
            InstantiateCard();
        }
        else
        {
            Debug.LogWarning("Card não foi atribuído!");
        }
    }

    private void Update()
    {
        // Verifica se a imagem mudou
        if (cardImage != previousImage)
        {
            UpdateCardImage();
            previousImage = cardImage; // Atualiza a imagem anterior
        }
    }

    // Método para instanciar o sprite como filho do GameObject ao qual o script está anexado
    private void InstantiateCard()
    {
        // Cria um novo GameObject
        spriteObject = new GameObject("InstantiatedCard");

        // Adiciona um componente SpriteRenderer ao GameObject
        renderer = spriteObject.AddComponent<SpriteRenderer>();

        // Atribui o sprite ao SpriteRenderer
        renderer.sprite = cardImage;
        previousImage = cardImage;

        // Define o objeto atual como pai do sprite instanciado
        spriteObject.transform.SetParent(transform);

        // Define a posição e escala diretamente no script
        spriteObject.transform.localPosition = new Vector3(0f, 0.004f, -2.7f); // Exemplo de posição (modifique conforme necessário)
        spriteObject.transform.localScale = new Vector3(0.55f, 0.38f, 1.0f);  // Exemplo de escala (modifique conforme necessário)
        spriteObject.transform.localRotation = Quaternion.identity; // Exemplo de escala (modifique conforme necessário)
    }

    // Método para atualizar a imagem do cartão
    private void UpdateCardImage()
    {
        if (renderer != null)
        {
            renderer.sprite = cardImage;
            Debug.Log("Imagem do cartão atualizada!");
        }
        else
        {
            Debug.LogWarning("SpriteRenderer não encontrado. Certifique-se de que o objeto foi instanciado corretamente.");
        }
    }
}
