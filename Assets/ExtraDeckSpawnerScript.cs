using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ExtraDeckSpawnerScript : MonoBehaviour
{
    public GameObject extraDeckPrefab; // Referência ao prefab do cubo

    void Start()
    {
        Instantiate(extraDeckPrefab, extraDeckPrefab.transform.position, extraDeckPrefab.transform.rotation);
    }
}
