using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio2Y3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 primerVector;
    public Vector3 segundoVector;
    private Transform transformEsfera;
    void Start()
    {
        Debug.Log("La magnitud del primer vector es:" + primerVector.magnitude);
        Debug.Log("La magnitud del segundo vector es: " + segundoVector.magnitude);
        Debug.Log("El ángulo que forman los vectores es: " + Vector3.Angle(primerVector, segundoVector));
        Debug.Log("La distancia entre los vectores es: " + Vector3.Distance(primerVector, segundoVector));
        if (primerVector.y > segundoVector.y)
        {
            Debug.Log("El primer vector está a una altura mayor");
        }
        else if (primerVector.y < segundoVector.y)
        {
            Debug.Log("El segundo vector está a una altura mayor");
        }
        else
        {
            Debug.Log("Los dos vectores están a la misma altura");
        }
        transformEsfera = GetComponent<Transform>();
        Debug.Log("La posición de la Esfera es " + transformEsfera.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
