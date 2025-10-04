using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public Vector3 vectorDesplazamiento;
    public float velocidad;
    private Transform posicionCubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (velocidad < 1.0f)
        {
            velocidad = 1.0f;
        }
        posicionCubo = gameObject.transform;
        posicionCubo.position = new Vector3(posicionCubo.position.x, 0, posicionCubo.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        posicionCubo.Translate(vectorDesplazamiento * velocidad * Time.deltaTime);
    }
}
