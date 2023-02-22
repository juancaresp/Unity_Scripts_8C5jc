using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptAnim : MonoBehaviour
{
    public Animator animCaballero;
    public int activo;
    //public Animator animEsqueleto;

    void Update()
    {
        if(activo==0){
            animCaballero.SetBool("atack",false);
            animCaballero.SetBool("walk",false);
            animCaballero.SetBool("charge",false);
        }else if(activo==1){
            animCaballero.SetBool("atack",true);
            animCaballero.SetBool("walk",false);
            animCaballero.SetBool("charge",false);
        }else if(activo==2){
            animCaballero.SetBool("atack",false);
            animCaballero.SetBool("walk",true);
            animCaballero.SetBool("charge",false);
        }else if(activo==3){
            animCaballero.SetBool("atack",false);
            animCaballero.SetBool("walk",false);
            animCaballero.SetBool("charge",true);
        }
        
    }

    public void cambioInt(int n){
        activo=n;
    }
}
