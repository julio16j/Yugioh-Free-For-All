using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FaseModalScript : MonoBehaviour
{
    public GameObject modalPanel;
    
    // Update is called once per frame
    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            if (!WasClickOnModal() && modalPanel.activeSelf)
            {
                modalPanel.SetActive(false);
            }
            else if (WasClickOnSon() && modalPanel.activeSelf)
            {
                var clickedItens = GetClickedList();

                foreach (var item in clickedItens)
                {
                    var faseItem = item.gameObject.GetComponent<PassFaseScript>();
                    if (faseItem != null)
                        faseItem.SetFase();
                }

                modalPanel.SetActive(false);
            }
        }
    }

    private bool WasClickOnModal()
    {
        var results = GetClickedList();

        // Verifica se o modal foi clicado
        foreach (var result in results)
        {
            if (result.gameObject == modalPanel || result.gameObject.transform.IsChildOf(modalPanel.transform))
            {
                return true;
            }
        }

        return false;
    }

    private bool WasClickOnSon()
    {
        var results = GetClickedList();

        // Verifica se o modal foi clicado
        foreach (var result in results)
        {
            if (result.gameObject.transform.IsChildOf(modalPanel.transform))
            {
                return true;
            }
        }
        return false;
    }

    private System.Collections.Generic.List<RaycastResult> GetClickedList()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };
        var results = new System.Collections.Generic.List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        return results;
    }
}
