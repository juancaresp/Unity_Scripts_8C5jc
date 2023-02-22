using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    public GameObject marcador;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(Random.Range(-100f,100f),1.5f,Random.Range(-100f,100f));
        marcador.SetActive(false);
    }
    
    void FixedUpdate(){
        marcador.SetActive(false);
    }
}
