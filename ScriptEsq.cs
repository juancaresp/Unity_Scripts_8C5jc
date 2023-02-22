using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEsq : MonoBehaviour
{
    public Animator animEsq;
    public int activo;
    //public Animator animEsqueleto;

    void Update()
    {
        if(activo==0){
            animEsq.SetBool("atack",false);
            animEsq.SetBool("walk",false);
            animEsq.SetBool("charge",false);
        }else if(activo==1){
            animEsq.SetBool("atack",true);
            animEsq.SetBool("walk",false);
            animEsq.SetBool("charge",false);
        }else if(activo==2){
            animEsq.SetBool("atack",false);
            animEsq.SetBool("walk",true);
            animEsq.SetBool("charge",false);
        }else if(activo==3){
            animEsq.SetBool("atack",false);
            animEsq.SetBool("walk",false);
            animEsq.SetBool("charge",true);
        }
        
    }

    public void cambioInt(int n){
        activo=n;
    }
}
