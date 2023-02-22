using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject j;
    public int vida;
    public bool pegando;

    // Start is called before the first frame update
    void Start()
    {
        vida=100;
        pegando=false;
    }
    void Update(){
        if(!pegando){
            if(Vector3.Distance(transform.position, j.transform.position)<3){
                if(Input.GetKeyDown(KeyCode.Space)){
                    pegando = true;
                    vida-=50;
                    StartCoroutine(pegar());
                }
            }
        }
        if(vida<=0){
            Destroy(this.gameObject);
        }
    }

    IEnumerator pegar(){
        yield return new WaitForSeconds(1f);
        pegando=false;
    }
}
