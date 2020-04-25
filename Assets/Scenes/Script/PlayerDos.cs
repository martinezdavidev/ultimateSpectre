﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDos : MonoBehaviour
{
    
GameObject personaje;
    void Start()
    {
      personajeSeleccionado();
    }
    void Update()
    {
        Muerte();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<PlayerUno>() || other.gameObject.GetComponent<CPU>())
        {
            GameManager.instance.vida -= 10; 
        }
        if (other.gameObject.GetComponent<objetos>())
        {
            ///
        }
    }
    public void personajeSeleccionado ()
    {
        switch (GameManager.instance.selecPerso2)
        {
            case 0:
             personaje = Instantiate(GameManager.instance.madreMonte,new Vector3(-7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 1:
             personaje = Instantiate(GameManager.instance.sonbreron,new Vector3(-7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 2:
             personaje = Instantiate(GameManager.instance.llorona,new Vector3(-7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 3:
             personaje = Instantiate(GameManager.instance.moahn,new Vector3(-7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;        
        }
    }
    public void Muerte()
    {       
        if(GameManager.instance.vida <= 0)
        {
         Destroy(gameObject);
        }
    }
    
}