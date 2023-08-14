using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public string GUI;
    public string MenuJuego;
  

  public void AbrirInterfazJuego()
    {
        PlayerPrefs.SetString("MenuJuego",MenuJuego);
        SceneManager.LoadScene(GUI);
    }
}
