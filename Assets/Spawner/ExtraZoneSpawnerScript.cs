using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraZoneSpawnerScript : MonoBehaviour
{
    public GameObject extrazonePrefab; // Referência ao prefab do cubo
    public int numberOfCubes = 2; // Número de cubos a serem criados
    public float spacing; // Distância entre os cubos

    void Start()
    {
        // Gerar vários cubos na cena
        float extrazoneXsize = extrazonePrefab.transform.localScale.x;
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Calcula a posição para cada cubo
            Vector3 position = extrazonePrefab.transform.position + new Vector3(i * (spacing + extrazoneXsize), 0, 0);

            // Instancia o cubo no local calculado
            Instantiate(extrazonePrefab, position, extrazonePrefab.transform.localRotation);
        }
    }
}