using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void pantallaPrincipal()
    {
        SceneManager.LoadScene(1);
    }
    public void Arcade()
    {
        SceneManager.LoadScene(2);
    }
    public void OnevsOne()
    {
        SceneManager.LoadScene(3);
    }
    public void Configuracion()
    {
        SceneManager.LoadScene(4);
    }
    public void Controles()
    {
        SceneManager.LoadScene(5);
    }
    public void Pantalla()
    {
        SceneManager.LoadScene(6);
    }
    public void Sonido()
    {
        SceneManager.LoadScene(7);
    }
}
