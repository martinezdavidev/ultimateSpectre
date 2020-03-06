using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void pantallaPrincipal() // Carga la esena principal del juego -tambien se usa para volver atras desde confi
    {
        SceneManager.LoadScene(1);
    }
    public void Arcade() // Carga la esena seleccion de personajes modo arcade (un jugador) vs UPC 
    {
        SceneManager.LoadScene(2);
    }
    public void OnevsOne() // Carga la esena seleccion de personajes modo 1 vs 1 
    {
        SceneManager.LoadScene(3);
    }
    public void Configuracion() // Carga la esena comfiguracion-tambien se usa para volver atras desde controles,pantalla,sonido e idioma
    {
        SceneManager.LoadScene(4);
    }
    public void Controles() // Carga la esena comfiguracion de controles
    {
        SceneManager.LoadScene(5);
    }
    public void Pantalla() // Carga la esena comfiguracion de pantalla, resolucion
    {
        SceneManager.LoadScene(6);
    }
    public void Sonido() // Carga la esena comfiguracion de sonido, volumen de la musica efectos etc...
    {
        SceneManager.LoadScene(7);
    }
    public void Idioma() // Carga la esena comfiguracion de indioma, cambia de ingles a español 
    {
        SceneManager.LoadScene(8);
    }
}
