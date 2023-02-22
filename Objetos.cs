using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public Transform c;
    public Jug puntuacion;
    public GameObject canvas;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-50,50),0,Random.Range(-50,50));
        canvas.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) {
        puntuacion.puntos+=20;
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        canvas.SetActive(false);
    }

    void Update(){
        canvas.transform.LookAt(c.position);
    }
}
