using System;
using UnityEngine;

public class Ejercicio5Y11 : MonoBehaviour
{
    public Vector3 desplazamientoCubo;
    public Vector3 desplazamientoEsfera;
    public Vector3 desplazamientoCilindro;
    private Transform posicionCubo;
    private Transform posicionEsfera;
    private Transform posicionCilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionCubo = GameObject.FindGameObjectWithTag("cuboBuscador").GetComponent<Transform>();
        posicionEsfera = GameObject.FindGameObjectWithTag("esferaABuscar").GetComponent<Transform>();
        posicionCilindro = GameObject.FindGameObjectWithTag("cilindroBuscador").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            posicionCilindro.position += desplazamientoCilindro;
            posicionCubo.position += desplazamientoCubo;
            posicionEsfera.position += desplazamientoEsfera;
        }
        Vector3 distancia = (posicionEsfera.position - posicionCubo.position).normalized;
        // distancia = new Vector3(distancia.x, 0, distancia.z); // Para que el cubo no varie la altura. Descomentar.
        posicionCubo.position += distancia * Time.deltaTime;
    }
}
