using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecpersonaje2 : MonoBehaviour
{

    public void SeleccionandoMadreMonte()
    {
      GameManager.instance.selecPerso2 = 0;     
    }
    public void SeleccionandoSonbreron()
    {
      GameManager.instance.selecPerso2 = 1;
    }
    public void SeleccionandoLorona()
    {
      GameManager.instance.selecPerso2 = 2;
    }
    public void SeleccionandoMoahn()
    {
      GameManager.instance.selecPerso2 = 3;
    }
}
