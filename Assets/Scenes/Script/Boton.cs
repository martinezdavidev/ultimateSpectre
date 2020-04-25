using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public Color [] colores;
    public Image botonImagen;
    public bool seleccionado = false;


    void Start()
    {
        botonImagen = GetComponent<Image>();
        botonImagen.color = colores[0];
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
           if (seleccionado)
        {
            botonImagen.color = colores[1];
        }
        else
        {
            botonImagen.color = colores[0];
        }

    }
}
