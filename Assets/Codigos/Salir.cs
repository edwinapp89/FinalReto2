using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionSalir : MonoBehaviour
{
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        
    }
}
