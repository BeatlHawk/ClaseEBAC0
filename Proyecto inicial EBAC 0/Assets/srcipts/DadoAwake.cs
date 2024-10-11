using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoAwake : MonoBehaviour
{
    public GameObject PrefabDado;
    private void Awake()
    {
        Instantiate(PrefabDado, transform.position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
