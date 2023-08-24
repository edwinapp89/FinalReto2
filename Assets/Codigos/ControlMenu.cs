using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMenu : MonoBehaviour
{
    public GameObject MenuJuego;
    public GameObject Inicio;

    public void ShowMenu()
    {
        if (MenuJuego != null)
        {
            MenuJuego.SetActive(true);
            Inicio.SetActive(false);
        }
        else
        {
            Debug.LogWarning("El GameObject del menú no está asignado.");
        }
    }

}
