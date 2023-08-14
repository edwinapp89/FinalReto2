using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public GameObject MenuJuego;
    void Start()
    {
        string MenuToOpen = PlayerPrefs.GetString("MenuJuego", "");
        if(MenuToOpen == "MenuJuego")
        {
            MenuJuego.SetActive(true);
        }
        else
        {

        }
    }

}
