using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirGUI : MonoBehaviour
{
    public string GUI;
    public string MenuJuego;


    public void AbrirInterfaz()
    {
        PlayerPrefs.SetString("MenuJuego",MenuJuego);
        SceneManager.LoadScene(GUI);
    }
}
