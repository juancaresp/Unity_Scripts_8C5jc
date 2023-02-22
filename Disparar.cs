using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject flecha;
    public Transform jugador;
    public Transform arquero;
    public float tiempo;
    public int alcance;
    public bool enRango;

    void Start(){
        enRango = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * alcance, Color.yellow);
        if(!enRango){

            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, alcance, LayerMask.GetMask("Player"))){
                enRango=true;
            }

        }else{
                if(Vector3.Distance(arquero.position,jugador.position)<alcance){    

                    tiempo+=Time.deltaTime;
                    arquero.LookAt(jugador.position);

                    if(tiempo>0.5f){

                        tiempo=0f;
                        GameObject f=Instantiate(flecha, transform.position,Quaternion.Euler(Vector3.forward));
                        f.GetComponent<Rigidbody>().velocity = transform.forward * 1000 * Time.deltaTime;
                        Destroy(f,2f);

                    }
                }else{

                    enRango=false;
                    tiempo=0f;

                }
        }
    }

}
