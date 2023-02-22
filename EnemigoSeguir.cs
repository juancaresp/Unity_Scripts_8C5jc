using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSeguir : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    public float distancia;
    public float wVelocity;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempo+=Time.deltaTime;
        if(tiempo>=2){
            transform.Rotate(0,Random.Range(60,180),0);
            tiempo=0;
        }
        
        rb.velocity=transform.forward * wVelocity * Time.deltaTime;
        wVelocity=200;
        if(Vector3.Distance(player.position,transform.position) < distancia){
            wVelocity=500;
            transform.LookAt(player.position);
            GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(player.position);
        }
    }
}
