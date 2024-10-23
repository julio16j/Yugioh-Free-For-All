using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BannedZoneSpawnerScript : MonoBehaviour
{
    public GameObject bannedZonePrefab; // Referência ao prefab do cubo

    void Start()
    {
        Instantiate(bannedZonePrefab, bannedZonePrefab.transform.position, bannedZonePrefab.transform.rotation);
    }
}
