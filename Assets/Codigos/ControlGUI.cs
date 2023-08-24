using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGUI : MonoBehaviour
{
    public void AbrirEscenaGUI()
    {
        SceneManager.LoadScene("GUI");

        ControlMenu menuScript = FindObjectOfType<ControlMenu>();
        if (menuScript != null)
        {
            menuScript.ShowMenu();
        }
    }
}
