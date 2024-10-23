using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckSpawnerScript : MonoBehaviour
{
    public GameObject deckPrefab; // Referência ao prefab do cubo

    void Start()
    {
        Instantiate(deckPrefab, deckPrefab.transform.position, deckPrefab.transform.rotation);
    }
}
