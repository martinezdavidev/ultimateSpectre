using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Animator anim; 
    float speed = 10;
    public float contador = 0 ;
    public AudioSource punch; 
    bool idel = true;
    void Start()
    {
      anim = GetComponent<Animator>();      
    }
    void Update()
    {
        contador += Time.deltaTime;      
        Movi();
        Idle();
    }
    public void Movi()
    {
         if(Input.GetKey(KeyCode.G))
        {  
            int rnd = Random.Range(0,2);

            if (rnd == 1)
            {
                anim.Play ("Punching Bag",-1,0f);
                idel = true;
                contador = 0; 
            }         
            else
            {
                anim.Play ("Punching",-1,0f);
                idel = true;
                contador = 0;
                punch.Play();
            }
         
        }  
      
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            anim.Play("Walk Backwards",-1,0f);
            idel = true;
            contador = 0;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            anim.Play("Female Tough Walk",-1,0f);
            idel = true;
            contador = 0;

        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.Play("Crouching",-1,0f);           
            idel = true;
            contador = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Jump",-1,0f);           
            idel = true;
            contador = 0;
        }
    }
    public void Idle()
    {
        if (contador >= 2.5f && idel == true)
        {
            anim.Play("Idle",-1,0f);
            idel = false;   
        }        
    }
}
