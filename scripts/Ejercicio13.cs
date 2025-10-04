using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public float velocidad;
    private Transform transformCubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformCubo = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angulos = transformCubo.rotation.eulerAngles;
        angulos.y += Input.GetAxis("Horizontal") * 90 * Time.deltaTime;
        transformCubo.rotation = Quaternion.Euler(angulos);
        if (Input.GetKey(KeyCode.Space))
        {
            transformCubo.position += transformCubo.forward * velocidad * Time.deltaTime;
        }
    }
}
