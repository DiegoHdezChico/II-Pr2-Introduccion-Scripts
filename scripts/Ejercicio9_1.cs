using UnityEngine;

public class Ejercicio9_1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transformObjectivo.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transformObjectivo.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transformObjectivo.Translate(Vector3.down * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transformObjectivo.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
    }
}
