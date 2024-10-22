using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardSpawnerScript : MonoBehaviour
{
    public GameObject graveyardPrefab; // Referência ao prefab do cubo

    void Start()
    {
        Instantiate(graveyardPrefab, graveyardPrefab.transform.position, graveyardPrefab.transform.rotation);
    }
}
