using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpawnerScript : MonoBehaviour
{
    public GameObject spellPrefab; // Referência ao prefab do cubo
    public int numberOfCubes = 5; // Número de cubos a serem criados
    public float spacing; // Distância entre os cubos

    void Start()
    {
        // Gerar vários cubos na cena
        float spellXsize = spellPrefab.transform.localScale.x;
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Calcula a posição para cada cubo
            Vector3 position = spellPrefab.transform.position + new Vector3(i * (spacing + spellXsize), 0, 0);

            // Instancia o cubo no local calculado
            Instantiate(spellPrefab, position, spellPrefab.transform.localRotation);
        }
    }
}