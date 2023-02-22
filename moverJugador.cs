using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public Animator animator;
    private Rigidbody rb;
    public float wVelocity;
    public float rVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity=transform.forward * wVelocity * Time.deltaTime*100;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity=-transform.forward * wVelocity * Time.deltaTime*100;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-rVelocity*Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,rVelocity*Time.deltaTime,0);
        }
        if(!Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.S))
        {
            rb.velocity=Vector3.zero;
        }

        //Animaciones
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walk",true);
        }else{
            animator.SetBool("walk",false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("atack",true);
        }else{
            animator.SetBool("atack",false);
        }

    }
}
