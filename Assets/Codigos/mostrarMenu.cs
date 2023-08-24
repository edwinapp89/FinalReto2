using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MostrarMenu : MonoBehaviour
{
    public GameObject MenuJuego;

    public void ShowMenu()
    {
        if (MenuJuego != null)
        {
            MenuJuego.SetActive(true);
        }
        else
        {
            Debug.LogWarning("El GameObject del menú no está asignado.");
        }
    }
}


