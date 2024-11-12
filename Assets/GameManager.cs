using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TurnState currentState;

    public int currentPlayer = 1; // Alterna entre 1 e 2, por exemplo

    public GameObject faseObject;

    public void PassFase(TurnState fase)
    {
        if (currentState < fase)
        {
            currentState = fase;

            // Alteramos o Valor do texto do botão exibido com a fase
            ChangeFaseText();

            // Verificaremos se ninguém quer ativar nada
            CheckEffect(fase);
        }

        if (fase == TurnState.End)
        {
            // Se for a última fase do Player 4, volta pro Player 1
            currentState = TurnState.Start;
            currentPlayer = currentPlayer == 4 ? 1 : currentPlayer + 1;
        }
    }

    bool CheckEffect(TurnState fase)
    {
        // Faremos uma verificação na mão dos players para ver se eles tem alguma carta a ser ativada nessa fase
        // As próprias cartas devem dizer ao jogador se ele pode ativar algo
        return true;
    }

    void ChangeFaseText()
    {
        TextMeshPro faseText = faseObject.GetComponent<TextMeshPro>();

        switch (currentState)
        {
            case TurnState.Start: faseText.text =  "S"; break;
            case TurnState.Draw: faseText.text =  "Draw"; break;
            case TurnState.StandBy: faseText.text = "SB"; break;
            case TurnState.MainOne: faseText.text =  "M1"; break;
            case TurnState.Battle: faseText.text =  "BA"; break;
            case TurnState.MainTwo: faseText.text =  "M2"; break;
            case TurnState.End: faseText.text =  "S"; break;
            default: break;
        };
    }
}
