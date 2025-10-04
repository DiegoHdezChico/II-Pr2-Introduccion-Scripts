using UnityEngine;

public class Ejercicio9_2 : MonoBehaviour
{
    private Transform transformObjectivo;
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformObjectivo = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transformObjectivo.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transformObjectivo.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transformObjectivo.Translate(Vector3.down * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            transformObjectivo.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
    }
}