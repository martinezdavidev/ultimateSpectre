using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetos : MonoBehaviour
{   

    void Start()
    {
        StartCoroutine("SpawnDeObjetos");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerUno>() || other.GetComponent<PlayerDos>() || other.GetComponent<CPU>())
        {
            GameManager.instance.armado = true;
            Destroy(gameObject);
        }
    }
    IEnumerator SpawnDeObjetos()
    {
         while (GameManager.instance.inGame == true)
        {
            int rng = Random.Range(0,3);
            GameObject arma;
            switch (rng)
            {
                case 0:
                  arma = Instantiate(GameManager.instance.arma1,new Vector3(Random.Range(-7,7),3,0),Quaternion.identity);               
                break;
                case 1:
                  arma = Instantiate(GameManager.instance.arma2,new Vector3(Random.Range(-7,7),3,0),Quaternion.identity);               
                break;
                case 2:
                  arma = Instantiate(GameManager.instance.arma2,new Vector3(Random.Range(-7,7),3,0),Quaternion.identity);               
                break;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
