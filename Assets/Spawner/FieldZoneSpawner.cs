using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldZoneSpawner : MonoBehaviour
{
    public GameObject fieldZonePrefab; // Referência ao prefab do cubo

    void Start()
    {
        Instantiate(fieldZonePrefab, fieldZonePrefab.transform.position, fieldZonePrefab.transform.rotation);
    }
}
