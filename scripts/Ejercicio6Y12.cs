using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio6Y12 : MonoBehaviour
{
    public float velocidad;
    private Transform transformCubo;
    private Transform transformEsfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformCubo = gameObject.transform;
        transformEsfera = GameObject.FindGameObjectWithTag("esferaABuscar").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transformCubo.position += new Vector3(0, 0, velocidad * Time.deltaTime);
            Debug.Log(KeyCode.RightArrow + " pulsada. El valor del eje horizontal es " + transformCubo.position.z);
            transformCubo.LookAt(transformEsfera);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transformCubo.position += new Vector3(0, 0, -velocidad * Time.deltaTime);
            Debug.Log(KeyCode.LeftArrow + " pulsada. El valor del eje horizontal es " + transformCubo.position.z);
            transformCubo.LookAt(transformEsfera);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transformCubo.position += new Vector3(0, velocidad * Time.deltaTime, 0);
            Debug.Log(KeyCode.UpArrow + " pulsada. El valor del eje vertical es " + transformCubo.position.y);
            transformCubo.LookAt(transformEsfera);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transformCubo.position += new Vector3(0, -velocidad * Time.deltaTime, 0);
            Debug.Log(KeyCode.DownArrow + " pulsada. El valor del eje vertical es " + transformCubo.position.y);
            transformCubo.LookAt(transformEsfera);
        }
    }
}
