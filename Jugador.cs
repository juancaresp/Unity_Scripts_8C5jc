using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos=0;
    }

    
    void Update(){
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1000,Color.green);
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, 1000,LayerMask.GetMask("Monedas"))){
            GameObject hitted=hit.collider.gameObject;
            hitted.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    
}
