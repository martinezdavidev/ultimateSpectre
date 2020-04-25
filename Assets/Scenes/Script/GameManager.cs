using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject madreMonte,sonbreron,llorona,moahn,arma1,arma2,arma3;
    public int selecPerso;
    public int selecPerso2;
    public bool modoDeJuego = false;
    public bool armado = false;
    public bool inGame = true;
    public float vida;
    private void Awake()
    {
        inGame = true;
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
