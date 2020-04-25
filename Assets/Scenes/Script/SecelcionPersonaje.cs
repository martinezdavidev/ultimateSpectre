using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecelcionPersonaje : MonoBehaviour
{
    
    public void SeleccionandoMadreMonte()
    {
      GameManager.instance.selecPerso = 0;     
    }
    public void SeleccionandoSonbreron()
    {
      GameManager.instance.selecPerso = 1;
    }
    public void SeleccionandoLorona()
    {
      GameManager.instance.selecPerso = 2;
    }
    public void SeleccionandoMoahn()
    {
      GameManager.instance.selecPerso = 3;
    }
    public void SeleccionarModo()
    {
      GameManager.instance.modoDeJuego = true;
    }
}

