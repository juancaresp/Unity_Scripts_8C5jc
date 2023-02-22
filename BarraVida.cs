using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Jug jugador;
    public Slider slider;


    // Update is called once per frame
    void Update()
    {
        slider.value=jugador.vida;
    }
}
