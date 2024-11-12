using UnityEngine;

public class CardHighlightScript : MonoBehaviour
{
    // Parâmetros para ajuste da ênfase
    public float hoverHeightY = 13f; // Altura para levantar a carta
    public float hoverHeightZ = 13f; // Altura para levantar a carta
    public float hoverScaleMultiplier = 1.1f;  // Multiplicador de escala ao passar o mouse

    // Variáveis para armazenar a posição e escala iniciais
    private Vector3 originalPosition;
    private Vector3 hoverPosition;
    private Vector3 originalScale;

    private void Start()
    {
        // Armazena a posição e a escala inicial da carta
        originalPosition = transform.localPosition;
        originalScale = transform.localScale;

    }

    private void OnMouseEnter()
    {

        // Calcula a posição de destaque considerando o plano inclinado
        hoverPosition = originalPosition - transform.localRotation * new Vector3(0, hoverHeightY, hoverHeightZ);

        // Define a posição e escala da carta ao passar o mouse
        transform.localPosition = hoverPosition;
        transform.localScale = originalScale * hoverScaleMultiplier;
    }

    private void OnMouseExit()
    {
        // Retorna a carta para a posição e escala originais
        transform.localPosition = originalPosition;
        transform.localScale = originalScale;
    }
}
