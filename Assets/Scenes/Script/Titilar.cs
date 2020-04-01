using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titilar : MonoBehaviour
{
    public GameObject texto,particula;
    public float contador = 0;
    bool temporal = true;
    void Start()
    {
        StartCoroutine("titilar");//inicialisa la corrutina 
       
    }
    private void Update() 
    {
        if (contador >= 5 && temporal == true)// sentencia para activar la funcion 
        {
            particula.SetActive(true);      
            temporal = false;
        } 
        if (contador >= 5.09f && temporal == false)
        {
           particula.SetActive(false); 
        }
    }
    IEnumerator titilar()// corrutina para hacer el efecto de titilar 
    {
        while (true)
        {
            texto.SetActive(false);
            yield return new WaitForSeconds(0.75f);

            texto.SetActive(true);
            contador++;       
            yield return new WaitForSeconds(1f);
            
        }
      
    }
  
}
