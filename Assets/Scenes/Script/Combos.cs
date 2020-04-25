using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos : MonoBehaviour
{
    int numeroPuños = 0;
    int numeroPatadas = 0;

    int numeroCombos = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GolpesYMovi();
        Combo();  
    }
    void Combo()
    {

      if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.G) && numeroPuños == 3) // Combo 1 puñetazo multiple
      {
          Debug.LogWarning("Combo 1");
          numeroPuños = 0; 
          numeroCombos ++; 
      }
      if(Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.G) && numeroPuños >= 2 )// Combo 2 puños fuerte 
      {
         Debug.LogWarning("Combo 2");
         numeroPuños = 0;
         numeroCombos ++; 

      }
      if (Input.GetKeyDown(KeyCode.H) && Input.GetKey(KeyCode.W) && numeroPatadas >= 2)// combo 3 patada voladora 
      {
          Debug.LogWarning("combo 3");
          numeroPatadas = 0;
          numeroCombos ++; 

      }
      if(Input.GetKey(KeyCode.S) && Input.GetKeyUp(KeyCode.H) && numeroPatadas >= 2)// combo 4 patada tornado 
      {
         Debug.LogWarning("combo 4");
         numeroPatadas = 0;  
         numeroCombos ++; 

      }
      if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.H)) // combo 5 patada deslizante
      {
         Debug.LogWarning("combo 5");
         numeroPatadas = 0;
         numeroCombos ++; 

      }
      if (Input.GetKey(KeyCode.W) && Input.GetKeyUp(KeyCode.G) && numeroPuños <= 2 ) // combo 6 puño volador
      {
         Debug.LogWarning("combo 6");
         numeroPuños = 0;
         numeroCombos ++; 

      }
      if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.G) && numeroCombos >= 3) // combo 7 final 1
      {
          if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
          {
            Debug.LogWarning("combo 7 - 1");
            numeroPatadas = 0;
            numeroPuños = 0;
            numeroCombos = 0;
          }
      }
       if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.H) && numeroCombos >= 3 ) // combo 7 final 2
      {
          if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
          {
            Debug.LogWarning("combo 7 - 2");
            numeroPatadas = 0;
            numeroPuños = 0;
            numeroCombos = 0;
          }
      }
    }
    void GolpesYMovi ()
    {
        if (Input.GetKeyDown(KeyCode.G)) // Letra G es para puño
        {
            numeroPuños ++;
            numeroPatadas = 0;
            print(numeroPuños + " puños");
        }
        if (Input.GetKeyDown(KeyCode.H)) // Letra H es para patadas 
        {
            numeroPatadas ++;
            numeroPuños = 0;
            print(numeroPatadas + " patadas");
        }
        if (Input.GetKeyDown(KeyCode.W)) // Letra W es para salto 
        {
            print("salto");
        }
        if (Input.GetKeyDown(KeyCode.S)) // Letra W es para abajo
        {
            print("agacha");
        }
        if (Input.GetKeyDown(KeyCode.J)) // Letra J para Agarrar objetos y enemigos
        {
            print("agarrar");
        }
    }
}
