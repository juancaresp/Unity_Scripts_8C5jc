using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject panCab,panEsq,menu;
    public GameObject cab,esq;
    

    
    void Start()
    {
        panCab.SetActive(false);
        panEsq.SetActive(false);
        cab.SetActive(false);
        esq.SetActive(false);
    }

    public void elegir(int n){
        if(n==1){
            esq.SetActive(true);
            panEsq.SetActive(true);
        }else{
            cab.SetActive(true);
            panCab.SetActive(true);
        }
        menu.SetActive(false);
    }

    public void volverMenu(){
        panCab.SetActive(false);
        panEsq.SetActive(false);
        cab.SetActive(false);
        esq.SetActive(false);
        menu.SetActive(true);
    }
}
