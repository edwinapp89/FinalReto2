using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AbrirInterfazGUI : MonoBehaviour
{
    public UnityEvent abrirInterfazEvent;

    public void AbrirInterfazConMenu()
    {
        abrirInterfazEvent.Invoke();
    }
}
