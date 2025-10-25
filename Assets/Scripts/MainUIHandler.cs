using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Esta función pública será llamada por el botón
    public void BackToMenu()
    {
        // Cargamos la escena del menú.
        // Generalmente la escena del menú es la 0 en el Build Settings.
        SceneManager.LoadScene(0);
    }
}
