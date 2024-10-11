using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDisableOnEnable : MonoBehaviour
{
    public GameObject PrefabDado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Instantiate(PrefabDado, transform.position, Quaternion.identity);
    }


    private void OnDisable()
    {
        Instantiate(PrefabDado, transform.position, Quaternion.identity);
    }
}
