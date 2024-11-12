using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModalOpenScript : MonoBehaviour
{
    public GameObject modalPanel;

    // Start is called before the first frame update
    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Verifica se o Raycast atingiu um objeto
            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                modalPanel.SetActive(true);
            }
        }
    }
}
