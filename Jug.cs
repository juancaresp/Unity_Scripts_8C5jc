using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jug : MonoBehaviour
{
    public int vida;
    public int puntos;
    
    public void Start(){
        vida=100;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="bala"){
            vida-=10;
            Destroy(other.gameObject);
            if(vida<=0){
                Destroy(this.gameObject);
            }
        }
        if(other.gameObject.tag=="enemigo"){
            vida-=20;
            
            if(vida<=0){
                Destroy(this.gameObject);
            }
        }
    }
}
