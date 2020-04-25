using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesM : MonoBehaviour
{
    public Boton [] botones;
    public int posicion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print ("A");
            botones[posicion].seleccionado = false;
            posicion++;
            return;
            if (posicion < 0)
            {
                posicion = botones.Length - 1;
                botones[posicion].seleccionado = true;
                return;
            }
            if (posicion > botones.Length - 1)
            {
                posicion = 0; 
                botones[posicion].seleccionado = true;
                return;
            }

            botones[posicion].seleccionado = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("D");
            botones[posicion].seleccionado = false;
            posicion--;
            return;

            if(posicion < 0)
            {
                posicion = botones.Length - 1;
                botones[posicion].seleccionado = true;
                return;
            }

            if (posicion > botones.Length - 1)
            {
                posicion = 0; 
                botones[posicion].seleccionado = true;
                return;
            }
            botones[posicion].seleccionado = true;
        }
    }
}
