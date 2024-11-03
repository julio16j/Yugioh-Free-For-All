using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PassFaseScript : MonoBehaviour
{
    public TurnState fase;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Encontre o GameManager na cena (certifique-se de que haja apenas um)
        gameManager = FindObjectOfType<GameManager>();
    }

    public void SetFase()
    {
        if (gameManager != null)
        {
            gameManager.PassFase(fase);
        }
        else
        {
            Debug.LogWarning("GameManager não encontrado!");
        }
    }
}
