using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject personaje;

    void Start()
    {
       SeleccionDepersonajeUPC();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SeleccionDepersonajeUPC()
    {
        if (GameManager.instance.modoDeJuego == true)
        {
        int rng = Random.Range(0,4);
        switch (rng)
        {
            case 0:
             personaje = Instantiate(GameManager.instance.madreMonte,new Vector3(7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 1:
             personaje = Instantiate(GameManager.instance.sonbreron,new Vector3(7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 2:
             personaje = Instantiate(GameManager.instance.llorona,new Vector3(7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;

            case 3:
             personaje = Instantiate(GameManager.instance.moahn,new Vector3(7,0,0),Quaternion.identity);
             personaje.AddComponent<Movimiento>();
            break;        
        }
        }
        
    }
}
