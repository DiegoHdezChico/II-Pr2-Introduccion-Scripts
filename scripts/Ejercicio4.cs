using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cubo = GameObject.FindGameObjectWithTag("cuboBuscador");
        GameObject cilindro = GameObject.FindGameObjectWithTag("cilindroBuscador");
        float distanciaCubo = Vector3.Distance(transform.position, cubo.transform.position);
        float distanciaCilindro = Vector3.Distance(transform.position, cilindro.transform.position);
        Debug.Log("La distancia entre el cubo " + " y la esfera es " + distanciaCubo);
        Debug.Log("La distancia entre el cilindro " + " y la esfera es " + distanciaCilindro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
