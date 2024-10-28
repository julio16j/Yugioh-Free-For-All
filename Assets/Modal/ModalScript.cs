using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ModalScript : MonoBehaviour
{
    public GameObject modalPanel;
    public GameObject confirmButton;
    public GameObject cancelButton;

    private Modal modal;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!WasClickOnModal(modalPanel) && modalPanel.activeSelf)
            {
                modalPanel.SetActive(false);
            }

            if (WasClickOnModal(confirmButton))
            {
                // Confirma
                modal.Confirm();
            }

            if (WasClickOnModal(cancelButton))
            {
                // Cancela
                modal.Cancel();
            }
        }
    }

    public void Abrir(Modal modal1)
    {
        modal = modal1;
        modalPanel.SetActive(true);
    }

    private bool WasClickOnModal(GameObject item)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };
        var results = new System.Collections.Generic.List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        // Verifica se o modal foi clicado
        foreach (var result in results)
        {
            if (result.gameObject == item || result.gameObject.transform.IsChildOf(item.transform))
            {
                return true;
            }
        }
        return false;
    }
}
