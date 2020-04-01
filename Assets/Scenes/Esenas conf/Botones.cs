using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject boton1, boton2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        boton1.SetActive(false);
        boton2.SetActive(true);
        print("entra 1");
       
    }
    private void OnMouseExit()
    {
        boton1.SetActive(true);
        boton2.SetActive(false);
        print("entra 2");
    }
    
}
