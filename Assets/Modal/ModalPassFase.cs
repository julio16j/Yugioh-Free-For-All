using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalPassFase : Modal
{
    public override void Confirm()
    {
        Debug.Log("Confirmou");
    }

    public override void Cancel()
    {
        Debug.Log("Cancelou");
    }
}
