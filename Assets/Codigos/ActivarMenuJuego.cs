using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarMenuJuego : MonoBehaviour
{
    public void AbrirEscenaGUI()
    {
        SceneManager.LoadScene("GUI");
    }
}
