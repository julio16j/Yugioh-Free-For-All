using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnerScript : MonoBehaviour
{
    public GameObject monsterPrefab; // Referência ao prefab do cubo
    public Vector3 spawnPosition; // Posição para spawnar o cubo
    public int numberOfCubes = 5; // Número de cubos a serem criados
    public float spacing; // Distância entre os cubos
  
    void Start()
    {
        // Gerar vários cubos na cena
        float monsterXsize = monsterPrefab.transform.localScale.x;
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Calcula a posição para cada cubo
            Vector3 position = spawnPosition + new Vector3(i * (spacing + monsterXsize), 0, 0);

            // Instancia o cubo no local calculado
            Instantiate(monsterPrefab, position, Quaternion.identity);
        }
    }
}