using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titilar : MonoBehaviour
{
    public GameObject texto;
    void Start()
    {
        StartCoroutine("titilar");
    }
    IEnumerator titilar()
    {
        while (true)
        {
            texto.SetActive(false);
            yield return new WaitForSeconds(0.75f);

            texto.SetActive(true);
            yield return new WaitForSeconds(0.75f);
        }
      
    }
        
}
