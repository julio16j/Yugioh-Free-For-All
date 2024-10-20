using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpawnerScript : MonoBehaviour
{
    public GameObject spellPrefab; // Refer�ncia ao prefab do cubo
    public Vector3 spawnPosition; // Posi��o para spawnar o cubo
    public int numberOfCubes = 5; // N�mero de cubos a serem criados
    public float spacing; // Dist�ncia entre os cubos

    void Start()
    {
        // Gerar v�rios cubos na cena
        float spellXsize = spellPrefab.transform.localScale.x;
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Calcula a posi��o para cada cubo
            Vector3 position = spawnPosition + new Vector3(i * (spacing + spellXsize), 0, 0);

            // Instancia o cubo no local calculado
            Instantiate(spellPrefab, position, Quaternion.identity);
        }
    }
}