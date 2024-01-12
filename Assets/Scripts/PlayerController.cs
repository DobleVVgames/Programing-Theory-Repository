using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Sprite[] personajeJugador;

    Rigidbody2D rb;
    float xInput;
    float speed = 1000;

    bool gire;

    public TextMeshProUGUI textV;
    public Scrollbar enterVelocity;


    private void Start()
    {
         rb = GetComponent<Rigidbody2D>();

        if (GameController.numPersonaje == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = personajeJugador[0];
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = personajeJugador[1];
        }
    }


    private void Update()
    {
         xInput = Input.GetAxis("Horizontal") * speed;

        decimal value = Convert.ToDecimal(enterVelocity.value);

        textV.text = $"Velocidad: {decimal.Round(value,2)}";

        speed = 1000 * enterVelocity.value;        

        rb.velocity = new Vector2(xInput * Time.deltaTime, rb.velocity.y);



        if(xInput > 0 && !gire)
        {
            CambiarDireccion();
        }else if(xInput < 0 && gire)
        {
            CambiarDireccion();
        }

    }


    void CambiarDireccion()
    {   
        gire = !gire;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
