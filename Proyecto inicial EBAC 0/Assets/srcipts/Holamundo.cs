using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola desde Awake");
    }
    //int x;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola desde Start");
        //x = 0;
        //print("algo paso");

        //Debug.LogWarning("algo salio medianamente mal");
        //Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1; 
        //Debug.Log(x);

        Debug.Log("HolaDesdeUpdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola Desde FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola Desde Late Update");
    }

    private void OnEnable()
    {
        Debug.Log("Hola desde OnEnable");
    }


    private void OnDisable()
    {
        Debug.Log("Hola desde OnDisable");
    }

}