using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    private Renderer rb;
    private Vector3 vectorColores;
    private int contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = 0;
        rb = GetComponent<Renderer>();
        for (int i = 0; i < 3; ++i)
        {
            vectorColores[i] = Random.value;
        }
        rb.material.color = new Color(vectorColores[0], vectorColores[1], vectorColores[2]);
    }

    // Update is called once per frame
    void Update()
    {
        ++contador;
        int posicion_a_cambiar = 0;
        if (contador == 120)
        {
            contador = 0;
            posicion_a_cambiar = Random.Range(0, 3);
            vectorColores[posicion_a_cambiar] = Random.value;
            rb.material.color = new Color(vectorColores[0], vectorColores[1], vectorColores[2]);
        }
    }
}
