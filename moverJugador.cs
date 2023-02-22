using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverJugador : MonoBehaviour
{
    public Rigidbody rb;
    public float vel;

    void FixedUpdate()
    {
        if(Input.anyKey){
            float h =Input.GetAxis("Horizontal");
            float v =Input.GetAxis("Vertical");
            Vector3 vector=new Vector3(h,0.0f,v);
            rb.AddForce(vector*vel);
        }else{
            rb.velocity=new Vector3(0,-2,0);
        }
    }
}
